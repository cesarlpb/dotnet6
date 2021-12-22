<<<<<<< HEAD:7-8/Soluciones/1-AssemblyMSTest/ConsoleApp.MSTest/MSTest.cs
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.MSTest;

[TestClass]
public class TestClass1 : IDisposable
{
    [AssemblyInitialize]
    //
    // 1. Called once before each test
    public TestClass1()
    {
        Console.WriteLine("ctor");
    }

    //  2. Called once before each test after the constructor
    [TestInitialize]
    public void TestInitialize()
    {
        Console.WriteLine("TestInitialize");
    }

    [TestMethod]
    public void Test1()
    {
        // 3.
    }

    // 4. Called once after each test before the Dispose method
    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("TestCleanup");
    }

    // 5. Called once after each test
    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
    [AssemblyCleanup]
    //
=======
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.MSTest;

[TestClass]
public class TestClass1 : IDisposable
{
    // 1. Called once before each test
    public TestClass1()
    {
        Console.WriteLine("ctor");
    }

    //  2. Called once before each test after the constructor
    [TestInitialize]
    public void TestInitialize()
    {
        Console.WriteLine("TestInitialize");
    }

    [TestMethod]
    public void Test1()
    {
        // 3.
    }

    // 4. Called once after each test before the Dispose method
    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("TestCleanup");
    }

    // 5. Called once after each test
    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }
>>>>>>> fb08d3f18fea955960131d86cccb28f53d6cc0d9:7-8-Sockets-Rabbitmq/Soluciones/1-AssemblyMSTest/ConsoleApp.MSTest/MSTest.cs
}