
//2 Написать программу, которая принимает на вход два числа и проверяет первое число: является ли первое число квадратом второго числа 

Console.Clear();
// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
    // Console.Write("First number is a square of second number");
// else
    // Console.Write("First number is not square of second number");

// 3 Написать программу, которая будет выдавать название дня недели по заданному номеру

Console.Write ("Input number of the day: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day >7)
{
    Console.Write("Incorrect number");
}
else
{
    if (day == 1)
    {
        Console.Write("Monday");
    }
    if (day == 2)
    {
        Console.Write("Tuesday");
    }
    if (day == 3)
    {
        Console.Write("Wednesday");
    }
    if (day == 4)
    {
        Console.Write("Thursday");
    }
    if (day == 5)
    {
        Console.Write("Friday");
    }
    if (day == 6)
    {
        Console.Write("Saturday");
    }
    if (day == 7)
    {
        Console.Write("Sunday");
    }
}

// Напишите программу , которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

Console.Clear();

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// number *= number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.Write("number squared: " + sqrt1);