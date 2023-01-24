### Overview:

- The builder design pattern separates the construction of a complex object from its representation
   so that the same construction process can create different representations.

### Classes and objects participating in this pattern include:

* **Builder**	      - Specifies an abstract interface for creating parts of a product object
* **ConcreteBuilder** - Assembles parts of the product by implementing the builder interface
		      - Designs and keeps track of the representation it creates
		      - Provides an interface for retrieving the product
* **Director**        - Constructs an object using the builder interface
* **Product**	      - Represents the complex object under construction
		      - ConcreteBuilder builds the product's internal representation
			and defines the process by which it's assembled
		      - Includes classes that define the constituent parts
		        (Including interfaces for assembling the parts into the final result)


### Sources:

https://dofactory.com/net/builder-design-pattern

