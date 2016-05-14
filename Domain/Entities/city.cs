using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class city
    {
        public city()
        {
            this.planning = new List<planning>();
        }

        public int id { get; set; }
        public Nullable<int> latitude { get; set; }
        public Nullable<int> longitude { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public virtual ICollection<planning> planning { get; set; }
    }
}
