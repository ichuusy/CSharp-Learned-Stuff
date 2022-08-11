using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    public abstract class Engineering : Human, IEngineering
    {
        public void CreateAny() => Console.WriteLine("You created a machine.");
        public void Destroy() => Console.WriteLine("Destroyed.");
        public void ThinkIdea() => Console.WriteLine("You find a idea.");
        public void Start() => Console.WriteLine("You started project.");
        public override void GetInformation() => Console.WriteLine($"Name : {name}\nAge : {age}\nGroup : Engineering group\nNationality ID : {nationalityID}");
    }
}
