using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class FurtherDbContext : IdentityDbContext<User>
    {
        public FurtherDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.CompanyId);

            string roleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole()
                    {
                        Id = roleId,
                        Name = "admin",
                        NormalizedName = "ADMIN"
                    },
                    new IdentityRole()
                    {
                        Id = userRoleId,
                        Name = "user",
                        NormalizedName = "USER"
                    }
                );

            string userId = Guid.NewGuid().ToString();
            string userId2 = Guid.NewGuid().ToString();
            string userId3 = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                    // seed two admin users
                    new User()
                    {
                        Id = userId,
                        FirstName = "Filip",
                        LastName = "Kostadinov",
                        UserName = "filip",
                        PasswordHash = hasher.HashPassword(null, "Filip123#"),
                        SecurityStamp = string.Empty,
                        DateOfBirth = new DateTime(1993, 7, 19),
                        CompanyId = 1,
                        PermissionToLogin = true
                    },
                    new User()
                    {
                        Id = userId2,
                        FirstName = "Admin",
                        LastName = "Admin",
                        UserName = "admin",
                        PasswordHash = hasher.HashPassword(null, "Admin123#"),
                        SecurityStamp = string.Empty,
                        DateOfBirth = new DateTime(2000, 1, 1),
                        CompanyId = 1,
                        PermissionToLogin = true
                    },
                    // seed one employee user with permission to log in
                    new User()
                    {
                        Id = userId3,
                        FirstName = "Bob",
                        LastName = "Bobsky",
                        UserName = "bob",
                        PasswordHash = hasher.HashPassword(null, "Bob123#"),
                        SecurityStamp = string.Empty,
                        DateOfBirth = new DateTime(2000, 1, 1),
                        CompanyId = 2,
                        PermissionToLogin = true
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = roleId,
                    UserId = userId
                },
                new IdentityUserRole<string>()
                {
                    RoleId = roleId,
                    UserId = userId2
                },
                new IdentityUserRole<string>()
                {
                    RoleId = userRoleId,
                    UserId = userId3
                }
            );

            modelBuilder.Entity<Company>().HasData(
                    new Company()
                    {
                        Id = 1,
                        Name = "Company1"
                    },
                    new Company()
                    {
                        Id = 2,
                        Name = "Company2"
                    }
                );
        }
    }
}
