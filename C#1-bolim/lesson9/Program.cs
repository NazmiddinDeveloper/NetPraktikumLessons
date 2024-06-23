// numbers
// short, int, long
short age = 20;
int studentsCount = 1200;
long worldPopulationCount = 8_000_000_000;

//ushort, uint, ulong
ushort uage = 20;
uint ustudentsCount = 1200;
ulong uworldPopulationCount = 8_000_000_000;

// sizeof()

Console.WriteLine(sizeof(short));
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(long));
Console.WriteLine(sizeof(ushort));
Console.WriteLine(sizeof(uint));
Console.WriteLine(sizeof(ulong));

//MinValue , MaxValue

Console.WriteLine(short.MinValue);
Console.WriteLine(short.MaxValue);

Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

Console.WriteLine(long.MinValue);
Console.WriteLine(long.MaxValue);

// u - MinValue , u - MaxValue

Console.WriteLine(ushort.MinValue);
Console.WriteLine(ushort.MaxValue);

Console.WriteLine(uint.MinValue);
Console.WriteLine(uint.MaxValue);

Console.WriteLine(ulong.MinValue);
Console.WriteLine(ulong.MaxValue);
