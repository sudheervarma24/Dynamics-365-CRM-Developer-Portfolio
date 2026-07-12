
# C# Basics

## Overview

C# is the primary programming language used to develop Microsoft Dynamics 365 CRM Plugins, Custom Workflow Activities, Azure Functions, and integration components. Before implementing business logic in Dynamics 365, it is essential to understand the core concepts of C#, including methods, parameters, arrays, loops, class libraries, return types, and object-oriented programming principles.

This module focuses on building a strong C# foundation through hands-on assignments and practical examples that are directly applicable to Dynamics 365 CRM development.

---

## Learning Objectives

After completing this module, I was able to:

- Create Console Applications using Visual Studio
- Understand the Namespace → Class → Method hierarchy
- Create and consume methods
- Work with parameterized methods
- Use arrays and loops effectively
- Implement conditional statements
- Apply naming conventions
- Create reusable Class Libraries
- Generate DLL files
- Add project references
- Create objects and consume reusable methods
- Understand return types and method reusability

---

## Prerequisites

- Visual Studio 2022
- .NET Framework 4.6.2
- Basic programming knowledge
- Windows Operating System

---

## Concepts Covered

### Console Application

Created a Console Application to practice C# fundamentals and understand program execution through the `Main()` method.

### Namespace, Class and Method

Learned the basic structure of every C# application.

```text
Namespace
    ↓
Class
    ↓
Method
```

This hierarchy is similar to the CRM customization structure:

```text
Tab
   ↓
Section
   ↓
Field
```

---

### Methods

Implemented simple methods to perform arithmetic operations and understand method execution.

Examples:

- Addition()
- Multiplication()

---

### Parameterized Methods

Implemented methods that accept values through parameters, allowing the same logic to be reused with different inputs.

Examples:

- AdditionOfTwoNumbers(int firstNumber, int secondNumber)
- MultiplicationOfTwoNumbers(int firstNumber, int secondNumber)

---

### Arrays

Worked with arrays to store collections of values.

Examples:

- Car Companies
- Mobile Companies
- Laptop Companies

---

### Loops

Implemented:

- for Loop
- foreach Loop

Used loops to iterate through arrays and display values.

---

### Conditional Statements

Used `if` conditions to validate data and perform decision-making.

Example:

- Check whether "Nokia" exists in the mobile companies list.

---

### break Statement

Used the `break` statement to exit a loop immediately after finding the required value, improving performance.

---

### Naming Conventions

Followed standard C# naming conventions.

**PascalCase**

- Program
- Addition()
- PrintValues()
- StudentCalculation

**camelCase**

- firstNumber
- secondNumber
- studentTotal
- mobileCompanies

---

### Return Types

Implemented methods returning different data types.

- void
- int
- decimal
- string

Return values were used for further calculations such as percentage and grade.

---

### Class Library

Created a separate Class Library project to understand reusable code architecture.

Implemented methods for:

- Total Marks Calculation
- Percentage Calculation
- Grade Calculation

Generated a DLL and consumed it from the Console Application.

---

### Project References

Added the Class Library as a project reference to the Console Application and accessed reusable methods using objects.

---

### Object Creation

Created objects to consume non-static methods from the Class Library.

Example:

```csharp
StudentCalculation student = new StudentCalculation();
```

---

## Practical Assignments

The following assignments were completed during this module:

- Simple Addition Method
- Simple Multiplication Method
- Parameterized Addition Method
- Parameterized Multiplication Method
- Array Printing
- Mobile Company Search
- Nokia Availability Check
- Student Marks Calculation
- Percentage Calculation
- Grade Calculation
- Class Library Creation
- DLL Generation
- Project Reference
- Object Creation
- Method Reusability

---

## Project Workflow

```text
Create Console Application
        ↓
Implement Methods
        ↓
Parameterized Methods
        ↓
Arrays and Loops
        ↓
Conditional Statements
        ↓
Create Class Library
        ↓
Build DLL
        ↓
Add Project Reference
        ↓
Create Object
        ↓
Consume Reusable Methods
        ↓
Execute Application
```

---

## Real-Time Usage in Dynamics 365 CRM

The concepts learned in this module are widely used in:

- Plugin Development
- Custom Workflow Activities
- Azure Functions
- Console Utilities
- Web API Integrations
- Business Logic Implementation
- Reusable Utility Libraries
- Dataverse Integrations

---

## Best Practices

- Use meaningful class and method names.
- Follow PascalCase and camelCase naming conventions.
- Create reusable methods whenever possible.
- Avoid duplicate code.
- Separate business logic into Class Libraries.
- Build projects before deployment.
- Use return types instead of printing values directly when further processing is required.

---

# Interview Questions & Answers

### 1. Why is C# important for Dynamics 365 CRM?

C# is the primary language used to develop Plugins, Custom Workflow Activities, Azure Functions, and integration components in Microsoft Dynamics 365.

---

### 2. What is the difference between a Console Application and a Class Library?

| Console Application | Class Library |
|----------------------|---------------|
| Has Main() method | No Main() method |
| Produces EXE | Produces DLL |
| Runs independently | Used by other applications |
| Mainly used for testing and learning | Used for reusable business logic |

---

### 3. What is a Parameterized Method?

A parameterized method accepts values through parameters, allowing the same method to be reused with different inputs.

Example:

```csharp
AdditionOfTwoNumbers(int firstNumber, int secondNumber)
```

---

### 4. What is a DLL?

DLL (Dynamic Link Library) is a compiled assembly generated from a Class Library project. Dynamics 365 loads this DLL during Plugin execution.

---

### 5. What is Method Reusability?

Method reusability means writing business logic once and using it multiple times throughout the application, reducing duplication and simplifying maintenance.

---

### 6. Why are Class Libraries used in CRM development?

Class Libraries centralize reusable business logic, generate DLLs for deployment, improve maintainability, and reduce duplicate code across multiple plugins.

---

### 7. What is a Return Type?

A return type specifies the type of value returned by a method.

Examples:

- void
- int
- decimal
- string
- bool

---

### 8. Why do we create Objects?

Objects are required to access non-static methods and properties defined within a class.

---

### 9. What is the Main() Method?

The `Main()` method is the entry point of a Console Application. Program execution always starts from this method.

---

### 10. Why are Plugins developed using Class Libraries?

Dynamics 365 Plugin Registration Tool accepts only compiled DLL files generated from Class Library projects. Console Applications cannot be deployed as Plugins.

---

## Key Takeaways

- Built a strong foundation in C# programming.
- Learned reusable programming practices.
- Understood Class Library architecture.
- Implemented parameterized methods and return types.
- Generated and consumed DLLs.
- Applied concepts directly related to Dynamics 365 Plugin development.
- Prepared for advanced topics such as Plugins, Custom Workflow Activities, Azure Functions, and Dataverse integrations.

---

## References

- Microsoft Learn – C#
- Microsoft Learn – .NET Framework
- Microsoft Learn – Microsoft Dynamics 365
- Microsoft Learn – Plugin Development
