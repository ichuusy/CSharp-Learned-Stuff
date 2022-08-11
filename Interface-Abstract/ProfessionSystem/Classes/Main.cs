using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawEnforcement police = new Police("Hori", 16, 31);
            police.ArrestPerson("Marci");
            police.KillPerson("capri-sun");
            police.JoinMission("Codename 47");
            police.QuitWork();
            Console.WriteLine();
            LawEnforcement soldier = new Soldier("ichuusy", 16, 31);
            soldier.ArrestPerson("Pykatone");
            soldier.KillPerson("Pykatone");
            soldier.GetJobInfo();
            soldier.GetInformation();
            soldier.ChangeJob("Engineering");
            soldier.JoinMission("Create a walking plane");
            Console.WriteLine();
            Engineering computerEngineer = new ComputerEngineering("ichuusy",16,31);
            computerEngineer.ThinkIdea();
            computerEngineer.Start();
            computerEngineer.QuitWork();
            Console.WriteLine();
            Engineering civilEngineer = new CivilEngineering("awesome", 18, 31);
            civilEngineer.CreateAny();
            civilEngineer.Destroy();
            Console.WriteLine();
            Architect architect = new Architect("thorocket", 16, 31);
            architect.FindBuilder();
            architect.DrawBuildPlan();
            architect.FindHost();
            architect.ChangeJob("Computer Engineering");
            Console.WriteLine();
            Builder builder = new Builder("yasinldev", 15, 31);
            builder.BuildApartment(3);
            builder.DestroyApartment();
            Console.ReadKey();
        }
    }
}