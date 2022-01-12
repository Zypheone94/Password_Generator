using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int AskPositivNumber(string question)
        {
            return AskIntervalNumber(question, 1, int.MaxValue, "Erreur : La valeur ne peux être négative ou nulle");
        }

        public static int AskIntervalNumber(string question, int min, int max, string errorMessage = null)
        {
            int passwordLength = AskNumber(question);
            while (true)
            {
                if (passwordLength >= min && passwordLength <= max) { return passwordLength; }

                if (errorMessage == null) 
                {
                    passwordLength = AskNumber($"Incorrect, la valeur doit être contenu entre : {min} et {max}\n");
                }

                else { Console.WriteLine(errorMessage); }

                return AskIntervalNumber(question, min, max);
            }
        }
        public static int AskNumber(string question)
        {
            int passwordNumber;
            while (true)
            {
                Console.Write(question);
                string numberString = Console.ReadLine();
                try
                {
                    passwordNumber = int.Parse(numberString);
                    return passwordNumber;
                }
                catch
                {
                    Console.WriteLine("Erreur : Veuillez rentrer une valeur valide\n");
                }
            }
        }
    }
}
