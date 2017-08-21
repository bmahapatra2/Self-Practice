using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delegates;

namespace DelegateTEst
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_For_AddNum()
        {
            Program p = new Program();
            Assert.AreEqual(14, p.NumAdd(4));
        
        }

        [TestMethod]
        public void Test_For_MulNum()
        {
            Program p = new Program();
            Assert.AreEqual(40, p.NumMul(4));

        }
        [TestMethod]
        public void Test_For_Delegate()
        {
            Program p = new Program();
            p.NumAdd(4);
            int result = p.NumMul(4);
            Assert.AreEqual(result, new Program().Functionality(4));
            

        }
    }
}
