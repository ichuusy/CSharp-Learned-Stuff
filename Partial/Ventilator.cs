using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public partial class Ventilator
    {
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ventilator vantilator = new Ventilator();
            vantilator.Open();
            vantilator.Stop();
            vantilator.PowerOn();
            vantilator.PowerOff();
            Console.Read();
        }
    }
}
