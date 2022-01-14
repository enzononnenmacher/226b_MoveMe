using NUnit.Framework;
using MoveMe;

namespace TestMoveMe
{
    public class TestMoveMe
    {

        [Test]
        public void Passenger_CanSeePaysage_Succes()
        {
            //given
            string exeptedSeePaysage = "Je profite du paysage";
            string actualSeePaysage;
            Passenger passenger = new Passenger();

            //when
            actualSeePaysage = passenger.SeePaysage();

            //then
            Assert.AreEqual(exeptedSeePaysage, actualSeePaysage);
        }

        [Test]
        public void Person_CanDrink_Succes()
        {
            //given
            string exeptedDrink = "Je bois";
            string actualDrink;
            Person person = new Person();

            //when
            actualDrink = person.Drink();

            //then
            Assert.AreEqual(exeptedDrink, actualDrink);
        }

        [Test]
        public void Person_CanEat_Succes()
        {
            //given
            string exeptedDrink = "Je mange";
            string actualDrink;
            Person person = new Person();

            //when
            actualDrink = person.Eat();

            //then
            Assert.AreEqual(exeptedDrink, actualDrink);
        }

        [Test]
        public void Person_CanSleep_Succes()
        {
            //given
            string exeptedDrink = "Je dors";
            string actualDrink;
            Person person = new Person();

            //when
            actualDrink = person.Sleep();

            //then
            Assert.AreEqual(exeptedDrink, actualDrink);
        }

        [Test]
        public void RaceDriver_ExcepetionEat_Succes()
        {
            //given
            Vehicle vehicle = new Vehicle();
            RaceDriver raceDriver = new RaceDriver(vehicle);
            raceDriver.StartMotor();

            //then
            Assert.Throws<ExceptionEat>(delegate
            {
                raceDriver.Eat();
            });
            
            //when
            //Exception thrown
        }

        [Test]
        public void Driver_Sleep_Succes()
        {
            //given
            bool exeptedStateMotor = false;
            string message = "";
            Vehicle vehicle = new Vehicle();
            Driver driver = new Driver(vehicle);
            
            //when
            message = driver.Sleep();

            //then
            Assert.AreEqual(exeptedStateMotor, driver.Vehicle.MotorState);
        }
    }
}
