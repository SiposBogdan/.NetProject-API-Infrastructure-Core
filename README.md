# 🛍️ SkiNet E-Commerce Store

This project is a complete E-Commerce web application built using **.NET 8** for the backend and **Angular 18** for the frontend.

> ⚙️ Based on the course: **"Learn to build an e-commerce app with .NET Core and Angular"** by **Neil Cummings**  
> 📚 Updated for .NET 8 and Angular 18

---

## 📦 What I used?

- ASP.NET Core 8 - RESTful API Backend
- Angular 18 - Modern SPA Frontend
- Identity - User Registration, Login, Roles
- Stripe Integration - Secure Payments (3D Secure)
- Redis - Shopping Cart Storage
- Repository Pattern, Specification Pattern
- Angular Reactive Forms + Custom Validators
- Angular Material + TailwindCSS UI
- Pagination, Sorting, Searching, Filtering
- Real-Time Notifications with SignalR

---

## 🧠 What I Learned

- Setting up a full-stack development environment
- Building a multi-project .NET solution using the CLI
- Creating a modular and responsive Angular 18 UI
- Implementing advanced architectural patterns in .NET
- Using Redis to persist shopping cart state
- Processing payments using Stripe (w/ 3D Secure)
- Real-time features using SignalR
- Building clean, reusable components with Angular


## 🧪 Screenshots

Here are some pictures from the website, demonstrating key features of the application:

---

### 🏠 Homepage

![Homepage Screenshot](https://github.com/user-attachments/assets/1eea6c01-769b-4266-8c16-5ecb969f3abc)

The homepage introduces the brand and allows users to navigate directly to the shop. Built with Angular 18 and styled using TailwindCSS, it includes a hero image and call-to-action button.

---

### 🛍️ Shop Page

![Shop Page](https://github.com/user-attachments/assets/814ec6e9-6374-47f5-85cf-d302866dbb71)


The shop page displays a dynamic list of products with features like:

- **Search bar** for quick product lookup
- **Filtering and sorting** by brand, type, and price
- **Pagination** to manage large product lists
- **Responsive product grid** with item cards showing title, price, and “Add to cart” button

Each product card is clickable and routes to a detailed product page. This view is fully responsive and built using Angular components with TailwindCSS styling.

---

### 🔍 Product Filters

![Product Filters](https://github.com/user-attachments/assets/fbf2321f-50fc-42a0-9466-85773a9636ae)

Users can filter products by brand, type, and sort by price or name. The filtering functionality is implemented using Angular reactive forms and observables.

---

### 🙍‍♀️ Registration Page with Validation

![Register Page](https://github.com/user-attachments/assets/daa8e09e-ec5d-4fe9-ba38-285f62014dee)

This is the user registration form. If fields are left empty or invalid, Angular’s reactive form validation displays helpful error messages in real-time.

---

### 🔐 Login Page

![Login Page](https://github.com/user-attachments/assets/dc45fc56-d459-457c-8d1f-245288df403a)

The login page allows users to sign in with their credentials. The form includes validation and integrates with the ASP.NET Identity system to securely authenticate users.

---

### 🧺 Product Details and Shopping Cart

![Product Detail](https://github.com/user-attachments/assets/567d4c51-d0f1-4140-9014-4c9d95fcc57c)

Displays detailed product information and allows users to add items to the cart if that quantity is not already in the shopping cart.

![Shopping Cart](https://github.com/user-attachments/assets/0b6e2dd3-bedb-45ce-a9df-34b50aff33e6)

---

### 💳 Multi-step Checkout with Stripe Integration

![Checkout Step 1](https://github.com/user-attachments/assets/6fbbd57b-17dc-4d8d-8301-4e0dfde22361)

Shows a summary of products in the basket with options to update quantities or proceed to checkout. The basket state is persisted using Redis.

![Checkout Step 2 - Payment](https://github.com/user-attachments/assets/3e29a850-d5c4-4728-b351-b34120c959af)

Users provide their shipping address and review their order.

![Admin Panel](https://github.com/user-attachments/assets/d42af1c4-51f8-4b05-a4ee-54990d8601c6)

User provide the method of shipping they want.

![Order Confirmation](https://github.com/user-attachments/assets/5b812131-228f-4fb6-b0ef-1dc822e23ba1)

Payment is processed securely using Stripe's 3D Secure standard.

![SignalR Notifications](https://github.com/user-attachments/assets/5cb1be4d-100e-4d38-bcd1-c9cc40a59c86)

The order confirmation page.
