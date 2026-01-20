using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautySalon.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Service Name")]
        public string Name { get; set; }

        [Display(Name = "Duration (Minutes)")]
        public int Duration {  get; set; }

        [DataType(DataType.Currency)]

        public decimal price { get; set; }
       
    }
}