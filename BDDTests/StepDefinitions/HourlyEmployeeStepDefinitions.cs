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
    [Binding]
    public class HourlyEmployeeSteps
    {
        private HourlyEmployee? _employee;
        private double? _payment;
        private string? _details;

        /*
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



    }

}
