// Задать массив, заполнить случайными положительными трехзначными числами. Показать количество нечетных/четных чисел

int [] array= new int [10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
}

for (int i = 0; i < array.Length; i++)
Console.Write ($" {array[i]} \t");

int number = array.Count(i=>i% 2 == 0);

if  (number > 0);
   {
        Console.WriteLine("Количество четных цифр в массиве выводится " + number + " раз(а), а количество нечетных цифр равно " + (array.Length-number));
   }