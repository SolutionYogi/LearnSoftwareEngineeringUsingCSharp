<Query Kind="Program" />

//05 - Lambda Expressions to save us from all the boiler plate.

//Key Concepts
//Expression vs Statement 
//Lambda Expression => A short way to write a function.
//Type inference.
//Compiler translates the lambda expression in to a C# class with internal method. 

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //STATEMENT.
	
	IsEven(10); //statement.
	
	//EXPRESSION always PRODUCES a VALUE. 
	
	var i = 10;
	var y = i / 2; //The whole line is a statement. i/2 is expression wihtin statement.

	var evenNumbers1 = GetNumbersBasedOnFilter(numbers, IsEven);
	evenNumbers1.Dump();
	
	var evenNumbers2 = GetNumbersBasedOnFilter(numbers, number => number % 2 == 0);	
	evenNumbers2.Dump();

	var evenNumbers3 = GetNumbersBasedOnFilter(numbers, (int number) => number % 2 == 0);
	evenNumbers2.Dump();

	var oddNumbers = GetNumbersBasedOnFilter(numbers, number => number % 2 != 0);
	oddNumbers.Dump();
}

public bool IsEven(int number)
{
	return number % 2 == 0;
}

public bool IsOdd(int number)
{
	return number % 2 != 0;
}

public delegate bool IntegerFilter(int i);

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
