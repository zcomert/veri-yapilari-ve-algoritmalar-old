using EmployeeApp.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Extensions
{
    public static class ArchitecutreExtensions
    {
        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
            RepositoryContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RepositoryContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }
    }
}
