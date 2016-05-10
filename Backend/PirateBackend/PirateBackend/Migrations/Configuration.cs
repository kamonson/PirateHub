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

        //protected override void Seed(PirateBackend.Models.PirateBackendContext context)
        //{
        //    context.AthleticEvents.AddOrUpdate(p => p.AthleticEventType,
        //       new AthleticEvent
        //       {
        //           AthleticEventType = "BASKetball",
        //           AthleticEventDescription = "Like the love child of basketball and baseball",
        //           AthleticEventDateTime = DateTime.Now,
        //           AthleticEventLocation = "Milwaukee",
        //           AthleticEventOpponent = "Roswell Aliens"
        //       },
        //        new AthleticEvent
        //        {
        //            AthleticEventType = "Power Walking",
        //            AthleticEventDescription = "It's as gay as it sounds",
        //            AthleticEventDateTime = DateTime.Now,
        //            AthleticEventLocation = "Far From Here",
        //            AthleticEventOpponent = "Self"
        //        }
        //        );
        //    context.AcademicCalandars.AddOrUpdate(p => p.AcademicCalandarTitle,
        //        new AcademicCalandar
        //        {
        //            AcademicCalandarTitle = "The First Day Of The Rest Of Your Life",
        //            AcademicCalandarDescription = "Another bougas motivational speach",
        //            AcademicCalandarDateTime = DateTime.Now
        //        }
        //        );
        //    context.EventCalandars.AddOrUpdate(p => p.EventCalandarTitle,
        //        new EventCalandar
        //        {
        //            EventCalandarTitle = "Yet another booring lecture",
        //            EventCalandarLocation = "Dixon Hall",
        //            EventCalandarDescription = "Core 350 talk about food policy, drone on and on and on and ...",
        //            EventCalandarDateTime = DateTime.Now
        //        }
        //        );
        //}
    }
}
