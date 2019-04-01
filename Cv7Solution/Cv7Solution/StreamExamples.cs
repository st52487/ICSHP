using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv7Solution
{
    public class StreamExamples
    {
        public static void FileExample()
        {
            const string testPath01 = "test.txt";
            if (!File.Exists(testPath01))
            {
                FileStream test1 = File.Create(testPath01);
            }

            const string testPath02 = "testWithBuffer.txt";
            if (!File.Exists(testPath02))
            {
                FileStream test2 = File.Create(testPath02, sizeof(int) * 100, FileOptions.Encrypted);
                test2.Flush();
            }
        }
    }
}
