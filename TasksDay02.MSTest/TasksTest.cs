using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TasksDay02.Tasks;

namespace TasksDay02.MSTest
{
    [TestClass]
    public class TasksTest
    {
        [TestMethod]
        public void InsertNumber_15IsInsertedIn15From0To0Bit_15Returned()
        {
            int expected = 15;
            int actual = InsertNumber(15, 15, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_15IsInsertedIn8From0To0Bit_9Returned()
        {
            int expected = 9;
            int actual = InsertNumber(8, 15, 0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_15IsInsertedIn8From3thTo8thBit_120Returned()
        {
            int expected = 120;
            int actual = InsertNumber(8, 15, 3, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_22095IsInsertedInMinus4106From4thTo9thBit_minus4874Returned()
        {
            int expected = -4874;
            int actual = InsertNumber(-4106, 22095, 4, 9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_TrowArgumentOutOfRangeException()
            => InsertNumber(8, 15, -1, 33);
    }
}
