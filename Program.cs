using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Iterator_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            IterableCollection<string> X = new IterableCollection<string>();

            for (int i = 0; i < 10; i++)
            {
                X[i] = $"i = {i + 1}";
            }

            var iter = X.CreateIterator();

            while(!iter.IsDone())
            {
                Console.WriteLine(iter.CurrentItem());
                iter.Next();
            }
            
        }
    }
}
