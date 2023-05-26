using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Sergeant : Conscript
    {
        /// Конструктор 
        /// <param name="military_position_conscript">Должность сержанта</param>
        /// <param name="military_rank_conscript">Воинское звание сержанта</param>
        /// <param name="full_name_conscript">ФИО сержанта</param>
        public Sergeant(Military_position_conscript military_position_conscript, 
            Military_ranks_conscript military_rank_conscript, string full_name_conscript) : 
            base(military_position_conscript, military_rank_conscript, full_name_conscript) { }

        public void Military_Ranks()
        {
            Console.WriteLine("This military man is a sergeant");
        }
    }
}
