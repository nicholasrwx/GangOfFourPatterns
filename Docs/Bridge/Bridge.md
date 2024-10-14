### Overview:

The Bridge Pattern is the concept of connecting different components together through abstractions. Say you have a Base Class ( TaskRunner ), and you have 2 classes that are derived from this. One is DailyTaskRunner and the other is EventTaskRunner. Each Interface is designed to work with windows implementation classes. WindowsDailyTask inherits from DailyTaskRunner and WindowsEventTask inherits from EventTaskRunner. If you want them to additionally work on a Linux Machine you now need to create a LinuxDailyTask and LinuxEventTask implementation classes. If you wanted it to work with a Mac, then you need to add two more implementation classes and so on. This is what is called the "Cartesian Product" Complexity Explosion. In this scenario your Implementation Classes Keep Multiplying and Inheriting from an Interface Hierarchy. The Bridge Pattern aims to prevent this scenario from happening by way of agreggation instead of inheritance which is a slightly different process. You provide a private field to TaskRunner that stores an interface type or makes use of an Abstract Class which is used for your implementation classes instead of inheriting from your interface hierarchy. This essentially decouples an interface ( hierarchy ) from an implementation ( hierarchy ).

### Classes and objects participating in this pattern include:

- **IRenderer**
	- This interface is used to define a base criteria for different types of renderers. This allows for different functionality while using the same methods and same type. Ultimately allows you to change the behaviour independently of the domain object that uses it. 

- **VectorRenderer**
	- The VectorRenderer extends the IRenderer class and has to contractually implement the RenderCircle Method. It Renders the Circle in Vector Graphics ( Non-Pixelated - Imitated Using A Descriptive Output ).
	
- **RasterRenderer**
	- The RasterRenderer extends the IRenderer class and has to contractually implement the RenderCircle Method. It Renders the Circle in Raster Graphics ( Pixelated - Imitated Using A Descriptive Output ).
	
- **Shape**
	- The Shape is a Abstract Class. It is a blueprint that outlines how the concrete class will be setup. It requires the IRenderer as a Dependency which is stored in a Class Variable in the Abstract. It Also has two override methods which allow for custom implementation across different Concrete Classes of the same Abstract.

- **Circle**
	- The Circle is a Concrete Class of Shape. It can utilize any IRenderer passed to it, which is stored in the base abstract class of Shape. It overrides the abstract methods in Shape to produce a custom output using the same parameters as any other Concrete Implementation of Shape would. This means I do not need two or more Concrete classes of the same Type to use different implementation for the same result.

### Sources:
[Design Patterns in C# and .NET - Bridge: Bridge](https://www.udemy.com/course/design-patterns-csharp-dotnet/)

[![image](https://github.com/nicholasrwx/GangOfFourPatterns/blob/main/Imgs/back-arrow_1f519.png)](https://github.com/nicholasrwx/GangOfFourPatterns/tree/main)