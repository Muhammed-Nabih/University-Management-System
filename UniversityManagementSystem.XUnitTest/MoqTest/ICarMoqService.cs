using UniversityManagementSystem.XUnitTest.TestModels;

namespace UniversityManagementSystem.XUnitTest.MoqTest
{
    public interface ICarMoqService
    {
        public bool AddCar(Car car);
        public bool RemoveCar(int? id);
        public List<Car> GetAll();
    }
}
