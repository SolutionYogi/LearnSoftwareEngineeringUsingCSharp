<Query Kind="Program" />

//03 - You need more and more helper functions to help you slice and dice the data.

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = GetEvenNumbers(numbers);
	evenNumbers.Dump();
	
	var oddNumbers = GetOddNumbers(numbers);
	oddNumbers.Dump();
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

public List<int> GetOddNumbers(List<int> numbers)
{
	var oddNumbers = new List<int>();

	for (var i = 0; i < numbers.Count; i++)
	{
		var currentNumber = numbers[i];
		var isOdd = currentNumber % 2 != 0;
		if (isOdd)
			oddNumbers.Add(currentNumber);
	}

	return oddNumbers;
}