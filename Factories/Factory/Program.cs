var bottles = new List<string>() { "Bottle", "Bottle", "Bottle", "", "", "", "Bottle" };
var cups = new List<string>() { "Cup", "Cup", "", "", "Cup", "Cup", "" };

var multiplyCounter = CountFactory.containerAddition(bottles, cups);
var divideCounter = CountFactory.containerSubtraction(bottles, cups);

Console.WriteLine(multiplyCounter);
Console.WriteLine(divideCounter);
