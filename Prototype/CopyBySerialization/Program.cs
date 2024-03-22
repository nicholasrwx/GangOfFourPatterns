using System;
using static System.Console;

var john = new Person();
john.Names = new string[] { "Jason", "Corey" };
john.Address = new Address { HouseNumber = 435, StreetName = "Gordon Rd. SE" };

var tony = john.DeepCopy();

tony.Names[0] = "Tony";
tony.Names[1] = "Smith";
tony.Address.HouseNumber++;


Console.WriteLine(john);
Console.WriteLine(tony);
