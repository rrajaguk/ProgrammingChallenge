using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingChallange.Chapter1;

namespace ProgrammingChallangeTest.Chapter1
{
    [TestClass]      
    public class TheTripTest
    {
        [TestMethod]
        public void TheTrip_Normal_OK()
        {
            // arrange
            TheTrip ts = new TheTrip();
            List<int> inputs = new List<int>();
            inputs.Add(3);
            inputs.Add(1000);
            inputs.Add(2000);
            inputs.Add(3000);
            inputs.Add(4);
            inputs.Add(1500);
            inputs.Add(1501);
            inputs.Add(300);
            inputs.Add(301);
            inputs.Add(0);
            ts.setInput(inputs);
            
            // act
            List<int> results = ts.calculate();
            List<int> expected = new List<int>() { 1000, 1199 };
            
            // assert
            Assert.AreEqual(expected.Count, results.Count);
            for (int i = 0; i < expected.Count;  i++)
            {
                Assert.AreEqual(expected[i], results[i]);
                
            }
        }
    }
}
