CsvToSqlInsert
===================================

Write a C# class called CsvToSqlInsert which can read a CSV file and produce INSERT statements.

Let's say name of the file is 'Person.csv' which has following data:

```
FirstName, LastName, State, BirthYear
SolutionYogi,,New York, 1980
Eric,Lippert,Seattle, 1970
Joel,Spolsky,Seattle, 1971
Eric,Sink,Illinois, 1972
```

The program should have following API

```C#
var insertGenerator = new CsvToSqlInsert('C:\Temp\Person.csv');
insertGenerator.GenerateSqlInsertFile('C:\Temp\Person.sql');
```

The file 'Person.sql' will look like this:

```
INSERT INTO dbo.Person (FirstName, LastName, State, BirthYear) VALUES ('SolutionYogi', NULL, 'New York', 1980);
GO

INSERT INTO dbo.Person (FirstName, LastName, State, BirthYear) VALUES ('Eric', 'Lippert', 'Seattle', 1970);
GO

INSERT INTO dbo.Person (FirstName, LastName, State, BirthYear) VALUES ('Joel', 'Spolsky', 'Seattle', 1971);
GO

INSERT INTO dbo.Person (FirstName, LastName, State, BirthYear) VALUES ('Eric', 'Sink', 'Illinois', 1972);
GO
```
