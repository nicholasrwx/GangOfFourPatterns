### Overview:


This type of fluent builder allows one fluent builder to inherit from another fluent builder while maintaining access to all methods and properties that are in both fluent builder interfaces. This is done using recursive generics to create a self referential relationship, applying self referential constraint to the generic parameter being passed in, and downcasting the return type of 'this' to the generic being used.

### Classes and objects participating in this pattern include:

- **FluentBuilder** (Parent)
	- Provides an fluent interface for continually accessing builder methods to build out the product
	- Designs and keeps track of the representation it creates (Contains a single Instance of the product)

- **FluentBuilder** (Child)
	- Provides an fluent interface for continually accessing builder methods to build out the product

- **Product**
	- Represents the complex object under construction
	- The FluentBuilder build the product's internal representation  
	- Contains a Builder that Inherits from the Child FluentBuilder and takes itself (the Builder class) as the type passed in as the generic parameter of the Child FluentBuilder. This Builder is instantiated within the Product Class. Doing this exposes both of the fluent builders methods when accessing the builder instance within this product class.


### Sources:
[Design Patterns in C# and .NET - Builder: Fluent Builder Inheritance With Recursive Generics](https://www.udemy.com/course/design-patterns-csharp-dotnet/)
