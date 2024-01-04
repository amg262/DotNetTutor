namespace DotNetTutor;

/// <summary>
/// 
/// </summary>
public class Person
{
	// These are properties of our Person class. The Get and Set are whats actually called when we reference it in our code
	// Objects are just a collection of properties and functions, we want to use them so we can expect every Person object to always have these fields
	// 
	// Note: the ? after the data type means that it can be null. If we dont put the ? then it will always have a value, this is
	// optional and a newer feature of C# 8.0
	public int? Age { get; set; } = 31;
	public string? Name { get; set; } = "Andrew";
	public string? GithubUrl { get; set; } = "https://github.com/amg262/";
	public string? Tag { get; set; }


	/// <summary>
	/// This is the default constructor, it will be called when we create a new Person object and doesn't require any parameters
	/// to be passed in to create a new Person object.
	///
	/// A CONSTRUCTOR is a C# function that is called when we create a new object. It is always named the same as the class and you can have multiple
	/// as long as they have different parameters. If you have multiple constructors you can create a new object with different parameters.
	/// If its empty, you'll need to manually set the properties after you create the object using the SET methods above.
	///
	/// </summary>
	public Person()
	{
	}

	/// <summary>
	/// Calling this constructor will create a new Person object and set the Age, Name, and GithubUrl properties based on the parameters passed in
	/// meaning we dont have to manually set them after we create the object. We can also call the SetTagBasedOnAge() function here to set the Tag
	/// </summary>
	/// <param name="age">Age of person</param>
	/// <param name="name">Name of person</param>
	/// <param name="githubUrl">Github Profile URL</param>
	public Person(int? age, string? name, string? githubUrl)
	{
		Age = age;
		Name = name;
		GithubUrl = githubUrl;
		SetTagBasedOnAge(); // We could also remove this and manually call it from the Program.cs file if we wanted to change the logic
	}


	// A few OOP principles here - we are ENCAPSULATING our code. We are hiding the logic of how Get, Set the Person's name or Tag
	// from the outside world. We are also using ABSTRACTION - we are hiding the details of how we are getting and setting the name
	// Objects should be single purpose, they should do one thing and do it well. We are using the Single Responsibility Principle here.

	/// <summary>
	/// Just a simple function to set the Tag property based on the Age property if its even the Tag is Engineer, if its
	/// odd the Tag is Developer. Only a Person object can call this function. We will have to manually call this function,
	/// we can do that from the Program.cs file or from a constructor.
	/// </summary>
	public void SetTagBasedOnAge()
	{
		if (Age.HasValue && Age.Value % 2 == 0)
		{
			Tag = "Engineer";
		}
		else
		{
			Tag = "Developer";
		}
	}
}