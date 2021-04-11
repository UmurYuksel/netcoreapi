using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data
{
    public class ProjectCon :DbContext
    {
        public ProjectCon(DbContextOptions<ProjectCon> options):base(options)
        {
        }

       public DbSet<BlogPost> BlogPosts { get; set; }
       public DbSet<Tag> Tags { get; set; }
    }
}
