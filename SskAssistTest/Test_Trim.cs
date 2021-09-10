using NUnit.Framework;
using SskAssistWF;
using System.Collections.Generic;

namespace SskAssistTest
{
    class Test_Trim
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TrimPrefixAndDigitsTest_Prefix()
        {
            string actual = Parse.TrimPrefDig("lpar1_AccessServer");
            string expected = "AccessServer";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TrimPrefixAndDigitsTest_Digits()
        {
            string actual = Parse.TrimPrefDig("AccessServer1145");
            string expected = "AccessServer";

            Assert.AreEqual(expected, actual);
        }
    }
}