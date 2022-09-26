/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int inputNumber = int.Parse(Console.ReadLine() ?? "");
    return inputNumber;
}

int number = ReadData("Введите число: ");

if (number >5 && number <8 )
{
    Console.WriteLine("Да!");
}
else if (number > 0 && number < 6 )
{
    Console.WriteLine("Нет((");
}
else
{
    Console.WriteLine("Введено неверное число");
}