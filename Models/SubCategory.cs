using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {
        [Key]
        public int SubID { get; set; }
        public int SuCategoryID { get; set; }
        
        [Required]
        [StringLength (50)]
        [Display(Name ="SubCategory Name")]
        public string SubCategoryName { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Categoies { get; set; }            
    }
}
