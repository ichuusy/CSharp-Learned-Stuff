using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    public abstract class LawEnforcement : Human, IDepartmentWorker
    {
        public void ArrestPerson(string name) => Console.WriteLine($"{name} arrested by {this.name}");
        public void KillPerson(string name) => Console.WriteLine($"{name} killed by {this.name}");
        public void JoinMission(string missionName) => Console.WriteLine($"You joined {missionName} named mission");
        public override void GetInformation() => Console.WriteLine($"Name : {name}\nAge : {age}\nGroup : Law Enforcement group\nNationality ID : {nationalityID}");
        public abstract void GetJobInfo();
    }
}
