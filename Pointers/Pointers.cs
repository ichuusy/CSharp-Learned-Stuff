using System;

namespace Pointers
{
    internal class Program
    {
        public static unsafe void Main(string[] args)
        {
            PointerStruct test = new PointerStruct(5,1.35f);
            PointerStruct* testP = &test;
            Console.WriteLine((*testP).y);
            Console.WriteLine(testP->x);

            int[] dizi = { 1, 2, 3, 4, 5, 1 };
            fixed (int* star = &dizi[0])
            {
                Console.WriteLine(((uint)star+1));
                Console.WriteLine((*star+1));
                for (int i = 0; i <= dizi.Length-1; i ++)
                {
                    Console.WriteLine($"Index : {i}, Address : {(uint)star+i:X}, Content : {*(star+i)}");
                }
            }
        }

        public struct PointerStruct
        {
            public int x;
            public float y;

            public PointerStruct(int x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
