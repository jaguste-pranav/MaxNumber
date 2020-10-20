using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxNumber;

namespace MaxNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Max_Number_At_First_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            int maxNumber = comp.compareIntegers(3, 2, 1);
            Assert.AreEqual(maxNumber, 3);
        }

        [TestMethod]
        public void Given_Max_Number_At_Second_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            int maxNumber = comp.compareIntegers(2, 3, 1);
            Assert.AreEqual(maxNumber, 3);
        }

        [TestMethod]
        public void Given_Max_Number_At_Third_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            int maxNumber = comp.compareIntegers(1, 2, 3);
            Assert.AreEqual(maxNumber, 3);
        }

        [TestMethod]
        public void Given_Max_Double_At_First_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            double maxNumber = comp.compareDoubles(3.3, 2.2, 1.1);
            Assert.AreEqual(maxNumber, 3.3);
        }

        [TestMethod]
        public void Given_Max_Double_At_Second_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            double maxNumber = comp.compareDoubles(2.2, 3.3, 1.1);
            Assert.AreEqual(maxNumber, 3.3);
        }

        [TestMethod]
        public void Given_Max_Double_At_Third_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            double maxNumber = comp.compareDoubles(1.1, 2.2, 3.3);
            Assert.AreEqual(maxNumber, 3.3);
        }

        [TestMethod]
        public void Given_Max_String_At_First_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            string maxString = comp.compareString("c", "b", "a");
            Assert.AreEqual(maxString, "c");
        }

        [TestMethod]
        public void Given_Max_String_At_Second_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            string maxString = comp.compareString("b", "c", "a");
            Assert.AreEqual(maxString, "c");
        }

        [TestMethod]
        public void Given_Max_String_At_Third_Position_Return_First_Number()
        {
            Compare comp = new Compare();
            string maxString = comp.compareString( "a", "b", "c");
            Assert.AreEqual(maxString, "c");
        }
    }
}
