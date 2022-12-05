Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number / 10) % 10;
Console.Write("Вторая цифра: ");
Console.WriteLine(secondDigit);