using NUnit.Framework;
using OrderEngineP;

namespace OrderEngine
{

    public class OrderUnitTest
    {
        [Test]
        public void CreateOrderDetails()
        {
            var orderdetails = new OrderDetails(3,null,null,100);
            Assert.AreEqual(3,orderdetails.ItemCount);
            Assert.AreEqual(100,orderdetails.Amount);
            
        }
    }
}
