using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class RESERVATIONS_LIST :ACTIVITTIES_LIST
    {
        private List<RESERVATION> ResevationList = new List<RESERVATION>();// family created as a list of members

        public RESERVATIONS_LIST()
        {
            
        }

        override public void AddPosition() // need to override to connect member and activity
        {
            Console.WriteLine("Give Reservation Name");//check if it exist in list
            string name = Console.ReadLine();
            RESERVATION k = new RESERVATION(name);

            //AddMembertoReservation()

            FAMILY myFamily = new FAMILY();

            myFamily.AddMember();
            myFamily.PrintMembers();//it is not printing list without adding new mwmbers from here

            Console.WriteLine("Give member name from reservation_list:");
            myFamily.SearchMembeAddToResevation(Console.ReadLine()); //in what list it is searching?
            Console.WriteLine(k._reservationActivityName);
            myFamily._memberNameFamily = k._reservationMemberName; //picking only name?
            myFamily._memberIDFamily = k._reservationMemberID;
            myFamily._memberAgeFamily = k._reservationMemberAge;
            myFamily._isitAdultFamily = k._reservationMemberIsitAdult;

            Console.ReadLine();
            //AddActivitytoReservation()



        }

        
        public void AddReservationtoList() 
        
        {

           // ResevationList.Add();this also does not work
        }
            
    }
}


