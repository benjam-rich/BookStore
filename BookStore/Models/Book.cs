using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        //This creates a Primary key for this table in the database
        [Key]
        public int BookID { get; set; }
        //All Fields are required in the database
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirst { get; set; }
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //This regular expression should only allow inputs to the database with this format xxx-xxxxxxxxxx
        [RegularExpression(@"^\d{2,3}[-]{0,1}\d{10}|\d{9,11}$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Cat { get; set; }
        [Required]
        public string Price { get; set; }
    }


}
