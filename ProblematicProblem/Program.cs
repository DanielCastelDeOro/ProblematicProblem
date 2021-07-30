using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Runtime;


namespace ProblematicProblem
{
    class program
    {
        
        static void Main(string[] args)
        {
            Random rng = new Random();

            bool cont = true;
            var activities = new List<string>() { "Movies,", "Paintball,", "Bowling,", "Lazer Tag,", "LAN Party,", "Hiking,", "Axe Throwing,", "Wine Tasting," };

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //cont = bool.(Console.ReadLine());
            var anwser = Console.ReadLine().ToLower();
            if (anwser == "yes")
            {
                Console.WriteLine("We are going to need your information first! What is your name?");
                
            }
            else
            {
                return;
            }
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();

            Console.Write($"Awesome {userName}! What is your age? ");
           
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? yes/no: ");
            var seeList = Console.ReadLine().ToLower();
           

            if (seeList == "yes")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                var addToList = Console.ReadLine().ToLower();
                
                if (addToList == "yes")
                {

                  
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        Console.WriteLine("great");//just to see where i am
                        activities.Add(userAddition);

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                   

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    var addToListMore = Console.ReadLine().ToLower();
                    if (addToListMore == "yes")
                    {
                        Console.WriteLine("What would you like to add?");
                        string userAddition2 = Console.ReadLine();
                        activities.Add(userAddition2);
                        Console.WriteLine("great");
                       
                    }
                   
                }
            }
            else
            {
                return;
            }
            
            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                
                int randomNumber = rng.Next(activities.Count); 

                string randomActivity = activities[randomNumber]; 

                if (userAge < 21 && randomActivity == "Wine Tasting") 
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                   
                    activities.Remove(randomActivity);
                    
                    int randomNumber2 = rng.Next(activities.Count);

                   
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                var answer3 = Console.ReadLine().ToLower();
                if (answer3 == "redo") // left off here....
                {
                    Console.Write("Connecting to the database");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();

                    Console.Write("Choosing your random activity");

                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();

                    int randomNumberRedo = rng.Next(activities.Count);

                    string randomActivityRedo = activities[randomNumberRedo];
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivityRedo}! Thank you for playing!!");


                   
                }
                else
                {
                    return;
                }
                Console.WriteLine();
                cont = bool.Parse(Console.ReadLine());
            }
        }
    }
}
