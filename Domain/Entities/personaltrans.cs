using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class personaltrans
    {
        public int id { get; set; }
        public string arrivalPlace { get; set; }
        public string description { get; set; }
        public string startPlace { get; set; }
        public Nullable<int> client_fk { get; set; }
        public virtual user user { get; set; }
    }
}
