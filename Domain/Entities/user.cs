using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class user
    {
        public user()
        {
            this.messages = new List<message>();
            this.personaltrans = new List<personaltrans>();
            this.planning = new List<planning>();
            this.subscription = new List<subscription>();
            this.subscription1 = new List<subscription>();
        }

        public string myDType { get; set; }
        public int id { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> birth_date { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string picture { get; set; }
        public string profession { get; set; }
        public string fax { get; set; }
        public Nullable<int> phoneNumber { get; set; }
        public Nullable<int> drivingLicence { get; set; }
        public string matricule { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<personaltrans> personaltrans { get; set; }
        public virtual ICollection<planning> planning { get; set; }
        public virtual ICollection<subscription> subscription { get; set; }
        public virtual ICollection<subscription> subscription1 { get; set; }
    }
}
