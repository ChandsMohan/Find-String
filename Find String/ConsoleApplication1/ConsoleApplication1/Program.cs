using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] array = new string[][]
            {
            new string[]{"mohan", "Sachin" },
            new string[]{"B.tech","M.tech"}
            };
            string foundKey = Search(array, "Sachin");
            Console.WriteLine(string.Format("Found:{0} ", foundKey));
            Console.ReadKey();
        }
        static string Search(string[][] strdoublearr, string search)
        {
            string str = null;
            foreach (string[] stra in strdoublearr)
            {
                str = Array.Find(stra, eachElement => eachElement.Equals(search, StringComparison.CurrentCultureIgnoreCase));
                if (!string.IsNullOrEmpty(str))
                    break;
            }
            return str;
        }
    }
}
