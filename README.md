# PlatformDemo - Customer Management Application

PlatformDemo is a web application built using ASP.NET Core Razor Pages and Entity Framework Core. It allows you to manage a list of customers and their associated orders. Customers can be searched and viewed in a user-friendly interface.
# Test Task to Complete

This repository contains a .NET solution named `PlatformDemo` with two projects: a .NET 6 Class Library and an ASP.NET Core 6 web application.

## .NET 6 Class Library

The class library project contains:
- An Entity Framework DbContext using a SQL Server provider.
- Two entity classes:
  - `Customer` class with properties: Customer Id, Name, and Phone number.
  - `Order` class with properties: Order Id, Order Number, and Amount.

## ASP.NET Core 6 Web Application

The web application project references the class library and includes:
- A web page that displays a list of customers along with their phone numbers and the total amount of their orders. Each customer is displayed on a separate line, even if they have no orders.
- Sample data is provided with 10-15 customers and 0-5 orders per customer.

## Additional Instructions

- Please make sure to document your code with proper comments.
- Feel free to add your own enhancements to showcase your capabilities. It can be visual or functional.
- If you have any questions about something not specified, use your judgment.
- This task should take you less than an hour to complete.

## How to Run

To run the application, follow these steps:

1. Clone this repository to your local machine.
2. Open the `PlatformDemo.sln` solution file in Visual Studio or your preferred IDE.
3. Build and run the ASP.NET Core web application project.
4. Access the web page to view the list of customers and their orders.

Please provide feedback and share the GitHub repository link with `recruiting@logicimtech.com`.

Good luck with the task!

## Prerequisites

Before running PlatformDemo, make sure you have the following installed:

- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [MySQL](https://www.mysql.com/downloads/) or another supported database

## Getting Started

1. **Clone the repository:**

```bash
git clone https://github.com/yourusername/PlatformDemo.git
```

2. **Update the database connection string in the appsettings.json file with your MySQL or database credentials:**
```
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=PlatformDemo;User=yourusername;Password=yourpassword;"
}
```
3. **Open a terminal in the project directory and run the following commands to apply migrations and create the database:**
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
4. **Build and run the application:**
```
dotnet build
dotnet run
```
5. **Access the application in your web browser at [http://localhost:5000](http://localhost:5000).**

## Features

- **Customer Management:** Add, edit, and delete customer records.
- **Order Management:** Associate orders with customers.
- **Search Functionality:** Search for customers by name.
- **User-Friendly Interface:** A clean and intuitive interface for managing customer data.

## Technologies Used

- ASP.NET Core 5.0
- Entity Framework Core
- MySQL (or other supported databases)
- Bootstrap 5

## Project Structure

Here's an overview of the project structure:

```
PlatformDemo/
│
├── Controllers/
│ ├── HomeController.cs
│ ├── ...
│
├── ApplicationDbContext.cs
│
├── Models/
│ ├── Customer.cs
│ ├── Order.cs
│ ├── ...
│
├── Pages/
│ ├── Index.cshtml.cs
│ ├── ...
│
├── wwwroot/
│ ├── css/
│ ├── js/
│ ├── ...
│
├── appsettings.example.json
├── Program.cs
├── ...
```


## Usage

1. **Customer List:**

   - When you access the application, you'll see a list of customers.
   - You can click on a customer's name to view their details in a modal.
   - Use the search bar to search for customers by name.

2. **Adding a Customer:**

   - Click the "Add Customer" button to add a new customer.
   - Fill in the customer's details and click "Save."

3. **Editing a Customer:**

   - Click the "Edit" button next to a customer's name in the list.
   - Update the customer's details and click "Save Changes."

4. **Deleting a Customer:**

   - Click the "Delete" button next to a customer's name in the list.

5. **Managing Orders:**

   - Customers can have multiple orders associated with them.
   - You can view a customer's orders in their details modal.

6. **Database Configuration:**

   - Update the `appsettings.json` file with your database connection string.

## License

This project is licensed under the MIT License. See the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- Thanks to the ASP.NET Core and Entity Framework Core communities for their excellent documentation and resources.

