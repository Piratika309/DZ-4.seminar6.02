// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int [] array= new int [123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 300);
}
int count = 0;

for (int i = 0; i < array.Length; i++)

if  (array[i] < 100 && array[i]> 9)
   {
    count = count+1;
   }

 Console.WriteLine("Количество  " + count);


