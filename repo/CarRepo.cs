using System;

namespace Program
{
    class Car {
        public string CarName;
        public int CarSpeed;
        public string CarModel;
    }

    class CarRepo {
        static List<Car> cars = new List<Car>();

        public static List<Car> GetCars() {
            return cars;
        }

        public static Car GetCar() {
            return cars.FirstOrDefault(car => car.CarName == carName);
        }

        public static void SetCar(Car car) {
           cars.Add(car);
        }

        public static void UpdateCars(Car updatedCar) {
            foreach (Car car in cars) {
                if (car.CarName == updatedCar.CarName)
                {
                    car.CarName = updatedCar.CarName;
                    car.CarSpeed = updatedCar.CarSpeed;
                    car.CarModel = updatedCar.CarModel;
                    break;
                }
            }
        }

        public static void DeleteCar(string carName) {
            cars.RemoveAll(car => car.CarName == carName);
        }
    }
}