using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prog8170Assignment1.Test
{
   [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void GetLength_InputLength9_ExpectLength9()
        {
            var rec = new Rectangle(9, 5);
            Assert.AreEqual(9, rec.GetLength());
        }

        [TestMethod]
        public void SetLength_SetLengthTo5_ExpectedLength5()
        {
            var rec = new Rectangle(9, 5);
            rec.SetLength(5);
            Assert.AreEqual(5, rec.GetLength());
        }

        [TestMethod]
        public void GetWidth_InputWidth5_ExpectedWidth5()
        {
            var rec = new Rectangle(9, 5);
            Assert.AreEqual(5, rec.GetWidth());
        }

        [TestMethod]
        public void SetWidth_SetWidthTo7_ExpectedWidth7()
        {
            var rec = new Rectangle(9, 5);
            rec.SetWidth(7);
            Assert.AreEqual(7, rec.GetWidth());
        }

        [TestMethod]
        public void GetPereimeter_Inputs8_5_ExpectedPerimeter26()
        {
            var rec = new Rectangle(8, 5);
            Assert.AreEqual(26, rec.GetPerimeter());
        }

        [TestMethod]
        public void GetArea_Inputs8_5_ExpectedArea40()
        {
            var rec = new Rectangle(8, 5);
            Assert.AreEqual(40, rec.GetArea());
        }
    }
}

