<Query Kind="Program" />

//04 - Delegates, aka how to pass 'functions' around.

public delegate bool IntegerFilter(int i);

public delegate bool IntegerFilter2(int i);

public class PersonA
{
	public string Name { get; set; }
}

//accessibility modifier 
//TYPE of the type (class/delegate/interface etc.)
//name for the type
//definition of the type.

public class PersonB
{
	public string Name { get; set; }
}

//Class, Struct, Interface, Delegate- Types are concerned.
//field, method etc.

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var p1 = new PersonA();

	var i1 = new IntegerFilter(IsEven);
	var i2 = new IntegerFilter2(IsEven);

	var evenNumbers = GetNumbersBasedOnFilter(numbers, IsEven);
	evenNumbers.Dump();

	var evenNumbers2 = GetNumbersBasedOnFilter(numbers, new IntegerFilter(IsEven));
	evenNumbers.Dump();

	var evenNumbers3 = GetNumbersBasedOnFilter(numbers, new IntegerFilter2(IsEven));
	evenNumbers.Dump();

	var oddNumbers = GetNumbersBasedOnFilter(numbers, IsOdd);
	oddNumbers.Dump();
	

}


public bool IsEven(int number)
{
	return number % 2 == 0;
}

public bool IsOdd(int number)
{
	return !IsEven(number);
}

public List<int> GetNumbersBasedOnFilter(List<int> numbers, IntegerFilter2 filter)
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


public List<int> GetNumbersBasedOnFilter(List<int> numbers, IntegerFilter filter)
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
