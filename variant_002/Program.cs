// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//  [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//   [“Russia”, “Denmark”, “Kazan”] → []

// Вариант №2


void MekArray_2(string [] mass_1)
{
  for (int i = 0; i < mass_1.Length;i++)
  {
     Console.Write($"Введите {i+1} элемент массива: ");
    mass_1[i] = Console.ReadLine()!;
  }
}
string [] SortArray_2(string [] mass_2)
{
  int count_1 = 0;
  for (int i = 0;i < mass_2.Length; i++)
  {
    if(mass_2[i].Length <=3)
    count_1++;
  }
  string []  new_mass = new string [count_1];
  int count_2 = 0;
  for (int i = 0; i < mass_2.Length; i++)
  {
    if(mass_2[i].Length <=3)
    {
        new_mass[count_2] = mass_2[i];
        count_2++;
    }
  }
  return new_mass;
}
void PrintArray_2(string [] amass_3)
{
     Console.Write("[");
    for (int i = 0; i < amass_3.Length; i++)
    {
    Console.Write($"{amass_3[i]}, ");
    }
     Console.Write("]");
}

Console.Write("Введите количество элементов массива: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
string [] new_mass = new string [number_1];

MekArray_2(new_mass);
PrintArray_2(SortArray_2(new_mass));
Console.WriteLine();

