using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class paiement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name = "Code CVV2 :")]
        public Nullable<int> codeCVV2 { get; set; }
        [Display(Name = "Confidential Code :")]
        public Nullable<int> confidentialCode { get; set; }
        [Display(Name = "Number Carte Bancaire :")]
        public Nullable<int> numberCarteBancaire { get; set; }
        [Display(Name = "Reference :")]
        public string reference { get; set; }
    }
}
