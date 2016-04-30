# PirateHub
This is an app for Whitworth University.  It compiles a "hub" of information pertinent to students, faculty, staff, and parents into one easily accessible phone app.  The information included in this app includes Facebook and Instagram University feeds, a compilation of important phone numbers, various calendars, a campus map, and various in-app browsers.  

##Features
*Academic Calendar:
{more on Academic Calendar}

*Blackboard:
Uses iFrame to display blackboard within app page
--bug blackboard is non responsive website, as a result scalling is broken

*Course Evaluations:
{more on Course Evaluations}

*Event Calendar:
{more on Event Calendar}

*Facebook:
{more on Facebook}

*Instagram:
{more on Instagram}

*Location Services:
{more on Location Services}

*Map:
{more on Map}

*Phonebook:
{more on Phonebook}

*Sodexo Menu:
{more on Sodexo Menu}

*Sports Calendar:
Uses custom script to pull down API from pirate backend and populate a list of athletic events


##Backend
PirateBacked Deployed to Azure available api's:
[Backend API Viewing] (piratehub.azurewebsites/api/athleticEvent)

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

[Backend API Viewing] (piratehub.azurewebsites/api/athleticEvent) add /i --I being the id of the event desired, or no i for all listed evens, returned in json/xml format depending on browser

Added CORS support for cross domain api calls

###Known Problem

Tried to add XSRF protection, but this broke the build, for now it is disabled via comments :(

##Frontend
[Start Bootstrap](http://startbootstrap.com/) -  [Grayscale](http://startbootstrap.com/template-overviews/grayscale/) Using: [PhoneGap](http://phonegap.com/) for MultiPlatform Support

###PhoneGap

Used to convert to platfom specific projects for individual editing/compiling, no changes to the source code.  PhoneGap's documentation can be found here http://docs.phonegap.com/

Program implementations:
{+/- implementations here}

###Bootstrap

See the Bootstrap readme.md, https://github.com/twbs/bootstrap/blob/master/README.md

Modified:
{+/- changes}

###Modified Grayscale Template

We used Grayscale Template as our base template, their readme.md can be found here http://startbootstrap.com/template-overviews/grayscale/

We made extensive modification to the template:

CSS Modified:
{+/- changes here}

JS Modified:
{+/- changes here}
