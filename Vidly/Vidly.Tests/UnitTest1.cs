using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vidly.Controllers;

namespace Vidly.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customerController = new CustomersController();
            var result = customerController.New() as ViewResult;
            Assert.AreEqual("CustomerForm", result.ViewName);
        }
    }
}
