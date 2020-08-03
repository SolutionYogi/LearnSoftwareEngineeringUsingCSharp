<Query Kind="Program" />

//02 - Separate mechanics into a method.

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = GetEvenNumbers(numbers);
	
	evenNumbers.Dump();
}

public List<int> GetEvenNumbers(List<int> numbers)
{
	var evenNumbers = new List<int>();

	for (var i = 0; i < numbers.Count; i++)
	{
		var currentNumber = numbers[i];
		var isEven = currentNumber % 2 == 0;
		if (isEven)
			evenNumbers.Add(currentNumber);
	}

	return evenNumbers;
}