using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    internal class Verbaflora : Plante, IParlable
    {
        public Verbaflora(int position_X, int position_Y) : base(position_X, position_Y, "Verbaflora")
        {

        }
    public void Parler(string message)
        {
            Console.WriteLine($"🌱�{message}�🌱");

        }
    }
}
