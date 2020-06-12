using System;

namespace DojoDachi.Models
{
    public  class Dojodachi
    {
        private static Random rand = new Random();
        public int Happiness { get; set; } = 20;
        public int Fullness { get; set; } = 20;
        public int Energy { get; set; } = 50;
        public int Meals { get; set; } = 3;
        public string Message { get; set; } = "Click a button to perform an activity!";
        public  string Photo { get; set; } = @"~/img/pikachu.jpeg";
        
        public void Feed()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"{Meals} | {Fullness}");
            Meals -= 1;
            if(rand.Next(1, 5) != 1)
            {
                Fullness += rand.Next(5, 11);
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"{Meals} | {Fullness}");
            /* Photo = @"/img/eat.jpeg"; */
        }
        public void Play()
        {
            Energy -= 5;
            if (rand.Next(1, 5) != 1)
            {
                Happiness += rand.Next(5, 11);
            }
            Photo = @"/img/play.jpeg";
        }
        public void Work()
        {
            Energy -= 5;
            Meals += rand.Next(1, 4);
            Photo = @"/img/work.jpeg";
        }
        public void Sleep()
        {
            Energy += 15;
            Fullness -= 5;
            Happiness -= 5;
            Photo = @"/img/sleep.jpeg";
        }
    }
}