namespace SignlR_Smart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column("message")]
        [StringLength(500)]
        public string message { get; set; }

        public DateTime? date { get; set; }
    }
}
