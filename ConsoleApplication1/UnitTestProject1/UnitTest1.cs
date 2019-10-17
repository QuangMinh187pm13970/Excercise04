using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
        public void TestIsOdd()
        {
            bool result03 = Program.isOdd(3);
            Assert.AreEqual(true, result03);
            bool result04 = Program.isOdd(4);
            Assert.AreEqual(false, result04);
        }
        [TestMethod]
         public void TestIsEven()
         {
             bool result05 = Program.isEven(5);
             Assert.AreEqual(false, result05);
             bool result06 = Program.isEven(6);
             Assert.AreEqual(true, result06);
         }
            }
        }