using System;

namespace Les5MethodScopes
{
    class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
               
                string scope8Var = "8";

                string scope12Var = "N/A";

                if (true)
                {
                   
                    scope12Var = "12";
                }

                string scope17Var = "N/A";

                if (false)
                {
                     
                    scope17Var = "17";
                }

                Console.WriteLine("This was set in scope line 8: " + scope8Var);
                Console.WriteLine("This was set in scope line 12: " + scope12Var);
                Console.WriteLine("This was set in scope line 17: " + scope17Var);
            }
        }
    }
}

   