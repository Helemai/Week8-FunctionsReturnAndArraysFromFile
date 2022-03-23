using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void  DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}.");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}.");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Titanic", "Blue lagoon", "Maze runner", "Spiderman" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovies = movies [randomIndex];
            Console.WriteLine($"Computer picked: {randomMovies}.");
        }




    }
}
