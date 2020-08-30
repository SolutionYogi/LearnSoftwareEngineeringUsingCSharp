<Query Kind="Program" />

//11- Query Syntax

void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = numbers.Where(x => x % 2 == 0);
	var evenNumbersAgain = from x in numbers
							where x % 2 == 0
							select x;
							
	//Those two are EXACTLY the same thing.
	//C# translates the 'query' syntax into method calls. 
	
	//Question: why is FROM and SELECT reversed??
}
