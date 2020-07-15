using System;
using AllegiesProject;

class Program
{
  static void Main()
  {
    string[] arrayOfAllergens = {"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};
    Console.WriteLine("Input a score number: ");
    int score = int.Parse(Console.ReadLine());
    if(score < 1 || score > 255)
    {
      Console.WriteLine("Score must be between 1 and 255");
      Main();
    }
    else
    {
      int[] arrayOfAllergenIndex = Score.ConvertToBinary(score);
      for(int i=0; i < arrayOfAllergenIndex.Length; i++) {
        if(arrayOfAllergenIndex[i] == 1)
        {
          Console.WriteLine(arrayOfAllergens[i]);
        }
      }
      Main();
    }   
  }
}