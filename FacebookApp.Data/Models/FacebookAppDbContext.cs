using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookApp.Data.Models
{
    public class FacebookAppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public FacebookAppDbContext(DbContextOptions<FacebookAppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Property(x => x.SendTime).HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<User>().Property(x => x.RegistrationDate).HasDefaultValue(DateTime.Now);
            //modelBuilder.Entity<User>()   
            //.HasKey(u => new { u.UserId, u.Email , u.Phone });
            modelBuilder.Entity<Like>().HasKey(x => x.UserId);
            modelBuilder.Entity<Like>().HasKey(x => x.LikeId);

        }
    }
}
