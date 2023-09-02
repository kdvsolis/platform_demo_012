# PlatformDemo - Customer Management Application

PlatformDemo is a web application built using ASP.NET Core Razor Pages and Entity Framework Core. It allows you to manage a list of customers and their associated orders. Customers can be searched and viewed in a user-friendly interface.

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

