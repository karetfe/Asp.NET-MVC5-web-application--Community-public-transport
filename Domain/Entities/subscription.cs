using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class subscription
    {
        public int id { get; set; }
        public Nullable<System.DateTime> expiration_date { get; set; }
        public byte[] picture { get; set; }
        public float price { get; set; }
        public Nullable<int> sector { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public string titel { get; set; }
        public Nullable<int> typeSub { get; set; }
        public Nullable<int> client_fk { get; set; }
        public Nullable<int> manager_fk { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
