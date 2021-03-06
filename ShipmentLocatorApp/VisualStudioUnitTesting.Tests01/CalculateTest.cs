// <copyright file="CalculateTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualStudioUnitTesting;

namespace VisualStudioUnitTesting.Tests
{
    [TestClass]
    [PexClass(typeof(Calculate))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CalculateTest
    {

        [PexMethod]
        public double ShippingCost(
            [PexAssumeUnderTest]Calculate target,
            double length,
            double width,
            double height,
            Calculate.ShippingType type
        )
        {
            PexAssume.IsTrue(length > 0);
            PexAssume.IsTrue(width > 0);
            PexAssume.IsTrue(height > 0);            
            double result = target.ShippingCost(length, width, height, type);
            return result;
            // TODO: add assertions to method CalculateTest.ShippingCost(Calculate, Double, Double, Double, ShippingType)
        }
    }
}
