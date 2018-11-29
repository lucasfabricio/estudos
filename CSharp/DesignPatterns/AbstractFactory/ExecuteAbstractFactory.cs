using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Car MountCar(string type)
        {
            CarFactory carFactory = null;

            switch (type)
            {
                case "regular":
                    carFactory = new RegularCarFactory();
                    break;

                case "sporting":
                    carFactory = new SportingCarFactory();
                    break;
            }

            Car car = new Car();
            car.Color = carFactory.Paint();
            car.Engine = carFactory.InstallEngine();

            return car;
        }
    }
}
