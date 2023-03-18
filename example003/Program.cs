// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] FillMass(int size)
{
  int[] Array = new int[size];
  for (int i = 0; i < size; i++)
  {
    Array[i] = new Random().Next(1000);
  }
  return Array;
}

System.Console.WriteLine("Введите размерность массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] massive = FillMass(number);
System.Console.WriteLine($"[{String.Join("; ", massive )}]");