using Ucu.Poo.TestDateFormat;
using NUnit.Framework;
namespace LibraryTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFormatoCorrecto()
    {
        string resultado = DateFormatter.ChangeFormat("23/08/2005");
        Assert.AreEqual("2005-08-23",resultado);
    }
    
    [Test]
    public void TestFormatoIncorrecto()
    {
        Assert.Pass();
    }
    
    [Test]
    public void TestFechaEnBlanco()
    {
        Assert.Pass();
    }
}
