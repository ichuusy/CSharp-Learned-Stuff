using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    public class Soldier : LawEnforcement
    {
        public Soldier(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Soldier");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");
            }
        }
        public override void GetJobInfo() => Console.WriteLine("I am a soldier.");
    }

    public class Police : LawEnforcement
    {
        public Police(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Police");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");
            }

        }
        public override void GetJobInfo() => Console.WriteLine("I am a police.");
    }
    public class ComputerEngineering : Engineering
    {
        public ComputerEngineering(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Computer Engineering");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");
            }
        }
        public override void GetJobInfo() => Console.WriteLine("I am a computer engineer.");
    }

    public class CivilEngineering : Engineering
    {
        public CivilEngineering(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Civil Engineering");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");

            }
        }
        public override void GetJobInfo() => Console.WriteLine("I am a civil engineer.");
    }

    public class Architect : Human, IArchitect
    {
        public Architect(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Architect");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");
            }

        }
        public void DrawBuildPlan() => Console.WriteLine("You drawed a building plan.");
        public void FindBuilder() => Console.WriteLine("You found a builder.");
        public void FindHost() => Console.WriteLine("You found a host.");
        public override void GetInformation() => Console.WriteLine($"Name : {name}\nAge : {age}\nJob : Architect\nNationality ID : {nationalityID}");
        public override void GetJobInfo() => Console.WriteLine("I am an architect.");
    }

    public class Builder : Human, IBuilder
    {
        public Builder(string name, int age, int nationalityID)
        {
            try
            {
                this.name = name;
                this.age = age;
                this.nationalityID = nationalityID;
                Console.WriteLine($"A person named {name} was created, her profession is a Builder");
            }
            catch
            {
                Console.WriteLine("Information is not correct.");
            }
        }
        public void BuildApartment(int floor) => Console.WriteLine($"You built a {floor} storey apartment.");
        public void DestroyApartment() => Console.WriteLine("You destroyed a apartment.");
        public override void GetInformation() => Console.WriteLine($"Name : {name}\nAge : {age}\nJob : Builder\nNationality ID : {nationalityID}");
        public override void GetJobInfo() => Console.WriteLine("I am a builder.");
    }
}
