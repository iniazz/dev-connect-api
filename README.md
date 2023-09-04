# DevConnect - API
# CDN - Complete Developer Network Backend

This is the backend component of CDN - Complete Developer Network, built with .NET. It provides a RESTful API to manage user data.

## Getting Started

These instructions will help you set up and run the backend server locally.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 4.X.X)
- [MSSQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (version 19.X.X)

### Installation

1. Clone this repository:

 	  `git clone https://github.com/iniazz/dev-connect-api.git`
 	  `cd dev-connect-api`

2. Update the appsettings.json file with your local MSSQL database connection string.
   You can use Windows Authentication or specify a username and password in the connection string.

3. Run the migrations to create the database:
	  `dotnet ef database update`

### Running the Application

1. Start the backend server:
      `dotnet run`

The API will be running at http://localhost:5000. (depends on your local machine configurations)

### API Endpoints

    `GET /api/Users:`           Get a list of all registered users.
    `GET /api/Users/{id}:`      Get user details by ID.
    `POST /api/Users:`          Register a new user.
    `PUT /api/Users/{id}:`      Update user details by ID.
    `DELETE /api/Users/{id}:`   Delete a user by ID.

### Configuration

You can customize the database connection string and other settings in the `appsettings.json` file.