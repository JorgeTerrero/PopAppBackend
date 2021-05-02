using Microsoft.EntityFrameworkCore;
using PopApp.Core.Entities;
using PopApp.Data.Model.Config;

namespace PopApp.Data.Context
{
    /// <summary>
    /// Represent the DbContex of application.
    /// </summary>
    public class PopAppContext : DbContext
    {
        #region Ctor
        /// <param name="options">dbcontext param.</param>
        public PopAppContext(DbContextOptions<PopAppContext> options): base(options)
        {

        }
        #endregion

        #region OnModelCreating
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder">modelbuild param</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContainerConfiguration());
            modelBuilder.ApplyConfiguration(new FreightConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new VesselConfiguration());
        }
        #endregion

        #region DbSets
        public DbSet<Company> Companies { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Freight> Freights { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vessel> Vessels { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        #endregion
         
    }
}
