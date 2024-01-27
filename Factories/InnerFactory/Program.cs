var defaultSigns = Sign.DefaultSignOrder("Stop", "Road Sign", "Hexagon");
var customSigns = Sign.Factory.CustomSignOrder("No Public Access", "Gate Sign", "Rectangle", 300, "195 lbs");
var blankSigns = Sign.Factory.BlankCustomSignOrder(1000, "540 lbs");
var smileSigns = Sign.PremadeSmileSignOrder;
var naanSigns = Sign.PremadeNaanCatSignOrder;

Console.WriteLine(defaultSigns.ToString());
Console.WriteLine(customSigns.ToString());
Console.WriteLine(blankSigns.ToString());
Console.WriteLine(smileSigns.ToString());
Console.WriteLine(naanSigns.ToString());

