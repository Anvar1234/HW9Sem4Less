//Все задачи решал с применением методов для практики по ним.



/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int MultipNumbersAaB(int A, int B)
{
    int mult = Convert.ToInt32(Math.Pow(A, B)); //почему то с Parse не сработало, только с ToInt32
    return mult;
}

Console.Clear(); 

Console.WriteLine("Введите число, которое необх возвести в степень:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите степень, в которую необходимо возвести число {A}");
int B = int.Parse(Console.ReadLine());

int stepen = MultipNumbersAaB(A, B);

Console.Write($"Число {A} в степени {B} = {stepen}");
*/





/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int SumOfDigit(int number)
{
    int count = 0;

    int digit = 0;
    int sumDigit = 0;
    while (number > 0)
    {
        digit = number % 10;
        number = number / 10;
        sumDigit = sumDigit + digit;
        count += 1;
        //Console.WriteLine($"Число после деления № {count} = {number}");
    }
    return sumDigit;

}

Console.WriteLine("Введите число, для котрого будет посчитана сумма его цифр");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb < 0)
{
    System.Console.WriteLine("Дружочек, введи-ка положительное число!");
}
else
{
int sum = SumOfDigit(numb);
Console.WriteLine($"Сумма цифр в числе {numb} = {sum}");
}
*/





/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] GetArray(int min, int max)
{
    int[] collection = new int[8];
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(min, max + 1);
    }
    return collection;
}

Console.Write("Введите левую границу диапазона значений массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу диапазона значений массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
if (minValue > maxValue)
{
    System.Console.WriteLine("Левая граница должна быть меньше правой!");
}
else Console.WriteLine($"Массив, состоящий из 8-ми случайных чисел: [{String.Join(", ", GetArray(minValue, maxValue))}]");
*/
