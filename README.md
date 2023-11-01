# Task Management System

Task Management System is a web application designed to simplify project management and enhance team collaboration. Built using .NET Core, Angular, and SQL Server, this system provides a robust solution for managing tasks, projects, and team members efficiently.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Introduction

Task Management System streamlines project management by enabling users to create projects, assign tasks, set deadlines, and monitor progress. It offers an intuitive interface developed with Angular for seamless user experience and utilizes .NET Core for robust back-end functionality.

## Features

- **Project Management:** Create, edit, and manage multiple projects.
- **Task Assignment:** Assign tasks to team members with detailed descriptions and deadlines.
- **Real-time Updates:** Receive notifications and updates on task assignments and completions.
- **Interactive Dashboard:** Visualize project progress and task status through interactive charts and graphs.

## Technologies

- **Frontend:** Angular, Bootstrap
- **Backend:** .NET Core, Entity Framework Core
- **Database:** SQL Server
- **Authentication:** JSON Web Tokens (JWT)
- **Version Control:** Git, GitHub

## Getting Started

### Prerequisites

Ensure you have the following software/tools installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [Angular CLI](https://cli.angular.io/)
- [SQL Server](https://www.microsoft.com/sql-server/)

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/g0elles/TaskAssigmentPlatform.git
   ```

2. Navigate to the project directory (frontend and backend) and install dependencies:

   For frontend (Angular):
   ```
   cd task-management-system/frontend
   npm install
   ```

   For backend (.NET Core):
   ```
   cd TaskAssigmentPlatform/backend
   dotnet restore
   ```

3. Configure the database connection in the `appsettings.json` file in the backend project.

4. Apply database migrations to create the database schema:
   ```
   cd TaskAssigmentPlatform/taskApi
   dotnet ef database update
   ```

5. Run the backend server:
   ```
   cd TaskAssigmentPlatform/backend
   dotnet run
   ```

6. Run the Angular development server:
   ```
   cd task-management-system/frontend
   ng serve
   ```

7. Access the application in your browser: `http://localhost:4200`

## Usage

Upon installation, log in to the Task Management System. Create projects, assign tasks, and collaborate effectively with your team. Enjoy real-time updates and visualizations to track project progress.

## Contributing

Contributions are welcome! Please follow the [Contribution Guidelines](CONTRIBUTING.md) to contribute to this project.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- The development team would like to thank the open-source community for their valuable contributions.
- Special thanks to [Angular](https://angular.io/), [.NET Core](https://dotnet.microsoft.com/), and [SQL Server](https://www.microsoft.com/sql-server/) for the powerful tools and technologies used in this project.