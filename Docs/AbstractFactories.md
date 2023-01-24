### Overview

- Abstract factories are creational design patterns
- They are used for creating families of related or dependent objects
- You could think of an abstract as a template for a concrete class

### Classes and objects participating in this pattern include:

* **AbstractFactory** - declares an interface for operations that create abstract products
* **ConcreteFactory** - implements the operations to create concrete product objects
* **AbstractProduct** - declares an interface for a type of product object
* **Product**	      - define a product object to be created by the corresponding concrete factory
		      - implements the AbstractProduct interface
* **Client**	      - uses interfaces declared by abstract factory and abstract product classes

### Sources

https://dofactory.com/net/abstract-factory-design-pattern
