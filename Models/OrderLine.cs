using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Models
{
    [Table("OrderLine")]
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int? Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        [Range(1,100,ErrorMessage ="Price must between {0} and {1}")]
        public decimal? Price { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}
