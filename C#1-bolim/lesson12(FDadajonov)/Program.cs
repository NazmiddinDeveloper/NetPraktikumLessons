using System.Data;

Console.WriteLine("Boolean");
int yosh;



try
{
    Console.Write("Yoshingiz nechida: ");
    yosh = Convert.ToInt32(Console.ReadLine());
    yosh = yosh % 0;
    if (yosh <= 12)
    {
        Console.WriteLine($"boljon sanga tekin kiruvir {yosh} da ekan yoshin");
    }
    else if (yosh > 12 && yosh <= 60)
    {
        Console.WriteLine($"yoshingiz {yosh} da ekan qirchillama paytiz sizga 25 ming so'm boladi brat");
    }
    else
    {
        Console.WriteLine($"Yoshingiz {yosh} da ekan Sizga bepul kirverin mazza qib chiqin ! ");
    }
}
catch(DivideByZeroException zde)
{
    Console.WriteLine(zde.Message);
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}



Console.ReadKey();