# 🛒 E-Commerce Backend API (.NET)

A production-ready E-Commerce backend system built using **ASP.NET Core Web API** following **Clean Architecture principles**.

---

## 📌 Overview

This project provides a scalable and maintainable backend for an E-Commerce platform.
It supports user authentication, product management, order processing, and more.

---

## 🚀 Features

### 🔐 Authentication & Authorization

* JWT Authentication
* Role-Based Authorization (Admin / User)

### 📦 Product Management

* Create, Update, Delete Products
* Product Categories
* Stock Management

### 🛒 Cart System

* Add to Cart
* Remove from Cart
* Update Quantity

### 📑 Order Management

* Checkout Process
* Order History
* Order Status Tracking

### ⚙️ Advanced Features

* Global Error Handling
* Logging
* Pagination, Filtering, Sorting
* Soft Delete
* Audit Logging
* Background Jobs (e.g., Email after order)

---

## 🏗️ Architecture

This project follows **Clean Architecture**:

```
Ecommerce.API            → Presentation Layer (Controllers)
Ecommerce.Application    → Business Logic
Ecommerce.Domain         → Entities & Interfaces
Ecommerce.Infrastructure→ Data Access & External Services
```

---

## 🛠️ Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* FluentValidation
* Mapster

---

## ⚡ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/ecommerce-backend.git
cd ecommerce-backend
```

### 2. Setup Database

* Update connection string in `appsettings.json`
* Run migrations:

```bash
dotnet ef database update
```

### 3. Run the project

```bash
dotnet run
```

---

## 🔑 API Endpoints (Sample)

### Auth

* `POST /api/auth/register`
* `POST /api/auth/login`

### Products

* `GET /api/products`
* `POST /api/products`

### Orders

* `POST /api/orders`
* `GET /api/orders`

---

## 🧪 Testing

You can test the API using:

* Postman
* Swagger UI (`/swagger`)

---

## 📈 Future Improvements

* Payment Integration (Stripe)
* Docker Support
* CI/CD Pipeline
* Microservices Architecture

---

