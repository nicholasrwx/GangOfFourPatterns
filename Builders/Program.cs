//Instantiate the director
var director = new Shop();
//Instantiate a concrete builder
var F35 = new F35Builder();
var F22 = new F22Builder();
//Construct a product by passing the 'concrete builder' instance to the construct method on the director instance
director.Construct(F35);
director.Construct(F22);
//Call the show method to see the results in the console
F35._aircraft.Show();
F22._aircraft.Show();




//Director - Shop 
//ConcreteBuilder - F22Builder, F35Builder, Su35sBuilder
//AbstractBuilder - AircraftBuilder 
//Product - Aircraft 