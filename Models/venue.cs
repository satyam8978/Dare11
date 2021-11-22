using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;

namespace CricketBooking.Models
{
    [Table("Venues")]
    public class venue
    {

        [Key]
        public int iId { get; set; }
        [Required(ErrorMessage = "Please enter Venue")]
        [Display(Name = "Name")]
        public string sname { get; set; }

        public int ilId { get; set; }
        public int iCId { get; set; }
        [Display(Name = "Location Name")]
        public string slname { get; set; }

        [NotMapped]
        public SelectList locationList { get; set; }
    
      
    }
}