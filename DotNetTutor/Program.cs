// See https://aka.ms/new-console-template for more information

/*
		Pete -

		You're in the 3rd week, I know you can do this. You have to write down:
		You need to know the different data types. The basics are string, int, double, and boolean
		string is text, int is whole numbers, double is decimal, boolean is True or False

		Any time you get Console.ReadLine() data and you need to do any sort of number calculation

		You have to Convert.ToDouble() or Convert.ToInt32() otherwise youll get an error cuz its text
		Every single line of code BESIDES ->  if, while, for, do while, functions and classes - These ALWAYS
		begin with { and end in }  EVERYthing else ends in semi colon ;

		I will demonstrate the basics down below. You need to have this syntax on hand, if you can't remember it yet
		thats okay. But you need to look for patterns in code. If you see any code that looks exactly like something else
		or theres a repeating kind of logic - they're related and if you figure out what the first part is doing the
		rest of it will make sense.

		Something thing that every good programmer does - if youre confused or cant remember the exact command like say
		You know that to read and write to the console begins with   Console.   but you dont remember what comes next
		Just type the dot and intellisense will show a drop down of every single function to choose from.
		Scroll through and maybe itll jog your memory once see you ReadLine() or WriteLine() in the list

		*/

using DotNetTutor;

double myDouble = 1.0;
int myInteger = 1;
string myString = "this is a string";
bool myBoolean = true;

// We are asking from a number to be input and we will check its value below 
Console.WriteLine("Enter a double: ");

// This Converts the Readline and stores it in our variable we declared above
myDouble = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an integer");
// This converts our ReadLine to an Integer and stores it in Integer variable from above.
myInteger = Convert.ToInt32(Console.ReadLine());

// Booleans are always True or False - Thats it
// This converts our Readline into a boolean and stores it in our bool variable
// If a user manually types in "true" or "false" it will convert accurately and work
Console.WriteLine("Enter True or false");
myBoolean = Convert.ToBoolean(Console.ReadLine());

// If - Then logic is a core concept of programming, you need to know this. Its just logic.
// If -> I go buy something | Then -> My bank balance goes down. Its really just this but in code syntax

/*

When we are assigning a value to our variable we use a single equals sign.  =
But when we are checking if our variable IS equal to something we use double equals  ==
If we want to know if its less than or equal something its  <=
If we want to know if its greater than or equal to  >=
IF we want to know if its NOT equal to something we use  !=
Assigning value  =   |   Comparing value ==

Below I want to check if myDouble - which is the ReadLine() value we got in response to WriteLine()
If its Less than or Equal to -1 we want to print out "We are less than or equal to negative one"
If its equal to 0 we want to print out "We are equal to zero"
If its equal to 1 we want to print out "We are equal to one"
ANY OTHER NUMBER thats not checked for we want to print "We are NOT equal to -1, 0, or 1"

Just to demonstrate a boolean - On the Else statement I am creating a boolean named: isDifferentNumber
And store it as True when the statement is true - so the last condition
Since isDifferentNumber isn't true until we actually have a different number

*/

Console.WriteLine();
Console.WriteLine("This is checking the very 1st number we put in the program. The other inputs are just examples");
Console.WriteLine();

bool isDifferentNumber = false;

if (myDouble <= -1)
{
	Console.WriteLine("We are less than or equal to negative one");
}
else if (myDouble == 0)
{
	Console.WriteLine("We are equal to zero");
}
else if (myDouble == 1)
{
	Console.WriteLine("We are equal to one");
}
else
{
	Console.WriteLine("We are NOT equal to -1, 0, or 1");
	isDifferentNumber = true;
	Console.WriteLine("Is this a different number? " + isDifferentNumber);
}

Console.WriteLine();
//Below uses String Interpolation to output some text with our variables inside. This concept is very simple
// First character is a dollar sign $. We can write whatever text we want as normal. Any variable is
// put inside of curly braces. Thats it, thats how we output our variables easily
Console.WriteLine($"Our Double was: {myInteger}");
Console.WriteLine($"Our Integer was: {myInteger}");
Console.WriteLine($"Our Boolean was: {myBoolean}");


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
