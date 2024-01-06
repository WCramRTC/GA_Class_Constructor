# Guided Assignment - Understanding Constructors in C#

## Introduction
In this assignment, we'll explore constructors in C#, a fundamental concept in object-oriented programming. Constructors are special methods used to initialize new objects of a class. We'll cover different types of constructors, including default and custom constructors, and learn how to overload constructors for more flexible object initialization. We'll also discuss the importance of initializing fields within constructors.

---

## Detailed Requirements

#### Project Setup (15 Points)
- Create a new console application in your IDE (e.g., Visual Studio).
- Name the project `GA_Constructors_YourName`, where "YourName" should be replaced with your actual name.
- Ensure proper configuration with the necessary default files (e.g., `Program.cs`).

#### Student Name Comment (5 Points)
- At the top of the `Program.cs` file, add a comment with your name.
- This is to demonstrate the practice of code attribution and documentation.

#### Understanding of Constructors (15 Points)
- Explain what a constructor is and its role in a class.
- Add comments in your code to highlight the purpose of constructors.

#### Default Constructor (10 Points)
- Demonstrate the use of a default constructor in your class (e.g., `Book` class).
- Explain what a default constructor is and its behavior if not explicitly defined.

#### Custom Constructors (15 Points)
- Create at least one custom constructor in your class.
- Use this constructor to initialize class fields.
- Explain the purpose of creating custom constructors.

#### Overloading Constructors (15 Points)
- Implement constructor overloading with multiple constructors having different parameters.
- Explain through comments how overloading constructors provides flexibility in object initialization.

#### Field Initialization in Constructors (10 Points)
- Initialize class fields using the constructors.
- Explain why initializing fields in constructors is a good practice.

#### Usage of Constructors in Object Creation (10 Points)
- In the `Main` method, create instances of your class using different constructors.
- Show how each constructor initializes the object differently.

#### Code Testing and Output Accuracy (10 Points)
- Test your constructors by creating various objects in the `Main` method.
- Ensure the output in the console is as expected and accurately reflects the behaviors of the constructors.

#### Submission (5 Points)
- Successfully upload the complete project to GitHub.
- Ensure the repository is public and contains all necessary files.
- Provide the correct GitHub repository link in your Canvas submission.

#### Total (100 Points)
- Each section is mandatory.
- Points are awarded based on fulfilling each detailed requirement accurately.

Follow these requirements closely to meet all the criteria outlined in the rubric for your assignment.

---

### Starting Code
```csharp
using System;

// Student Name: [Your Name Here]
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring Constructors in C#");
    }
}
```

We'll focus on adding a new class with various constructors.

---

## Create a new Book class file

- Add a new class file to your project named `Book.cs`.

```csharp
public class Book
{
    // Fields and constructors will go here
}
```

---

### **Step 1: Understanding Constructors**

**Constructors** are special methods used to initialize objects.

- Add a comment in the `Book` class explaining the role of constructors.

```csharp
class Book
{
    // Constructors initialize objects and set initial values for fields
}
```

---

### **Step 2: Default Constructor**

A **default constructor** is provided by C# if no constructors are explicitly defined. It initializes the object without setting any fields.

- Demonstrate this with a comment in the `Book` class.

```csharp
class Book
{
    // Default constructor is implicitly created if no constructors are defined
}
```

---

### **Step 3: Custom Constructors**

Custom constructors allow for more controlled object initialization.

- Add a custom constructor in the `Book` class to initialize fields like `title` and `author`.

```csharp
class Book
{
    private string title;
    private string author;

    // Custom constructor
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
}
```

---

### **Step 4: Overloading Constructors**

**Constructor overloading** means having multiple constructors with different parameters.

- Add another constructor to `Book` for different initialization scenarios.

```csharp
class Book
{
    ...

    // Overloaded constructor
    public Book(string title)
    {
        this.title = title;
    }
}
```

---

### **Step 5: Field Initialization in Constructors**

Initializing fields in constructors is a way to ensure that objects start with valid states.

- Explain this concept in a comment in the `Book` class.

```csharp
class Book
{
    ...

    // Field initialization in constructors ensures objects have valid states
}
```

---

### **Step 6: Using Constructors for Object Creation**

Create instances of `Book` in the `Main` method using different constructors.

```csharp
static void Main(string[] args)
{
    Book book1 = new Book("1984", "George Orwell");
    Book book2 = new Book("The Hobbit");

    // Display initialized values
    ...
}
```

---

### **Step 7: Testing Constructors**

- Test the behavior of different constructors and output their results.

```csharp
static void Main(string[] args)
{
    ...
    // Test and display results
}
```

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation and setup of a new console application. | 15 |
| **Student Name Comment** | Including a comment with the student's name at the top of the main program file. | 5 |
| **Understanding of Constructors** | Correct explanation of what constructors are and their role. | 15 |
| **Default Constructor** | Demonstration and explanation of the default constructor. | 10 |
| **Custom Constructors** | Creation and purpose of custom constructors. | 15 |
| **Overloading Constructors** | Implementation and explanation of constructor overloading. | 15 |
| **Field Initialization in Constructors** | Initializing fields in constructors and its importance. | 10 |
| **Usage of Constructors in Object Creation** | Demonstration of object creation using various constructors. | 10 |
| **Code Testing and Output Accuracy** | Testing constructor functionality and verifying output accuracy. | 10 |
| **Submission** | Successful upload to GitHub with correct link submission. | 5 |
| **Total** |  | 100 |

OpenAI. (2024). Understanding Constructors in C#. ChatGPT Conversation.

