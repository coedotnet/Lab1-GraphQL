# Lab1-GraphQL
This repository contains a GraphQL Webapi Lab made for learning purposes.
This project is managed by the .Net COE.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
Make sure you have installed the following tools:

+ Git
You can download GIT from: https://git-scm.com/downloads

+ Visual Studio
You can download Visual Studio from: https://visualstudio.microsoft.com/

+ .Net 6:
You can download .Net 6 from: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

+ Microsoft SQL Server
You can download MSS from: https://www.microsoft.com/es-cl/download/details.aspx?id=104781

## Installing
The following steps will help you to configure the development environment:

### Clone repository
Using a terminal, run the following sentence in the local folder where the source code will be downloaded
$ git clone https://github.com/coedotnet/GraphQL.git
clone it directly using Visual Studio is also possible.

### Restore the nuget packages
+ In Solution Explorer, right-click on Solution and then select Restore NuGet Packages.
+ Wait until the restoration is completed.

### Configure connection string
Locate the appsettings.json file located in the root path and update the connection string setting to the local SQL Server Instance

### Run the migrations
Run migrations with the following command on the console:
Update Database

### Add additional data
Within folder Database Scripts you can find 3 scripts that you can run in your local database to add data to the tables.

### Run the project
Run the SuperHeroes Webapi project and Execute the following query in the Operations Tab on the Hot Chocolate Page:

query{
`superheroes{`
 name
`}`
}

If the following response is shown then the project setup has been successful:

{"data": {
`"superheroes": [`

`	  	{`"name": "Superman"``}`

`]`
}
