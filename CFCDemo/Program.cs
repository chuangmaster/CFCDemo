using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.CurrentDirectory);
            KTStoreEntities model =new KTStoreEntities();
            int c = model.Products.Count();
            Console.WriteLine(c);
            Console.Read();
        }
    }
}
