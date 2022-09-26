/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

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

char OutputNumber(string inputNumber)
{
    char[] digits = inputNumber.ToCharArray();
    return digits[2];
}

int number = ReadData("Введите число");

if (number<100 && number>-100)
{
    Console.WriteLine("Такого числа нет!");
}
else if (number<-100)
{
    int absNumber = Math.Abs(number);
    char thirdDigit = OutputNumber(absNumber.ToString());
    PrintData("Третья цифра - ", thirdDigit.ToString());
}
else
{
    char thirdDigit = OutputNumber(number.ToString());
    PrintData("Третья цифра - ", thirdDigit.ToString());
}