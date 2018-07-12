﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridge.Models
{
    public class Customer
    {
        [Key]

        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string Drink { get; set; }
        public string Meal { get; set; }
        public double LargestBill { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }


    }
}