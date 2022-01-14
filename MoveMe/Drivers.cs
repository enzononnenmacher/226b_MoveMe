using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class Driver : Person
    {
        #region private attributs
        private protected Vehicle _vehicle;
        #endregion

        #region public methods
        /// <summary>
        /// Ceci est le constructeur de la classe Driver héritant de la classe Person
        /// </summary>
        /// <param name="vehicle"></param>
        public Driver(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        /// <summary>
        /// Cette méthode va retourer un get de l'attribut privé _vehicle de type Vehicle
        /// </summary>
        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }
        }

        /// <summary>
        /// Cette méthode va faire appel à la méthode MotorStart de la classe Vehicle
        /// </summary>
        public void StartMotor()
        {
            _vehicle.MotorStart();
        }

        /// <summary>
        /// Cette méthode va faire appel à la méthode MotorStop de la classe Vehicle
        /// </summary>
        public void StopMotor()
        {
            _vehicle.MotorStop();
        }

        /// <summary>
        /// Cette méthode va faire appel à la méthode Sleep de classe Person et utiliser la méthode MotorStop si le moteur est allumé
        /// </summary>
        /// <returns>Le string de la méthode Sleep</returns>
        public override string Sleep()
        {
            if (_vehicle.MotorState == true)
            {
                _vehicle.MotorStop();
            }
            return base.Sleep();
        }

        #endregion
    }
}
