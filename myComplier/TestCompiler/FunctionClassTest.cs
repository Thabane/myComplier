using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunComplier;

namespace TestCompiler
{
    [TestClass]
    public class FunctionClassTest
    {
        [TestMethod]
        public void when_adding_two_numbers()
        {
            Functionality func =  new Functionality();
            var result = func.Adding(5, 5);
            Assert.IsTrue(result == 10, "Numbers dont add up" );
        }
        [TestMethod]
        public void when_subtracting_two_numbers()
        {

            Functionality func = new Functionality();
            var result = func.Subtract(10, 5);
            Assert.IsTrue(result == 5, "Numbers dont subtract up");
        }
    }
}
