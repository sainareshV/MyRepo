namespace CustomerActivityLog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlockActivityLog")]
    public partial class BlockActivityLog
    {
        public long BlockActivityLogID { get; set; }

        public short? BlockType { get; set; }

        [StringLength(250)]
        public string BlockName { get; set; }

        public short? ActivityType { get; set; }

        public DateTime ActivityDate { get; set; }

        [StringLength(50)]
        public string SystemIP { get; set; }

        [StringLength(250)]
        public string SessionID { get; set; }

        [StringLength(250)]
        public string UniqueID { get; set; }

        [StringLength(50)]
        public string InsertedBy { get; set; }

        public DateTime InsertedDate { get; set; }
    }
}
