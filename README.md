# Todo List Application

This is a Todo list application built using ASP.NET Core MVC, React.js, Material UI, and IIS. The application allows users to create categories and tasks within those categories. Authentication and Authorization mechanisms are implemented to ensure that users only have access to their own data.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- User authentication: Users can register, log in, and log out securely.
- Category management: Users can create, edit, and delete categories.
- Task management: Users can create, edit, and delete tasks within categories.
- User-specific data: Each user has access to their own categories and tasks only.
- Responsive design: The application is optimized for various screen sizes using Material UI.

## Technologies Used

- ASP.NET Core MVC: Backend framework for building web applications.
- React.js: Frontend JavaScript library for building user interfaces.
- Material UI: UI library for creating visually appealing and responsive designs.
- IIS: Web server for hosting the application.

## Getting Started

To get a local copy of the project up and running, follow these steps:

### Installation

1. Clone the repository:

git clone https://github.com/your-username/todo-list.git

2. Navigate to the project directory:

cd todo-list

3. Install the required dependencies for the ASP.NET Core backend. Run the following command in the project's root directory:

dotnet restore

4. Install the required dependencies for the React.js frontend. Run the following command in the `ClientApp` directory:

npm install

### Usage

1. Start the ASP.NET Core backend server. Run the following command in the project's root directory:

dotnet run

The backend server will be running on `http://localhost:5000`.

2. Start the React.js frontend development server. Run the following command in the `ClientApp` directory:

npm start


The frontend development server will be running on `http://localhost:3000` and will automatically open in your default browser.

3. Access the application in your browser by visiting `http://localhost:3000`.

### Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request.

1. Fork the repository.
2. Create a new branch: `git checkout -b feature/your-feature-name`.
3. Commit your changes: `git commit -am 'Add some feature'`.
4. Push to the branch: `git push origin feature/your-feature-name`.
5. Open a pull request.

### License

This project is licensed under the [MIT License](LICENSE).
