<Query Kind="Program" />

//12- Lazy Execution and Query Composition.

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = numbers.Where(x => x % 2 == 0);
	var evenNumbersAgain = from x in numbers
						   where x % 2 == 0
						   select x;

	//Comparison with SQL.

	//Both lines above only 'express' what the query is. Query is not executed until you run it.	
	foreach(var i in evenNumbers)
	{
		i.Dump();
	}
	
	//You can COMPOSE a query. 
	
	var allPeopleInTheWorld = GetPeopleOfTheWorld();
	var nameStartsWithJ = allPeopleInTheWorld.Where(x => x.Name.StartsWith("J"));
	var nameStartsWithJAndLivesInNyc = nameStartsWithJ.Where(x => x.City == "NYC");
	var nameStartsWithJAndLivesInNycAndIsImmigrant = nameStartsWithJAndLivesInNyc.Where(x => x.IsImmigrant);
	
	//How many times do we iterate over the original IEnumerable?
	nameStartsWithJAndLivesInNycAndIsImmigrant.Dump();
}

public class Person
{
	public string Name { get; set;}	
	
	public string City { get; set;}
	
	public bool IsImmigrant { get; set;}	
}

public IEnumerable<Person> GetPeopleOfTheWorld()
{
	Console.WriteLine(nameof(GetPeopleOfTheWorld));
	return Enumerable.Empty<Person>();
}