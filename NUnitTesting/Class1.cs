using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LaptopDiscount;

namespace NUnitTesting
{
    
        [TestFixture]
        public class EmployeeDiscountTests
        {
            [Test]
            // This Test Case verifies that Contract- Part Time Employyes gets No Discount
            public void CalculationOfDiscountedPrice_ForPartTimeEmp_NoDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartTime,
                    Price = 1000m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(1000m), "Contract- PartTime employees should not receive a discount.");
            }

            [Test]
            // This Test case checks that PartialLoad Employee gets 5% Discount on their purchases.
            public void CalculationOfDiscountedPrice_PartialLoadEmp_5PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartialLoad,
                    Price = 1000m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(950m), "PartialLoad employees should get a 5% discount on their purchases.");
            }

            [Test]
            // This Test case checks that FullTime Employee gets 10% Discount on their purchases.
            public void CalculationOfDiscountedPrice_FullTime_10PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.FullTime,
                    Price = 1000m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(900m), "FullTime employees should get a 10% discount on their purchases.");
            }

            [Test]
            // This Test case checks that CompanyOurchase gets 20% Discount on their purchases.
            public void CalculationOfDiscountedPrice_PurchasingFromCompany_20PercentDiscount()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.CompanyPurchasing,
                    Price = 1000m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(800m), "CompanyPurchasing should get a 20% discount on their purchases.");
            }

            [Test]
            // This test case checks on the price of 0 any type of employee do not get any kind of discount. 
            public void CalculationOfDiscountedPrice_PriceIsZero()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.FullTime,
                    Price = 0m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(0m), "The price of 0 should return a discounted price of 0 regardless type of the employee.");
            }

            [Test]
            // This test case checks that PatialLoad employee gets 5% discount on high price.
            public void CalculationOfDiscountedPrice_PriceIsHigh()
            {
                // Arrange
                var employeeDiscount = new EmployeeDiscount
                {
                    EmployeeType = EmployeeType.PartialLoad,
                    Price = 10000m
                };

                // Act
                var actual = employeeDiscount.CalculateDiscountedPrice();

                // Assert
                Assert.That(actual, Is.EqualTo(9500m), "PartialLoad employees should get a 5% discount on a high price.");
            }
        }
 }

