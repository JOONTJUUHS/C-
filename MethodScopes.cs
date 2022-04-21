using System;

namespace method_scopes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                // Scope line 8: If Statement & Alles er buiten
                string scope8Var = "8";

                string scope12Var;

                if (true)//Deze regel mag niet worden veranderd
                {
                    // Scope line 12: If Statement & Alles er buiten
                    scope12Var = "12";
                }

                string scope17Var = "N/A";
                if (false)//Deze regel mag niet worden veranderd
                {
                    // Scope line 17: If Statement & Alles er buiten    
                    scope17Var = "17";
                }

                //Code hieronder moet hier blijven staan. en mag niet aangepast worden
                Console.WriteLine("This was set in scope line 8: " + scope8Var);
                Console.WriteLine("This was set in scope line 12: " + scope12Var);
                Console.WriteLine("This was set in scope line 17: " + scope17Var);
            }
        }
    }
}
