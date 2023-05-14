README

# Hotel Schwanen - Additional Services API

This is an ASP.NET Core API project for managing additional services offered by Hotel Schwanen.
The API allows for CRUD (Create, Read, Update, Delete) operations on additional services, as well as querying for all services or a specific service by ID.

## Getting Started

To run this project, you will need to have .NET 5.0 installed.
Clone the repository and open the project in Visual Studio or your preferred IDE. In the `appsettings.json` file, you will need to specify the connection string for your MongoDB database.

## API Endpoints

### `GET /api/Additional`

Returns a list of all additional services.

### `GET /api/Additional/{id}`

Returns the additional service with the specified ID.

### `POST /api/Additional`

Creates a new additional service.

### `PUT /api/Additional/{id}`

Updates the additional service with the specified ID.

### `DELETE /api/Additional/{id}`

Deletes the additional service with the specified ID.

## Technologies Used

- ASP.NET Core 5.0
- MongoDB
- MongoDB.Driver
- Newtonsoft.Json
