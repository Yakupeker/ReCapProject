using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;


        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c=>c.CarId ==CarId).ToList();
        }


        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, Description = "Ford", ModelYear = 2022 },
                new Car { CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 400, Description = "Toyota", ModelYear = 2023 },
                new Car { CarId = 3, BrandId = 1, ColorId = 1, DailyPrice = 600, Description = "Mazda", ModelYear = 2023 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;


        }
    }
    
}
