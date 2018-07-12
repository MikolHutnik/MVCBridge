using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBridge.Models
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Customer")]
        public int StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public Customer Customer { get; set; }

    }
}