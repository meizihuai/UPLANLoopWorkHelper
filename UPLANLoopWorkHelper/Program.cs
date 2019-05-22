using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLANLoopWorkHelper
{
    class Program
    {
        public static readonly string title = "UPLAN LoopWorkHelper V 1.0.0";
        static void Main(string[] args)
        {
            Console.Title = title;
            Run();
            Console.ReadLine();
        }
       public static void Log(string str,string TAG="")
        {
          
            if (!string.IsNullOrEmpty(TAG))
            {
                str = DateTime.Now.ToString("[HH:mm:ss] ") +$"<{TAG}>"+ str;
            }
            else
            {
                str = DateTime.Now.ToString("[HH:mm:ss] ") + str;
            }
            Console.WriteLine(str);
        }
        static void Run()
        {
            Log("初始化...");
            LoopWorker.Start();
        }
    }
}
