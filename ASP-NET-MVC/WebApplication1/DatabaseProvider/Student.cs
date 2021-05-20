namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Globalization;

    [Table("webt2289_phu.Student")]
    public partial class Student
    {
        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ID { get; set; }

        [StringLength(50)]
        public string STU_NAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATE_OF_BIRTH { get; set; }

        [StringLength(4)]
        public string CLA_ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string UNI_ID { get; set; }

        [StringLength(4)]
        public string DEP_ID { get; set; }

        public virtual Class Class { get; set; }

    }
}
