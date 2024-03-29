﻿using BNI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BNI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Events>()
        .HasMany(e => e.EventTitles)
        .WithOne(et => et.Event)
        .HasForeignKey(et => et.EventId);

            modelBuilder.Entity<EventTitle>()
                .HasMany(et => et.TitleImages)
                .WithOne(ti => ti.EventTitle)
                .HasForeignKey(ti => ti.EventTitleId);
            base.OnModelCreating(modelBuilder);

            var listRole = new List<Role>
            {
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                },
                new Role
                {
                    Id = 3,
                    Name = "Member",
                }
            };
            
            modelBuilder.Entity<Role>().HasData(listRole);
        }

        public DbSet<AddtionalInformation> AddtionalInformation { get; set; }
        public DbSet<Business_Sector> Business_Sector { get; set; }
        public DbSet<Business_Support> Business_Support { get; set; }
        public DbSet<Category_Support> Category_Support { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventsRegister> EventsRegister { get; set; }
        public DbSet<Logo> Logo { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Membership_Term> Membership_Term { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<PostsCategory> PostsCategory { get; set; }
        public DbSet<Reference_Information> Reference_Information { get; set; }
        public DbSet<Step> Step { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TitleImage> TitleImage { get; set; }
        public DbSet<EventTitle> EventTitle { get; set; }
    }
}
