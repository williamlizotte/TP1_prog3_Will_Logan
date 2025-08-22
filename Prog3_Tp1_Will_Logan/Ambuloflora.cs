using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
<<<<<<< HEAD
    internal class Ambuloflora : Plante, IBougeable
    {
        public int vitesse { get; set; }
        public Ambuloflora(int position_X, int position_Y, string nom, int vitesse) : base(position_X, position_Y, nom)
=======
    internal class Ambuloflora : Plante,IBougeable
    {
        public int vitesse { get; set; }
        public Ambuloflora(int position_X, int position_Y, string nom, int vitesse ) : base(position_X, position_Y, nom)
>>>>>>> 6e259a3f60a4351adcc5c80ca8a333e705dbee95
        {
            this.vitesse = vitesse;
        }

        void IBougeable.Bouger(Organisme o, int deplacement_X, int deplacement_Y)
        {
<<<<<<< HEAD
            if (deplacement_X % 3 != deplacement_X)
=======
            if(deplacement_X % 3 != deplacement_X)
>>>>>>> 6e259a3f60a4351adcc5c80ca8a333e705dbee95
            {
                o.position_X += deplacement_X - (deplacement_X % 3);
            }
            else
            {
                o.position_X += deplacement_X;
            }
            if (deplacement_Y % 3 != deplacement_Y)
            {
                o.position_Y += deplacement_Y - (deplacement_Y % 3);
            }
            else
            {
                o.position_Y += deplacement_Y;
            }

        }
    }
}
