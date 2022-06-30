/*
Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.
*/

Console.WriteLine("Программа, которая определяет какая цифра расположена в массиве левее заданного числа: максимальная или минимальная");
Console.WriteLine();
Console.WriteLine("Введите натуральное число, в котором все цифры различны:");
int number = Convert.ToInt32(Console.ReadLine());
string array = number.ToString(); 
int max = 0;
int min = 0;
int maxIndex = array.Length - 1;
int index =  0;
char[] ints = new char [array.Length];
while (index < maxIndex) 
{
    ints[index] = Convert.ToChar(array[index]);
    Console.WriteLine(ints[index]);
    if (ints[index] > max)
    {
      max = ints[index];
    }
    if (ints[index] < min)
    {
        min = ints[index];
    }
    index++;
}


/* ------------------------------------------------------------------------------------ 
while (index < maxIndex) 
{
    Console.WriteLine(ints[index]);
    index++;
}
Console.WriteLine(max);
Console.WriteLine(min);
*/

/*
Console.WriteLine("Введите любое натуральное число до 10 и узнайте какое число лежит левее от него, максимальное или минимальное");
int currentNumber = Convert.ToInt32(Console.ReadLine());
*/
