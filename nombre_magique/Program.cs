using System;

namespace nombre_magique
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NBMIN = 1;
            const int NBMAX = 10;


            NombreMagique(NBMIN, NBMAX);
        }

        static int DemanderNombre()
        {

            int reponseUtilNum;
            const int NBMIN = 1;
            const int NBMAX = 10;

            Console.Write($"Entrez un nombre compris entre {NBMIN} et {NBMAX} :");
            string reponseUtilisateur = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(reponseUtilisateur, out reponseUtilNum))
                {
                    if (reponseUtilNum == 0)
                    {
                        Console.WriteLine("Erreur, vous ne pouvez pas proposer le chiffre 0");
                        Console.Write("Recommencez:");
                        reponseUtilisateur = Console.ReadLine();
                    }
                    else if (reponseUtilNum < NBMIN || reponseUtilNum > NBMAX)
                    {
                        Console.WriteLine($"Vous devez entrer un nombre compris entre {NBMIN} et {NBMAX}");
                        Console.Write("Recommencez:");
                        reponseUtilisateur = Console.ReadLine();
                    }
                    else
                    {
                        return reponseUtilNum;
                    }


                }
                else
                {
                    Console.WriteLine("Vous devez entrer un nombre");
                    Console.Write("Recommencez:");
                    reponseUtilisateur = Console.ReadLine();
                }
            }

        }

        static void NombreMagique(int NBMIN, int NBMAX)
        {
            Random rand = new Random();
            int NBMAGIQUE =rand.Next(1, 11);
            int nombre = NBMAGIQUE+1;

            while (nombre != NBMAGIQUE)
            {
                nombre = DemanderNombre();
                if (nombre > NBMAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else
                {   
                    Console.WriteLine("Le nombre magique est plus grand ");
                }
            }
            Console.WriteLine("Bravo, vous avez trouvé le nombre magique !");          

        }
    }
}
