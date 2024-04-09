using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebArg.Storage.Database;

namespace WebArg.Storage.MS_SQL
{
    public class SqlServerContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        private const string DbConnectionString = "Server=localhost,1433;Database=StudioDb;User ID=sa;Password=<YourStrong@Passw0rd>;MultipleActiveResultSets=true;TrustServerCertificate=True";

        public DataContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DataContext>();

            optionBuilder.UseSqlServer(DbConnectionString, b => b.MigrationsAssembly(typeof(SqlServerContextFactory).Namespace));

            return new DataContext(optionBuilder.Options);
        }
    }
}
