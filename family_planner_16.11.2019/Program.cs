using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace family_planner_16._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {

          
           FAMILY myFamily = new FAMILY();
           myFamily.AddMember();
            myFamily.PrintMembers();
        // myFamily.AddMember();
        //   myFamily.SearchMember();
         //   myFamily.SearchMember();

           //  myFamily.PrintMembers();
            // Console.ReadLine();
            // myFamily.SearchMember();

            //ADD list of activities

          //  ACTIVITTIES_LIST myActivitiesList = new ACTIVITTIES_LIST();

          //  myActivitiesList.AddPosition(); //chech date input, it can parse time to date.. tryparse to some format, and print to string.
            Console.ReadLine();
            
            // myActivitiesList.AddPosition();
           //  Console.ReadLine();
          //  myActivitiesList.PrintPositions();
            //Console.ReadLine();
          //  myActivitiesList.SearchPositionsByName();
            

             RESERVATIONS_LIST myReservationList = new RESERVATIONS_LIST();
            myReservationList.AddPosition();
           // Console.ReadLine();
            //   myReservationList.SearchPositionsByName();
            //  myReservationList.SearchPositionsByName();
              Console.ReadLine();
           // myReservationList.PrintPositions();



        }
    }
}
