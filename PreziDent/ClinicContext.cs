using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PreziDent
{
    public partial class ClinicContext : DbContext
    {
        public ClinicContext()
            : base("name=ClinicContext")
        {
        }

        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<group_services> group_services { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<orders_services> orders_services { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<shedule> shedules { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appointment>()
                .Property(e => e.name_patient)
                .IsFixedLength();

            modelBuilder.Entity<group_services>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<group_services>()
                .HasMany(e => e.services)
                .WithRequired(e => e.group_services)
                .HasForeignKey(e => e.group_services_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.orders_services)
                .WithRequired(e => e.order)
                .HasForeignKey(e => e.order_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.first_name)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .Property(e => e.last_name)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .Property(e => e.other_name)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.patient)
                .HasForeignKey(e => e.patient_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<role>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithRequired(e => e.role)
                .HasForeignKey(e => e.role_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<room>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.room)
                .HasForeignKey(e => e.room_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<service>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<service>()
                .HasMany(e => e.orders_services)
                .WithRequired(e => e.service)
                .HasForeignKey(e => e.service_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shedule>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.shedule)
                .HasForeignKey(e => e.shedule_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsFixedLength();

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<user>()
                .Property(e => e.first_name)
                .IsFixedLength();

            modelBuilder.Entity<user>()
                .HasMany(e => e.rooms)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
