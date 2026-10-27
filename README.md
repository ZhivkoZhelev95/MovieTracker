	
	
	About the Project

MovieTracker is a web application that i created for my project.It allows the 
user to add delete and edit movies in order to keep track of what they have watched
what they want to watch what they liked and disliked.

	Features

-View a collection of movies
-Add new movies 
-Edit existing movie information
-Delete movies
-Add movie ratings
-validate user input

	Technologies Used

-C#
-ASP.NET Core MVC (.NET 8)
-Entity Framework Core
-Microsoft SQL Server
-Razor Views
-HTML and CSS
-Bootstrap
-JavaScript

	Database

MovieTracker uses SQL server to store the movie information.
Enitity Framework Core is used to interact with the database
and perform CRUD operations on the movie data.
The project contains three main entity models
-Movie: Stores info about each movie
-Genre: Represents the catagory of a movie
-Director: Stores information about movie directors

	How to Run the Project

To run MovieTracker locally, you need:
Visual Studio 2022
SQL Server LocalDB
Entity Framework Core tools

	Installation

1.Clone or download the GitHub repository.
2.Open MovieTracker.sln in Visual Studio.
3.Restore the NuGet packages.
4.Check the database connection string in appsettings.json.
5.Open the Package Manager Console.
6.Run the following command:Update-Database
7.Start the application using Visual Studio.