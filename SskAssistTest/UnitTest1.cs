using NUnit.Framework;
using SskAssistWF;

namespace SskAssistTest
{
    public class Tests
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