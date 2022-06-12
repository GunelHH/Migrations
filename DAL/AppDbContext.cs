using System;
using Microsoft.EntityFrameworkCore;
using MigrationToDataBase.Models;

namespace MigrationToDataBase.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        DbSet<Slider> Sliders { get; set; }

        DbSet<Blog> Blogs { get; set; }
    }
}
