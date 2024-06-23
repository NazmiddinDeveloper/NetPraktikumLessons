
// type conversion
//implicit cast

using System;

byte varByte = 128;
short varShort = 500;
int varInt = 1000;
long varLong = 9_000_000_000;

/*
varShort = varByte;
varInt = varShort;
varLong = varInt;


Console.WriteLine(varShort);
Console.WriteLine(varInt);
Console.WriteLine(varLong);
*/

// byte > short > int > long > float > double > decimal ----> implicit cast

// explicit cast

varByte = (byte)varInt;
Console.WriteLine(varByte);

varInt = (int)varLong;
Console.WriteLine(varInt);


// Conversoin to string 
// .ToString()
//Console.WriteLine(varLong.ToString());
Console.WriteLine(Convert.ToBoolean(1));
Console.ReadKey();