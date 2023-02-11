// Найти произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и тд.

int [] array = new int [10];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
Console.Write($"{array[i]} \t");
}

for (int i = 0; i < array.Length; i++)
{
    result = array[0]*(array[array.Length - 1]);
}
   Console.Write($"\n");
   Console.WriteLine("Прозведение пар чисел первого и последнего массива равно: " + result); 
