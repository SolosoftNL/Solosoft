using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solosoft.Lib.Builders;

namespace Solosoft.Lib.Test
{
    [TestClass]
    public class BuilderTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
            {
            //Arrange
            var builder = new Builder();

            //Act
            var result = builder.BuildIntegerSequence();

            //Analyse
            foreach (int i in result)
            {
                Console.WriteLine(i.ToString());
                TestContext.WriteLine(i.ToString());
            }

            //Assert
            Assert.IsNotNull(result);

            }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            //Arrange
            var builder = new Builder();

            //Act
            var result = builder.BuildStringSequence();

            //Analyse
            foreach (string i in result)
            {
                Console.WriteLine(i);
                TestContext.WriteLine(i);
            }

            //Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        public void CompareSequensenceTests()
        {
            //Arange
            var builder = new Builder();

            //Act
            var result = builder.CompareSequensence();

            //Analyse
            foreach (int i in result)
            {
                TestContext.WriteLine(i.ToString());
            }

            //Assert
            Assert.IsNotNull(result);


        }
        
    }
}
