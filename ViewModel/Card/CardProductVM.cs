﻿using Ecom.Paypal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.ViewModel.Card
{
    public class CardProductVM
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal ProductTotal { get; set; }
        public  virtual PaypalOrder Paypal { get; set; }
    }
}
