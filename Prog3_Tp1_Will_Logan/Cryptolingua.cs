using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    internal class Cryptolingua : Creature, IParlable
    {
        public Cryptolingua(int position_X, int position_Y) : base(3, position_X, position_Y, "Cryptolingua")
        {
            
        }

        public void Parler(string message) // // complexité de la fonction = O(n) , car la méthode contient une boucle foreach sur la longueur du message et celui-ci peut être illimité, mais nous avons un indexof dans la boucle mais elle ne peut pas dépasser 26 donc c'est une constante.
        {
            Console.WriteLine("Message codé : " + EncrypterMessage(message));

        }

        static string EncrypterMessage(string message)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string cipher = "cjdgoyhktvxfzelquapwmbsnri";

            string result = "";

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    result += cipher[index];
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
