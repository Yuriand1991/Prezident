namespace PreziDent
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClinicContext : DbContext
    {
        public ClinicContext()
            : base("name=ClinicContext")
        {
        }

        public virtual DbSet<appointments> appointments { get; set; }
        public virtual DbSet<patients> patients { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<rooms> rooms { get; set; }
        public virtual DbSet<schedule> schedule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appointments>()
                .Property(e => e.patient_name)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .Property(e => e.first_name)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .Property(e => e.last_name)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .Property(e => e.other_name)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<patients>()
                .HasMany(e => e.appointments)
                .WithOptional(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<roles>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<rooms>()
                .HasMany(e => e.appointments)
                .WithOptional(e => e.rooms)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<schedule>()
                .HasMany(e => e.appointments)
                .WithOptional(e => e.schedule)
                .HasForeignKey(e => e.schedule_id);
        }
    }
}
