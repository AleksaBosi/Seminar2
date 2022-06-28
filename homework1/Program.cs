Console.WriteLine("Введите трехзначное число.");
string? number = Console.ReadLine();
if (number != null && number.Length == 3) Console.WriteLine($"Вторая цифра числа {number[1]}");
