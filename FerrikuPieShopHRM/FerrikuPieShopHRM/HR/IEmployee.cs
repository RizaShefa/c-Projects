using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal interface IEmployee
    {
        double ReceiveWage(bool resetHours = true);
        void GiveBonus();  
        void DisplayEmployeeDetails();
        void PerformWork();
        void PerformWork(int numberOfHours);
        //int CalculateBonus(int bonus);
        //int CalculateBonusAndBonusTax(int bonus, ref int taxBonus);
        void GiveComplimentation();
    }
}
