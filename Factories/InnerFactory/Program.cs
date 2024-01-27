var defaultSign = Sign.DefaultSignOrder("Stop", "Road Sign", "Hexagon");
var customSign = Sign.Factory.CustomSignOrder("No Public Access", "Gate Sign", "Rectangle", 300, "195 lbs");
var blankSign = Sign.Factory.BlankCustomSignOrder(1000, "540 lbs");


Console.WriteLine(defaultSign.ToString());
Console.WriteLine(customSign.ToString());
Console.WriteLine(blankSign.ToString());

