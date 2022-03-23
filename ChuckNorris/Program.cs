using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = GetRandomJokeFromFile("chuck.txt");

            Console.WriteLine($"Here's a joke for you: {randomJoke}.");

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomJokeFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\OneDrive\Töölaud\Programmeerimise algkursus\Samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
