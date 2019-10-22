using System;

namespace indexers
{
    class Program
    {

        static void Main(string[] args)
        {
            IndexerCreation ic = new IndexerCreation();
            ic[0] = 1;
            ic[1] = 6;
            ic[2] = 33;
            ic[3] = 53;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Index: {i} - Value: {ic[i]}");
            }
        }
    }
}
