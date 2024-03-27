using Trabalho2;
namespace TestTrabalho2;

[TestClass]
public class ExerciciosTests
{
     [TestMethod]
     public void TestSomar()
     {
         SomaInt somar = new SomaInt();
         Assert.AreEqual(5, somar.Somar(2, 3));
     }

     [TestMethod]
     public void TestConverterMetrosParaMilimetros()
     {
        MetroMM metro = new MetroMM();
        Assert.AreEqual(5000, metro.ConverterMetrosParaMilimetros(5));
     }

     [TestMethod]
     public void TestPodeSeAposentar()
     {
        Aposenta aposenta = new Aposenta();
        Assert.IsTrue(aposenta.PodeSeAposentar(65, 30));
        Assert.IsFalse(aposenta.PodeSeAposentar(60, 24));
     }
}
