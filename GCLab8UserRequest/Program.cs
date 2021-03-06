﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GCLab8UserRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {

                string[] names = { "Katie", "Andrew", "Chuck", "Jon", "Tommy", "Jeremy", "Joseph", "Kelsey", "Justin", "Sean" };
                string[] homeTown = { "Grand Rapids", "Grand Haven", "Ripon", "Alger", "Raleigh,NC", "Milwaukee", "Grand Rapids", "Grand Rapids", "Wyoming", "Grand Rapids" };
                string[] faveFood = { "Indian Cuisine", "Chicken Wings", "Almonds", "Tres Leche", "Buttered Chicken", "Peanut Butter", "Burritos", "Grits", "Burgers", "BBQ" };

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
                    Console.WriteLine("Please enter a name");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Please enter a HomeTown");
                    string newTown = Console.ReadLine();
                    Console.WriteLine("Please enter a favorite food");
                    string newFood = Console.ReadLine();
                    bool verified = AddaStudentVerify(newName, newTown, newFood);
                    if (verified == true)
                    {
                        Names.Add(newName);
                        HomeTown.Add(newTown);
                        FaveFood.Add(newFood);
                        foreach (var Name in Names)
                        {
                            Console.WriteLine("\n" + Name);
                        }
                        foreach (var Town in HomeTown)
                        {
                            Console.WriteLine("\n" + Town);
                        }
                        foreach (var Food in FaveFood)
                        {
                            Console.WriteLine("\n" + Food);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You did not enter name, town, or food correctly");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter either see or add");
                }
                Continue();
                
            }
        }

        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Do you want to pick another student? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry that is not an acceptable answer.");
                run = Continue();
            }
            return run;

        }

        public static bool AddaStudentVerify(string name, string town, string food)
        {
            Regex n = new Regex("^[a-zA-Z ]+$");
            if (n.IsMatch(name) && n.IsMatch(town) && n.IsMatch(food))
            {
                return true;
            }
            else
            {
                return false;
            }

            
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