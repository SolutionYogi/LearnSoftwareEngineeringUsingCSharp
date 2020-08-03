<Query Kind="Program" />

//07 - Generics. 

//BCL Base Class Library. 
//'System.Object' is. 
//C# Language. knows intimately about. e.g. System.Object


/*

Generic programming centers around the idea of abstracting from concrete, 
efficient algorithms to obtain generic algorithms that can be combined with 
different data representations to produce a wide variety of useful software.
-- David, Stephanov (1989)

List, Stack, Queue are generic algorithms, we want to write them once and use it for any type.

List<T>
Stack<T>
Queue<T>

Same applies for delegates. .NET defines many delegates in terms of Func and Action.

//Action => Method that takes 0 to N parameters and returns void.
//Func => Method that takes 0 to N parameteers and returns a single value.

Action = public delegate void Action();
Action<T> = public delegate void Action<T>(T arg);
Action<T1, T2> = public delegate void Action<T1, T2>(T1 arg, T2 arg);
Action<T1, T2, T3> = public delegate void Action<T1, T2, T3>(T1 arg, T2 arg, T3 arg);

Func<TResult> = public delegate TResult Func<TResult>();
Func<T, TResult> = public delegate TResult Func<T, TResult>(T arg);
Func<T1, T2, TResult> = public delegate TResult Func<T1, T2, TResult>(T1 arg, T2 arg);

What is our IntegerFilter???

IntegerFilter = existing Action/Func. 

public delegate bool IntegerFilter(int i);

Func<int, bool> 

DELEGATE, 0 to N inputs. REturn 0 or 1 value. O to N inputs of WHAT type?

Action<T> = public delegate void Action<T>(T arg);

var a1 = new Action<int>();
var a2 = new Action<string>();
var a3 = new Action<bool>();

Func<T, TResult> = public delegate TResult Func<T, TResult>(T arg);

public delegate bool IntegerFilter(int i);
     Func<int, bool>
public delegate bool StringFilter(string i);
	Func<string, bool>
public delegate bool PersonFilter(Person p);
	Func<Person, bool>
public delegate bool PositionFilter(Position p);
	Func<Position, bool>

Takes one input, returns one output as Func<T, TResult>



*/
void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var evenNumbers = numbers.Filter(number => number % 2 == 0);
	evenNumbers.Dump();

	var oddNumbers = numbers.Filter(number => number % 2 != 0);
	oddNumbers.Dump();

	//This Filter method looks awfully familiar to something you already know, isn't it?
	
	//Question: Why did they implement extension method?
}

public delegate bool IntegerFilter(int i);

public static class ExtensionsMethods
{
	public static List<int> Filter(this List<int> numbers, Func<int, bool> filter)
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