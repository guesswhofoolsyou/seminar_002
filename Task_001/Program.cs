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

int ReadData(string line)
{
    Console.WriteLine(line);
    int inputNumber = int.Parse(Console.ReadLine() ?? "");
    return inputNumber;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int number = ReadData("Введите число:");

if (number<100)
{
    Console.WriteLine("Введенное неверное число!");    
}
else
{
    int secondDigit = SecondDigit(number);
PrintData("Ваше число: ", secondDigit.ToString());
}