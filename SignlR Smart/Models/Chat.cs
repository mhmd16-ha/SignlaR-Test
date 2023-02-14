using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SignlR_Smart.Models
{
    public partial class Chat : DbContext
    {
        public Chat()
            : base("name=ChatDb")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.message)
                .IsUnicode(false);
        }
    }
}
