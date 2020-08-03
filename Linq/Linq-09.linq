<Query Kind="Program" />

//09 - IEnumerable<T> and auto generated enumerators to the rescue!

//This Filter method is what the 'Where' method in LINQ does.

//The entire Linq to Objects is defined using static extension methods on IEnumerable<T>
//The actual implementation is not as simple as what we outlined here but 
//the concept is the same.

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = numbers.Filter(number => number % 2 == 0);
	evenNumbers.Dump();

	var oddNumbers = numbers.Filter(number => number % 2 != 0);
	oddNumbers.Dump();
}

public delegate bool IntegerFilter(int i);

public static class ExtensionsMethods
{
	public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> filter)
	{	
		foreach(var item in items)
		{
			if(filter(item))
				yield return item;
		}
	}
}