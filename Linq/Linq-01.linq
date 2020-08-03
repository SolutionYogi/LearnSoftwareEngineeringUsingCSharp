<Query Kind="Program" />

//01 - Get Even Numbers. 
void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
	
	var evenNumbers = new List<int>();
	
	for(var i=0; i < numbers.Count; i++)
	{
		var currentNumber = numbers[i];
		var isEven = currentNumber % 2 == 0;
		if(isEven)
			evenNumbers.Add(currentNumber);
	}
	
	evenNumbers.Dump();
}

