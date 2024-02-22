using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDay, 
            double? hourlyRated) : base(firstName, lastName, email, birthDay, hourlyRated)
        {

        }
        public  void AttendMeeteing()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email ");
        }

        public override void GiveBonus()
        {
            if (NumberOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} receive management bonus of 500!");

            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} receive management bonus of 500!");
            }
        }

    }
}
