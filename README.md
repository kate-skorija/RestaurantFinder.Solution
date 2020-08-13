# Restaurant Finder

#### Entity Exercise for Epicodus 08.03.2020

### By Kate Skorija, Noel Kirkland, Mariel Hamson

## Description

This project was created to practice SQL and Entity Framework. It allows users to associate restaurants with cuisines, then view a list of restaurants in each cuisine.

## Setup/Installation Requirements

1.  Navigate to the [RestaurantFinder.Solution respository](https://github.com/kate-skorija/RestaurantFinder.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/RestaurantFinder.Solution.git`

3. Navigate to the `RestaurantFinder.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the RestaurantFinder directory, and type `dotnet restore`, then `dotnet build`. 

5. Return to your terminal for the RestaurantFinder directory, and enter dotnet ef migrations add Initial. If there is an Unable to resolve project error, ensure you are in the correct directory, RestaurantFinder. A Migrations folder should automatically generate in the RestaurantFinder directory.

6. After the initial migration is complete, run the command `dotnet ef database update`. This will create a `restaurant_finder` database. Refresh MySql Workbench and confirm that the new database has been created.

7. Type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser.

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET-Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
*  [Entity Framework](https://docs.microsoft.com/en-us/ef/)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija, Noel Kirkland, & Mariel Hamson_** 
