# Menu Orders ASP.NET Core Web App


Restaurant orders web app developed with ASP.NET Core Razor pages (server side) and Entity Framework Core. It consists of 5 pages with a SQL server connection to read and write purchase orders data. The user views are created using C# embedded in html with some simple CSS bootstrap custom classes, and all data bindings are executed with post (create new order) and get (retrieve orders data) endpoints. Additionally, data is sent and retrieved from the database dynamically using dependency injections with inherited constructors.


## Usage
Clone the repository in VS and install the database context entity framework core, these packages are neccesary:
1. Entity framework core 7.0.10
2. Entity framework core SQL Server 7.0.10
3. Entity framework core tools 7.0.10

It is neccesary to execute database migrations if the data models change or the database context classes are modified. This can be done in the package manager console with the following command: ad-migration MigrationCustomName.

## Layout
<br/>

<br/>

<img src="/Source/wwwroot/Images/MenuPage.PNG" width="700" height="500">

<br/>

<br/>

<br/>

<img src="/Source/wwwroot/Images/BurgerSelectorPage.PNG" width="700" height="500">

<br/>

<br/>

<br/>

<img src="/Source/wwwroot/Images/CheckoutPage.PNG" width="700" height="500">

<br/>

<br/>

<img src="/Source/wwwroot/Images/CustomOrderPage.PNG" width="700" height="500">
<br/>

<br/>

<img src="/Source/wwwroot/Images/CustomOrderCheckoutPage.PNG" width="700" height="500">
<br/>

<br/>

<img src="/Source/wwwroot/Images/OrdersDatabasePage.PNG" width="700" height="500">



