using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GUI.Models
{
    public class SubscriptionViewModels
    {
        
        public int id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must give an expiration date for your subscription ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiration Date :")]
        public Nullable<System.DateTime> expiration_date { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        public byte[] picture { get; set; }
        [Required]
        public float price { get; set; }
        [Required]
        [Display(Name = "Sector :")]
        public Nullable<int> sector { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must give a start date for your subscription ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date :")]
        public Nullable<System.DateTime> start_date { get; set; }
        [Required]
        [Display(Name = "Title :")]
        public string titel { get; set; }
        [Required]
        [Display(Name = "Type Subscription :")]
        public Nullable<int> typeSub { get; set; }
       
        [Display(Name = "The client is :")]
        public Nullable<int> client_fk { get; set; }
        
        [Display(Name = "The manager is :")]
        public Nullable<int> manager_fk { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }

}