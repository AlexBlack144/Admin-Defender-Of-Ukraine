using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Game_Kursak_Admin.model.DB_Model
{
    public partial class AdminModel : DbContext
    {
        public AdminModel()
            : base("name=AdminModel1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<Med_kit> Med_kit { get; set; }
        public virtual DbSet<PC_Name_And_ID> PC_Name_And_ID { get; set; }
        public virtual DbSet<Player_statistics> Player_statistics { get; set; }
        public virtual DbSet<Spent_ammo> Spent_ammo { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Med_kit>()
                .HasMany(e => e.Player_statistics)
                .WithOptional(e => e.Med_kit)
                .HasForeignKey(e => e.Med_kit_id);

            modelBuilder.Entity<PC_Name_And_ID>()
                .HasMany(e => e.Bans)
                .WithOptional(e => e.PC_Name_And_ID)
                .HasForeignKey(e => e.PC_ID_And_Name_Id);

            modelBuilder.Entity<PC_Name_And_ID>()
                .HasMany(e => e.Player_statistics)
                .WithOptional(e => e.PC_Name_And_ID)
                .HasForeignKey(e => e.PC_ID_And_Name_Id);

            modelBuilder.Entity<Spent_ammo>()
                .HasMany(e => e.Player_statistics)
                .WithOptional(e => e.Spent_ammo)
                .HasForeignKey(e => e.Spent_ammo_id);

            modelBuilder.Entity<Weapon>()
                .HasMany(e => e.Player_statistics)
                .WithOptional(e => e.Weapon)
                .HasForeignKey(e => e.Weapon_id);
        }
    }
}
