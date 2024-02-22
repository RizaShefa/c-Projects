using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    internal struct WorkTask
    {
        public string description;
        public int hours;
        public void PerformWorkask()
        {
            Console.WriteLine($"Tast {description} of {hours} hours(s) has benn performed");
        }
    }
}
