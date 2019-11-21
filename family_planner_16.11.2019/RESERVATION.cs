using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class RESERVATION : ACTIVITY
    {
        public string _reservationMemberName { get; set; }
        public string _reservationActivityName { get; set; }
        public int _reservationMemberID { get; set; } //19.11
        public int _reservationMemberAge { get; set; } //19.11
        public bool _reservationMemberIsitAdult { get; set; } //19.11



        public RESERVATION(string reservationtName) : base(reservationtName) //reservMemberName and reservActivityName can be added to constructor
        {

             
        }
    }
}
