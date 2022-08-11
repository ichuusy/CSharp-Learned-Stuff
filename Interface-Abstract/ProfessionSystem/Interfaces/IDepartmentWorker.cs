using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    internal interface IDepartmentWorker
    {
        void ArrestPerson(string name);
        void KillPerson(string name);
        void JoinMission(string missionName);
    }
}
