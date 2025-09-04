using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3_Tp1_Will_Logan
{
    public class Environement<T> where T : Organisme
    {
        private List<T> _environement;

        public Environement()
        {
            _environement = new List<T>();
        }

        
    }
}
