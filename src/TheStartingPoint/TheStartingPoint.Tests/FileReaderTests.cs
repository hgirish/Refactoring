using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace TheStartingPoint.Tests
{
  // ReSharper disable InconsistentNaming 

  [TestFixture]
  public class FileReaderTests
  {
    private StreamReader input;
  [SetUp]
  public void Setup()
  {
    try
    {
       input = new StreamReader("data.txt");
    }
    catch (FileNotFoundException e)
    {
      Console.WriteLine(e.Message);
      throw new Exception("Unbale to open test file");
    }
  }
  [TearDown]
  public void Teardonw()
  {
    try
    {
      input.Close();
    }
    catch (IOException e)
    {
      Console.WriteLine(e.Message);
      throw new Exception("Error on closing the test file");
    }
  }
    [Test]
    public void TestRead()
    {
      char ch = '&';
      for (int i = 0; i < 4; i++)
      {
        ch = (char) input.Read();
      }
      Assert.AreEqual('d', ch);
    }

    [Test][ExpectedException(typeof(ObjectDisposedException))]
    public void ThrowsException()
    {
    input.Close();
      char ch = '&';
      for (int i = 0; i < 4; i++)
      {
        ch = (char)input.Read();
      }
      Assert.AreEqual('2', ch);
    }
    [Test]
    public void TestReadAtEnd()
    {
      char ch = '&';
      for (int i = 0; i < 176; i++)
      {
        ch = (char)input.Read();
      }
      
      Assert.AreEqual(65535, ch);
      
    }
    [Test]
    public void TestBoundaries()
    {
    Assert.AreEqual('B',input.Read());
     
      for (int i = 1; i < 174; i++)
      {
        input.Read();
      }
      Assert.AreEqual('6',input.Read());
      Assert.AreEqual(-1, input.Read());
      Assert.AreEqual(-1, input.Read());
      Assert.AreEqual(-1, input.Read());
      Assert.AreEqual(-1, input.Read());
      Assert.AreEqual(-1, input.Read());
      Assert.AreEqual(-1, input.Read(),"read past end");

    }

    [Test]
    public void TestEmptyRead()
    {
      var empty = File.Create("empty.txt");
      var reader = new StreamReader(empty);
      Assert.AreEqual(-1, reader.Read());

    }
  }

  // ReSharper restore InconsistentNaming 
}