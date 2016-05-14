using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class transportationmean
    {
        public transportationmean()
        {
            this.planning = new List<planning>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> circulation_date { get; set; }
        public string fuel { get; set; }
        public Nullable<int> km { get; set; }
        public string mark { get; set; }
        public string model { get; set; }
        public Nullable<int> nmbrPlaces { get; set; }
        public string picture { get; set; }
        public Nullable<int> registrationNumber { get; set; }
        public virtual ICollection<planning> planning { get; set; }
    }
}
