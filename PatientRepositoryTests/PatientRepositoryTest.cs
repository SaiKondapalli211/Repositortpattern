using Castle.Core.Resource;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Repositortpattern1.Controllers;
using Repositortpattern1.Models;
using Repositortpattern1.Repositories.Interfaces;
using Xunit;

namespace PatientRepositoryTests
{
    public class PatientRepositoryTestss
    {
        private readonly Mock<IPatient> _mockPatient;   
        private readonly Mock<PatientController> _mockPatientController;

        public PatientRepositoryTestss()
        {
            _mockPatient = new Mock<IPatient>();    
            _mockPatientController = new Mock<PatientController>(_mockPatient.Object); 
        
        }

        [Fact]
        public void GetAll_ShouldReturnAllPatient()
        {
            //Arrange
            var patients = new List<Patient> { new Patient { Id = 1, FirstName = "Sai", LastName = "Kondapalli", Age = "24", Address = "P.K PALAVALASA", PatientType = "Nervous", bednum = "test", diagnosis = "Fever" } };
            _mockPatient.Setup(repo => repo.GetAllPatients()).Returns(patients);    


            //Act
            var result = _mockPatientController.GetById() as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(customers, result.Value)

        }

    }
}