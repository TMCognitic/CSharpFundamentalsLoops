using System;

namespace CSharpFundamentalsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice 1
            {
                //int premier = 1;
                //int second = 1;

                //Console.WriteLine(premier);
                //Console.WriteLine(second);

                //for (int i = 0; i < 23; i++)
                //{
                //    int addition = premier + second;
                //    Console.WriteLine(addition);
                //    premier = second;
                //    second = addition;
                //}
            }
            #endregion

            #region Exercice 2
            {
                int i;
                do
                {
                    Console.Write("Donner un entier positif > 0 : ");
                }
                while (!int.TryParse(Console.ReadLine(), out i) || i < 0);

                int result = i;

                while (i > 1)
                {
                    result *= --i;
                }

                Console.WriteLine(result);
            }
            #endregion

            #region Exercice 3
            {
                //int count;
                //do
                //{
                //    Console.Write("Combien de nombre premier voulez-vous ? : ");
                //}
                //while (!int.TryParse(Console.ReadLine(), out count) && count > 0);

                //int loopCount = 0;
                //for (int i = 0, nombre = 2; i < count; nombre++)
                //{
                //    bool isPrime = true;
                //    int racine = (int)Math.Sqrt(nombre);

                //    for (int diviseur = 2; diviseur <= racine && isPrime; diviseur++, loopCount++)
                //    {
                //        if (nombre % diviseur == 0)
                //            isPrime = false;
                //    }

                //    if(isPrime)
                //    {
                //        Console.WriteLine(nombre);
                //        i++;
                //    }
                //}

                //Console.WriteLine($"nombre de boucles : {loopCount}");
            }
            #endregion

            #region Exercice 4
            {
                //const int maxFacteur = 20, maxTable = 5;

                //for (int facteur = 1; facteur < maxFacteur + 1; facteur++)
                //{
                //    for (int table = 1; table < maxTable + 1; table++)
                //    {
                //        Console.Write($"{table:D2} * {facteur:D2} = {table * facteur:D2}   ");
                //    }
                //    Console.WriteLine();
                //}
            }
            #endregion

            #region Exercice 5
            {
                //for (decimal temperature = 0; temperature < 20; temperature = temperature + 0.1M)
                //{
                //    Console.WriteLine($"{temperature}");
                //}
            }
            #endregion

            #region Exercice 6 Méthode de Newton
            {
                //decimal error = decimal.Zero;
                //decimal nombre = 255_698_763.2556M;

                //decimal Xn = nombre;
                //decimal RC = nombre;
                //decimal pas = nombre;

                //while (pas > error)
                //{
                //    RC = 0.5M * (RC + (nombre / RC));
                //    pas = (Xn - RC) / Xn;
                //    Xn = RC;

                //    Console.WriteLine($"pas={pas} Racine={RC}");
                //}

                //Console.WriteLine($"la racine carrée de {nombre} est : {RC}");
            }
            #endregion
        }
    }
}
