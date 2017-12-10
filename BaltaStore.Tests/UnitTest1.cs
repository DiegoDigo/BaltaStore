using BaltaStore.Domain.StoreContext.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Dego","Delmiro",
                "123456","teste@gmail.com",
                "777777","rua");                       
        }
    }
}
