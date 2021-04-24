using System;
using NUnit.Framework;
using Math.Library;

namespace Math.Library.Tests
{
    [TestFixture]
    public class Tester
    {
        private Math Math = new Math();

        private const double Delta = 0.001;

        [Test]
        public void Add()
        {
            Assert.AreEqual(10, Math.Add(0, 10));
            Assert.AreEqual(110, Math.Add(100, 10));
            Assert.AreEqual(0, Math.Add(0, 0));
            Assert.AreEqual(-5, Math.Add(0, -5));
            Assert.AreEqual(9999, Math.Add(999, 9000));
            Assert.AreEqual(20, Math.Add(10, 10));
            Assert.AreEqual(0.5, Math.Add(0.2, .3), Delta);
        }


        [Test]
        public void Sub()
        {
            Assert.AreEqual(-10, Math.Sub(0, 10));
            Assert.AreEqual(0, Math.Sub(10, 10));
            Assert.AreEqual(0.9, Math.Sub(0, 0.1), Delta);
            Assert.AreEqual(-10, Math.Sub(0, 10));
        }

        [Test]
        public void Mul()
        {
            Assert.AreEqual(0, Math.Mul(0, 10));
            Assert.AreEqual(2.52, Math.Mul(2.3, 1.1), Delta);
            Assert.AreEqual(28980, Math.Mul(69, 420), Delta);
        }

        [Test]
        public void Div()
        {
            Assert.AreEqual(0, Math.Div(0, 10));
            Assert.AreEqual(10, Math.Div(10, 1));
            Assert.AreEqual(2.5, Math.Div(10, 4), Delta);
        }

        [Test]
        public void Abs()
        {
            Assert.AreEqual(0, Math.Abs(0));
            Assert.AreEqual(10, Math.Abs(10));
            Assert.AreEqual(10, Math.Abs(-10));
        }

        [Test]
        public void Fact()
        {
            Assert.AreEqual(1, Math.Fact(0));
            Assert.AreEqual(120, Math.Fact(5));
            Assert.AreEqual(40320, Math.Fact(8));

        }

        [Test]
        public void Sqrt()
        {
            Assert.AreEqual(3.1622776601683793319988935444327, Math.Sqrt(10,2),Delta);
            Assert.AreEqual(3, Math.Sqrt(9, 2), Delta);
            Assert.AreEqual(1.31607401, Math.Sqrt(9, 3), Delta);

        }

        [Test]
        public void Pow()
        {
            Assert.AreEqual(1, Math.Pow(10,0));
            Assert.AreEqual(10, Math.Pow(10,1));
            Assert.AreEqual(1.728, Math.Pow(1.2,3));

        }
    }
}
