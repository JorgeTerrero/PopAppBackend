using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using PopApp.Data.Services;

namespace PopAppBackend.Extension
{
    /// <summary>
    /// Represent extension manager.
    /// </summary>
    public static class ExtensionManager
    {
        #region Ctor
        /// <summary>
        /// Sql server confing
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configuration"></param>
        public static void SqlServerConfiguration(this IServiceCollection service, IConfiguration configuration)
            => service.AddDbContext<PopAppContext>(context => context.UseSqlServer(configuration
                .GetConnectionString("DefaultConnection") , build => build.MigrationsAssembly("PopAppBackend")));

        /// <summary>
        /// Schedule context config
        /// </summary>
        /// <param name="service"></param>
        /// <param name="configuration"></param>
        public static void ScheduleContextConfiguration(this IServiceCollection service, IConfiguration configuration)
            => service.AddDbContext<ScheduleContext>(context =>
            context.UseSqlServer(configuration.GetConnectionString("DefaultConnection") , build => build.MigrationsAssembly("PopAppBackend")));

        /// <summary>
        /// Repository manager config.
        /// </summary>
        /// <param name="service"></param>
        public static void AddRepositoryManagerService(this IServiceCollection service)
            => service.AddTransient<IRepositoryManager , RepositoryManager>();
        #endregion
    }
}
