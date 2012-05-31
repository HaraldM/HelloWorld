using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoodbyeWorld;

namespace GoodbyeWorldTests
{
    [TestClass]
    public class MessageManagerTests
    {
        public MessageManagerTests()
        {
        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private MessageManager man;

        [TestInitialize()]
        public void MessageManagerInitialiser()
        {
            man = new MessageManager();
        }

        [TestMethod]
        public void TestSay_MessageGetsSet()
        {
            var parameter = "Goodbye";
            man.Say(parameter);
            Assert.AreEqual(parameter, man.Message);
        }

        [TestMethod]
        public void TestSay_EmptyMessage_MessageNotSet()
        {
            string parameter = null;
            man.Say(parameter);
            Assert.AreEqual(parameter, man.Message);
        }

        [TestMethod]
        public void TestSay_TransformsText()
        {
            var parameter = "gOOdbye";
            man.Message = parameter;

            var result = man.Transform();
            Assert.AreEqual("Goodbye", result);
        }
    }
}
