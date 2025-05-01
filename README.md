
This is a C# desktop application I built as part of a software engineering course project. The goal was to design and implement an inventory management system that meets specific business requirements for a small manufacturing company. 
It simulates how real-world systems are built from initial business requirements to final implementation.

🚀 Overview

The application allows users to:
- Add, modify, and delete parts and products
- Associate parts with products
- Search for parts and products by name or ID
- Perform input validation for numeric fields and business rules
- Navigate between multiple forms for product and part management

The user interface is built using Windows Forms (WinForms), and the architecture is based on object-oriented programming principles with support from a UML class diagram provided in the project.


🧱 Features & Concepts Demonstrated

✅ User Interface (WinForms)
- Multi-form layout using C# Windows Forms Designer
- Controls used: `DataGridView`, `TextBox`, `RadioButton`, `Button`, `Label`, `MessageBox`
- Separate forms for:
  - Main dashboard
  - Add/Modify Part
  - Add/Modify Product

 ✅ Object-Oriented Programming
- Implemented abstract base class `Part` with derived classes `InHouse` and `Outsourced`
- Created `Product` and `Inventory` classes for managing state and associations
- Used inheritance, polymorphism, encapsulation, and abstraction throughout the solution

✅ Application Logic:
- Adding/removing parts to/from a product
- Searching for parts/products with partial string match
- Automatically generating unique IDs for parts/products
- Validation logic:
  - Prevent non-numeric entries in numeric fields
  - Inventory count must be between min and max
  - Cannot delete a part associated with a product without confirmation

✅ UX & Error Handling
- Confirmations before delete operations using `MessageBox`
- Handling of invalid inputs with user feedback
- Form transitions with proper cancellation and save behavior


 🛠 Technologies Used:
- C#
- .NET Framework
- Windows Forms
- Visual Studio 2022



 Screenshots:
![Screenshot (5)](https://github.com/user-attachments/assets/c7b6c77a-01ca-4dd2-ae2e-07c72cb955d8)
![Screenshot (6)](https://github.com/user-attachments/assets/64bd8322-a67c-44ec-9f4a-76df79e47341)
![Screenshot (7)](https://github.com/user-attachments/assets/20588a5b-5faf-4333-bb0a-43d0ba798d66)
![Screenshot (8)](https://github.com/user-attachments/assets/15c35bf6-8cf0-4b53-9bab-209cd75f65d0)

 Some things I learned:

This project helped reinforce:
- Translating business requirements and UML diagrams into working code
- Building desktop applications using WinForms
- Writing clean and maintainable object-oriented code
- Validating and handling user input robustly
- Creating user-friendly interfaces with responsive feedback



There are some things I think I could imporve upon and refactor in this project. If I decided to continue development I would try to implement these changes.
- Persistent data storage using SQL or file I/O
- Improved UI with modern design elements
- Role-based access (admin vs. regular user)
- Unit testing and logging features


