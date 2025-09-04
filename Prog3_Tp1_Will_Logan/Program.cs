namespace Prog3_Tp1_Will_Logan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cryptolingua cryptolingua = new Cryptolingua( 1, 1);
            cryptolingua.Bouger(cryptolingua,2, 2);
            Console.WriteLine($"Position apres déplacement {cryptolingua.position_X},{cryptolingua.position_X}");

            // Utilisation de la méthode Parler pour envoyer un message
            Console.WriteLine("Écriver ce que le cryptolingua veut dire");
                string message = Console.ReadLine();
                Console.WriteLine("Message original : " + message);
                cryptolingua.Parler(message);

                // Attendre que l'utilisateur appuie sur une touche pour quitter
                Console.ReadKey();

            Verbaflora verbaflora = new Verbaflora(5, 5);
            Console.WriteLine("Écriver ce que le verbaflora veut dire");
            message = Console.ReadLine();
            Console.WriteLine("Message original : " + message);
            verbaflora.Parler(message);


            Ambuloflora ambuloflora = new Ambuloflora(10,10);


        }
    }
}



/*
 *  Exemple utilisation encryptage
 * 
 // Création d'un objet Cryptolingua
                Cryptolingua cryptolingua = new Cryptolingua(10, 0, 0, "Cryptobot");

                // Utilisation de la méthode Parler pour envoyer un message
                Console.WriteLine();
                string message = Console.ReadLine();
                Console.WriteLine("Message original : " + message);
                ((IParlable)cryptolingua).Parler(message);

                // Attendre que l'utilisateur appuie sur une touche pour quitter
                Console.ReadKey();
 */
