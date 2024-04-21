using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAIN_LIBRARY;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime date1 = new DateTime(2024, 3, 20, 11, 20, 00);
            DateTime date2 = new DateTime(2024, 3, 20, 12, 50, 00);
            DateTime date3 = new DateTime(2024, 3, 20, 12, 50, 00);
            DateTime date4 = new DateTime(2024, 3, 20, 13, 00, 00);

            
            MAIN_LIBRARY.Para account = new MAIN_LIBRARY.Para(date1, date2, date3, date4);

            // Act
            if (date1 == date4 && date2!=date3 || date2 == date3 && date1!=date4)
            {
                Assert.IsNotNull(account);
            }
            else
            {
                Assert.Fail();
            }
            
          
          
        }
    }
}
