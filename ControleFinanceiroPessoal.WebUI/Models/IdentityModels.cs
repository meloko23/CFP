using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ControleFinanceiroPessoal.WebUI.Models {
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            //AppDbContext
            //DefaultConnection
            : base("DefaultConnection") {
        }

        /*protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            if (modelBuilder == null) {
                throw new ArgumentNullException("modelBuilder");
            }

            // Keep this:
            modelBuilder.Entity<IdentityUser>().ToTable("Usuarios");
            modelBuilder.Entity<IdentityUser>().HasKey(r => r.Id).ToTable("Usuarios");
            modelBuilder.Entity<IdentityUser>().Property(r => r.UserName).HasColumnName("Login");
            modelBuilder.Entity<IdentityUser>().Property(r => r.PasswordHash).HasColumnName("Senha");
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.Email);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.EmailConfirmed);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.SecurityStamp);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.PhoneNumber);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.PhoneNumberConfirmed);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.TwoFactorEnabled);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.LockoutEndDateUtc);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.LockoutEnabled);
            modelBuilder.Entity<IdentityUser>().Ignore(r => r.AccessFailedCount);


            // Change TUser to ApplicationUser everywhere else - 
            // IdentityUser and ApplicationUser essentially 'share' the AspNetUsers Table in the database:
            EntityTypeConfiguration<ApplicationUser> table =
            modelBuilder.Entity<ApplicationUser>().ToTable("Usuarios");
            //modelBuilder.Entity<ApplicationUser>().HasKey(r => r.Id).ToTable("Usuarios");
            modelBuilder.Entity<ApplicationUser>().Property(r => r.UserName).HasColumnName("Login");
            modelBuilder.Entity<ApplicationUser>().Property(r => r.PasswordHash).HasColumnName("Senha");
            //modelBuilder.Entity<ApplicationUser>().

            table.Property((ApplicationUser u) => u.UserName).IsRequired();
        }*/
    }
}