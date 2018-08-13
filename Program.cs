using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthProfile myProfile = new HealthProfile();
            Console.WriteLine("Name: {0}, {1}" +
            "\nGender: {2}" +
            "\nBMI: {3}" +
            "\nMaximum heart rate: {4}",
             myProfile.LastName, myProfile.FirstName, myProfile.Gender, myProfile.GetBmi(), myProfile.MaxRate());

        }
    }
}
