// ichuusy

using System;

namespace arraystackalloc
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            // Stackallock unmanaged type
            int * array = stackalloc int[5] { 1, 3, 12, 4, 1 };
            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(*(array+i));
            }
            
            // Managed type to unmanaged type
            int[] array1 = { 1, 3, 12, 4, 1 };
            fixed (int * ptr = & array1[0])
            {
                for (int i = 0; i < array1.Length; i ++)
                {
                    Console.WriteLine($"Address : {(uint)ptr+i:X} | Content : {*(ptr+i)} | Added 4 byte to content : {((uint)ptr+i)} | Index : {i}");
                }
            }
            
            // Mixed unmanaged type, stackalloc and fixed keyword, moved cPointer address to sPointer address. It will be dangerous don't execute this code...
            int[] nArray = { 5, 4, 124, 3, 1 };
            int * pArray = stackalloc int[5] { 5, 4, 124, 3, 1 };
            fixed (int * cPointer = &nArray[0])
            {
                Console.WriteLine((uint)cPointer);
                int * sPointer = & pArray[0];
                Console.WriteLine((uint)sPointer);
                * cPointer = * sPointer;
                Console.WriteLine((uint)cPointer);
            }

            // Stackalloc struct type test
            Github * test = stackalloc Github[1];
            test -> id = 120;
            test -> repo = 320;
            
            Console.WriteLine("test->id");
            Console.WriteLine(test->id);
            Console.WriteLine(test->repo);

            Github structPointer = new Github(30,120);
            Github * addressHolder = & structPointer;
            
            Console.WriteLine("addressHolder->id");
            Console.WriteLine(addressHolder->id);
            Console.WriteLine(addressHolder->repo);
            
            Console.WriteLine("(*addressHolder).id");
            Console.WriteLine((*addressHolder).repo);
            Console.WriteLine((*addressHolder).id);

        }
    }

    public struct Github
    {
        public int repo;
        public int id;

        public Github(int repo, int id)
        {
            this.repo = repo;
            this.id = id;
        }
    }
}
