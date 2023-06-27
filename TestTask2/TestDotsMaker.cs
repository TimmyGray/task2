using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2;

namespace TestTask2
{
    [TestClass]
    public class TestDotsMaker
    {

        [TestMethod]
        public void TestDots()
        {
            string[] testdata = { 
                "rest", "verylongtestdata",
                "testdata2", "testdata1", "datatestd1" };


            DotsMaker dotsMaker = new DotsMaker(16, 10, 1);
            List<string> actualdata = new List<string>();
            string[] expecteddata = {"..........",".",".....","..."};
            int count = 1;
            foreach (string test in testdata)
            {
                string dots = dotsMaker.MakeDots(count);
                Console.WriteLine(count);
                Console.WriteLine(dots);
                actualdata.Add(dots);
                count*= 2;
            }

            Assert.AreEqual(expecteddata[0].Length, actualdata[4].Length);
            Assert.AreEqual(expecteddata[1].Length, actualdata[0].Length);
            Assert.AreEqual(expecteddata[1].Length, actualdata[1].Length);
            Assert.AreEqual(expecteddata[2].Length, actualdata[3].Length);
            Assert.AreEqual(expecteddata[3].Length, actualdata[2].Length);

        }

    }
}
