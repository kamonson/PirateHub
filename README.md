# PirateHub
This is the working copy of the missing Whitworth University Student App

##Backend

PirateBacked Deployed to Azure

###Creation

Web App Name: PirateBacked
Subscription: Azure Pass (this is a trial associated with Kyle Amonson's Account)
Service Plan: South Centeral US
Resource Group: Backend

Database Server: PirateDB
User Name: see team
Password: see team

Updated _Layout.cshtmll to represent document

###Publishing

Server:  piratehub.scm.azurewebsites.net:443
Site Name: PirateHub
User name: see team
Password:  see team
Destination URL: http://piratehub.azurewebsites.net

###Database

The ASP.NET MVC the scaffolding feature can automatically generate code that performs create, read, update, and delete (CRUD) actions.

Model Framework for AthleticEvent:
    public class AthleticEvent
    {
        public int AthleticEventId { get; set; }
        public string AthleticEventType { get; set; }
        public string AthleticEventDescription { get; set; }
        public DateTime AthleticEventDateTime { get; set; }
        public string AthleticEventLocation { get; set; }
        public string AthleticEventOpponent { get; set; }
        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture,
               "api/athleticEvent/{0}", this.AthleticEventId);
            }
            set { }
        }
    }
	
###MVC 5 Controller with views using Entity Framework

Model Class: AthleticEvents (PirateBackend.Models)
Data context class: PirateBackend.Models.PirateBackendContext
Controller Name: HomeController

###View Edititing

This is a complicated beast.

Customized index to call and set api data to website

added AthleticEventController to handle api calls

piratehub.azurewebsites/api/athleticEvent/ i --I being the id of the event desired, or no i for all listed evens, returned in json/xml format depending on browser

###Known Problem

Tried to add XSRF protection, but this broke the build, for now it is disabled via comments :(



