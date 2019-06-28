using Ecom.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.ViewModel.Card
{
    public class CardIndexVM
    {
        public CardIndexVM()
        {
            CardProductVMList = new List<CardProductVM>();
        }
        public List<CardProductVM> CardProductVMList { get; set; }
        public decimal CardTotalPrice { get; set; }
        public decimal Amount { get; set; }
    }
}
