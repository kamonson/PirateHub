# PirateHub
This is an app for Whitworth University.  It compiles a "hub" of information pertinent to students, faculty, staff, and parents into one easily accessible phone app.  The information included in this app includes Facebook and Instagram University feeds, a compilation of important phone numbers, various calendars, a campus map, and various in-app browsers.  

##Features
*Academic Calendar:
Uses custom script to pull down API from pirate backend.
The academic calendar information is from https://www.whitworth.edu/cms/administration/registrar/academic-calendars-and-schedules/.  An academic calendar is chosen (based on year and month), scraped, parsed and stored in a database through Microsoft's azure.  All this is done through an Authomation account in Kyle Amonson's azure account.  It is scripted with powershell and updated every day at 2 AM.

*Athletic Calendar:
Uses custom script to pull down API from pirate backend and populate a list of athletic events.
The information for this calendar is from an RSS feed (http://whitworthpirates.com/composite?print=rss).  In a Microsoft Azure runbook, (powershell) the information is parsed and stored in the azure database.  This information is updated every day at 2 AM.

*Blackboard:
Uses iFrame to display blackboard within app page (bb.whitworth.edu)
--bug blackboard is non responsive website, as a result scalling is broken

*Course Evaluations:
An embedded url in an iFrame.  (https://www.smartevals.com/loginMobile.aspx?s=whitworth)

*Event Calendar:
Uses custom script to pull down API from pirate backend.
In a Microsoft Azure powershell runbook, the url: https://www.whitworth.edu/Calendar/Master/listview.aspx?Day= is editted to include a date at the end in the format ('MM-dd-yyyy').  It is then scraped, parsed, and stored in the azure db. This calendar is also updated every day at 2 AM. 

*Facebook:
Embedded in an iFrame.  Utilizes the juicer.io API. Username and password located in SEPirateHub Google Doc. It pulls feed from Whitworth's facebook page.

*Instagram (Gallery):
Embedded in an iFrame.  Utilizes the juicer.io API. Username and password located in SEPirateHub Google Doc. It pulls photos from Whitworth's Instagram page.

*Location Services:
Location services would require permissions on each mobile device, so this feature was left off.

*Map:
{more on Map}

*Phonebook:
{more on Phonebook}




##Backend
PirateBacked Deployed to Azure available api's:
[Backend API Viewing] (piratehub.azurewebsites/api/athleticEvent)

There seems to be a problem with the configuration of visual studio holding onto cors and knockout, with nuget use

Update-Package Microsoft.AspNet.WebApi.Cors -Reinstall
Update-Package knockoutjs -reinstall

also keep after any change to db makesure that 
Update-Database is ran may require -Force (if things are removed)

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

One model for Accademic, Event, and Sports Calendars (this would be better as 3 tables but for now it is what it is):

        public int EventId { get; set; }
        public string ACName { get; set; }
	public string ECName { get; set; }
	public string SCName { get; set; }
        public string ACLocation { get; set; }
	public string ECLocation { get; set; }
	public string SCLocation { get; set; }
        public string ACDescription { get; set; }
	public string ECDescription { get; set; }
	public string SCDescription { get; set; }
        public dateTime ACDateTime { get; set; }
	public dateTime ECDateTime { get; set; }
	public dateTime SCDateTime { get; set; }
        public string SCOpponent { get; set; }
	
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
