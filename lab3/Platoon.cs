using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// Возможные звания командира взвода
    public enum Military_ranks_platoon
    {
        Sublieutenant,
        Lieutenant,
        Senior_lieutenant
    }

    /// Класс Взвод
    class Platoon
    {
        /// Наименование подразделения
        protected string _name;
        /// Воинское звание командира подразделения
        protected Military_ranks_platoon _military_rank_commander;
        /// ФИО командира подразделения
        protected string _full_name_commander;
        /// Призывники взводов
        protected List<Conscript> _conscripts;
        /// Конструктор 
        /// <param name="name">Наименование подразделения</param>
        /// <param name="military_rank_commander">Воинское звание командира взвода</param>
        /// <param name="full_name_commander">ФИО командира подразделения</param>
        /// <param name="conscripts">Список призывников</param>

        public Platoon(string name, Military_ranks_platoon military_rank_commander, string full_name_commander, List<Conscript> conscripts)
        {
            _name = name;
            _military_rank_commander = military_rank_commander;
            _full_name_commander = full_name_commander;
            _conscripts = conscripts;
        }

        /// Свойство для получения наименования поздразделения
        public string Name { get { return _name; } }
        /// Свойство для получения воинского звания командира взвода
        public Military_ranks_platoon Military_rank_commander { get { return _military_rank_commander; } }
        /// Свойство для получения ФИО командира взвода
        public string Full_name_commander { get { return _full_name_commander; } }
        /// Свойство для получения списка призывников
        public List<Conscript> Сonscripts { get { return _conscripts; } }
    }

}
