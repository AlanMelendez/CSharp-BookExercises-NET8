using Packt.Shared; // To use Person.

using Fruit = (string Name, int Number); // Aliasing a tuple type.

ConfigureConsole(); // Sets current culture to US English.

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French culture.

#region Instantiating a class

// Person bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.

Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call to ToString().
// WriteLine(bob.ToString()); // Does the same thing.

#endregion

#region Setting and outputting field values

bob.Name = "Alan Melendez";
bob.Born = new DateTimeOffset(
  year: 1985, month: 4, day: 11,
  hour: 16 , minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5) // UTC-5
); // DateTimeOffset is a struct, so it can't be null.

WriteLine(format: "{0} was born on {1:D}.", arg0: bob.Name, arg1: bob.Born); // D means long date pattern. (it's similar to use a pipe in Angular)
WriteLine($"{bob.Name} was born on {bob.Born:D}."); // Interpolated string.
WriteLine($"{bob.Name} was born on {bob.Born:yyyy-MM-dd}."); // Interpolated string with format.

#endregion