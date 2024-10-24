using DynamicDecorator;

// We are applying decorators upon decorators
// Additionally, you can apply the same decorator twice

var square = new Square(1.23f);
WriteLine(square.AsString());

var redSquare = new ColoredShape(square, "red");
WriteLine(redSquare.AsString());

var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
WriteLine(redHalfTransparentSquare.AsString());