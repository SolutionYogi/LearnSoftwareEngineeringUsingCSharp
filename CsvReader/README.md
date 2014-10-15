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
    
    public DateTime BlogStartDate { get; set; }
    
    public int BirthYear { get; set; }
    
    public int Awesomeness { get; set; }
}
```

Sample CSV file is located at TestData\Person.csv 



```C#
var csvReader = new CsvReader("C:\Temp\SampleData.csv");
var personList = csvReader.GetObjects(); 


public List<Person> GetObjects()
{
    //Implement this method. 
}

```
