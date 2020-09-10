<Query Kind="Program" />

//13- VAR and Anonymous Types, Object initializer.

void Main()
{
	var result = from p in GetPeopleOfTheWorld()
				 group p by p.City into g
				 select new { City = g.Key, TotalPopulation = g.Count() };

	//Anonymous type. 
	//Every type must have a name. This one does as well. 
	//But compiler generates it for you and you don't know its name
	//i.e. it's anonymous to YOU. 

	//So if you don't know the name, how can you declare the 'variable' for the result?

	//This is why VAR was invented.

	var result2 = from p in GetPeopleOfTheWorld()
				  group p by p.City into g
				  select new CityPopluation { City = g.Key, TotalPopulation = g.Count()} ;
				  
	//CityPopluation is what you call a 'nominal type'. 
	//When you don't specify the name of a nominal type, C# will create 
	//an anonymous type on your behalf.
	
	//Remember, CLR only has fields, methods, types, delegates.
	//All other concepts are BUILT on top of it.
}

public class CityPopluation
{
	public string City { get; set; }
	
	public int TotalPopulation { get; set; }
}

public class Person
{
	public string Name { get; set; }

	public string City { get; set; }

	public bool IsImmigrant { get; set; }
}

public IEnumerable<Person> GetPeopleOfTheWorld()
{
	return Enumerable.Empty<Person>();
}