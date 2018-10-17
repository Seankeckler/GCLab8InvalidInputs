using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab8UserRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] names = { "Katie" , "Andrew", "Chuck", "Jon", "Tommy", "Jeremy" , "Joseph" , "Kelsey" , "Justin", "Sean" };
            string[] homeTown = { "Grand Rapids","Grand Haven", "Ripon", "Alger", "Raleigh,NC", "Milwaukee", "Grand Rapids", "Grand Rapids", "Wyoming", "Grand Rapids"};
            string[] faveFood = {"Indian Cuisine", "Chicken Wings", "Almonds", "Tres Leche", "Buttered Chicken", "Peanut Butter", "Burritos", "Grits", "Burgers", "BBQ" };

            List<string> Names = new List<string>(names);
            List<string> HomeTown = new List<string>(homeTown);
            List<string> FaveFood = new List<string>(faveFood);

            Console.WriteLine("Do you want to see information on a student or add a new student?");
            Console.Write("see or add: ");
            string seeOrAdd = Console.ReadLine();
            string SeeOrAdd = seeOrAdd.ToLower();
            
            
            if (SeeOrAdd == "see")
            {

               int index = SeeStudentNumber(Names);
                HometownOrFavefood(HomeTown, FaveFood, index);
                

            }
            else if (seeOrAdd == "add")
            {
                Console.WriteLine("You will need to enter a name, a hometown, and then a favorite food.");
            }
            else
            {
                Console.WriteLine("Please enter either see or add");
            }
            
            Console.ReadKey();
        }

        public static int SeeStudentNumber(List<string> theirnames) 
        {
            Console.WriteLine("Which student would you like to know more about?");
            Console.Write("1 to 10: ");
            int seeNumber = int.Parse(Console.ReadLine());

            if (seeNumber <= 10 && seeNumber >= 1)
            {
                Console.WriteLine("You Chose " + theirnames[seeNumber - 1]);
                Console.WriteLine("\n Do you want to know " + theirnames[seeNumber - 1] + "'s Hometown or Favorite food? ");
                
            }
            else
            {
                Console.WriteLine("That is not a valid option.");
                SeeStudentNumber(theirnames);
            }
            return seeNumber;

        }

        public static void HometownOrFavefood(List<string> HT, List<string> FF, int IndexOf )
        {
            string HomeOrFood;
            Console.Write("HT or FF: ");
            HomeOrFood = Console.ReadLine().ToUpper();
            if (HomeOrFood == "HT")
            {
                Console.WriteLine("Hometown is " + HT[IndexOf -1]);
            }
            else if (HomeOrFood == "FF")
            {
                Console.WriteLine("Favorite Food is " + FF[IndexOf -1]);
            }
            else
            {
                Console.WriteLine("That is not a valid option");
                HometownOrFavefood(HT, FF, IndexOf);
            }
        }
    }
    

        
    
    
}