CsvReader
===================================

Write a C# class called CsvReader which can read a CSV file and return C# objects from it.

The API should look like this:

Let's say you have following class defined.


```C#
public class Person
{   
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string State { get; set; }
}
```

And here's sample data in a CSV file.

```
FirstName, LastName, State
SolutionYogi,,New York
Eric,Lippert,Seattle
Joel,Spolsky,Seattle
Eric,Sink,Illinois
```


```C#
var csvReader = new CsvReader("C:\Temp\SampleData.csv");
var personList = csvReader.GetObjects(); 


public List<Person> GetObjects()
{
    //Implement this method. 
}

```
