using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTests
{
    [TestClass]
    public class MyFracTests
    {
        [TestMethod]
        public void TestToStringWithIntPart_WhenFractionHasNoIntegerPart_ShouldReturnOnlyFraction()
        {
           
            MyFrac frac = new MyFrac(1, 2); // 1/2

            string result = frac.ToStringWithIntPart();

            Assert.AreEqual("1/2", result);
        }

        [TestMethod]
        public void TestToStringWithIntPart_WhenFractionHasIntegerPart_ShouldReturnMixedFraction()
        {
            MyFrac frac = new MyFrac(5, 2); // 5/2

            string result = frac.ToStringWithIntPart();

            Assert.AreEqual("2+(1/2)", result);
        }

        [TestMethod]
        public void TestToStringWithIntPart_WhenFractionIsNegativeWithIntegerPart_ShouldReturnNegativeMixedFraction()
        {
            MyFrac frac = new MyFrac(-5, 2); // -5/2

            string result = frac.ToStringWithIntPart();

            Assert.AreEqual("-(2+(1/2))", result);
        }

        [TestMethod]
        public void TestToStringWithIntPart_WhenFractionIsNegativeWithoutIntegerPart_ShouldReturnOnlyFraction()
        {
            MyFrac frac = new MyFrac(-1, 2); // -1/2

            string result = frac.ToStringWithIntPart();

            Assert.AreEqual("-1/2", result);
        }

        [TestMethod]
        public void TestToStringWithIntPart_WhenFractionIsNegativeWithoutIntegerPart1_ShouldReturnOnlyFraction()
        {
            MyFrac frac = new MyFrac(1, -2); // 1/-2

            string result = frac.ToStringWithIntPart();

            Assert.AreEqual("-1/2", result);
        }

        [TestMethod]
        public void TestPlus_WhenAddingTwoFractions_ShouldReturnCorrectSum()
        {
            MyFrac frac1 = new MyFrac(1, 2);
            MyFrac frac2 = new MyFrac(1, 3);

            MyFrac sum = frac1.Plus(frac2);

            Assert.AreEqual("5/6", sum.ToString());
        }

        [TestMethod]
        public void TestMinus_WhenSubtractingTwoFractions_ShouldReturnCorrectDifference()
        {
            MyFrac frac1 = new MyFrac(3, 4);
            MyFrac frac2 = new MyFrac(1, 2);

            MyFrac difference = frac1.Minus(frac2);

            Assert.AreEqual("1/4", difference.ToString());
        }

        [TestMethod]
        public void TestMultiply_WhenMultiplyingTwoFractions_ShouldReturnCorrectProduct()
        {
            MyFrac frac1 = new MyFrac(1, 2);
            MyFrac frac2 = new MyFrac(1, 3);

            MyFrac product = frac1.Multiply(frac2);

            Assert.AreEqual("1/6", product.ToString());
        }

        [TestMethod]
        public void TestDivide_WhenDividingTwoFractions_ShouldReturnCorrectQuotient()
        {
            MyFrac frac1 = new MyFrac(1, 2);
            MyFrac frac2 = new MyFrac(1, 3);

            MyFrac quotient = frac1.Divide(frac2);

            Assert.AreEqual("3/2", quotient.ToString());
        }
    }
}