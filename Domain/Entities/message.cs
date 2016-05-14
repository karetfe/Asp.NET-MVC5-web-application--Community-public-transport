using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class message
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string subject { get; set; }
        public string type { get; set; }
        public Nullable<int> client_fk { get; set; }
        public virtual user user { get; set; }
    }
}
