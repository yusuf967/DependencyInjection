namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(new Car());
            vehicle.Use();

            Car car = new Car();//kötü kod
            car.Brake();
        }

        interface IVehicle
        {
            void GiveGas();//gaz ver
            void Brake();//fren yap
            void TurnLeft();//sola sinyal
            void TurnRight();//sağa sinyal
        }

        class Car : IVehicle
        {
            public void Brake()
            {
                Console.WriteLine("Araba frene bastı.");
            }

            public void GiveGas()
            {
                Console.WriteLine("Araba gaza bastı.");
            }

            public void TurnLeft()
            {
                Console.WriteLine("Araba sola sinyal tuşuna bastı.");
            }

            public void TurnRight()
            {
                Console.WriteLine("Araba sağa sinyal tuşuna bastı.");
            }
        }

        class Bus :IVehicle
        {
            public void Brake()
            {
                Console.WriteLine("Otobüs frene bastı.");
            }

            public void GiveGas()
            {
                Console.WriteLine("Otobüs gaza bastı.");
            }

            public void TurnLeft()
            {
                Console.WriteLine("Otobus sola sinyal tuşuna bastı.");
            }

            public void TurnRight()
            {
                Console.WriteLine("Otobus sağa sinyal tuşuna bastı.");
            }
        }

           class Vehicle
        {
            IVehicle vehicle;

            public Vehicle(IVehicle vehicle)// dependency injection
            {
                this.vehicle = vehicle;
            }

            public void Use()
            {
                vehicle.GiveGas();
                vehicle.TurnLeft();
                vehicle.TurnRight();
                vehicle.Brake();
            }
        }

    }

}