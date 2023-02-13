// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным  элементом

double [] array = new double [10];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10,10);
}
for (int i = 0; i < array.Length; i++)
Console.Write ($" {array[i]} \t");

double max = 0;

for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max)
    {
        max = array[i];
    }
}

double min = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.Write ("Разница между минимальным и максимальным значением равна: " + (max - (-1)*min));

