// See https://aka.ms/new-console-template for more information
using DotNetTutor;

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Creating a new Person object with default constructor");
Console.WriteLine("Enter a name for our new Person object: ");
var name = Console.ReadLine();


Console.WriteLine("Enter an age for our new Person object: ");
// This is a better way to convert a string to an integer, its called TryParse - it will do the conversion or return false
// if it cant convert it. Then it will store the converted value in the variable we pass in as the 2nd parameter "age"
int.TryParse(Console.ReadLine(), out var age);


Console.WriteLine("Enter a Github URL for our new Person object: ");
var githubUrl = Console.ReadLine();

// Using the default constructor - so we set manually
var person1 = new Person();
// using the SET methods to set the properties of our Person object
person1.Age = age;
person1.Name = name;
person1.GithubUrl = githubUrl;
Console.WriteLine($"Person1's name is: {person1.Name}"); // using the GET methods to get the properties of our Person object
Console.WriteLine($"Person1's age is: {person1.Age}");
Console.WriteLine($"Person1's name is: {person1.Name}");
Console.WriteLine($"Person1's tag is: {person1.Tag}");

// Using the constructor that takes parameters - so we set them when we create the object and not manually set them 
// and it'll also set the Tag property for us
var person2 = new Person(age, name, githubUrl);
Console.WriteLine($"Person2's name is: {person2.Name}"); // using the GET methods to get the properties of our Person object
Console.WriteLine($"Person2's age is: {person2.Age}");
Console.WriteLine($"Person2's name is: {person2.Name}");
Console.WriteLine($"Person2's tag is: {person2.Tag}");

// You asked why objects were useful - because we can create a new Person object and expect it to always have these properties
// so we can write code that uses these properties and functions and we know that every Person object will always have.
// With Classes (Objects), we would have to specify the properties a Person has - which would be difficult to use
// later on in a loop, since we cannot depend on any uniformity.
