using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Paypal
{
    public class PaypalSettings
    {
        public static string ApiDomain
        {
            get
            {
                return Sandbox ? ApiDomainSandBoxURL : ApiDomainURL;
            }
        }

        public static string CgiDomain
        {
            get
            {
                return Sandbox ? CgiDomainSandboxURL : CgiDomainURL;
            }
        }

        public static string ApiDomainURL { get; set; }
        public static string ApiDomainSandBoxURL { get; set; }
        public static string CgiDomainURL { get; set; }
        public static string CgiDomainSandboxURL { get; set; }

        public static bool Sandbox { get; set; }
        public static string Signature { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string ReturnUrl { get; set; }
        public static string CancelUrl { get; set; }

    }
}
