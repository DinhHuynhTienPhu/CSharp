namespace DatabaseProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("webt2289_phu.Department")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Classes = new HashSet<Class>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string ID { get; set; }

        [StringLength(50)]
        public string DEP_NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string UNI_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? create_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        public virtual University University { get; set; }
    }
}
