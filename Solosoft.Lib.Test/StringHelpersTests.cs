using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solosoft.Lib.Helpers;

namespace Solosoft.Lib.Test
{
    [TestClass]
    public class StringHelpersTests
    {
        [TestMethod]
        public void StringToTitleCaseTest()
        {
            //Arrange
            var str = "dit is een tekst zonder capitalen";

            //Act
            string result = str.ToTitleCase();

            //Assert
            Assert.AreEqual("Dit Is Een Tekst Zonder Capitalen", result);
        }
    }
}