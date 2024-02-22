using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, string email, DateTime birthDay, 
            double? hourlyRated) : base(firstName, lastName, email, birthDay, hourlyRated)
        {
        }
    }
}
