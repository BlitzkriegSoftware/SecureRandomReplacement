using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SecureRandom_Test
{
    [TestClass]
    public class SystemRandom_Tests
    {
        private System.Random dice = new System.Random();

        public SystemRandom_Tests()
        {
        }

        private static TestContext _testcontext;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _testcontext = context;
        }

        [TestMethod]
        public void Random_Seed()
        {
            // this is a dumb method and should not be used in Prod.
            dice = new System.Random(1);
        }

        [TestMethod]
        public void Ransom_Next_0()
        {
            var result = dice.Next();
            TestOut("Result: {0}", result);
            bool ok = (result >= 0) && (result <= int.MaxValue);
            Assert.IsTrue(ok, "Not a valid positive integer");
        }

        [TestMethod]
        public void Ransom_Next_Max()
        {
            int max = 100;
            var result = dice.Next(max);
            TestOut("Result: {0}", result);
            bool ok = (result >= 0) && (result < max);
            Assert.IsTrue(ok, "Not a valid range");
        }

        [TestMethod]
        public void Ransom_Next_Min_Max()
        {
            int min = 1;
            int max = 100;
            var result = dice.Next(min,max);
            TestOut("Result: {0}", result);
            bool ok = (result >= min) && (result < max);
            Assert.IsTrue(ok, "Not a valid range");
        }

        [TestMethod]
        public void Random_Next_Double()
        {
            var result = dice.NextDouble();
            TestOut("Result: {0}", result);
            bool ok = (result >= double.MinValue) && (result <= double.MaxValue);
            Assert.IsTrue(ok, "Not a valid range");
        }

        [TestMethod]
        public void Random_Next_Bytes()
        {
            bool atLeastOne = false;
            var buf = new byte[256];
            dice.NextBytes(buf);
            foreach(byte result in buf)
            {
                TestOut("Result: {0}", result);
                bool ok = (result >= byte.MinValue) && (result <= byte.MaxValue);
                Assert.IsTrue(ok, "Not a valid range");
                if (result > 0) atLeastOne = true;
            }
            Assert.IsTrue(atLeastOne, "Should have one non-zero result");
        }


        public void Random_Next_Bytes_Span()
        {
            bool atLeastOne = false;
            var buf = new byte[512];
            var arraySpan = new Span<byte>(buf);
            dice.NextBytes(arraySpan);
            foreach (byte result in buf)
            {
                TestOut("Result: {0}", result);
                bool ok = (result >= byte.MinValue) && (result <= byte.MaxValue);
                Assert.IsTrue(ok, "Not a valid range");
                if (result > byte.MinValue) atLeastOne = true;
            }
            Assert.IsTrue(atLeastOne, "Should have one non-zero result");
        }

        private void TestOut(string format, params object[] args)
        {
            Console.WriteLine(format, args);
            _testcontext.WriteLine(format, args);
        }

    }
}
