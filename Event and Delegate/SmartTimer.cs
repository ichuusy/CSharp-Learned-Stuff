using System;

namespace CsharpLearn
{
    public delegate void EventHandler();
    public partial class Timer
    {
        int timeCloud;
        int themeCloud;
        public Timer(int time, int theme) 
        {
            timeCloud = time;
            themeCloud = theme;
            addTimer += SetTimer;
            deleteTimer += DelTimer;
            addTheme += SetTheme;
            deleteTheme += DelTheme;
        }

        public event EventHandler addTimer;
        public event EventHandler addTheme;

        void SetTimer() 
        {
            Console.WriteLine($"Timer {timeCloud} is set");
        }

        void SetTheme() 
        {
            Console.WriteLine($"Theme {themeCloud} is set");
        }

        public void Apply() 
        {
            if(addTimer != null && addTheme != null) 
            {
                addTimer();
                addTheme();
            }
        }

    }

    public partial class Timer
    {

        public event EventHandler deleteTimer;
        public event EventHandler deleteTheme;
        void DelTimer()
        {
            Console.WriteLine($"Timer {timeCloud} is deleted");
        }

        void DelTheme()
        {
            Console.WriteLine($"Theme {themeCloud} is deleted");
        }

        public void Delete()
        {
            if (deleteTimer != null && deleteTheme != null)
            {
                deleteTimer();
                deleteTheme();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args) 
        {
            Timer timer = new Timer(15,2);
            timer.Apply();
            Console.WriteLine();
            timer.Delete();
            Console.ReadLine();
        }
    }
}
