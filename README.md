# FoodStore
#### March 19 2020

ASP.NET core MVC application using Entity Framework Core and MySQL for a restaurant review website. Search our restaurants by cuisine and see reviews for each restaurant. Practice with ASP.NET core MVC with Entity Framework Core and MySQL.

## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone (INSERT REPO NAME)
    ```
2. Change directories into the project working directory:
    ```
    cd FoodStore.Solution
    ```
3. Restore all dependencies:
    ```
    dotnet restore
    ```

 #### Setup Database

4. Run the following commands in MySQL to setup this project Database
    ```
    CREATE DATABASE `bestaurants`;
    USE bestaurants;
    CREATE TABLE `cuisines` (
        `CuisineId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` varchar(255) DEFAULT NULL,
        PRIMARY KEY (`CuisineId`)
    );
    CREATE TABLE `restaurants` (
        `RestaurantId` int(11) NOT NULL AUTO_INCREMENT,
        `Name` varchar(255) DEFAULT NULL,
        `CuisineId` int(11) NOT NULL DEFAULT '0',
        `Description` varchar(255) DEFAULT NULL,
        `Address` varchar(255) DEFAULT NULL,
        `Delivery` tinyint(1) DEFAULT '0',
        PRIMARY KEY (`RestaurantId`)
    ); -->

    ```
5. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```
6. Open the locally hosted server in your preferred web browser:
    ```
    start http://localhost:5000
    ```

## Application Design

### Routing Flowchart

![Project Flowchart](https://github.com/keturahdev/Bestaurants/Bestaurants/images/flowchart.png "Project Flowchart")
<img src="https://github.com/keturahdev/Bestaurants/Bestaurants/images/flowchart.png" />

### MySQL Database Structure

![Project Database Structure](https://github.com/keturahdev/Bestaurants/Bestaurants/images/db.Structure.png "Project FDB Structure")
<img src="https://github.com/keturahdev/Bestaurants/Bestaurants/images/db.Structure.png" />

## Technologies Used

* C#
* ASP.NET core MVC 2.2
* Entity Framework Core
* MySQL + MySQL Workbench version 8.0.15
* RESTful Routing
* CRUD Functionality
* Git

## Authors

* **Patrick Delaney** - (https://github.com/)
* **Keturah Howard** - (https://github.com/KeturahDev)
* **Mariam** - (https://github.com/MMalaeddin)

## License

Licensed under the MIT license.

&copy; 2020 - Mariam , Patrick Delaney, Keturah Howard