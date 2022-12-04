/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];

FillArrayRandomDoubleNumbers(numbers, 1, 5);
WriteArray(numbers);

double min = numbers[0];
double max = numbers[0];

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]<min) min = numbers[i];
    else if (numbers[i]>max) max = numbers[i];
}
Console.Write("Max: " + max + " ");
Console.WriteLine("Min: " + min + " ");
Console.Write("Разница: "); 
Console.Write(max-min);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomDoubleNumbers(double[] array, double min, double max)
{
for(int i = 0; i < array.Length; i++)
{
array[i] = Math.Round(new Random().NextDouble(), 2);
}
}

void WriteArray(double[] array)
{
for(int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
