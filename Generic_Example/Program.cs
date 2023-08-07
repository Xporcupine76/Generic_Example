using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
namespace MyStruct
{

    class Peogram
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(2);

            Console.WriteLine("none generic list reults ...");
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }
        }
    }
}

