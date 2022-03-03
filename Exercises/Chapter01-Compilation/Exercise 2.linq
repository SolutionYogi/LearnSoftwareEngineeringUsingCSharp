<Query Kind="Program" />

//Fully understanding the Generic IEnumerable & IEnumerator interface
/*

All the types like List,Array,Stack,Queue internally implement the IEnumerable<T> interface.
This provides/creates an object of IEnumerator<T> which has the following methods: MoveNext(), Reset(), Dispose()
Why is IEnumerable seperate from IEnumerator : https://stackoverflow.com/a/1993169
*/

void Main()
{
	Words w = new Words();
	var iterator = w.GetEnumerator();
	while(iterator.MoveNext())
	{
		iterator.Current.Dump();
	}
	
}


public class Words : IEnumerable<string>
{
	public IEnumerator<string> GetEnumerator()
	{
		return  new WordsEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator() //Non-generic interface
	{
		throw new NotImplementedException();
	}
}

public class WordsEnumerator : IEnumerator<string>
{
	private  string _current = null;
	public string Current => _current;

	object IEnumerator.Current => throw new NotImplementedException(); //non-generic implementation

	public void Dispose()
	{
		throw new NotImplementedException();
	}

	public bool MoveNext()
	{
		if(_current ==null)
		{
			_current = "Hi";
			return true;
		}
		if (_current == "Hi")
		{
			_current = "Hello";
			return true;
		}
		if (_current == "Hello")
		{
			
			return false;
		}
		return false;
	}

	public void Reset()
	{
		_current =null;
	}
}

