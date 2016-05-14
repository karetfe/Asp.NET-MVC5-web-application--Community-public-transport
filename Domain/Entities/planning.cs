using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class planning
    {
        /// <summary>
        /// Id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// heure de Depart
        /// </summary>
        public DateTime? heureDepart { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// // foreign key
        public int? city_fk { get; set; }
        /// <summary>
        ///Driver
        /// </summary>
        ///  // foreign key
        public int? driver_fk { get; set; }
        /// <summary>
        /// transportationMean
        /// </summary>
        /// // foreign key
        public int? transportationMean_fk { get; set; }
        
        public virtual city city { get; set; }
        [ForeignKey("driver_fk")]
        public virtual user user { get; set; }
        [ForeignKey("transportationMean_fk")]
        public virtual transportationmean transportationmean { get; set; }
    }
}
