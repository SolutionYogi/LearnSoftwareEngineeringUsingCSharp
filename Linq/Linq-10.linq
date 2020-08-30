<Query Kind="Expression">
  <IncludeUncapsulator>false</IncludeUncapsulator>
</Query>

< Query Kind = "Program" />

 //10- Let's write Linq method FirstOrDefault.

 //Jon Skeet reimplemented Linq to Objects in an entire series. 

 //https://codeblog.jonskeet.uk/2010/09/03/reimplementing-linq-to-objects-part-1-introduction/

 //If you want to master Linq, read the series and implent it on your own.
 void Main()
{
	List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

	var doubleNumbers = numbers.Select(n => n * 2); //IEumerable<int> -> IEnumerable<int>

	var persons2 = numbers.LinqSelect(n => new Person(n)); //IEumerable<int> -> IEnumerable<Person>

	//PROJECTION 

	foreach (var person in persons2)
	{
		Console.WriteLine(person);
	}

	//SELECT -> There are two types. 

	//numbers.LinqFirstOrDefault().Dump();
}

public class Person
{
	public int Number { get; set; }

	public Person(int number)
	{
		Number = number;
	}

	public override string ToString()
	{
		return $"Person-{Number}";
	}
}

//<Place holder for the type>

public delegate string MyDelegateName(int i); //Specifiy definiition

public delegate TResult MyDelegateName<TInput, TResult>(TInput i);

public delegate TResult FuncX<T, TResult>(T i);

//public delegate MyDelegateName
//{
//    i = int 	
//    output = void
//}


//public struct 

public class IntQueue
{
	private List<int> _items = new List<int>();

	public void Enqueue(int i)
	{
	}

	public int Dequeue()
	{
		return 0;
	}
}



//name of generic type that you want to use.

public class Queue<T>
{
	private List<T> _items = new List<T>();

	public void Enqueue(T i)
	{

	}

	public T Dequeue()
	{
		throw new NotImplementedException();
	}
}



public delegate Person IntToPersonDelegate(int i);
public delegate int DoubleIntDelegate(int i);

public delegate TResult IntToX<TResult>(int i);



public Person GetPersonFromInt(int i)
{
	return new Person(i);
}


public int GetDouble(int i)
{
	return i * 2;
}


public delegate bool IntegerFilter(int i);

public static class ExtensionsMethods
{
	//Does everyone understand it fully?
	//Let's write SELECT ourselves.
	public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Func<T, bool> filter)
	{
		foreach (var item in items)
		{
			if (filter(item))
				yield return item;
		}
	}

	public static IEnumerable<TTarget> LinqSelect<TSource, TTarget>(this IEnumerable<TSource> source, Func<TSource, TTarget> map)
	{
		foreach (var item in source)
		{
			yield return map(item);
		}
	}


	//Let's implement the default SingleORDefualt and then implement
	//a better SingleOrDefault that you can use everywhere.
	public static T LinqSingleOrDefault<T>(this IEnumerable<T> items)
	{
		throw new NotImplementedException();
	}

	//Correct implementation using C# local functions.
	public static T BetterFirstOrDefault<T>(this IEnumerable<T> items)
	{
		throw new NotImplementedException();
	}

}