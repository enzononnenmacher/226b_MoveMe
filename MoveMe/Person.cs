using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Person : IPerson
    {
        #region private attributs
        private bool _isSleeping;

        public bool IsSleeping { get => _isSleeping; }
        #endregion

        #region public methods
        /// <summary>
        /// Cette méthode affiche un texte 
        /// </summary>
        /// <returns>Je bois</returns>
        public string Drink()
        {
            return "Je bois";
        }

        /// <summary>
        /// Cette méthode affiche un texte 
        /// </summary>
        /// <returns>Je mange</returns>
        public virtual string Eat()
        {
            return "Je mange";
        }

        /// <summary>
        /// Cette méthode affiche un texte 
        /// </summary>
        /// <returns>Je dors</returns>
        public virtual string Sleep()
        {
            return "Je dors";
        }
        #endregion
    }
}
