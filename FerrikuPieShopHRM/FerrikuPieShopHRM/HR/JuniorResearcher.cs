using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRated) : base(firstName, lastName, email, birthDay, hourlyRated)
        {
        }
    }
}

