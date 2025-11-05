
## CSharp-Generic-Repository-Pattern
# C# Generic Repository Pattern with Factory & Dependency Injection

This repository contains a **C# console application** that demonstrates the implementation of the **Generic Repository Pattern** combined with the **Factory Pattern** and **Dependency Injection (DI)** principles.

The project provides a flexible and decoupled approach to data management by performing basic **CRUD (Create, Read, Update, Delete)** operations on entities like **Brand**, **Category**, and **Product** using an **in-memory data store**.

This project serves as a solid example for understanding core **object-oriented design principles** and widely-used **software design patterns** in C#.

---

##  Features & Implemented Concepts

**Generic Repository Pattern**  
Provides a generalized interface (`IRepositories<T>`) and an in-memory implementation (`GenericRepositories<T>`) for common data operations (Add, Get, Update, Delete) across different entity types.

**Factory Pattern**  
Uses `IRepoFactory` and `RepoFactory` to create instances of repositories, abstracting object creation.

**Dependency Injection (DI)**  
Demonstrates constructor injection in `TestClass` to inject `IRepoFactory`, promoting loose coupling and testability.

**In-Memory Data Storage**  
Uses `List<T>` for data manipulation — no external database required.

**Data Models**  
Includes base class `CommonAttributes` and entity classes: `Brand`, `Category`, `Product`.

**CRUD Operations**  
Add, retrieve (by ID or all), update, and delete both single and multiple entities.

**Object Equality**  
Overrides `Equals()` and `GetHashCode()` in `CommonAttributes` for accurate comparisons during update/delete.

---

##  Project Structure

RepositoryProject/
├── Models/
│ ├── CommonAttributes.cs
│ ├── Brand.cs
│ ├── Category.cs
│ └── Product.cs
│
├── Repositories/
│ ├── IRepositories.cs
│ └── GenericRepositories.cs
│
├── Factory/
│ ├── IRepoFactory.cs
│ └── RepoFactory.cs
│
├── DITest/
│ └── TestClass.cs
│
└── Program.cs

##  How to Use

###  Clone the Repository

```bash
git clone https://github.com/habibnstu/CSharp-Generic-Repository-Pattern.git](https://github.com/Irin-Mimo/CSharp-Generic-Repository-Pattern-main.git
````

 Open in Visual Studio (or your preferred IDE)

    Navigate to the cloned folder

    Open the .sln file

    Go to Build > Build Solution

    Press F5 or click Start to run

    View CRUD operation results in the console

    Press any key to exit

🛠️ Technologies Used

    💻 Language: C#

    🔧 Framework: .NET Console Application

## 👨‍💻 Author

**Irin Sarker Mim**  
Linkedin: [Irin Sarker Mim](https://linkedin.com/in/irin-sarker-mim-374b54335)
   
##  License

This project is licensed under the MIT License - see the LICENSE file for details

