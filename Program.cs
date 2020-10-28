using System;

namespace MadLibStory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration

            string name;
            string adjective;
            string noun;
            string pastTenseVerb;
            string adverb;
            string adjectiveTwo;
            string nounTwo;
            string nounThree;
            string adjectiveThree;
            string verb;
            string adverbTwo;
            string pastTenseVerbTwo;
            string adjectiveFour;

            //MadLib Intro

            Console.WriteLine("Hi there! What is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"Hey {name}! Let's create a Mad Lib Story. Follow along with the console prompts to create a funny mad lib story! ");

            //User Input & Variable Inilization

  
            Console.WriteLine("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a past tense verb: ");
            pastTenseVerb = Console.ReadLine();

            Console.WriteLine("Enter an adverb ");
            adverb = Console.ReadLine();

            Console.WriteLine("Enter another adjective: ");
            adjectiveTwo = Console.ReadLine();

            Console.WriteLine("Enter another noun: ");
            nounTwo = Console.ReadLine();

            Console.WriteLine("Enter one last noun: ");
            nounThree = Console.ReadLine();

            Console.WriteLine("Enter another adjective: ");
            adjectiveThree = Console.ReadLine();

            Console.WriteLine("Enter a regular verb ");
            verb = Console.ReadLine();

            Console.WriteLine("Enter another adverb ");
            adverbTwo = Console.ReadLine();

            Console.WriteLine("Enter another past tense verb: ");
            pastTenseVerbTwo = Console.ReadLine();


            Console.WriteLine("Enter a final adjective and check out your new mad lib!: ");
            adjectiveFour = Console.ReadLine();

            //MadLibStory

            Console.WriteLine($"Today I went to the zoo. I saw a {adjective} {noun} jumping up and down in its tree. He {pastTenseVerb} {adverb} through the large tunnel that led to its {adjectiveTwo} {nounTwo}. I got some peanuts and passed them through the cage to a gigantic gray {nounThree} towering above my head. Feeding that animal made me hungry. I went to get a {adjectiveThree} scoop of ice cream. It filled my stomach. Afterwards, I had to {verb} {adverbTwo} to catch our bus. When I got home I {pastTenseVerbTwo} my mom for a {adjectiveFour} day at the zoo.");

            Console.ReadLine();
        }
    }
}
