namespace MyVideo.Demo.Brokers.Storages
{
    internal partial class StorageBroker : EFxceptionsContext
    {
        private readonly IConfiguration configuration;
        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate(); 
        }

        protected override void OnConfiguring(DBContextOptionsBuilder optionsBuilder) 
        {
            string connectionString = this.configuration.GetConnectionString();
        }
    }
}
