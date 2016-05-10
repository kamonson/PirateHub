<############################################################# Begin Athletic Events #################################################################>
<#
.SYNOPSIS
    Adds records in the specified SQL Server database table.
	
.EXAMPLE
    AddAthleticEvent -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -Type $Type -Description $Description -DateTime $DateTime -Location $Location -Opponent $Opponent   

.NOTES
    AUTHOR: System Center Automation Team
	UPDATED BY: Kyle Amonson
    LASTEDIT: May, 7 1986 
#>

workflow AddAthleticEvent
{
    param(
        [parameter(Mandatory=$True)]
        [string] $SqlServer,
        
        [parameter(Mandatory=$False)]
        [int] $SqlServerPort = 1433,
        
        [parameter(Mandatory=$True)]
        [string] $Database,
        
        [parameter(Mandatory=$True)]
        [string] $Type,		
		[parameter(Mandatory=$True)]
        [string] $Description,
		[parameter(Mandatory=$True)]
        [string] $DateTime,
		[parameter(Mandatory=$True)]
        [string] $Location,
		[parameter(Mandatory=$True)]
        [string] $Opponent
    )
"Athletic Events"
"Param's OK"
"Connecting"	
    # Get the username and password from the SQL Credential
    $SqlUsername = "pirate"
    $SqlPass = "P@ssw0rd"
    
    inlinescript {
        # Define the connection to the SQL Database
        $Conn = New-Object System.Data.SqlClient.SqlConnection("Server=tcp:$using:SqlServer,$using:SqlServerPort;Database=$using:Database;User ID=$using:SqlUsername;Password=$using:SqlPass;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;")
        
        # Open the SQL connection
        $Conn.Open()
"Connected"
"Writing to DB"
        # Define the SQL command to run. In this case we are getting the number of rows in the table
        $Cmd=new-object system.Data.SqlClient.SqlCommand("INSERT INTO dbo.AthleticEvents (AthleticEventType,AthleticEventDescription,AthleticEventDateTime,AthleticEventLocation,AthleticEventOpponent) VALUES ('$using:Type','$using:Description','$using:DateTime','$using:Location','$using:Opponent')", $Conn)
        $Cmd.CommandTimeout=120

        # Execute the SQL command
        $Ds=New-Object system.Data.DataSet
        $Da=New-Object system.Data.SqlClient.SqlDataAdapter($Cmd)
        [void]$Da.fill($Ds)
	
        # Close the SQL connection
        $Conn.Close()
"Great Success!"
    }
}
<############################################################# End Athletic Events #################################################################>

<############################################################# Begin Academic Calandars #################################################################>
<#
.SYNOPSIS
    Adds records in the specified SQL Server database table.
	
.EXAMPLE
    AddAcademicCalandar -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -ACTitle $ACTitle -ACDescription $ACDescription -ACDateTime $ACDateTime -Location $Location -Opponent $Opponent   

.NOTES
    AUTHOR: System Center Automation Team
	UPDATED BY: Kyle Amonson
    LASTEDIT: May, 7 1986 
#>

workflow AddAcademicCalandar
{
    param(
        [parameter(Mandatory=$True)]
        [string] $SqlServer,
        
        [parameter(Mandatory=$False)]
        [int] $SqlServerPort = 1433,
        
        [parameter(Mandatory=$True)]
        [string] $Database,
        
        [parameter(Mandatory=$True)]
        [string] $ACTitle,		
		[parameter(Mandatory=$True)]
        [string] $ACDescription,
		[parameter(Mandatory=$True)]
        [string] $ACDateTime
    )
"Academic Calandars"
"Param's OK"
"Connecting"	
    # Get the username and password from the SQL Credential
    $SqlUsername = "pirate"
    $SqlPass = "P@ssw0rd"
    
    inlinescript {
        # Define the connection to the SQL Database
        $Conn = New-Object System.Data.SqlClient.SqlConnection("Server=tcp:$using:SqlServer,$using:SqlServerPort;Database=$using:Database;User ID=$using:SqlUsername;Password=$using:SqlPass;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;")
        
        # Open the SQL connection
        $Conn.Open()
"Connected"
"Writing to DB"
        # Define the SQL command to run. In this case we are getting the number of rows in the table
        $Cmd=new-object system.Data.SqlClient.SqlCommand("INSERT INTO dbo.AcademicCalandars (AcademicCalandarTitle,AcademicCalandarDescription,AcademicCalandarDateTime) VALUES ('$using:ACTitle','$using:ACDescription','$using:ACDateTime')", $Conn)
        $Cmd.CommandTimeout=120

        # Execute the SQL command
        $Ds=New-Object system.Data.DataSet
        $Da=New-Object system.Data.SqlClient.SqlDataAdapter($Cmd)
        [void]$Da.fill($Ds)
	
        # Close the SQL connection
        $Conn.Close()
"Great Success!"
    }
}
<############################################################# End Academic Calandars #################################################################>

<############################################################# Begin Event Calandars #################################################################>
<#
.SYNOPSIS
    Adds records in the specified SQL Server database table.
	
.EXAMPLE
    AddAthleticEvent -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -AETitle $AETitle -AEDescription $AEDescription -AEDateTime $AEDateTime -Location $Location -Opponent $Opponent   

.NOTES
    AUTHOR: System Center Automation Team
	UPDATED BY: Kyle Amonson
    LASTEDIT: May, 7 1986 
#>

workflow AddAcademicEvent
{
    param(
        [parameter(Mandatory=$True)]
        [string] $SqlServer,
        
        [parameter(Mandatory=$False)]
        [int] $SqlServerPort = 1433,
        
        [parameter(Mandatory=$True)]
        [string] $Database,
        
        [parameter(Mandatory=$True)]
        [string] $AETitle,		
		[parameter(Mandatory=$True)]
        [string] $AELocation,		
		[parameter(Mandatory=$True)]
        [string] $AEDescription,
		[parameter(Mandatory=$True)]
        [string] $AEDateTime
    )
"Event Calandars"
"Param's OK"
"Connecting"	
    # Get the username and password from the SQL Credential
    $SqlUsername = "pirate"
    $SqlPass = "P@ssw0rd"
    
    inlinescript {
        # Define the connection to the SQL Database
        $Conn = New-Object System.Data.SqlClient.SqlConnection("Server=tcp:$using:SqlServer,$using:SqlServerPort;Database=$using:Database;User ID=$using:SqlUsername;Password=$using:SqlPass;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;")
        
        # Open the SQL connection
        $Conn.Open()
"Connected"
"Writing to DB"
        # Define the SQL command to run. In this case we are getting the number of rows in the table
        $Cmd=new-object system.Data.SqlClient.SqlCommand("INSERT INTO dbo.EventCalandars (EventCalandarTitle,EventCalandarLocation,EventCalandarDescription,EventCalandarDateTime) VALUES ('$using:AETitle','$using:AELocation','$using:AEDescription','$using:AEDateTime')", $Conn)
        $Cmd.CommandTimeout=120

        # Execute the SQL command
        $Ds=New-Object system.Data.DataSet
        $Da=New-Object system.Data.SqlClient.SqlDataAdapter($Cmd)
        [void]$Da.fill($Ds)
	
        # Close the SQL connection
        $Conn.Close()
"Great Success!"
    }
}
<############################################################# End Event Calandars #################################################################>

<# Run Additional Scripts To Set Variables #>
$SqlServer = "piratedb.database.windows.net"
$SqlServerPort = 1433
$Database = "PirateBackend_db"
$Type = "Another Test"
$Description ="Another Description"
$DateTime = "Jan 1 1996"
$Location = "Another Location"
$Opponent = "Another Opponent"

AddAthleticEvent -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -Type $Type -Description $Description -DateTime $DateTime -Location $Location -Opponent $Opponent


<# Run Additional Scripts To Set Variables #>
$SqlServer = "piratedb.database.windows.net"
$SqlServerPort = 1433
$Database = "PirateBackend_db"
$ACTitle = "Another Academic Calandar"
$ACDescription ="Another AC description"
$ACDateTime = "Jan 1 1996"

AddAcademicCalandar -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -ACTitle $ACTitle -ACDescription $ACDescription -ACDateTime $ACDateTime

<# Run Additional Scripts To Set Variables #>
$SqlServer = "piratedb.database.windows.net"
$SqlServerPort = 1433
$Database = "PirateBackend_db"
$AETitle = "Another Test"
$AELocation = "Another AE Location"
$AEDescription ="Another AEDescription"
$AEDateTime = "Jan 1 1996"

AddAcademicEvent -SqlServer $SqlServer -SqlServerPort $SqlServerPort -Database $Database -AETitle $AETitle -AELocation $AELocation -AEDescription $AEDescription -AEDateTime $AEDateTime