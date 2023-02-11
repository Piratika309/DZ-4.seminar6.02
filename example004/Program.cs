// Найти сумму чисел одномерного массива, стоящих на нечетной позиции


int [] array= new int [10];
int sum = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}

for (int i = 0; i < array.Length; i++)
Console.Write ($" {array[i]} \t");

for (int i = 0; i < array.Length; i++) 

if (array[i] % 2 !=0)
{
    sum = sum + array[i];
}
    Console.WriteLine(" Сумма нечетных чисел в массиве равна : " + sum);
