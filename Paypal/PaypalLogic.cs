using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace Ecom.Paypal
{
    public class PaypalLogic
    {
        public static PaypalRedirect ExpressCheckout(PaypalOrder order)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            values["USER"] = PaypalSettings.Username;
            values["PWD"] = PaypalSettings.Password;
            values["SIGNATURE"] = PaypalSettings.Signature;
            values["METHOD"] = "SetExpressCheckout";
            values["VERSION"] ="93";
            values["RETURNURL"] = PaypalSettings.ReturnUrl;
            values["CANCELURL"] = PaypalSettings.CancelUrl;
            values["AMT"] = order.Amount.ToString();
            values["TRXTYPE"] = "S";
            values["PAYMENTACTION"] = "Sale";
            values["CURRENCYCODE"] = "USD";
            values["BUTTONSOURCE"] = "PP-ECWizard";
            values["SUBJECT"] = "Test";

            values = Submit(values);
            string ACK = values["ACK"].ToLower();

            if(ACK == "success" || ACK  == "successwithwarning")
            {
                return new PaypalRedirect
                {
                    Token = values["TOKEN"],
                    Url = string.Format("{0}? cmd =_Express-checkout&token={1}", PaypalSettings.CgiDomain, values["TOKEN"])
                };
            }
            else
            {
                throw new Exception(values["L_LONGMESSAGE0"]);
            }

        }

        private static Dictionary<string, string> Submit(Dictionary<string, string> values)
        {
            HttpContent content = new FormUrlEncodedContent(values);
            Task<HttpResponseMessage> response = new HttpClient().PostAsync(PaypalSettings.ApiDomain, content);

            string responseResult = response.Result.Content.ReadAsStringAsync().Result;
            Dictionary<string, StringValues> result = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(responseResult);
            Dictionary<string, string> finalresult = result.ToDictionary(item => item.Key, item => item.Value[0]);

            return finalresult;
        }
    }
}
