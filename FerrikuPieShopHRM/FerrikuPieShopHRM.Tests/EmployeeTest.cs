using FerrikuPieShopHRM.HR;

namespace FerrikuPieShopHRM.Tests
{
    public class EmployeeTest
    {
        [Fact]
        public void PerformWork_Adds_The_Default_Value()
        {
            Employee mondi = new Employee("Ferriku", "Smith", "ferriku@gmail.com", 
                new DateTime(1975, 2, 16), 100, "Loni Dhamo", "Numri 1 ", "9001", "Lushnje");
            mondi.PerformWork();
            Assert.Equal(1 , mondi.NumberOfHoursWorked);
        }
        [Fact]
        public void PerformWork_Adds_The_NumberOfHoursWorked_Value_Form_Parameter()
        {
            Employee mondi = new Employee("Ferriku", "Smith", "ferriku@gmail.com",
                new DateTime(1975, 2, 16), 100, "Loni Dhamo", "Numri 1 ", "9001", "Lushnje");
            int numberOfHoursWorked = 5;
            mondi.PerformWork(numberOfHoursWorked);

            Assert.Equal(numberOfHoursWorked, mondi.NumberOfHoursWorked);
        }
        [Fact]
        public void CalculateBonus_If_numberOfHoursWorked_Are_Equal_To_Bonus()
        {
            Employee mondi = new Employee("Ferriku", "Smith", "ferriku@gmail.com",
                new DateTime(1975, 2, 16), 100, "Loni Dhamo", "Numri 1 ", "9001", "Lushnje");
            int numberOfHoursWorked = 5;
            int bonus = 30;
            mondi.CalculateBonus(bonus);

            Assert.Equal(bonus, mondi.CalculateBonus(bonus));
        }


        [Fact]
        public void CalculateBonus_If_numberOfHoursWorked_Are_Greater_Than_20_Double_It()
        {
            Employee mondi = new Employee("Ferriku", "Smith", "ferriku@gmail.com",
                new DateTime(1975, 2, 16), 100, "Loni Dhamo", "Numri 1 ", "9001", "Lushnje");

            int numberOfHoursWorked = 21;
            int bonus = 30;
            if (numberOfHoursWorked >20)
            {
                bonus *= 2;
            }
            mondi.CalculateBonus(bonus);


            Assert.Equal(bonus, mondi.CalculateBonus(bonus)) ;
        }

        [Fact]
       public void Number_Of_Two()
        {
            Employee mondi = new Employee("Ferriku", "Smith", "ferriku@gmail.com",
                new DateTime(1975, 2, 16), 100, "Loni Dhamo", "Numri 1 ", "9001", "Lushnje");

            int number = 1;
            mondi.NumberOf2(number);
            Assert.Equal(2, mondi.NumberOf2(number));
        }





        
    }
}