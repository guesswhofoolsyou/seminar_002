/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int GetRandomNumber(int leftRange, int rightRange) // [100-1000)
{
Random rnd = new Random();
int result = rnd.Next(leftRange, rightRange); // [leftRange,rightRange)
return result;
}
*/

int SecondDigit(int number)
{
int firstDigit = number % 100;
int secondDigit = firstDigit / 10;

return secondDigit;
}

int GetNumber ()
{
Console.WriteLine("Введите числа");
string firstNumberStr = Console.ReadLine();
int firstNumber = int.Parse(firstNumberStr);
return firstNumber;
}

int number = GetNumber();

int secondDigit = SecondDigit(number);
Console.WriteLine(secondDigit);