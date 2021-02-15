﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [RegularExpression(@"^\d{2,3}[-]{0,1}\d{10}|\d{9,11}$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }
        public string Class { get; set; }
        public string Cat { get; set; }
        public string Price { get; set; }
    }


}