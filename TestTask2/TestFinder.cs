using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2;

namespace TestTask2
{
    [TestClass]
    public class TestFinder
    {
        [TestMethod]
        public void TestCreate()
        {

            string[] testdata = { "rest", "verylongtestdata", "testdata2", "testdata1", "rest", "verylongtestdata", "datatestd2", "datatestd1", "rest", "rest" };
            Finder testf = new Finder(testdata);
            Dictionary<string, int> expected = new Dictionary<string, int>
            {
                { "datatestd1", 1 },
                { "datatestd2", 1 },
                { "testdata1", 1 },
                { "testdata2", 1 },
                { "verylongtestdata", 2 },
                { "rest", 4 }
            };

            foreach(var val in testf.Uniqwords)
            {
                Console.WriteLine(val.Key);
            }

            Assert.AreEqual(expected["datatestd1"], testf.Uniqwords.ElementAt(0).Value, $"Incorrect sorting - expected {expected["datatestd1"]}, actual - {testf.Uniqwords.ElementAt(0).Value}");
            Assert.AreEqual(expected["datatestd2"], testf.Uniqwords.ElementAt(1).Value, $"Incorrect sorting - expected {expected["datatestd1"]}, actual - {testf.Uniqwords.ElementAt(1).Value}");
            Assert.AreEqual(expected["rest"], testf.Uniqwords.ElementAt(5).Value, $"Incorrect sorting - expected {expected["rest"]}, actual - {testf.Uniqwords.ElementAt(5).Value}");
            Assert.AreEqual(expected.ElementAt(4).Key, testf.longestword,$"Wrong longest word - expected {expected.ElementAt(4).Key}, actual - {testf.longestword}");

        }
    }
}
