using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal class Researcher : Employee
    {
        private int numberOfPieTested = 0;
        public int NumberOfPieTested
        {
            get
            {
                return numberOfPieTested;
            }
            set { numberOfPieTested = value; }
        }
        public Researcher(string firstName, string lastName, string email, DateTime birthDay,
            double? hourlyRated) : base(firstName, lastName, email, birthDay, hourlyRated)
        {
        }
        public void ResearcherNewPieTastes(int researchHour)
        {
            NumberOfPieTested += researchHour;
            if (new Random().Next(100) > 50)
            {
                NumberOfPieTested++;
                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie " +
                    $"taste! Total number of pies invented: {NumberOfPieTested}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is still working on a new pie taste!");
            }
        }


        
    }
}
