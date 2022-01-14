using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMe
{
    public class RaceDriver : Driver
    {
        /// <summary>
        /// Ceci est le constructeur de la classe RaceDriver héritant de la classe Driver
        /// </summary>
        /// <param name="vehicle"></param>
        public RaceDriver(Vehicle vehicle) : base(vehicle)
        {

        }

        /// <summary>
        /// Cette méthode va faire appel à la méthode Eat de classe Person et lever une exception si le moteur est allumé
        /// </summary>
        /// <returns>Le string de la méthode Eat ou une exception</returns>
        public override string Eat()
        {
            if (base._vehicle.MotorState == true)
            {
                throw new ExceptionEat();
            }
            return base.Eat();
        }
    }

    public class ExceptionRaceDriver : Exception { };

    public class ExceptionEat : ExceptionRaceDriver { };
}
