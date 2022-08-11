using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    public abstract class Human
    {
        public string name;
        public int age;
        public int nationalityID;

        public void ChangeJob(string jobName) => Console.WriteLine($"Profession changed. New profession : {jobName}");
        public void QuitWork() => Console.WriteLine("You quitted job.");
        public virtual void GetInformation() => Console.WriteLine($"Name : {name}\nAge : {age}\nJob: None\nNationality ID : {nationalityID}");
        public abstract void GetJobInfo();
    }
}
