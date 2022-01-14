using System;

namespace MoveMe
{
    public class Vehicle : IVehicle
    {
        private bool _motorState = false;

        /// <summary>
        /// Ceci est le constructeur de la classe Vehicle
        /// </summary>
        /// <param name="motorState"></param>
        public Vehicle (bool motorState = false)
        {
            _motorState = motorState;
        }

        /// <summary>
        /// Cette méthode permet de définir que l'Etat du moteur soit activé
        /// </summary>
        public void MotorStart()
        {
            _motorState = true;
        }

        /// <summary>
        /// Cette méthode permet de définir que l'Etat du moteur soit desactivé
        /// </summary>
        public void MotorStop()
        {
            _motorState = false;
        }

        /// <summary>
        /// Cette méthode permet de retourner un get avec l'Etat du moteur
        /// </summary>
        public bool MotorState
        {
            get
            {
                return _motorState;
            }
        }
    }

    public class VehicleException : Exception { }

    public class MotorStartException : VehicleException { };
}
