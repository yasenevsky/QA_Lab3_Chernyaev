using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    /// Возможные звания призывника
    enum Military_ranks_conscript
    {
        Private,
        Corporal,
        Lance_sergeant,
        Sergeant,
        Staff_sergeant
    }

    /// Возможные должности призывника
    enum Military_position_conscript
    {
        First_sergeant,
        Second_sergeant,
        Rifleman,
        Grenade_launcher,
        Driver
    }

    /// Класс Призывник
    class Conscript
    {
        /// Должность призывника
        protected Military_position_conscript _military_position_conscript;
        /// Воинское звание призывника
        protected Military_ranks_conscript _military_rank_conscript;
        /// ФИО призывника
        protected string _full_name_conscript;

        /// Конструктор 
        /// <param name="military_position_conscript">Должность призывника</param>
        /// <param name="military_rank_conscript">Воинское звание призывника взвода</param>
        /// <param name="full_name_conscript">ФИО призывника</param>

        public Conscript(Military_position_conscript military_position_conscript, Military_ranks_conscript military_rank_conscript, string full_name_conscript)
        {
            _military_position_conscript = military_position_conscript;
            _military_rank_conscript = military_rank_conscript;
            _full_name_conscript = full_name_conscript;
        }

        /// Свойство для получения должности призывника
        public Military_position_conscript Military_position_conscript { get { return _military_position_conscript; } }
        /// Свойство для получения воинского звания призывника
        public Military_ranks_conscript Military_rank_conscript { get { return _military_rank_conscript; } }
        /// Свойство для получения ФИО призывника
        public string Full_name_conscript { get { return _full_name_conscript; } }
    }

}
