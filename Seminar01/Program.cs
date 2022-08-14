Console.WriteLine("Hello, 2World!");

// Напишите программу , которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

Console.Clear();

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// number *= number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.Write("number squared: " + sqrt1);
