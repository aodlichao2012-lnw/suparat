﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Models
{
    [Table("Picture")]
    public class Picture
    {
        public int PictureID { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }
    }

}
