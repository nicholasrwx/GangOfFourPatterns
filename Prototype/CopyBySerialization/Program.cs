using System;
using System.Net.Sockets;
using static System.Console;

// This is a way to perform partial deep copies through inheritance
// and casting to parent types


var john = new Employee();
john.Names = new string[] { "Jason", "Corey" };
john.Address = new Address { HouseNumber = 435, StreetName = "Gordon Rd. SE" };

var copy = john.DeepCopy();

copy.Names[1] = "Smith";
copy.Address.HouseNumber++;
copy.Salary = 7875550;

// these may have been removed
Employee e = john.DeepCopy<Employee>();
Person p = john.DeepCopy<Person>();

Console.WriteLine(john);
Console.WriteLine(copy);
