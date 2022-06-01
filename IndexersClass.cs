using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInDotNet
{
    class DemoIndexer
    {
        string[] names = new string[5];
        public string this[  int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
       


    }
    
    internal class IndexersClass
    {
        static void Main()
        {
            DemoIndexer indexer = new DemoIndexer();
            indexer[0] = "jhon";
            indexer[1] = "david";
            indexer[2] = "james";
            indexer[3] = "allan";
            indexer[4] = "scoot";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(indexer[i]);

            }


        }
    }
}
