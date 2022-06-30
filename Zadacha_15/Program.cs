/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели:");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = new []{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Weekend(number);

void Weekend(int currentNumber)
{
    int index = number - 1;
    if (index > 4 & index <= 6)
    {
        Console.WriteLine (array[index] + " является выходным днём, едем на шашлыки");
    }
    else if (index < 5)
    {
        Console.WriteLine (array[index] + " не является выходным днём, идем трудиться");
    }
    else Console.WriteLine ($"Дня неделени под порядковым номером {number} не существует, введите другое число");
}
