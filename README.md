# Employee Management System

![Platform](https://img.shields.io/badge/Platform-Console-success)
![C#](https://img.shields.io/badge/C%23-.NET-blue?logo=csharp)
![Architecture](https://img.shields.io/badge/Architecture-N--Tier-orange)
![Platform](https://img.shields.io/badge/Platform-Console-success)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen)

An Employee Management System developed in **C# using .NET**, following an **N-tier (Layered) Architecture** to ensure separation of concerns, maintainability, and scalability. The application manages employee and department records through dedicated Presentation, Business Logic, Data Access, and Data Transfer Object layers while implementing validation and file-based data persistence.

---

## Overview

The project demonstrates the implementation of a layered software architecture by separating the user interface, business rules, and data access into independent layers. Employee and department information is managed through a menu-driven console application with support for CRUD operations, searching, validation, and department management.

---

## Features

### Employee Management

- View all employee records.
- Add new employees.
- Update employee salary.
- Transfer employees between departments.
- Delete employee records.

### Search Functionality

- Search employees by ID.
- Search employees by name.
- Search employees by department.
- Search employees by joining date.

### Department Management

- Add new departments.
- Update department descriptions.
- Delete departments.

### Data Validation

- Prevent duplicate employee IDs.
- Prevent duplicate department IDs.
- Validate employee age.
- Validate employee names.
- Verify department existence before employee assignment.

---

## Technologies Used

| Category | Technology |
|----------|------------|
| Language | C# |
| Framework | .NET |
| Architecture | N-tier (Layered) Architecture |
| Data Storage | Text Files |
| Design | Object-Oriented Programming |
| Components | PL, BLL, DAL, DTO |

---

## Architecture

```
                  Employee Management System

                  Presentation Layer (PL)
                           │
                           ▼
                Business Logic Layer (BLL)
                           │
                           ▼
                 Data Access Layer (DAL)
                           │
                           ▼
               Employee & Department Files
```

### Layer Responsibilities

**Presentation Layer (PL)**

- Provides the console-based user interface.
- Handles user interaction and menu navigation.

**Business Logic Layer (BLL)**

- Processes business rules.
- Performs validations.
- Coordinates communication between layers.

**Data Access Layer (DAL)**

- Reads and writes employee and department data.
- Handles file operations.

**Data Transfer Objects (DTO)**

- Transfers employee and department data between layers.

---

## Project Structure

```
EmployeeManagementSystem/
│
├── PL/
├── BLL/
├── DAL/
├── DTO/
├── employee.txt
├── department.txt
├── EmployeeManagementSystem.sln
├── .gitignore
└── README.md
```

---

## Functional Modules

- Employee Management
- Department Management
- Employee Search
- Employee Updates
- Employee Transfer
- Data Validation
- File Management

---

## Workflow

```
User Input
      │
      ▼
Presentation Layer
      │
      ▼
Business Logic Layer
      │
      ▼
Data Access Layer
      │
      ▼
Employee & Department Files
      │
      ▼
Processed Result
```

---

## How to Run

1. Clone the repository.

```bash
git clone https://github.com/hoorialaiba/EmployeeManagementSystem.git
```

2. Open the solution in Visual Studio.

3. Build the solution.

4. Run the Presentation Layer project.

5. Use the console menu to perform employee and department management operations.

---

## Key Concepts Demonstrated

- N-tier Architecture
- Separation of Concerns
- Object-Oriented Programming
- Business Logic Layer
- Data Access Layer
- Data Transfer Objects (DTO)
- File Handling
- CRUD Operations
- Data Validation
- Modular Software Design

---

## Future Improvements

- Replace file-based storage with SQL Server or SQLite.
- Develop a Windows Forms or WPF graphical user interface.
- Implement authentication and role-based authorization.
- Export employee reports to PDF or Excel.
- Add advanced search, filtering, and sorting capabilities.
- Introduce unit testing for business logic.

---

## Author

**Hooria Laiba**

Software Engineering Graduate  
Punjab University College of Information Technology (PUCIT)

GitHub: https://github.com/hoorialaiba
