using System;
using Xunit;

namespace University_Hospitals.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PayEmployee()
        {
            //Arrange
            var Employee = new Employee();

            //Act
            Employee.PayAllEmployees();

            //Assert
            Assert.True(Employee.payEmployees);
        }
         
        [Fact]
        public void BloodDraw()
        {
            //Arrange
            var Doctor = new Employee();
            //var bloodLevel = new bloodLevel();

            //Act
            Doctor.DrawBlood();

            //Assert
            //Assert.Equal(Patient.he);
        }

        //}
        //[Fact]
        //public void Should_Remove_Pet() //Adopt() Method in shelter class
        //{
        //    //ARRANGE
        //    var test_shelter = new Shelter();
        //    //ACT
        //    test_shelter.Pet.Clear(); //Remove all items from LIST

        //    OrganicPetClass temp_organic = new OrganicPetClass("Tom", 15, "Lion"); //add  in PET LIST as organic pet
        //    test_shelter.Pet.Add(temp_organic); // Addes in Pet List
        //    test_shelter.Adopt(0); // Removes from  Pet List
        //    //ASSERT
        //    Assert.Empty(test_shelter.Pet);
        //}
    }
}




