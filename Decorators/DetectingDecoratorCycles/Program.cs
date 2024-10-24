// We are applying decorators upon decorators
// Additionally, you can apply the same decorator twice

var circle = new Circle(2);

var colored1 = new ColoredShape(circle, "red");
var colored2 = new ColoredShape(colored1, "blue");

WriteLine(colored2.AsString());