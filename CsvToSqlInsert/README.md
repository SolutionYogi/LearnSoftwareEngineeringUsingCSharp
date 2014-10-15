CsvToSqlInsert
===================================

Write a C# class called CsvToSqlInsert which can read a CSV file and produce INSERT statements.

Look at the sample CSV file at TestData\Person.csv


The program should have following API

```C#
var insertGenerator = new CsvToSqlInsert('C:\Temp\Person.csv');
insertGenerator.GenerateSqlInsertFile('C:\Temp\Person.sql');
```

The file 'Person.sql' will look like this:

```
INSERT INTO dbo.Person (FirstName, LastName, State, BlogStartDate, BirthYear, Awesomeness)
VALUES('SolutionYogi', '','New York','10/14/2014',1980, 50)

INSERT INTO dbo.Person (FirstName, LastName, State, BlogStartDate, BirthYear, Awesomeness)
VALUES('Eric', 'Lippert','Seattle','09/12/2003',1970, 100)

INSERT INTO dbo.Person (FirstName, LastName, State, BlogStartDate, BirthYear, Awesomeness)
VALUES('Joel', 'Spolsky','New York','01/01/1999',1970, 100)

INSERT INTO dbo.Person (FirstName, LastName, State, BlogStartDate, BirthYear, Awesomeness)
VALUES('Eric', 'Sink','Illinois','03/30/2003',1970, 100)

```
