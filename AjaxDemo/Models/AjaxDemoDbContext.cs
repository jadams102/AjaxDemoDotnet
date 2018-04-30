using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public class AjaxDemoDbContext : DbContext
    {
        public AjaxDemoDbContext()
        {

        }

        public virtual DbSet<Destination> Destinations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=ajaxtest;uid=root;pwd=root;");
        }

        public AjaxDemoDbContext(DbContextOptions<AjaxDemoDbContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
