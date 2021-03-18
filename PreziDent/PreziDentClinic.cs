using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PreziDent
{
    public partial class PreziDentClinic : DbContext
    {
        public PreziDentClinic()
            : base("name=PreziDentClinic")
        {
        }

        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<contacts_firm> contacts_firm { get; set; }
        public virtual DbSet<firm> firms { get; set; }
        public virtual DbSet<group_services> group_services { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<orders_services> orders_services { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<room> rooms { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<shedule> shedules { get; set; }
        public virtual DbSet<statuses_patient> statuses_patient { get; set; }
        public virtual DbSet<surgery> surgeries { get; set; }
        public virtual DbSet<type_product> type_product { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appointment>()
                .Property(e => e.name_patient)
                .IsFixedLength();

            modelBuilder.Entity<appointment>()
                .Property(e => e.phone_patient)
                .IsFixedLength();

            modelBuilder.Entity<contacts_firm>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<contacts_firm>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<contacts_firm>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<contacts_firm>()
                .Property(e => e.department)
                .IsFixedLength();

            modelBuilder.Entity<contacts_firm>()
                .Property(e => e.post)
                .IsFixedLength();

            modelBuilder.Entity<firm>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<firm>()
                .Property(e => e.address)
                .IsFixedLength();

            modelBuilder.Entity<firm>()
                .HasMany(e => e.contacts_firm)
                .WithRequired(e => e.firm)
                .HasForeignKey(e => e.id_firm);

            modelBuilder.Entity<group_services>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<group_services>()
                .HasMany(e => e.services)
                .WithRequired(e => e.group_services)
                .HasForeignKey(e => e.group_services_id);

            modelBuilder.Entity<order>()
                .HasMany(e => e.orders_services)
                .WithRequired(e => e.order)
                .HasForeignKey(e => e.order_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<orders_services>()
                .Property(e => e.name_service)
                .IsFixedLength();

            modelBuilder.Entity<orders_services>()
                .Property(e => e.price_service)
                .HasPrecision(19, 4);

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
                .Property(e => e.num_card)
                .IsFixedLength();

            modelBuilder.Entity<patient>()
                .HasMany(e => e.appointments)
                .WithRequired(e => e.patient)
                .HasForeignKey(e => e.patient_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<patient>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.patient)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patient>()
                .HasMany(e => e.surgeries)
                .WithRequired(e => e.patient)
                .HasForeignKey(e => e.patient_id);

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

            modelBuilder.Entity<room>()
                .HasMany(e => e.surgeries)
                .WithRequired(e => e.room)
                .HasForeignKey(e => e.room_id);

            modelBuilder.Entity<service>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<service>()
                .Property(e => e.price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<service>()
                .Property(e => e.code_service)
                .IsFixedLength();

            modelBuilder.Entity<service>()
                .Property(e => e.deleted_at)
                .IsFixedLength();

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

            modelBuilder.Entity<statuses_patient>()
                .Property(e => e.name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<statuses_patient>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.statuses_patient)
                .HasForeignKey(e => e.status_id);

            modelBuilder.Entity<surgery>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<type_product>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<type_product>()
                .HasMany(e => e.products)
                .WithRequired(e => e.type_product)
                .HasForeignKey(e => e.type_id);

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
                .HasForeignKey(e => e.user_id);
        }
    }
}
