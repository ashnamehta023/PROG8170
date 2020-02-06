//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Prog8170Assignment1.Test
{
    [TestFixture]
    public class RectangleTest
    {
        int actualValue;

        [SetUp]
        public void TestMethod1()
        {
            var recObject = new Rectangle();
        }

        //Test Cases for GetLength()
        [Test]
        public void GetLength_Default_ExpectedLengthdefault()
        {
            var rec = new Rectangle();
            actualValue = rec.GetLength();
            Assert.AreEqual(1, actualValue);
        }
        
        [Test]
        public void GetLength_InputLength5_ExpectedLength5()
        {
            var rec = new Rectangle(5, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(5, actualValue);
        }

        [Test]
        public void GetLength_InputLength9_ExpectedLength9()
        {
            var rec = new Rectangle(9, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(9, actualValue);
        }

        [Test]
        public void GetLength_InputLength5_ExpectedLength6()
        {
            var rec = new Rectangle(5, 7);
            actualValue = rec.GetLength();
            Assert.AreEqual(6, actualValue, "Intentioanlly Failed Scenario");
        }

        
        //Test Cases for SetLength()
        [Test]
        public void SetLength_SetLengthTo3_ExpectedLength3()
        {
            var rec = new Rectangle(9,5);
            actualValue = rec.SetLength(3);
            Assert.AreEqual(3, actualValue);
        }

        [Test]
        public void SetLength_SetLengthTo8_ExpectedLength8()
        {
            var rec = new Rectangle(9, 5);
            actualValue = rec.SetLength(8);
            Assert.AreEqual(8, actualValue);
        }

        [Test]
        public void SetLength_SetLengthTo6_ExpectedLength6()
        {
            var rec = new Rectangle(9, 5);
            actualValue = rec.SetLength(6);
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void SetLength_SetLengthTo7_ExpectedLength3()
        {
            var rec = new Rectangle(1, 5);
            actualValue = rec.SetLength(7);
            Assert.AreEqual(3, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for GetWidth()
        [Test]
        public void GetWidth_DefaultWidth_ExpectedWidth5()
        {
            var rec = new Rectangle();
            actualValue = rec.GetWidth();
            Assert.AreEqual(1, actualValue);
        }

        [Test]
        public void GetWidth_InputtWidth6_ExpectedWidth6()
        {
            var rec = new Rectangle(4,6);
            actualValue = rec.GetWidth();
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void GetWidth_InputWidth7_ExpectedWidth7()
        {
            var rec = new Rectangle(4,7);
            actualValue = rec.GetWidth();
            Assert.AreEqual(7, actualValue);
        }

        [Test]
        public void GetWidth_InputWidth7_ExpectedWidth5()
        {
            var rec = new Rectangle(2, 7);
            actualValue = rec.GetWidth();
            Assert.AreEqual(5, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for SetWidth()
        [Test]
        public void SetWidth_SetWidthTo7_ExpectedWidth7()
        {
            var rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(7);
            Assert.AreEqual(7, actualValue);
        }

        [Test]
        public void SetWidth_SetWidthTo2_ExpectedWidth2()
        {
            var rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(2);
            Assert.AreEqual(2, actualValue);
        }

        [Test]
        public void SetWidth_SetWidthTo6_ExpectedWidth6()
        {
            var rec = new Rectangle(9, 5);
            actualValue = rec.SetWidth(6);
            Assert.AreEqual(6, actualValue);
        }

        [Test]
        public void SetWidth_SetWidthTo4_ExpectedWidth6()
        {
            var rec = new Rectangle(1, 7);
            actualValue = rec.SetWidth(4);
            Assert.AreEqual(6, actualValue, "Intentioanlly Failed Scenario");
        }

        //Test Cases for GetPerimeter()
        [Test]
        public void GetPereimeter_Inputs8_5_ExpectedPerimeter26()
        {
            var rec = new Rectangle(8, 5);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(26, actualValue);
        }

        [Test]
        public void GetPereimeter_Inputs5_8_ExpectedPerimeter26()
        {
            var rec = new Rectangle(5,8);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(26, actualValue);
        }

        [Test]
        public void GetPereimeter_Inputs6_5_ExpectedPerimeter22()
        {
            var rec = new Rectangle(6,5);
            actualValue = rec.GetPerimeter();
            Assert.AreEqual(22, actualValue);
        }

        //Test Cases for GetArea()
        [Test]
        public void GetArea_Inputs8_5_ExpectedArea40()
        {
            var rec = new Rectangle(8, 5);
            actualValue = rec.GetArea();
            Assert.AreEqual(40, actualValue);
        }

        [Test]
        public void GetArea_Inputs5_8_ExpectedArea40()
        {
            var rec = new Rectangle(5, 8);
            actualValue = rec.GetArea();
            Assert.AreEqual(40, actualValue);
        }

        [Test]
        public void GetArea_Inputs6_5_ExpectedArea30()
        {
            var rec = new Rectangle(6, 5);
            actualValue = rec.GetArea();
            Assert.AreEqual(30, actualValue);
        }


    }
}
