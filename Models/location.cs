using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CricketBooking.Models
{
    [Table("location")]
    public class location
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter location")]
        [Display(Name = "Name")]
        public string name { get; set; }
    }
}