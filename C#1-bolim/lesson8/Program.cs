// strings
// literar string

string literarString = "Hello .NET course";
// escape character \"
// \n 
// \t - tabulate charachter
Console.WriteLine(literarString);


// VERBATIM String ( @ )
string verbatimString = @"C:\telephones\notes ";
Console.WriteLine(verbatimString);

//concatenation string
string name = "Nazmiddin";
string concatenatedSrting = "My name is "+name;
Console.WriteLine(concatenatedSrting);


//interpolated string
string interpolatedString = $"my name is {name}";
Console.WriteLine(interpolatedString);