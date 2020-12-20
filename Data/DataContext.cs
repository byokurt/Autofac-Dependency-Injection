using AutoFackExample.Helpers;
using AutoFackExample.Models.BusinessEntities;
using System.Data.Entity;

namespace AutoFackExample.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name = MyConnectionString")
        {
            Database.SetInitializer<DataContext>(null);

            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<ExampleModel> ExampleModel { get; set; }

    }
}