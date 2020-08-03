<Query Kind="Program" />

//08 - Writing a 'generic' Filter method using 'C# generics'

//What's the problem here? 

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = numbers.Filter(number => number % 2 == 0);
	evenNumbers.Dump();

	var oddNumbers = numbers.Filter(number => number % 2 != 0);
	oddNumbers.Dump();
	
	List<string> names = new List<string>() { "Jd", "Mark", "Allen", "Somil"};
	
	var shortNames = names.Filter(n => n.Length < 5);
	
	shortNames.Dump();
}

public delegate bool IntegerFilter(int i);

public static class ExtensionsMethods
{
	public static List<T> Filter<T>(this List<T> items, Func<T, bool> filter)
	{
		var result = new List<T>();

		for (var i = 0; i < items.Count; i++)
		{
			var currentItem = items[i];
			var shouldInclude = filter(currentItem);
			if (shouldInclude)
				result.Add(currentItem);
		}

		return result;
	}
}