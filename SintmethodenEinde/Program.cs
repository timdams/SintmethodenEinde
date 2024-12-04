namespace SintmethodenEinde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CadoMaker(15, "luc", Geslacht.Man));
            Console.WriteLine(CadoMaker(15, "polyna", Geslacht.Vrouw));
            Console.WriteLine(CadoMaker(5, "anna", Geslacht.Onbekend));
            Console.WriteLine(CadoMaker(5, "kevin", Geslacht.Man));

        }

        //Naam: CadeauMaker
        //IN: leeftijd (int), naam (string), geslacht (Geslacht)
        //UIT: cado (string)
        static string CadoMaker(int leeftijd, string naam, Geslacht geslacht)
        {
            bool isBraaf = IsBraaf(naam);
            int maxPrijs = BerekenMaxPrijs(leeftijd, isBraaf);
            string result = GenereerCado(geslacht, maxPrijs);
            return result;
        }

        enum Geslacht { Man, Vrouw, Onbekend }
        /*
         * IN: geslacht (Geslacht),prijsmax (int)
         * UIT: caso (string)
         * Naam: GenereerCado
         */

        static string GenereerCado(Geslacht geslacht, int maxPrijs)
        {
            string cado = "Gewone ";
            if (maxPrijs > 12)
            {
                cado = $"({maxPrijs}) Dure ";
            }

            switch (geslacht)
            {
                case Geslacht.Man:
                    cado += "boek";
                    break;
                case Geslacht.Vrouw:
                    cado += "bal";
                    break;
                case Geslacht.Onbekend:
                    cado += "auto'tje";
                    break;
                default:
                    cado += "waardebon";
                    break;
            }
            return cado;


        }


        /*
         * Naam: IsBraaf
         * IN: naam kind (string)
         * UIT: flink? (bool)
         * */

        static bool IsBraaf(string naam)
        {
            //Luc 
            if (naam == "luc" || naam == "jeanpiere")
            {
                return false;
            }
            return true;
        }

        /// IN: leeftijd (int), isbraaf (bool)
        /// UIT:maxprijs (int)
        /// naam: BerekenMaxPrijs

        static int BerekenMaxPrijs(int leeftijd = 6, bool isBraaf = true)
        {
            //leeftijd*2  => maxprijs
            // indien stout => maxprijs  2
            int prijs = leeftijd * 2;
            if (isBraaf)
            {
                return prijs;
            }
            return (prijs - 2);

            // return isBraaf? leeftijd*2 : leeftijd*2 - 2;

        }


    }
}
