using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Models
{
    [Table("add")]
    public class Addpg
    {
        
       
            [Key]

        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public int rent { get; set; }
        public int rooms { get; set; }
            public string email { get; set; }
        public string address { get; set; }

        public string picture { get; set; }
        public string electricity { get; set; }
        public string ac { get; set; }
        public string fan { get; set; }
        public string parking { get; set; }
        public string furnished { get; set; }
        public string internet { get; set; }
        public string security { get; set; }
        public string types { get; set; }



    }
}
