using Prototype.Services.UsingIDeepClone;

Owner firstOwner = new Owner() { Adress = "123 Cat street", Name = "Rodriguez El Gato" };
Cat originalCat = new Cat() { Color = "Orange", Id = 1, Name = "Tareco", Owner = firstOwner };

var copiedCat = (Cat)originalCat.Clone();
Owner newOwner = new Owner() { Adress = "222 new", Name = "el cloned" };
copiedCat.Id = 2;
copiedCat.Owner = newOwner;

System.Console.WriteLine(copiedCat.ToString());
System.Console.WriteLine(originalCat.ToString());


Owner doggoOwner = new Owner() { Adress = "555 doggo", Name = "Piranha C" };
Dog originalDog = new Dog() { Color = "Orange", Id = 3, Name = "Bobby", Owner = doggoOwner };

Dog copiedDog = (Dog)originalDog.Clone();
Owner newDoggoOwner = new Owner() { Adress = "666 el passo", Name = "Maryan" };
copiedDog.Id = 4;
copiedDog.Owner = newDoggoOwner;

System.Console.WriteLine(copiedDog.ToString());
System.Console.WriteLine(originalDog.ToString());