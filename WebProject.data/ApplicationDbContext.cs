using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.data.models;

namespace WebProject.data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
     public ApplicationDbContext()
            : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
     public DbSet<Pet>     Pets         { get; set; }
     public DbSet<Shelter> Shelters     { get; set; }
     public DbSet<Lizard>  Lizards      { get; set; }
     public DbSet<Pig>     Pigs         { get; set; }
     public DbSet<Cat>     Cats         { get; set; }
     public DbSet<Dog>     Dogs         { get; set; }
    }
}
