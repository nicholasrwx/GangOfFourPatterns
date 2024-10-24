using System;
using static System.Console;

// Creating a Deep Copy with JSON Serialization
var john = new Person();
john.Names = new string[] { "Jason", "Corey" };
john.Address = new Address { HouseNumber = 435, StreetName = "Gordon Rd. SE" };

var tony = john.DeepCopy();

tony.Names[0] = "Tony";
tony.Names[1] = "Smith";
tony.Address.HouseNumber++;

Console.WriteLine(john);
Console.WriteLine(tony);


// Creating a Deep Copy with XML Serialization
var kenneth = new Person();
kenneth.Names = new string[] { "Kenneth", "McMillan" };
kenneth.Address = new Address { HouseNumber = 532, StreetName = "Porter Cres. NW" };

var noel = kenneth.DeepCopyXml();
noel.Names[0] = "Noel";
noel.Names[1] = "Noverna";

Console.WriteLine(kenneth);
Console.WriteLine(noel);
