using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static TasksDay02.Tasks;

namespace TasksDay02.NUnitTest
{
    [TestFixture]
    public class TasksTest
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(-4106, 22095, 4, 9, ExpectedResult = -4874)]
        public int InsertNumber_nubmerInsertedInOtherNumber(int numberSource, int numberInsert, int i, int j)
            => InsertNumber(numberSource, numberInsert, i, j);

        [Test]
        public void InsertNumber_TrowArgumentOutOfRangeException()
            => Assert.Throws<ArgumentOutOfRangeException>(() => InsertNumber(15, 15, -1, 33));
    }
}
