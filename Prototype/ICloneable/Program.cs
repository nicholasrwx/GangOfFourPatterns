var John = new Person(new[] { "John", "Doe" }, new Address("London Road", 453));

Console.WriteLine(John.ToString());
Console.WriteLine(John.Address.ToString());