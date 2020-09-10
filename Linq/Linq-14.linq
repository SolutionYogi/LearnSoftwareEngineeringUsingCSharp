<Query Kind="Program" />

//14 - LINQ to X
// So far we mainly talked about Linq to Objects.
// There is also Linq to Sql.
// It's a 'simple' exercise of writing compiler to turn C# query into SQL query.

//DECLARATIVE vs IMPERATIVE.
//DECLARATIVE - You write code declaring what you want and compiler/library figures out how to do it.
//IMPERATIVE - You must specify all the steps yourself.

//Example: Asking your partner to make Tea. 
//Remember, at the end, computers don't work at declarative level. They only run machine code.
//The goal of programming languages is to let you express your ideas at 'human level'.

//Exercises:

//1. Implement at least 3 existing LINQ to OBJECTS method on your own. 
//2. Implement a new 'Batch' method.
//3. Go through MoreLinq https://github.com/morelinq/MoreLINQ
//4. Write a CsvReader<T> class.

void Main()
{
	
}

public IEnumerable<IEnumerable<T>> Batch<T>(IEnumerable<T> input, int batchSize)
{
	throw new NotImplementedException();
}