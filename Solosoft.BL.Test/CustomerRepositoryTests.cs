using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solosoft.BL.Test;


namespace Solosoft.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        private CustomerRepository _repository;
        private List<Customer> _customerList;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            _repository = new CustomerRepository();
            _customerList = _repository.Retrieve();
        }
        
        [TestMethod]
        public void FindTestExistingCustomer()
        {

            //Act
            var query = _repository.Find(_customerList, 1);

            //Assert
            Assert.IsNotNull(query);
            Assert.AreEqual("Ronald", query.FirstName);

        }

        [TestMethod]
        public void SortByNameTest()
        {
            //Arrange

            //Act
            var result = _repository.SortByName(_customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Endel", result.FirstOrDefault().LastName);
            Assert.AreEqual("Sjoerd", result.FirstOrDefault().FirstName);
        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {
            //Act
            var result = _repository.SortByNameInReverse(_customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Zijp", result.First().LastName);
            Assert.AreEqual("Nicolien", result.First().FirstName);
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            //Act
            var result = _repository.SortByType(customerList: _customerList);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Wiedijk", result.First().LastName);
            Assert.AreEqual("Ronald", result.First().FirstName);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
        }

        [TestMethod]
        public void GetNamesTest()
        {
            //Act
            var result = _repository.GetNames(customerList: _customerList);

            //Analyse
            foreach (string s in result)
            {
                TestContext.WriteLine(s);
            }

            //Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        public void GetNamesAndEmailsTest()
        {
            //Act
            var result = _repository.GetNamesAndEmails(customerList: _customerList);

            //Analyse
            

            //Assert
           // Assert.IsNotNull(result);

        }



        
    }
}
