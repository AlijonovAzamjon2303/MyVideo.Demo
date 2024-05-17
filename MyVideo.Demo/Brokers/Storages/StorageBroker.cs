using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace MyVideo.Demo.Brokers.Storages;

internal partial class StorageBroker : EFxceptionsContext
{
    public StorageBroker(IConfiguration configuration)
    {
        this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // string connectionString = this.configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        optionsBuilder.UseNpgsql("Server = ::1; Port=5433; Database=MyVideo.DemoDb; User Id=postgres; Password=postgres");

    }
}
