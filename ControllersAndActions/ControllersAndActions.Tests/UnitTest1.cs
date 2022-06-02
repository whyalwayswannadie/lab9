﻿using System;
using System.Web.Mvc;
using ControllersAndActions.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ControllersAndActions.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ControllerTest()
        {
            // Организация - создание контроллера
            ExampleController controller = new ExampleController();

            // Действие - вызов метода действия
          HttpStatusCodeResult result = controller.StatusCode();

            // Утверждение - проверка результата
            Assert.AreEqual(401, result.StatusCode);
        }
    }
}
