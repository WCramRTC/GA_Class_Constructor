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
We're starting off by creating a new class to represent a Book object. IRL this could be the representation of a digital book like an EBook on Kindle. This could be used in a Library app when representing their Inventory. This could even be a "Book" object in a video game.

- Add a new class file to your project named `Book.cs`.
- Add 3 fields
    - private string title;
    - private string author;

```csharp
public class Book
{
    // Fields and constructors will go here
    private string title;
    private string author;
}
```

---

### **Step 1: Understanding Constructors**

The Constructor has 2 purposes.
    - 1. When a constructor is called, `new ClassName();` it create a place in memory that holds all the information related to that instance.
    - 2. Enforce information required to create a new instance of the object.

The format of a constructor is
- Access Modifer ( usually public )
- Same Class Name ( For our book class it'll be Book )
- Any parameters you want to pass in ( No parameters will make it a default constructor )

```csharp
    public ClassName(parameters) 
    { 
        Additional Code
    }
```

Go back to `Program.cs` and in `Main` lets create a new instance of Book.

```csharp

public class Program {
    
    public static void Main(string[] args) {
    
    // Write this code
    Book newBook = new Book(); // <---- This is calling a constructor
    }
}
```

When you use `new ClassName()`, that is calling the constructor. It's like calling a method. 

---

### **Step 2: Default Constructor**

A **default constructor** is provided by C# if no constructors are explicitly defined. It initializes the object without setting any fields.

```csharp
    Book newBook = new Book(); // This is calling the default constructor
```

This will create that new Book object in "heap" memory, that's longer term memory. And then assign the address to the name `newBook` which is store in the stack, or shorter and faster memory. 

If you don't add a constructor to your class, it automatically has a default constructor.

```csharp
class Book
{
    private string title;
    private string author;

    // Default constructor is implicitly created if no constructors are defined
}
```

This will allow you to create a new `instance` of a book object, but if you tried to access any data assoicated with it, the fields will be empty. Depending on how you build your class this could cause it to break if there is data required for it to work.

For that we create our own `constructors`.

---

### **Step 3: Custom Constructors**

By creating our own constructor we do 2 things.
    1. We remove the default constructor.
        If you create your own constructor, there is no longer a default constructor that takes no arguments.
    2. We ensure that specific data HAS to be passed in to make an instance of this class.

> Example:
```csharp
    public Book(string author) {
        this.author = author;
    }
```

Adding this means we HAVE to pass a string as an agrument. And make sure that the author class has information in it.
``` csharp
    Book newBook = new Book("Terry Pratchett"); // This works
    Book brokenBook = new Book(); // No longer works
```

- **Add a custom constructor in the `Book` class to initialize fields like `title` and `author`.**

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
But what if we want to have more than just one option for our constructors? Then we can do what's known as "overloading our constructor". That means we create multiple constructors, but pass in different parameters. Depending on the arguments passed in, such as Book(string, string, int) or Book(string, int) or Book(string, string), the compiler will know which constructor to call.


- Add another constructor to `Book` for different initialization scenarios.

```csharp
class Book
{
    ...

    // Custom constructor
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Overloaded constructor
    public Book(string title)
    {
        this.title = title;
    }
}
```

Now you can create a new Book instance in 2 different ways.

***In Your code, create new instances of Book using both of your constructors***
```csharp
    Book bookAuthorAndName = new Book("Night Watch", "Terry Pratchett");
    Book bookNameOnly = new Book("Wyrd Sisters");
```


Note: That you have to have different arrangments of `Parameters`. You can't have one that does (string author, string title) and then another with (string title, and string author). The computer just sees (string, string) and wouldn't know which one to call.



---

### **Step 5: Field Initialization in Constructors**
You can also use a constructor to initialize a field with some default information.

Initializing fields in constructors is a way to ensure that objects start with valid states.

- Explain this concept in a comment in the `Book` class.

Lets go back to our constructor that just took a title. And give our author a default value.
```csharp
class Book
{
    ...

    // Field initialization in constructors ensures objects have valid states
    public Book(string title)
    {
        this.title = title;
        this.author = "No Author Given"; // Default value
    }
}
```

This way even if an author isn't given, a default value will be provided.

```csharp
    
    Console.WriteLine(bookNameOnly.Author);
    // Prints No Author Given
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

Create 5 different Book instances using different constructors and print out their information ( make sure to properly setup your fields and properties )

Create a NEW class of your own, and add two constructors.

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

