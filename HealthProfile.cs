using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class HealthProfile
    {
        private string firstName;
        private string lastName;
        private char gender;
        private int month;
        private int day;
        private int year;
        private int heightInInches;
        private int weightInPounds;

        public HealthProfile() : this("Patrick", "Davis", 'M', 1, 7, 1982, 70, 482) { }


        public HealthProfile(string firstName, string lastName, char gender, int month, int day, int year, int heightInInches, int weightInPounds)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.month = month;
            this.day = day;
            this.year = year;
            this.heightInInches = heightInInches;
            this.weightInPounds = weightInPounds;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
        public int Year { get => year; set => year = value; }
        public int HeightInInches { get => heightInInches; set => heightInInches = value; }
        public int WeightInPounds { get => weightInPounds; set => weightInPounds = value; }

        
        public int GetAge()
        {
            return (2018 - year);
        }

        private int calcRate()
        {
            return (220 - GetAge());

        }
        public int MinRate()
        {
            return (calcRate() / 2);
        }

        public double MaxRate()
        {
            return (calcRate() * 0.85);
        }

        public string GetBmi()
        {
            int bmi = (int)((weightInPounds * 703) / (Math.Pow(heightInInches, 2)));
                        
            return ("Your BMI is " + bmi);



        }
        

       
    }
}
