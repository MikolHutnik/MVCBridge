using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBridge.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public int EmployeeNum { get; set; }
        public string EmergencyContactName { get; set; }
        public int EmergnencyContactNumber { get; set; }
        public DateTime EmployeeStartDate { get; set; }
    }
}