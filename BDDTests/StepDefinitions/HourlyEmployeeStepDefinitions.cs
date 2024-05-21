/*
 * This file contains test methods for the the 'HourlyEmployee' class in the 'PayrollLibrary'.
 * It uses the SpecFlow framework and MsTest for testing.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using PayrollLibrary;
using FluentAssertions;

namespace BDDTests.StepDefinitions
{
    /// <summary>
    /// Represents the step definitions for the HourlyEmployee class.
    /// </summary>
    [Binding]
    public class HourlyEmployeeSteps
    {
        private HourlyEmployee? _employee;
        private double? _payment;
        private string? _details;

        // TODO: Add the 'WhenTheHoursWorkedIs40' method here and implement the 'Given' step

        /*
         * This is a 'Given' step.
         * Create a method named 'GivenTheHourlyRateIs10'.
         * Details:
         * This method creates an instance of the 'HourlyEmployee' class with the hourly rate set to 10.
         * All constructor arguments except the hourly rate and hours worked are nullable and should be set to 'null'.
         */
        [Given(@"the hourly rate is 10")]
        public void GivenTheHourlyRateIs10()
        {
            _employee = new HourlyEmployee(null, null, null, null, null, null, 10, 0);
        }

        // TODO: Add the 'WhenTheHoursWorkedIs40' method here and implement the 'Given' step

        /*
         * This is a 'Given' step.
         * Create a method named 'WhenTheHoursWorkedIs40'.
         * Details:
         * This creates an instance of the 'HourlyEmployee' class with the hours worked set to 40 given the hourly rate is 10 (from the previous step).
         */
        [Given(@"the hours worked is 40")]
        public void WhenTheHoursWorkedIs40()
        {
            _employee = new HourlyEmployee(null, null, null, null, null, null, 10, 40);
        }

        // TODO: Add the 'WhenThePaymentIsCalculated' method here and implement the 'When' step

        /*
         * This is a 'When' step.
         * Create a method named 'WhenThePaymentIsCalculated'.
         * Details:
         * This method calculates the payment for the employee instance created in the previous step and stores it in the '_payment' field.
         */
        [When(@"the payment is calculated")]
        public void WhenThePaymentIsCalculated()
        {
            _payment = _employee?.Payment;
        }

        // TODO: Add the 'ThenThePaymentShouldBe400' method here and implement the 'Then' step

        /*
         * This is a 'Then' step.
         * Create a method named 'ThenThePaymentShouldBe400'.
         * Details:
         * This method asserts that the payment calculated in the previous step is equal to 400.
        */
        [Then(@"the payment should be 400")]
        public void ThenThePaymentShouldBe400()
        {
            _payment.Should().Be(400);
        }

        /// <summary>
        /// Asserts that the employee details are displayed.
        /// </summary>
        [Then(@"the employee details should be displayed")]
        public void ThenTheEmployeeDetailsShouldBeDisplayed()
        {
            _details = _employee?.EmployeeDetails;
            _details.Should().Contain("Hourly Rate: 10, Hours Worked: 40");
        }
    }

}
