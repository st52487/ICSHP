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
                //FileStream test2 = File.Create(testPath02, sizeof(int) * 100, FileOptions.Encrypted);
                //test2.Flush();
                using (StreamWriter sw = File.CreateText(testPath02))
                {
                    sw.Write("test text");
                }
            }
            FileInfo fileInfoTest1 = new FileInfo(testPath01);
            if (fileInfoTest1.Exists)
            {
                var sw = fileInfoTest1.Create();
                sw.Close();
            }

            DriveInfo di = new DriveInfo("C");
            var freeSpace = di.TotalFreeSpace;
            
            
        }
    }
}
