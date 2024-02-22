using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FerrikuPieShopHRM.HR
{
    public  class Employee :IEmployee    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyRated;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;
        private static double taxRate =0.15;

        private Address address;

        public string FirstName
        {
            get {
                return firstName;
            }
            set { 
                firstName = value;
            } 
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            protected set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
           private set
            {
                wage = value;
            }
        }
        public double? HourlyRated
        {
            get { return hourlyRated; }

            set {
                    if (hourlyRated<0)
                    {
                        hourlyRated = 0;
                    }
                    else
                    {
                        hourlyRated = value;
                    }
                }
        }
        public DateTime BirthDay
        {
            get => birthDay;
            set => birthDay = value;
        }
        public Address Address
        {
            get { return address;}
            set { address = value; } 
        }
       
       
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRated)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRated = hourlyRated ?? 10;
        }
        public Employee(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRated,
           string street, string houseNumber, string zipCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRated = hourlyRated ?? 10;
            Address = new Address(street, houseNumber, zipCode, city);
            
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"The {FirstName}{LastName} received a generic bonuas of 100");
        }
        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
            //numberOfHoursWorked++;
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHoursWorked} hours(s)!");

        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 20)
            {
                bonus *= 2;
            }
            Console.WriteLine($"You got the bonus: {bonus}");
            return bonus;

        }
        public int CalculateBonusAndBonusTax(int bonus, ref int taxBonus)
        {
            if (NumberOfHoursWorked > 20)
                bonus *= 2;

            if (bonus >= 200)
            {
                taxBonus = bonus / 10;
                bonus -= taxBonus;

            }
            Console.WriteLine($"We have got the bonus:{bonus} and the tax on te bonus is {taxBonus}");
            return bonus;
        }
        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRated.Value;
            double taxAmount = wageBeforeTax * taxRate;
            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has recived a wage of {Wage} for {NumberOfHoursWorked} number of works.");


                wageBeforeTax = NumberOfHoursWorked * HourlyRated.Value;

            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }

            return Wage;
        }

       public int NumberOf2(int number)
        {
            return number * 2;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName} \nLast name: \t{LastName}  \nEmail: \t\t{Email} \nBirthday:" +
                $" \t{BirthDay.ToShortDateString()}\nTax Rate: \t{taxRate} ");
        }

        public void GiveComplimentation()
        {
            Console.WriteLine($"You have done a great job {FirstName}");
        }
       

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

     

    }
 

}





