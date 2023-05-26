using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Company Air_Assault_Company = 
                new("First Air Assault Company", Military_ranks_company.Major, "Lapin Ivan Vasilievich", new()
                {
                    new("First Airborne Platoon", Military_ranks_platoon.Lieutenant, "Frolov Maksim Alekseevich", new()
                    {
                       new(Military_position_conscript.First_sergeant, Military_ranks_conscript.Staff_sergeant, "Lyapunov Vladislav Maksimovich"),
                       new(Military_position_conscript.Driver, Military_ranks_conscript.Corporal, "Chernyaev Nikita Olegovich")
                    }),
                    new("Second Airborne Platoon", Military_ranks_platoon.Senior_lieutenant, "Vetrov Andrej Yakovlevich", new()
                    {
                        new(Military_position_conscript.Second_sergeant, Military_ranks_conscript.Sergeant, "Kachakov Vladislav Konstantinovich"),
                        new(Military_position_conscript.Rifleman, Military_ranks_conscript.Private, "Agapov Andrej Evgenjevich"),
                        new(Military_position_conscript.Grenade_launcher, Military_ranks_conscript.Lance_sergeant, "Shurenko Leonid Petrovich")
                    })
                });
            Air_Assault_Company.Display();
            Console.WriteLine($"Number of Сonscripts: { Air_Assault_Company.GetCountConscripts() }");
        }
    }
}
