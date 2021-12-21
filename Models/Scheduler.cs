using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CricketBooking.Models
{
    public class Scheduler
    {

        [Key]
        public int Id { set; get; }

        
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please select Location")]
        public int iLid { set; get; }

        [Display(Name = "Location")]
        [Required(ErrorMessage = "Please select Venue")]
        public int? iVid { set; get; }

        [Display(Name = "Tournment")]
        [Required(ErrorMessage = "Please enter Tournment")]
        public string iTid { set; get; }
        
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please Enter Date")]
        public DateTime dSdate { set; get; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [Display(Name = " from Time")]
        [Required(ErrorMessage = "Please Enter From Time")]
        public DateTime dFtime { set; get; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [Display(Name = "To Time")]
        [Required(ErrorMessage = "Please Enter From Time")]
        public DateTime dTtime { set; get; }
        public int iCreatedby { set; get; }
        [NotMapped]
        public SelectList locationList { get; set; }
        public SelectList lVenueist { get; set; }
        public SelectList lTournments { get; set; }
        public string slname { get; set; }
        public string svname { get; set; }
    }
}