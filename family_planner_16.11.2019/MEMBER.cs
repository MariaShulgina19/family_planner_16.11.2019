using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class MEMBER

    {
        public int _memberID { get; set; }
        public string _memberName { get; set; }

        public int _memberAge { get; set; }  // later age can be change to date of bith
        public bool _isitAdult { get; set ; }

        static int _amountOfmembers = 1;

        public MEMBER(string memberName)
        {
            _memberName = memberName;
            _memberID = _amountOfmembers;
            _amountOfmembers++;

        }    
    }
}
