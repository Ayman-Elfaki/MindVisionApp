using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MindVision.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MindVision.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Question> Questions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Question>().Property(p => p.Title).HasMaxLength(128).IsRequired();
            builder.Entity<Question>().Property(p => p.Answer).HasMaxLength(255).IsRequired();
            builder.Entity<Question>().Property(p => p.Description).HasMaxLength(255);

            builder.Entity<Question>().OwnsMany(s => s.SubQuestions, sq => 
            {
                sq.Property(c => c.Content).HasMaxLength(250).IsRequired();
                sq.Property(c => c.Duration).HasConversion(new TimeSpanToTicksConverter()).IsRequired();
            });
        }
    }
}
