using System.Data.Entity;

namespace PirateBackend.Models
{
    public class PirateBackendContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PirateBackendContext() : base("name=PirateBackendContext")
        {
        }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<AthleticEvent> AthleticEvents { get; set; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<AcademicCalandar> AcademicCalandars { get; set; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public DbSet<EventCalandar> EventCalandars { get; set; }
    }
}
