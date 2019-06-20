using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpSwatches;

namespace CsharpSwatchesTest
{
    [TestClass]
    public class CodeWarsKataTest
    {

        #region Tribonacci tests

        [TestMethod]
        public void Tribonacci_1()
        {
            double[] results;

            int n = 2;
            double[] signature = { 1, 1, 1 };

            results = CodeWarsKata.Tribonacci(signature, n);

            foreach (double d in results)
            {
                Console.WriteLine(d.ToString() + ',');
            }

            Assert.AreEqual(1, results[0]);
            Assert.AreEqual(1, results[1]);

        }

        [TestMethod]
        public void Tribonacci_2()
        {
            double[] results;

            int n = 10;
            double[] signature = { 1, 1, 1 };

            results = CodeWarsKata.Tribonacci(signature, n);

            foreach (double d in results)
            {
                Console.WriteLine(d.ToString() + ',');
            }

            Assert.AreEqual(1, results[0]);
            Assert.AreEqual(1, results[1]);
            Assert.AreEqual(1, results[2]);
            Assert.AreEqual(3, results[3]);
            Assert.AreEqual(5, results[4]);
            Assert.AreEqual(9, results[5]);
            Assert.AreEqual(17, results[6]);
            Assert.AreEqual(31, results[7]);
            Assert.AreEqual(57, results[8]);
            Assert.AreEqual(105, results[9]);

            //Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, results);
        }

        [TestMethod]
        public void Tribonacci_3()
        {
            double[] result;

            int n = 10;
            double[] signature = { 0, 0, 1 };

            result = CodeWarsKata.Tribonacci(signature, n);

            foreach (double d in result)
            {
                Console.WriteLine(d.ToString() + ',');
            }

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(1, result[2]);
            Assert.AreEqual(1, result[3]);
            Assert.AreEqual(2, result[4]);
            Assert.AreEqual(4, result[5]);
            Assert.AreEqual(7, result[6]);
            Assert.AreEqual(13, result[7]);
            Assert.AreEqual(24, result[8]);
            Assert.AreEqual(44, result[9]);

            //new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }
        }

        #endregion

        #region PrinterErrors tests

        [TestMethod]
        public void PrinterErrors_0()
        {
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("3/56", result);
        }

        [TestMethod]
        public void PrinterErrors_1()
        {
            string s = "aaabbbbhaijjjm";
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("0/14", result);
        }

        [TestMethod]
        public void PrinterErrors_2()
        {
            string s = "aaaxbbbbyyhwawiwjjjwwm";
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("8/22", result);
        }

        [TestMethod]
        public void PrinterErrors_3()
        {
            string s = string.Empty;
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("0/0", result);
        }

        [TestMethod]
        public void PrinterErrors_4()
        {
            string s = "!@#$%^&*()";
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("10/10", result);
        }

        [TestMethod]
        public void PrinterErrors_5()
        {
            string s = "0123456789";
            string result = CodeWarsKata.PrinterError(s);

            Assert.AreEqual("10/10", result);
        }

        #endregion

        #region IsTriangle tests

        [TestMethod]
        public void IsTriangle_1()
        {
            Assert.IsTrue(CodeWarsKata.IsTriangle(5, 7, 10));
        }

        [TestMethod]
        public void IsTriangle_2()
        {
            Assert.IsFalse(CodeWarsKata.IsTriangle(3, 4, 10));
        }

        #endregion

        #region Disemvowel tests

        [TestMethod]
        public void Disemvowel_1()
        {
            string result = CodeWarsKata.Disemvowel("This website is for losers LOL!");
            Assert.AreEqual("Ths wbst s fr lsrs LL!", result);
        }

        #endregion

        #region ParityOutlier tests

        [TestMethod]
        public void ParityOutlier_1()
        {
            int[] integers = { 2, 6, 8, -10, 3 };
            Assert.AreEqual(3, CodeWarsKata.ParityOutlier(integers));
        }

        [TestMethod]
        public void ParityOutlier_2()
        {
            int[] integers = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.AreEqual(206847684, CodeWarsKata.ParityOutlier(integers));
        }

        [TestMethod]
        public void ParityOutlier_3()
        {
            int[] integers = { int.MaxValue, 0, 1 };
            Assert.AreEqual(0, CodeWarsKata.ParityOutlier(integers));
        }

        [TestMethod]
        public void ParityOutlier_4()
        {
            int[] integers = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            Assert.AreEqual(11, CodeWarsKata.ParityOutlier(integers));
        }

        [TestMethod]
        public void ParityOutlier_5()
        {
            int[] integers = { 160, 3, 1719, 19, 11, 13, -21 };
            Assert.AreEqual(160, CodeWarsKata.ParityOutlier(integers));
        }

        #endregion

        #region GetSum tests

        [TestMethod]
        public void GetSum_1()
        {
            Assert.AreEqual(1, CodeWarsKata.GetSum(1, 0));
        }

        [TestMethod]
        public void GetSum_2()
        {
            Assert.AreEqual(3, CodeWarsKata.GetSum(1, 2));
        }

        [TestMethod]
        public void GetSum_3()
        {
            Assert.AreEqual(1, CodeWarsKata.GetSum(0, 1));
        }

        [TestMethod]
        public void GetSum_4()
        {
            Assert.AreEqual(1, CodeWarsKata.GetSum(1, 1));
        }

        [TestMethod]
        public void GetSum_5()
        {
            Assert.AreEqual(-1, CodeWarsKata.GetSum(-1, 0));
        }

        [TestMethod]
        public void GetSum_6()
        {
            Assert.AreEqual(2, CodeWarsKata.GetSum(-1, 2));
        }

        #endregion

        #region DuplicateEncoder tests

        [TestMethod]
        public void DuplicateEncoder_1()
        {
            Assert.AreEqual("(((", CodeWarsKata.DuplicateEncoder("din"));
        }

        [TestMethod]
        public void DuplicateEncoder_2()
        {
            Assert.AreEqual("()()()", CodeWarsKata.DuplicateEncoder("recede"));
        }

        [TestMethod]
        public void DuplicateEncoder_3()
        {
            Assert.AreEqual(")())())", CodeWarsKata.DuplicateEncoder("Success"), "should ignore case");
        }

        [TestMethod]
        public void DuplicateEncoder_4()
        {
            Assert.AreEqual("))((", CodeWarsKata.DuplicateEncoder("(( @"));
        }

        #endregion


    }
}
