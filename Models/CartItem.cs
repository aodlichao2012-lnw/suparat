using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Models
{
    [Table("Carditem")]
    public class CartItem
    {
        [Key]
        public int CardID { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int? ProductID { get; set; }
        public string CustomerID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AddDate { get; set; }

    }
}
