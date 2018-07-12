using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBridge.Models
{
    public class Menu
    {
        [Key]

        public string Item { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}