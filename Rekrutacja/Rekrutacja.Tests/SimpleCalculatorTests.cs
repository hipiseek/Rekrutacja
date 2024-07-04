using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Rekrutacja.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void Initialize()
        {
            _calculator = new SimpleCalculator();
        }

        [TestCase(5,10,15)]
        [TestCase(-5,10,5)]
        [TestCase(-5,-5,-10)]
        [TestCase(0,0,0)]
        public void AddTwoNumbers(double x, double y, double q)
        {
            Assert.That(_calculator.Calculate(x, y, '+'), Is.EqualTo(q));
        }

        [TestCase(5, 10, -5)]
        [TestCase(-5, 10, -15)]
        [TestCase(-5, -5, 0)]
        [TestCase(0, 0, 0)]
        public void SubtractTwoNumbers(double x, double y, double q)
        {
            Assert.That(_calculator.Calculate(x, y, '-'), Is.EqualTo(q));
        } 
        
        [TestCase(5, 10, 0.5)]
        [TestCase(-5, 10, -0.5)]
        [TestCase(-5, -5, 1)]
        [TestCase(-5, 1, -5)]
        [TestCase(-4, -2, 2)]
        [TestCase(-2, -2, 1)]
        public void DivideTwoNumbers(double x, double y, double q)
        {
            Assert.That(_calculator.Calculate(x, y, '/'), Is.EqualTo(q));
        }

        [TestCase(5,0)]
        public void DivideByZero(double x, double y)
        {
            Assert.That(()=>_calculator.Calculate(x, y, '/'), Throws.TypeOf<DivideByZeroException>());
        }
        
        [TestCase(5,0)]
        public void UseWrongOperator(double x, double y)
        {
            Assert.That(()=>_calculator.Calculate(x, y, 'x'), Throws.TypeOf<Exception>());
        }



        [TestCase(5, 10, 50)]
        [TestCase(-5, 10, -50)]
        [TestCase(-5, -5, 25)]
        [TestCase(-5, 1, -5)]
        [TestCase(-2, 0, 0)]
        [TestCase(5, 0, 0)]
        [TestCase(1, 2.5, 2.5)]
        [TestCase(2.5, 2.5, 6.25)]
        public void MultiplicateTwoNumbers(double x, double y, double q)
        {
            Assert.That(_calculator.Calculate(x, y, '*'), Is.EqualTo(q));
        }

    }
}
