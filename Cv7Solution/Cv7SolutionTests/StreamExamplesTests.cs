using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cv7Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7Solution.Tests
{
    [TestClass()]
    public class StreamExamplesTests
    {
        [TestMethod()]
        public void FileExampleTest()
        {
            StreamExamples.FileExample();
        }
    }
}