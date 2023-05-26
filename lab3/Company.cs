using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// Возможные звания командира роты
    public enum Military_ranks_company
    {
        Senior_lieutenant,
        Captain,
        Major
    }
    /// Класс Рота
    class Company
    {
        /// Наименование подразделения
        protected string _name;
        /// Воинское звание командира подразделения
        protected Military_ranks_company _military_rank_commander;
        /// ФИО командира подразделения
        protected string _full_name_commander;
        /// Подчиненные взводы
        protected List<Platoon> _platoons;
        /// Конструктор 
        /// <param name="name">Наименование подразделения</param>
        /// <param name="military_rank_commander">Воинское звание командира подразделения</param>
        /// <param name="full_name_commander">Дата рождения</param>
        /// <param name="platoons">Список взводов</param>
        public Company(string name, Military_ranks_company military_rank_commander, string full_name_commander, List<Platoon> platoons)
        {
            _name = name;
            _military_rank_commander = military_rank_commander;
            _full_name_commander = full_name_commander;
            _platoons = platoons;
        }
        /// Отображает в консоли информацию о роте и её взводах
        public void Display()
        {
            Console.WriteLine($"Name Companys: {_name}");
            Console.WriteLine($"Commander: { _military_rank_commander} {_full_name_commander}");
            Console.WriteLine();
            Console.WriteLine($"Platoons:");
            foreach (Platoon platoon in _platoons)
            {
                Console.WriteLine($"Name Platoons: { platoon.Name}");
                Console.WriteLine($"Commander: { platoon.Military_rank_commander} {platoon.Full_name_commander}");
                Console.WriteLine();
                Console.WriteLine($"Conscripts:");
                foreach (Conscript conscript in platoon.Сonscripts)
                {
                    Console.WriteLine($"Military Position: { conscript.Military_position_conscript}");
                    Console.WriteLine($"Military Rank: { conscript.Military_rank_conscript}");
                    Console.WriteLine($"Name: { conscript.Full_name_conscript}");
                    Console.WriteLine();
                }
            }
        }

        /// Считает количество призывников во взводе
        public int GetCountConscripts()
        {
            int count_company = 0;
            int count_platoon = 0;
            foreach (Platoon platoon in _platoons)
            {
                foreach (Conscript conscript in platoon.Сonscripts)
                {
                    count_platoon = platoon.Сonscripts.Count;
                }
                count_company += count_platoon;
            }
            return count_company;
        }
    }
}
