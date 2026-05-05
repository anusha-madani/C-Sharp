🧾 POS System (C# Windows Forms)

📌 Project Overview

This is a Point of Sale (POS) System developed using **C# Windows Forms** and **SQL Server**.
The system allows users to register, login, manage products, add items to cart, and confirm orders.


🚀 Features

🔐 1. User Authentication

* User Registration with **hashed password**
* Secure Login system
* Validation for:

  * Unregistered users
  * Incorrect username/password


📝 2. Registration Form

* Users can create an account
* Username and password stored in database
* Password is stored securely using **SHA256 hashing**


🔑 3. Login Form

* Existing users can login
* System checks:

  * If user exists
  * If password is correct
* Redirects to next page after successful login


📦 4. Product Management

* Add product details:

  * Product Name
  * Price
  * Quantity
* Display products in **DataGridView**
* Features:

  * Add Product
  * Update Product
  * Clear Fields


🛒 5. Your Cart

* Selected products are added to cart
* Displays selected items
* Shows total price


🧾 6. Order Confirmation (Slip)

* Displays confirmation message:

  * **"Your order has been confirmed"**
* Shows **total price**
* Does not display item details (simple confirmation screen)


🏗️ System Flow

1. User registers an account
2. User logs in
3. User adds products
4. Products added to cart
5. Total calculated
6. Order confirmed (message + total price shown)


📂 Forms in Project

1. Registration Form
2. Login Form
3. Product Management Form
4. Your Cart Form
5. Order Confirmation Form


⚠️ Important Notes

* Make sure SQL Server is running
* Update your **connection string** according to your system
* Database must contain required tables (e.g., Users)


💡 Future Improvements

* Show purchased items in slip
* Add invoice/receipt design
* Add print functionality
* Improve UI

---
