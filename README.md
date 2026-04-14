# C# Fundamentals

This repository is a small C# console application that demonstrates core language and platform concepts through nine hands-on tasks. Running the app executes each task in sequence from `Program.cs`.

## What This Project Covers

1. Basic data types and control structures
2. Simple object-oriented programming
3. Collections and string manipulation
4. Collections and LINQ
5. File I/O and exception handling
6. Event handling
7. Asynchronous programming and multithreading
8. Generics and interfaces
9. Reflection and custom attributes
10. Building a Mini Microservice with ASP.NET( https://github.com/114-Vaibhav/Mini_Microservices_using_cs )

## Project Structure

- `Program.cs` - entry point that runs all tasks one after another
- `1 Basic Data Types Control Structure.cs` - factorial example using recursion and console input
- `2 Simple OOP.cs` - `Person` class with properties, constructor, and method calls
- `3 Basic Collections and String Manipulation.cs` - simple name manager using a `List<string>`
- `4 Collections and LINQ.cs` - student list generation and LINQ filtering
- `5 File IO and Exception Handling.cs` - create, read, append, and delete a file with exception handling
- `6  Event Handling.cs` - custom delegate and events based on counter ranges
- `7 Asynchronous Programming and Multi threading.cs` - concurrent async tasks with `Task.WhenAll`
- `8 Generics and Interfaces.cs` - generic repository-style operations for products and students
- `9 Reflection and Custom Attributes.cs` - discovering and invoking methods marked with custom attributes
- `Output.txt` - sample output captured from a previous run

## Requirements

- .NET SDK installed
- A terminal or IDE that can run a C# console app

You can check your SDK with:

```powershell
dotnet --version
```

## How To Run

From the project folder, run:

```powershell
dotnet run
```

## Runtime Notes

- Task 1 asks for a number from the console and prints its factorial.
- Task 3 is interactive and waits for menu choices until you enter `4`.
- Task 5 creates a temporary file named `temp.txt`, reads it, appends content, and deletes it.
- Task 7 includes delays, so it takes a little time to finish.
- Because Task 3 is interactive, tasks after it will only run once you exit that menu.

## Learning Goal

This project is meant as a practice set for building confidence with foundational C# concepts. Each file focuses on one topic and keeps the code straightforward enough to study, run, and modify.
