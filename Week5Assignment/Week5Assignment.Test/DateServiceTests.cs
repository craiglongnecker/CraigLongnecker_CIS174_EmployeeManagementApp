using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week5Assignment.share.Services;
using Week5Assignment.share.Services.Interfaces;
using Week5Assignment.share.ViewModels;

namespace Week5Assignment.Test
{
    [TestClass]
    public class DateServiceTests
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker.GetMock<IDateTimeService>()
            .Setup(x => x.Now())
            .Returns(new DateTime(2018, 10, 31));
        }
        
        [TestMethod]
        public void BirthdayToday_ReturnsTrue_WhereBirthdayMatchesToday()
        {

            var employee = CreateEmployee(new DateTime(1975, 10, 31));

            var dateService = _mocker.Create<DateService>();

            var isBirthday = dateService.IsTodayYourBirthday(employee);

            Assert.IsTrue(isBirthday);
        }

        [TestMethod]
        public void BirthdayToday_ReturnsTrue_WhereBirthdayDoesNotMatchToday()
        {

            var employee = CreateEmployee(new DateTime(1975, 10, 20));

            var dateService = _mocker.Create<DateService>();

            var isNotBirthday = dateService.IsTodayNotYourBirthday(employee);

            Assert.IsTrue(isNotBirthday);
        }

        [TestMethod]
        public void AnniversaryToday_ReturnsTrue_WhereAnniversaryMatchesToday()
        {

            var employee = CreateEmployee(new DateTime(1975, 10, 31));

            var dateService = _mocker.Create<DateService>();

            var isAnniversary = dateService.IsTodayYourAnniversary(employee);

            Assert.IsTrue(isAnniversary);
        }

        [TestMethod]
        public void AnniversaryToday_ReturnsTrue_WhereAnniversaryDoesNotMatchToday()
        {

            var employee = CreateEmployee(new DateTime(1975, 10, 20));

            var dateService = _mocker.Create<DateService>();

            var isNotAnniversary = dateService.IsTodayNotYourAnniversary(employee);

            Assert.IsTrue(isNotAnniversary);
        }

        [TestMethod]
        public void IsYourAge43()
        {

            var dateService = _mocker.Create<DateService>();

            int isAge = dateService.GetAge(new DateTime (1975, 10, 20));

            Assert.AreEqual(43, isAge);
        }

        [TestMethod]
        public void IsYourAge44()
        {

            var dateService = _mocker.Create<DateService>();

            int isAge = dateService.GetAge(new DateTime(1975, 10, 20));

            Assert.AreNotEqual(44, isAge);
        }

        [TestMethod]
        public void IsYourAnniversary10()
        {

            var dateService = _mocker.Create<DateService>();

            int isAnniversary = dateService.GetAnniversary(new DateTime(2008, 10, 20));

            Assert.AreEqual(10, isAnniversary);
        }

        [TestMethod]
        public void IsYourAnniversary11()
        {

            var dateService = _mocker.Create<DateService>();

            int isAnniversary = dateService.GetAnniversary(new DateTime(2008, 10, 20));

            Assert.AreNotEqual(11, isAnniversary);
        }

        private EmployeeViewModel CreateEmployee(DateTime birthDate)
        {
            return new EmployeeViewModel
            {
                EmployeeID = Guid.NewGuid(),
                FirstName = "Matt",
                MiddleName = "James",
                LastName = "Campbell",
                BirthDate = new DateTime(1975, 10, 31),
                HireDate = new DateTime(2007, 10, 31)
            };
        }
    }
}
