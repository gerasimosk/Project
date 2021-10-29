﻿using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Services.DTOs;

namespace WebAPI.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTitle> UserTitles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasData(
                    new User { Id = 1, Name = "George", Surname = "GeorgeSurname", BirthDate = new DateTime(2020, 12, 12), UserTypeId = 1, UserTitleId = 1, EmailAddress = "george@example.com", isActive = true },
                    new User { Id = 2, Name = "Nikos", Surname = "NikosSurname", BirthDate = new DateTime(2021, 08, 10), UserTypeId = 2, UserTitleId = 2, EmailAddress = "nikos@example.com", isActive = true }
                    );

            builder.Entity<UserTitle>()
                .HasData(
                    new UserTitle { Id = 1, Description = "description1" },
                    new UserTitle { Id = 2, Description = "description2" }
                    );

            builder.Entity<UserType>()
                .HasData(
                    new UserType { Id = 1, Description = "description1", Code = 'a' },
                    new UserType { Id = 2, Description = "description2", Code = 'b' }
                    );

            builder.Entity<User>()
                .Property(x => x.Name)
                .HasMaxLength(20).IsRequired();

            builder.Entity<User>()
                .Property(x => x.Surname)
                .HasMaxLength(20).IsRequired();

            builder.Entity<User>()
                .Property(x => x.EmailAddress)
                .HasMaxLength(50).IsRequired();

            builder.Entity<User>()
                .Property(x => x.Name)
                .HasMaxLength(20).IsRequired();

            builder.Entity<UserTitle>()
                .Property(x => x.Description)
                .HasMaxLength(20).IsRequired();

            builder.Entity<UserType>()
                .Property(x => x.Description)
                .HasMaxLength(20).IsRequired();

            builder.Entity<UserType>()
                .Property(x => x.Code)
                .HasMaxLength(2).IsRequired();

            builder.Entity<User>()
                .HasOne(s => s.UserTitle)
                .WithMany(g => g.User)
                .HasForeignKey(s => s.UserTitleId);

            builder.Entity<User>()
                .HasOne(s => s.UserType)
                .WithMany(g => g.User)
                .HasForeignKey(s => s.UserTypeId);
        }
    }
}