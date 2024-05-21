/*
 * This file contains test methods for an Hourly Employee.
 * It uses the SpecFlow framework to define the steps for the test scenario.
 * 
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

        // Given steps

        /*
         * Create a method 'GivenTheHourlyRateIs10' is a Given step that sets the hourly rate of the employee to 10.
         * It creates a new instance of the HourlyEmployee class and sets the hourly rate to $10 and the number of hours worked to 0.
         * Provide all parameters when creating a new HourlyEmployee. 
         * Example:
         * _employee = new HourlyEmployee(null, null, null, null, null, null, 10, 0);
         */




    }





}
