/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
thirdNumber (number);

void thirdNumber (int currentNumber)
{
    string array = currentNumber.ToString();
    int maxIndex = array.Length - 1;

    if (maxIndex < 2) 
    {
        Console.WriteLine("Третьей цифры в данном числе нет, введите другое число");
    }
    else
    {
        Console.WriteLine("Третья цифра заданного числа: " + array[2]);
    }
}




