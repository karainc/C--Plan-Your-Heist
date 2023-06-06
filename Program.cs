// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Heist
{
    public class GetMoney
    {
        //Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. 
        public class Criminal
        {

        public string? Name {get; set;}
        //SkillLevel is a positive integer
        public int SkillLevel {get; set;}
        //Courage Factor is double between 0.0 and 2.0
        public double CourageFactor {get; set;}
    }
    static void Main(string[] args)
    {
        //Prints "Plan Your Heist!
        Console.WriteLine("Plan Your Heist!");
      
        //Store several criminals
        List<Criminal> criminals = new List<Criminal>();

        //Store bank's difficulty level*Phase 3*
          Console.WriteLine("Enter bank's difficulty level(0-100): ");

          int bankDifficulty = int.Parse(Console.ReadLine());

        Console.WriteLine("Let's put together some criminal masterminds!");

        while (true)
        //Promt user to enter a criminal's name-then save
        {
            Console.WriteLine("Please enter criminal's name:");
            string name = Console.ReadLine();

            //When blank name is entered-STOP
            if (name == ""){
            break;
             }

        //Prompt user to enter Skill Level and save to contact
        Console.WriteLine("Please enter criminal's skill level:");
        string skillLevel = Console.ReadLine();

        //Prompt user to enter Courage Level and save to contact
        Console.WriteLine("Please enter courage factor (between 0-2):");
        string courageFactor = Console.ReadLine();

        //Display Criminals Information
        Console.WriteLine($"{name}, Skill Level: {skillLevel}, Courage Factor: {courageFactor}.");

//Stores all Criminals Info
        Criminal newCriminal = new Criminal
        {
            Name = name,
            SkillLevel = int.Parse(skillLevel),
            CourageFactor = int.Parse(courageFactor)
        };

    //Collect Multiple Criminals Info
    criminals.Add(newCriminal);


    //Display message with the number of criminals
    Console.WriteLine($"{newCriminal.Name} has joined the Heist Criminal Mastermind Team. You now have {criminals.Count} members.");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
  }
    int criminalsSkillLevel = criminals.Sum(x => x.SkillLevel);
    Console.WriteLine("How many trial attempts?");

    int trials = int.Parse(Console.ReadLine());

    for(int i = 0; i < trials; i++){


    //Display each criminal's information
       //*Phase 3-Stop displaying each criminals info-
    // foreach (var criminal in criminals)
    //     Console.WriteLine($"{criminal.Name}, Skill Level: {criminal.SkillLevel}, Courage Factor: {criminal.CourageFactor}");
     int[] criminalsSkillLevels = {};

            // Calculate the sum of the criminal's skill levels
            foreach (int criminalSkillLevel in criminalsSkillLevels)
            {
                criminalsSkillLevel += criminalSkillLevel;
            }

            // Generate a random luck value between -10 and 10
            int randomLuckValue = new Random().Next(-10, 10);
            // Add luck value to the bank's difficulty
            int totalDifficulty = bankDifficulty + randomLuckValue;

      
            // Display the criminal's combined skill level
            Console.WriteLine($"Criminal team mastermind's combined skill level is {criminalsSkillLevel}");

            // Display the bank's difficulty level
            Console.WriteLine("Bank's difficulty level: " + totalDifficulty);

            // Compare the criminal's skill level with the updated bank's difficulty
            if (criminalsSkillLevel >= totalDifficulty)
            {
                Console.WriteLine("Success! The criminal's skill level is greater than or equal to the updated bank's difficulty level.");
            }
            else
            {
                Console.WriteLine("Failure! The criminal's skill level is lower than the updated bank's difficulty level.");
            }
    }

     

     }
    }
}
    
