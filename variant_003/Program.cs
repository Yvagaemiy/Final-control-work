// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//  [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//   [“Russia”, “Denmark”, “Kazan”] → []


// Вариант №3

void Mass_3(string[]mass_1)
{
 for (int i = 0; i < mass_1.Length; i++)
 {
   Console.Write($"Введите {i+1} элемент массива: ");
   mass_1[i] = Console.ReadLine()!;
 }
}
string[] MekArray_3 (string[] mass_1, string[] mass_2)
{
  int count = 0;
  for (int i = 0; i <mass_1.Length; i++)
  {
     if (mass_1[i].Length <= 3) 
     {
      mass_2[count] = mass_1[i];
      count++;
     }
  }
 return mass_2;
}
void PrintArray_3(string[]mass_3)
{
   Console.Write("[");
   for (int i = 0; i < mass_3.Length; i++)
   {
      Console.Write($"{mass_3[i]}, ");
   }
   Console.Write("]");
}


Console.Write("Введите количество элементов массива: ");
int number_2 = Convert.ToInt32(Console.ReadLine()!);
string[]mass_1_1 = new string [number_2];

string[]mass_2_1 = new string [mass_1_1.Length];

Mass_3(mass_1_1);

MekArray_3 (mass_1_1, mass_2_1);
PrintArray_3(mass_2_1);

