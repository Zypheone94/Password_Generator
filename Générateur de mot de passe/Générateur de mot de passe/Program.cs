using System;
using FormationCS;

namespace Générateur_de_mot_de_passe
{
    class Program
    {
        

        static void Main(string[] args)
        {
            const int NB_PASSWORD = 10;

            int passwordLength = outils.AskPositivNumber("Longueur du mot de passe : ");
            Console.WriteLine("");

            int passwordType;

            passwordType = outils.AskIntervalNumber("Quel type de mot de passe voulez vous ?\n" +
                "\n" +
                "1 - Uniquement des caractères en minuscules \n" +
                "2 - Des caractères minuscules et majuscules \n" +
                "3 - Des caractères et des chiffres \n" +
                "4 - Caractères, chiffres et des caractères spéciaux\n" +
                "Votre choix : ", 1, 4);

            Console.WriteLine("");

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string numbers = "0123456789";
            string chara = "#!?+-@&()$";
            string alpha;

            if(passwordType == 1) { alpha = minuscule; }
            else if(passwordType == 2) { alpha = minuscule + majuscule; }
            else if(passwordType == 3) { alpha = minuscule + majuscule + numbers; }
            else { alpha = minuscule + majuscule + numbers + chara; }

            
            int alphaLength = alpha.Length;

            Random rand = new Random();

            for (int j = 0; j < NB_PASSWORD; j++)
            {
                string password = "";
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = rand.Next(1, alphaLength);
                    password += alpha[index];
                }
                Console.WriteLine($"password : {password}");
            }
            
        }
    }
}
