using PirateBackend.Models;
namespace PirateBackend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PirateBackend.Models.PirateBackendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PirateBackend.Models.PirateBackendContext context)
        {
            context.AthleticEvents.AddOrUpdate(p => p.AthleticEventType,
               new AthleticEvent
               {
                   AthleticEventType = "BASKetball",
                   AthleticEventDescription = "Like the love child of basketball and baseball",
                   AthleticEventDateTime = DateTime.Now,
                   AthleticEventLocation = "Milwaukee",
                   AthleticEventOpponent = "Roswell Aliens"
               },
                new AthleticEvent
                {
                    AthleticEventType = "Power Walking",
                    AthleticEventDescription = "It's as gay as it sounds",
                    AthleticEventDateTime = DateTime.Now,
                    AthleticEventLocation = "Far From Here",
                    AthleticEventOpponent = "Self"
                }
                );
        }
    }
}
