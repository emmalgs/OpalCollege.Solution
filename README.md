# Opal College Registrar

### By Emma Gerigscott, Thomas McDowell, Sarah Reimann

![gif of webpage in action](./OpalCollege/wwwroot/img/opalcollege.gif)

## Description

The registrar at Opal College needs to add students, courses, and departments. This webpage allows the registrar to manage student enrollment, course information, and related department information.

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MVC
* Entity Framework Core
* Pomelo Entity Framework Core
* EF Core Migrations
* Html Helpers
* MySQL

## Database Structure

![image of schema connections](./OpalCollege/wwwroot/img/schema.png)

## Setup Instructions

1. Clone this repo.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "OpalCollege".
3. Set up the project:
  * Create a file called 'appsettings.json' in HairSalon.Solution/HairSalon directory
  * Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=opal_college;uid=[YOUR_SQL_USER_ID];pwd=[YOUR_SQL_PASSWORD];"
    }
  }
  ```
  * Make sure to plug in your SQL user id and password at ```[YOUR_SQL_USER_ID]``` and ```[YOUR_SQL_PASSWORD]```
4. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project (OpalCollege.Solution/OpalCollege) run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench called ```opal_college```
5. Running the project in your browser:
  * Navigate to the production directory "OpalCollege" from your terminal.
  * Run the command from OpalCollege ```dotnet watch run```
  * Your browser should automatically open ```https://localhost:5001/```. You may need to enter your computers password when prompted to allow ASP.NET Core to run in your browser.


## Known Bugs

* _No professor data_
* _No class date information_

## License
[MIT](https://opensource.org/licenses/MIT)  
Copyright © 2023 Emma Gerigscott, Thomas McDowell, Sarah Reimann