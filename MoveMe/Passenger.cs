using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Passenger : Person
    {
        private bool _seePaysage;

        /// <summary>
        /// Cette méthode affiche un texte
        /// </summary>
        /// <returns>Je profite du paysage</returns>
        public string SeePaysage()
        {
            return "Je profite du paysage";
        }
    }
}
