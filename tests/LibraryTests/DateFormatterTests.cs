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
        string resultado = DateFormatter.ChangeFormat("23082005");
        Assert.AreNotEqual("2005-08-23",resultado);
    }
    
    [Test]
    public void TestFechaEnBlanco()
    {
        string resultado = DateFormatter.ChangeFormat("");
        Assert.AreEqual("",resultado);
    }
}
