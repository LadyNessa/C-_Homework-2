Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.WriteLine("Число кратно одновременно 7 и 23");
    }
}
else
{
    Console.WriteLine("Число не кратно одновременно 7 и 23");
}