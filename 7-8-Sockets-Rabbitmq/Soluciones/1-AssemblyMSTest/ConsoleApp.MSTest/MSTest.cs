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
}