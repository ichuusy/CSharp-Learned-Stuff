using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    public delegate void Emilia();
    internal class Program
    {

        static void Main(string[] args)
        {
            Rem rem = new Rem();
            rem.Checker();
            Console.ReadLine();
        }
    }

    class Rem 
    {

        public Rem() 
        {
            Ram += Think;
            Ram += Speak;
            Ram += Idle;
        }
        private Emilia _ram;
        
        public event Emilia Ram
        {
            add
            {
                Log($"{value.Method.Name} added");
                _ram += value;
            }
            remove
            {
                Log($"{value} removed");
                _ram -= value;
            }
        }

        void Log(string text) 
        {
            Console.WriteLine(text);
        }

        void Think() 
        {
            Console.WriteLine("Think");
        }
        
        void Speak() 
        {
            Console.WriteLine("Speak");
        }

        void Idle() 
        {
            Console.WriteLine("Idle");
        }

        public void Checker() 
        {
            if(_ram != null) 
            {
                Console.WriteLine("Checker");
                _ram();
            }
        }
    }
}
