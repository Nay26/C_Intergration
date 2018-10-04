using System;
using System.IO;

namespace Prestige.Biz
{
    class Program
    {
        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;
        static Program ()
        {
            ReadOnlyNumber = 5;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(ConstantNumber);
            Console.WriteLine(ReadOnlyNumber);
            Agency agency = null;
            Console.WriteLine(agency?.Name);
           
            using (FileStream fs1 = new FileStream(@"C:\clearn\Test.txt", FileMode.Open))
            {

            }
            using (FileStream fs2 = new FileStream(@"C:\clearn\Test.txt", FileMode.Open))
            {

            }
        }
    }
}
