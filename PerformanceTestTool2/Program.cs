using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerformanceTestTool2
{
    class Program
    {
        //原子计数
        public static int Count;
        static void Main(string[] args)
        {
            Logger.Initialize(@"D:\temp-test", "log.txt");
            PerformanceTest.Initialize();
            //
            PerformanceTest.Time("Test_Set", 400, 1000, (Test_Set));
            Console.WriteLine("Test End");
            Logger.Close();
            Console.Read();
        }

        static void Test_Set()
        {
            //
        }

        static void Test_Get()
        {
            //
        }

        static void Example()
        {
            var current = Interlocked.Increment(ref Count);
            Logger.Info(current.ToString());
        }
    }
}
