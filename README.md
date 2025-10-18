# StackDynamic-Profile (A GET Endpoint which returns dynamic data about Qtech.)

A .NET 9 Web API for dynamic user profiles, featuring integration with external APIs (e.g., Cat Facts).  
GitHub Repository: [https://github.com/rahmantaiwo/Stack-Profile](https://github.com/rahmantaiwo/Stack-Profile)

## Table of Contents

- [Features](#features)
- [Setup Instructions](#setup-instructions)
- [Running Locally](#running-locally)
- [Dependencies](#dependencies)
- [Environment Variables](#environment-variables)
- [API Documentation](#api-documentation)

## Features

- ASP.NET Core Web API (C# 13, .NET 9)
- Swagger/OpenAPI documentation
- CORS enabled (AllowAll policy)
- External API integration (Cat Facts)
- Profile management endpoints

## Setup Instructions

1. **Clone the repository:**

2. **Install .NET 9 SDK:**  
   Download and install from [dotnet.microsoft.com/download/dotnet/9.0](https://dotnet.microsoft.com/download/dotnet/9.0)

3. **Restore NuGet packages:**


## Running Locally

1. **Configure environment variables** (see below).
2. **Run the API:**
3. **Access Swagger UI:**  
   Navigate to [https://localhost:5001/swagger](https://localhost:5001/swagger) in your browser (development mode).


## Dependencies

| Package                        | Version   | Install Command                                      |
|---------------------------------|-----------|------------------------------------------------------|
| Microsoft.AspNetCore.OpenApi    | 9.0.9     | `dotnet add package Microsoft.AspNetCore.OpenApi`    |
| Swashbuckle.AspNetCore          | 9.0.6     | `dotnet add package Swashbuckle.AspNetCore`          |

All dependencies are restored automatically with `dotnet restore`.


## Environment Variables

The API requires configuration for the external Cat Facts API.  
Set the following in `src/StackProfile/appsettings.json` or as environment variables:

- **BaseUrl**: The root URL for the Cat Facts API.

If deploying to production, set these values securely as environment variables or in your cloud configuration.

---

## API Documentation

- Swagger UI is available in development mode at `/swagger`.
- Endpoints include profile management and fetching random cat facts.


