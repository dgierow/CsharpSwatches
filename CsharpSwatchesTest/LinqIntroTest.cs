using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpSwatches;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace CsharpSwatchesTest
{
    [TestClass]
    public class LinqIntroTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var query = LinqIntro.GetEvenQuery(numbers);

            int count = 0;
            var queryList = new List<int>(query);
            foreach (int i in query)
            {
                count++;
                Console.Write("{0}{1} ", i, (count == queryList.Count) ? string.Empty : ", ");
            }
            Console.WriteLine();

            Assert.AreEqual(4, query.Count());


            //string[] intsAsString = queryList.Select(x => x.ToString()).ToArray();

            //CommaDelimitedStringCollection cdsc = new CommaDelimitedStringCollection();
            //cdsc.AddRange(intsAsString);
            //Console.WriteLine(cdsc.ToString());
        }
    }
}
