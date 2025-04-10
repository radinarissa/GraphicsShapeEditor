Graphics Shape Editor
A Windows Forms application for creating and manipulating graphical shapes, designed to demonstrate object-oriented programming concepts and graphical user interface development in C#.
Features

Shape Creation: Create various geometric shapes (circle, triangle, rectangle)
Shape Editing: Modify dimensions, colors, and positions of shapes
Area and Perimeter Calculation: Automatic calculation of geometric properties
Interactive Movement: Drag and drop shapes with the mouse
Scene Saving: Save the created scene as an image
Undo/Redo: History of operations with the ability to undo and redo actions
LINQ Operations: Filter shapes by color and other properties

Architecture
The project is structured around a hierarchy of classes that inherit from the abstract Shape class:

Shape: Abstract base class defining common characteristics of all shapes

Circle: Represents a circle with center and radius
Triangle: Represents a triangle with three vertices
RectangleShape: Represents a rectangle with position, width, and height



Technologies and Concepts
The project demonstrates the following concepts from object-oriented programming and .NET:

Inheritance: Hierarchical class structure for different shape types
Encapsulation: Hiding internal representation of shapes
Polymorphism: Uniform handling of different shape types
Virtual Methods: For reusable and extendable functionality
System.Drawing: For shape visualization
LINQ: For manipulating collections of shapes
Operation History: Implementation of Undo/Redo functionality

How to Use the Application

Creating a Shape:

Select a shape type from the toolbar (circle, triangle, rectangle)
Enter the required parameters in the dialog window
Click on the canvas to place the shape


Editing a Shape:

Select the fill option from the toolbar
Click on the shape you want to edit
Change the color using the color picker


Moving a Shape:

Select the move option
Click and hold on the shape you want to move
Drag with the mouse to the desired position


Saving the Image:

Use the save button to store the current scene as an image


Undo/Redo Actions:

Use the Undo/Redo buttons to manage the history of actions



System Requirements

Windows operating system
.NET Framework 4.7.2 or newer
Visual Studio 2019 or newer (for development)

Project Information
This project was developed as a coursework assignment for object-oriented programming, demonstrating the core principles of OOP and graphical user interface development in C#.
