using Microsoft.EntityFrameworkCore;
using projectNaomi.Core.model;


namespace Project.Data
{
    public class DataContex:DbContext
    {
        public DbSet<Guide> guides { get; set; }
        public DbSet<Registers> registers { get; set; }
        public DbSet<Trip> trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Trip");
        }




    }




    
}
