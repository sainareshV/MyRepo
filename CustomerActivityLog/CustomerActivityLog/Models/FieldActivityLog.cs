namespace CustomerActivityLog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FieldActivityLog")]
    public class FieldActivityLog
    {
        public long FieldActivityLogID { get; set; }

        [Required]
        [StringLength(50)]
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        public DateTime ActivityDate { get; set; }

        [StringLength(50)]
        public string SystemIP { get; set; }

        [StringLength(250)]
        public string SessionID { get; set; }

        [StringLength(250)]
        public string UniqueID { get; set; }

        [Required]
        [StringLength(250)]
        public string InsertedBy { get; set; }

        public DateTime InsertedDate { get; set; }
      
    }
}
