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
        [Display(Name = "Fee")]
        [Required(ErrorMessage = "Please Enter fee")]
        public decimal dFee { set; get; }
        public int iCreatedby { set; get; }
        [NotMapped]
        public SelectList locationList { get; set; }
        public SelectList lVenueist { get; set; }
        public string slname { get; set; }
        public string svname { get; set; }

    }
}