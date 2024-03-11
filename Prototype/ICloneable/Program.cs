// ICloneable Deep Copy ( Bad - Misleading as this interfaces documentation states it is meant for shallow copying )
var John = new DeepCopyPerson(new[] { "John", "Doe" }, new DeepCopyAddress("London Road", 453));
var Jerry = (DeepCopyPerson)John.Clone();
Jerry.Names = new[] { "Jerry", "Campbell" };
Jerry.Address.HouseNumber = 879;

// These two instances will have different house numbers
Console.WriteLine(John.ToString());
Console.WriteLine(Jerry.ToString());

// ICloneable Shallow Copy ( Bad - Copies references only for Fields of reference types )
var Paul = new ShallowCopyPerson(new[] { "Paul", "Hammond" }, new ShallowCopyAddress("Victoria Street", 888));
var Kelly = (ShallowCopyPerson)Paul.Clone();
Kelly.Names = new[] { "Kelly", "Burneski" };
Kelly.Address.HouseNumber = 111;

// Pauls house number will be the same as Kellys ( Shallow Copied a Reference, Mutating Pauls house number )
Console.WriteLine(Paul.ToString());
Console.WriteLine(Kelly.ToString());
