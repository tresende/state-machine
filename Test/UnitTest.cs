using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EX2;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void UnitTestStateMachine()
        {
            var steps = new string[] { "a", "a", "a", "a", "a", "c", "d", "b" };
            var stateMachine = new StateMachine();
            var lastStep = stateMachine.Run(steps);
            Assert.AreEqual(lastStep, "S4");
        }
    }
}
