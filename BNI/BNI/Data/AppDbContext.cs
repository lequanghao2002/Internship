using BNI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BNI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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

    }
}
