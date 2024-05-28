using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject.Models;
using SchoolClassProject.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Repos.Tests
{
    [TestClass()]
    public class SchoolClassRepoTestsMostPaidSchoolClass
    {
        [TestMethod()]
        public void MostPaidSchoolClassTestAllSameAmount()
        {

            List<SchoolClass> SchoolClasses = new List<SchoolClass>
            {
                new SchoolClass
                {
                    ClassYear = 9,
                    ClassIdentifier = 'a',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 30,
                },
                new SchoolClass
                {
                    ClassYear = 10,
                    ClassIdentifier = 'b',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 28,
                },
                new SchoolClass
                {
                    ClassYear = 11,
                    ClassIdentifier = 'c',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 26,
                },
            };
            SchoolClassRepo repo = new SchoolClassRepo(SchoolClasses);

            string actual = repo.MostPaidSchoolClass();

            string expected = $"Az összes osztály ugyan annyit fizet!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestEmpty()
        {

            List<SchoolClass> SchoolClasses = new List<SchoolClass>
            {
                
            };
            SchoolClassRepo repo = new SchoolClassRepo(SchoolClasses);

            string actual = repo.MostPaidSchoolClass();

            string expected = "";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestMultipleSameAmount()
        {

            List<SchoolClass> SchoolClasses = new List<SchoolClass>
            {
                new SchoolClass
                {
                    ClassYear = 9,
                    ClassIdentifier = 'a',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 30,
                },
                new SchoolClass
                {
                    ClassYear = 10,
                    ClassIdentifier = 'b',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 28,
                },
                new SchoolClass
                {
                    ClassYear = 11,
                    ClassIdentifier = 'c',
                    MonthlyClassMoney = 5000,
                    NumberOfStudents = 26,
                },
            };
            SchoolClassRepo repo = new SchoolClassRepo(SchoolClasses);

            string actual = repo.MostPaidSchoolClass();

            string expected = $"9.a,10.b,";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestOnePaysTheMost()
        {

            List<SchoolClass> SchoolClasses = new List<SchoolClass>
            {
                new SchoolClass
                {
                    ClassYear = 9,
                    ClassIdentifier = 'a',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 30,
                },
                new SchoolClass
                {
                    ClassYear = 10,
                    ClassIdentifier = 'b',
                    MonthlyClassMoney = 7000,
                    NumberOfStudents = 28,
                },
                new SchoolClass
                {
                    ClassYear = 11,
                    ClassIdentifier = 'c',
                    MonthlyClassMoney = 10000,
                    NumberOfStudents = 26,
                },
            };
            SchoolClassRepo repo = new SchoolClassRepo(SchoolClasses);

            string actual = repo.MostPaidSchoolClass();

            string expected = $"11.c";
            Assert.AreEqual(expected, actual);
        }
    }
}