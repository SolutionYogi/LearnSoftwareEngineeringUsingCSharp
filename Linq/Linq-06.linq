<Query Kind="Program" />

//06 - Extension method to simplify our Filter function. 
void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers1 = numbers.Filter(number => number % 2 == 0);
	var evenNumber2 = numbers.Where(x  => x % 2 == 0);
	
	evenNumbers1.Dump();

	var oddNumbers = numbers.Filter(number => number % 2 != 0);
	oddNumbers.Dump();
	
	//LINQ's WHERE method essentially IS. 
}

public delegate bool IntegerFilter(int i);

public static class IntegerExtensionsMethods
{
	public static List<int> Filter(this List<int> numbers, IntegerFilter filter)
	{
		var result = new List<int>();
	
		for (var i = 0; i < numbers.Count; i++)
		{
			var currentNumber = numbers[i];
			var shouldInclude = filter(currentNumber);
			if (shouldInclude)
				result.Add(currentNumber);
		}
	
		return result;
	}
}