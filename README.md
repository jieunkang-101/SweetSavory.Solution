# :lollipop: Pierre's Sweet and Savory Treats

#### Advanced Databases and Authentication Independence Project, 27 March 2020
 
#### By **_Jieun Kang_**

---

## Description
A MVC web application with user authentication, authorization, and many-to-many relationship. Authentication lets the a user be able to log in ang log out, authoriztion lets the only logged in user be able to access create, update, and delete functionality. Program have many-to-many relationship between `Treat` and `Flavor`s, so a treat can have many flavors, and vice versa.

---

## Behavior Driven Development Specifications
|| Behavior(Spec)  | Input   | Output  |
|---| :---------------- | :----- | :----- |
|1| Upon launching the application, user sees homepage | http://localhost:5000 | Splash Page |
|2| All users can `read` lists all treats and flavors that currently exist | Click `Flavors` in the navigation bar | Display a list of all treats |
|3| All users can click on an individual treat or flavor to see all the treats or flavors that belong to it | Click `sweet` | Treats that belong to sweet flavor <li>chocolate</li><li>croissants</li><li>cheesecake</li>|
|4| Only logged in users can have `create`, `update` and `delete` functionality | Click `Add New Flavor` <li> Name: creamy </li><li> Treat(Dropdown): pudding  </li>| Flavors <li>...</li><li>creamy</li> |

---

## Setup/Installation 
### :small_orange_diamond: Installing C# and .NET

* _Download on Mac [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer)_
* _Download on Windows [64-bit .NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer)_

### :small_orange_diamond: Installing and Configuring MySQL
Follow the installation instructions below to installing **MySQL Community Server** and **MySQL Workbench**
#### MacOS  

1. _Download from the [MySQL Community Server Page](https://dev.mysql.com/downloads/file/?id=484914)_ (Use the No thanks, just start my download link.)
2. _Download from the [MySQL Workbench Page](https://dev.mysql.com/downloads/file/?id=484391)_ (Use the No thanks, just start my download link.)
3. Verity MySQL installation by opening terminal and entering the command: <br>`$ mysql -uroot -pYOURPASSWORD`

#### Windows 10

1. _Download the [MySQL Web Installer](https://dev.mysql.com/downloads/file/?id=484919)_ (Use the No thanks, just start my download link.)
2. Add the MySQL environment variable to the System PATH.
    * Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
    * Then select PATH..., click Edit..., then Add.
    * Add the exact location of your MySQL installation, and click OK.
3. Add the exact location of your MySQL installation, and click OK.
4. Verity MySQL installation by opening terminal and entering the command: <br>`$ mysql -uroot -pYOURPASSWORD`

### :small_orange_diamond: Re-create the database
#### Using MySQL:
```
$ mysql -uroot -pYOURPASSWORD
mysql> CREATE DATABASE `jieun_kang`;
mysql> USE `jieun_kang`; 
mysql> CREATE TABLE `Flavors` (
    `FlavorId` int(11) NOT NULL AUTO_INCREMENT,
    `FlavorName` longtext,
    `UserId` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`FlavorId`),
    KEY `IX_Flavors_UserId` (`UserId`),
    CONSTRAINT `FK_Flavors_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT);
mysql> CREATE TABLE `Treats` (
    `TreatId` int(11) NOT NULL AUTO_INCREMENT,
    `TreatName` longtext,
    `UserId` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`TreatId`),
    KEY `IX_Treats_UserId` (`UserId`),
    CONSTRAINT `FK_Treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT);
mysql> CREATE TABLE `TreatFlavors` (
    `TreatFlavorId` int(11) NOT NULL AUTO_INCREMENT,
    `TreatId` int(11) NOT NULL,
    `FlavorId` int(11) NOT NULL,
    PRIMARY KEY (`TreatFlavorId`),
    KEY `IX_TreatFlavors_FlavorId` (`FlavorId`),
    KEY `IX_TreatFlavors_TreatId` (`TreatId`),
    CONSTRAINT `FK_TreatFlavors_Flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
    CONSTRAINT `FK_TreatFlavors_Treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE);
```

#### Import from the Cloned Repository
```
1. Launch MySQL Workbench and open the [Navigator] window.
2. In the [Navigator > Administration] window, select [Data Import/Restore].
3. In [Import Options] select [Import from Self-Contained File].
4. Under [Default Schema to be Imported To], select the [New] button. Enter the name of database "jieun_kang"
5. Click [Start Import].    
```

### :small_orange_diamond: Run this project

1. Clone this project
    * `$ cd desktop`
    * `$ git clone https://github.com/jieunkang-101/SweetSavory.Solution`
    * `$ cd SweetSavory.Solution`
2. Add Dependencies for **Entity Framework Core**   
    * `$ cd SweetSavory`
    * `$ dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`
    * `$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
3. Run this MVC application    
    * `$ dotnet restore` 
    * `$ dotnet build` 
    * `$ dotnet run` 
    * Launch localhost http://localhost:5000

---

## Technologies Used
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.NET](https://dotnet.microsoft.com/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://www.mysql.com/)
* [MySQL Workbench](https://www.mysql.com/products/workbench/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.2)
* [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-2.2&tabs=visual-studio)
* [Bootstrap v4.4](https://getbootstrap.com/docs/4.4/getting-started/introduction/)

---

### License

*This webpage is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license*

Copyright (c) 2020 **_Jieun Kang_**