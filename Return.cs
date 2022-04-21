using System;


    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GetRandomNumber());
            }
        }

        private static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 21);
        }
    }