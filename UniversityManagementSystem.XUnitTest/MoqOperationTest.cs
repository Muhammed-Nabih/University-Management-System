using FluentAssertions;
using Moq;
using UniversityManagementSystem.XUnitTest.MoqTest;
using UniversityManagementSystem.XUnitTest.TestModels;

namespace UniversityManagementSystem.XUnitTest
{
    public class MoqOperationTest
    {
        private readonly Mock<List<Car>> _mockService = new();
        [Fact]
        public void Add_Car()
        {
            //Arrange
            var car = new Car() { Id = 2, Name = "Toyota", Color = "Red" };
            var carmoqService = new CarMoqService(_mockService.Object);
            //act
            var addResult = carmoqService.AddCar(car);
            var carList = carmoqService.GetAll();
            //Assert
            addResult.Should().BeTrue();
            carList.Should().NotBeNull();
            carList.Should().HaveCount(1);
        }
        //[Fact]
        //public void Remove_Car()
        //{
        //    //Arrange
        //    var car = new Car() { Id=2, Name="Toyota", Color="Red" };
        //    //act
        //    var removeResult = _carMoqService.RemoveCar(2);
        //    var carList = _carMoqService.GetAll();
        //    //Assert
        //    carList.Should().HaveCount(1);
        //}

    }
}
