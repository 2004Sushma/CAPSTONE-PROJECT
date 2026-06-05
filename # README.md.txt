# README.md

# SupportSphere – Customer Support Ticket Management System

## Project Overview

SupportSphere is a web-based Customer Support Ticket Management System developed using ASP.NET Core MVC, Entity Framework Core, and SQL Server.

The system allows customers to register, log in, raise support tickets, track ticket status, and submit feedback. Administrators can manage tickets, monitor customer issues, update ticket status, and generate reports.

---

## Problem Statement

Organizations often face challenges in managing customer support requests efficiently. Manual tracking of issues can lead to delayed resolutions and poor customer satisfaction.

SupportSphere provides a centralized platform to manage support tickets, improve communication between customers and administrators, and maintain service quality through feedback collection.

---

## Objectives

* Provide a centralized ticket management system.
* Allow customers to raise and track support tickets.
* Enable administrators to manage and resolve tickets.
* Collect customer feedback after issue resolution.
* Maintain secure access through authentication and authorization.

---

## Technology Stack

### Frontend

* HTML5
* CSS3
* Bootstrap
* Razor Views

### Backend

* ASP.NET Core MVC (.NET 8)

### Database

* SQL Server

### ORM

* Entity Framework Core

### Authentication

* ASP.NET Core Identity

### API Documentation

* Swagger / OpenAPI

### Testing

* xUnit

---

## System Modules

### Customer Module

* User Registration
* User Login
* Raise Ticket
* View My Tickets
* Submit Feedback

### Admin Module

* Dashboard
* View All Tickets
* Manage Tickets
* Resolve Tickets
* View Feedback
* Reports

---

## Database Tables

### Categories

Stores ticket categories.

### SubCategories

Stores subcategories under categories.

### Tickets

Stores customer support requests.

### Feedbacks

Stores customer ratings and comments.

### AspNetUsers

Stores registered users.

### AspNetRoles

Stores application roles.

---

## Features Implemented

### Authentication & Authorization

* User Registration
* User Login
* Logout
* Role-Based Access Control
* Admin Role
* Customer Role

### Ticket Management

* Create Ticket
* View Ticket
* Update Ticket
* Delete Ticket
* Track Ticket Status

### Feedback Management

* Submit Feedback
* View Feedback
* Customer Satisfaction Tracking

### API

* REST API Endpoint
* Swagger Documentation
* JSON Response Format

### Testing

* Unit Testing using xUnit
* Ticket Model Tests
* Feedback Model Tests

---

## Architecture

Customer/Admin

↓

ASP.NET Core MVC Application

↓

Controllers

↓

Entity Framework Core

↓

SQL Server Database

---

## Design Patterns Used

### MVC Pattern

The project follows the Model-View-Controller architecture for separation of concerns.

### Dependency Injection

Built-in ASP.NET Core Dependency Injection is used to inject services and database context.

---

## SOLID Principles Followed

### Single Responsibility Principle (SRP)

Each model and controller is responsible for a specific functionality.

Examples:

* Ticket.cs
* Feedback.cs
* TicketsController
* FeedbacksController

### Open/Closed Principle (OCP)

The application can be extended with new modules without modifying existing functionality.

### Dependency Inversion Principle (DIP)

Controllers depend on injected services such as ApplicationDbContext rather than creating dependencies directly.

---

## Security Features

* ASP.NET Identity Authentication
* Role-Based Authorization
* Input Validation using Data Annotations
* Secure Password Storage
* Anti-Forgery Protection

---

## API Documentation

### Swagger UI

```text
https://localhost:7271/swagger/index.html
```

### OpenAPI Specification

```text
https://localhost:7271/swagger/v1/swagger.json
```

### Sample Endpoint

```text
GET /api/TicketsApi
```

---

## Unit Testing

Testing framework used:

```text
xUnit
```

Tests Created:

* Ticket Model Tests
* Feedback Model Tests

Result:

```text
Total Tests : 10
Passed      : 10
Failed      : 0
```

---

## Future Enhancements

* JWT Authentication
* Email Notifications
* Docker Deployment
* Azure Cloud Hosting
* Mobile Application
* AI-Based Ticket Categorization
* Advanced Reporting Dashboard

---

## Business Rules

1. Only authenticated users can access the application.
2. Customers can raise support tickets.
3. Tickets are assigned a category and subcategory.
4. Ticket status is initially set to "Open".
5. Administrators can update ticket status.
6. Feedback can be submitted after ticket resolution.
7. Access is controlled based on user roles.

---

## Project Outcome

SupportSphere successfully provides a secure and efficient customer support ticket management platform. The application demonstrates the implementation of ASP.NET Core MVC, Entity Framework Core, SQL Server, Authentication & Authorization, REST API development, Swagger/OpenAPI documentation, and Unit Testing.

---

## Developed By

**CHINNII SUSHMA**

**Project Name:** SupportSphere – Customer Support Ticket Management System

**Capstone Project**
