# Online Banking Application with Advanced MVC Filters

## Project Name
OnlineBankingMVCFiltersApp

---

# Scenario Overview

This project demonstrates the implementation of Advanced MVC Filters in ASP.NET Core MVC for an Online Banking Application.

The application includes:

- Authentication Filters
- Authorization Filters
- Logging Filters
- Global Exception Handling
- Dependency Injection
- Filter Testing and Debugging

---

# Technologies Used

- ASP.NET Core MVC
- C#
- Visual Studio
- Dependency Injection

---

# Project Structure

```text
OnlineBankingMVCFiltersApp
│
├── Controllers
│     └── BankController.cs
│
├── Filters
│     ├── AuthenticationFilter.cs
│     ├── AuthorizationFilter.cs
│     ├── LoggingFilter.cs
│     └── GlobalExceptionFilter.cs
│
├── Services
│     ├── AuthService.cs
│     └── LoggingService.cs
│
├── Views
│     └── Shared
│           └── Error.cshtml
│
├── Program.cs
│
└── appsettings.json
```

---

# Features Implemented

## 1. Authentication Filter

The authentication filter verifies whether a user is logged in before allowing access to protected banking pages.

Protected pages include:

- Dashboard
- Transactions
- Admin Panel

---

## 2. Authorization Filter

The authorization filter restricts access based on user roles.

Only admin users can access:

- Admin Panel
- Administrative operations

---

## 3. Logging Filter

The logging filter records:

- User actions
- Request URLs
- HTTP Methods
- Response Status Codes
- Banking activities

This helps in monitoring user activity and auditing transactions.

---

## 4. Global Exception Filter

The global exception filter:

- Catches unhandled exceptions
- Logs error details
- Displays a user-friendly error page

This improves application reliability and user experience.

---

## 5. Dependency Injection

All services and filters are managed using Dependency Injection for modularity and maintainability.

---

# Controllers

## Bank Controller

The Bank Controller demonstrates:

- Banking Dashboard
- Transaction History
- Admin Panel Access
- Exception Testing

Filters are applied to secure and monitor these actions.

---

# Example URLs

| URL | Description |
|---|---|
| /Bank/Dashboard | Banking Dashboard |
| /Bank/Transactions | Transaction History |
| /Bank/AdminPanel | Admin Access |
| /Bank/ErrorTest | Exception Testing |

---

# Security Features

The application demonstrates:

- User Authentication
- Role-Based Authorization
- Secure Access Management
- Error Protection

---

# Error Handling

When an exception occurs, the application redirects to a friendly error page instead of crashing.

---

# Testing and Debugging

The application verifies:

- Authentication functionality
- Authorization checks
- Logging operations
- Exception handling
- Dependency Injection integration
- Filter execution

---

# Best Practices Followed

- Modular filter architecture
- Proper Dependency Injection
- Reusable filter implementation
- Centralized error handling
- Secure access management
- Clean project organization

---

# Assignment Outcome

This project successfully demonstrates Advanced MVC Filters in ASP.NET Core MVC including:

- Authentication Filters
- Authorization Filters
- Logging Filters
- Global Exception Filters
- Dependency Injection
- Error Handling
- Filter Testing and Debugging

The implementation improves application security, maintainability, monitoring, and exception management within the online banking system.
