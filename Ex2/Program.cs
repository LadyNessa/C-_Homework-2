Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string number2 = Convert.ToString(number);
    Console.WriteLine(number2[2]);
}