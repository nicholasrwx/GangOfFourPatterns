// Constructor Forwarding does not exist in C#
// We can only pass constructor params to the outer objects
// We can not pass them to the Types getting passed via Generics

// Using Default Parameterless Constructor
var blackSquare = new ColoredShape<Square>();
WriteLine(blackSquare.AsString());

var circle = new TransparentShape<ColoredShape<Circle>>(9.7f);
WriteLine(circle.AsString());


// Using Secondary Constructor
var redSquare = new ColoredShape<Square>("red");
WriteLine(redSquare.AsString());
