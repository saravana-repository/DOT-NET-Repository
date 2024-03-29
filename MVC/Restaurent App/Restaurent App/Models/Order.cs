﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurent_App.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Name is required to place the order")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Mobile Number is required to place the order")]
        [Phone(ErrorMessage = "Enter the valid phone number")]
        public double MobileNo { get; set; }
        public ICollection<Menu> Item { get; set; }
        public double TotalCost { get; set; }
    }
}