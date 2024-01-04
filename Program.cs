using System;

namespace ConsoleApp8
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ввод количества элементов массива:

      Console.Write("Введите количество элементов массива: ");
      
      int elementsCount = int.Parse(Console.ReadLine());
      string[] bots = new string[elementsCount];
      
      // Ввод элементов массива:
      
      for (int i = 0; i < elementsCount; i++)
      {
        bots[i] = Console.ReadLine();
      }

      // Вывод строк баноффа

      foreach (string s in bots) Console.WriteLine("/banoff 0 "+s+" 2000 Бот/Томаш");
    }
  }
}