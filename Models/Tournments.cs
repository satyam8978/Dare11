using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketBooking.Models
{
    [Table("Tournments")]
    public class Tournments
    {
        [Key]
        public int Id { set; get; }

        [Display(Name ="Tournment")]
        [Required(ErrorMessage = "Please enter Tournment")]
        public string sTname { set; get; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please select Location")]
        public int iLid { set; get; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please select Venue")]
        public int? iVid { set; get; }

        [Display(Name = "Overs")]
        [Required(ErrorMessage = "Please Enter Overs")]
        public int iOvers { set; get; }
        [Display(Name = "FromDate")]
        [Required(ErrorMessage = "Please Enter From Date")]
        public DateTime dFdate { set; get; }
        [Display(Name = "ToDae")]
        [Required(ErrorMessage = "Please Enter ToDate")]
        public DateTime dTdate { set; get; }
        
        public int iCreatedby { set; get; }
        [NotMapped]
        public SelectList locationList { get; set; }
        public SelectList lVenueist { get; set; }


    }
}