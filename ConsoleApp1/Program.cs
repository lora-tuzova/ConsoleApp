// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ввести число: ");
try
{
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ви ввели число {n}");
}
catch
{
    Console.WriteLine("Ви не ввели число");
}


