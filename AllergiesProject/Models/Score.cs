using System.Collections.Generic;

namespace AllegiesProject
{
  public class Score
  {
    public static int[] ConvertToBinary(int number)
    {
      List<int> result = new List<int>();
      while(number > 0)
      {
        result.Add(number%2);
        number /=2;
      }
      return result.ToArray();
    }
  }
}