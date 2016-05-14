using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GUI.Models
{
    public class PlanningViewModels

    {
        public int id { get; set; }     
        [Display(Name = "Title :")]
        [Required(ErrorMessage = "You must give a title to your planning")]
        public string title { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must give a daparture date for your planning ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Date :")]
        public DateTime heureDepart { get; set; }
        [Display(Name = "City :")]
        public int? city_fk { get; set; }
        [Display(Name = "City :")]
        public virtual city city { get; set; }
        [Display(Name = "Driver :")]
        public int? driver_fk { get; set; }
        [Display(Name = "Transportation Mean :")]
        public int? transportationMean_fk { get; set; }
    }
}