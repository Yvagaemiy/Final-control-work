// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//    лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//  [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//   [“Russia”, “Denmark”, “Kazan”] → []

// Вариант №1

Console.Clear();


string[] MekArray_1 (string[] mass_1, string[] mass_2)
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
void PrintArray_1(string[]mass_3)
{
   for (int i = 0; i < mass_3.Length; i++)
   {
      Console.Write($"{mass_3[i]}, ");
   }
      Console.WriteLine();
}

string[] mass_1 = new string [5] {"3678","aрп","56","пгова","7"};

string[] mass_2 = new string [mass_1.Length];


MekArray_1 (mass_1, mass_2);
PrintArray_1(mass_2);

