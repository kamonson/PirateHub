namespace PirateBackend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PirateBackend.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PirateBackend.Models.PirateBackendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PirateBackend.Models.PirateBackendContext context)
        {
            context.PirateDBs.AddOrUpdate(p =>p.Name,
                 new PirateDB
                 {
                     Name = "Debra Garcia",
                     Address = "1234 Main St",
                     City = "Redmond",
                     State = "WA",
                     Zip = "10999",
                     Email = "debra@example.com",
                     Twitter = "debra_example"
                 },
                  new PirateDB
                  {
                      Name = "Thorsten Weinrich",
                      Address = "5678 1st Ave W",
                      City = "Redmond",
                      State = "WA",
                      Zip = "10999",
                      Email = "thorsten@example.com",
                      Twitter = "thorsten_example"
                  },
                  new PirateDB
                  {
                      Name = "Yuhong Li",
                      Address = "9012 State st",
                      City = "Redmond",
                      State = "WA",
                      Zip = "10999",
                      Email = "yuhong@example.com",
                      Twitter = "yuhong_example"
                  },
                  new PirateDB
                  {
                      Name = "Jon Orton",
                      Address = "3456 Maple St",
                      City = "Redmond",
                      State = "WA",
                      Zip = "10999",
                      Email = "jon@example.com",
                      Twitter = "jon_example"
                  },
                  new PirateDB
                  {
                      Name = "Diliana Alexieva-Bosseva",
                      Address = "7890 2nd Ave E",
                      City = "Redmond",
                      State = "WA",
                      Zip = "10999",
                      Email = "diliana@example.com",
                      Twitter = "diliana_example"
                  }
                  );

        }
    }
}
