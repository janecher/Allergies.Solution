using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllegiesProject;

namespace AllergiesProject.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ConvertToBinary_ConvertNumberToBinaryArray_ArrayWithOnesAndZeros()
    {
      int[] array = {0, 1, 0, 1};
      CollectionAssert.AreEqual(array, Score.ConvertToBinary(10));
    }
  }
}