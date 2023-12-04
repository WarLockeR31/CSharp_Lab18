using System;
using NUnit.Framework;
using System.Collections.Generic;
using static Lab18.Program;

namespace NUnitProj
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Test1()
        {
            Assert.IsTrue(IsPalindrome(CreateDList<int>()), "Test #1");                // пустой
            Assert.IsTrue(IsPalindrome(CreateDList(5)), "Test #2");               // одноэлементный
            Assert.IsTrue(IsPalindrome(CreateDList(-13, -13)), "Test #3");        // четный размер, палиндром
            Assert.IsTrue(IsPalindrome(CreateDList(6, 7, 7, 6)), "Test #4");      // четный размер, палиндром
            Assert.IsTrue(!IsPalindrome(CreateDList(-13, 13)), "Test #5");        // четный размер, не палиндром
            Assert.IsTrue(!IsPalindrome(CreateDList(13, -13)), "Test #6");        // четный размер, не палиндром
            Assert.IsTrue(!IsPalindrome(CreateDList(6, 7, 5, 6)), "Test #7");     // четный размер, не палиндром
            Assert.IsTrue(IsPalindrome(CreateDList(6, -3, 6, -3, 6)), "Test #8"); // нечетный размер, палиндром
            Assert.IsTrue(IsPalindrome(CreateDList(1, 1, 1, 1, 1)), "Test #9");   // нечетный размер, палиндром
            Assert.IsTrue(!IsPalindrome(CreateDList(1, 0, -3)), "Test #10");      // нечетный размер, не палиндром
            Assert.IsTrue(!IsPalindrome(CreateDList(1, 2, 1, 1, 1)), "Test #11"); // нечетный размер, не палиндром
        }

        [Test]
        public void Test2()
        {
            var lst = new LinkedList<int>();
            var s = 0;
            SumList(lst.First, ref s);
            Assert.AreEqual(0, s, "Test #1");

            lst = new LinkedList<int>(new int[] { 1 });
            s = 0;
            SumList(lst.First, ref s);
            Assert.AreEqual(1, s, "Test #2");

            lst = new LinkedList<int>(new int[] { 1, 2, 3, 4 });
            s = 0;
            SumList(lst.First, ref s);
            Assert.AreEqual(10, s, "Test #3");

            lst = new LinkedList<int>(new int[] { -1, -2, -3, -4 });
            s = 0;
            SumList(lst.First, ref s);
            Assert.AreEqual(-10, s, "Test #4");

            lst = new LinkedList<int>(new int[] { -1, 1, 0, 3 });
            s = 0;
            SumList(lst.First, ref s);
            Assert.AreEqual(3, s, "Test #5");
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(1, SumFactorials(1), "Test #1");
            Assert.AreEqual(3, SumFactorials(2), "Test #2");
            Assert.AreEqual(9, SumFactorials(3), "Test #3");
            Assert.AreEqual(33, SumFactorials(4), "Test #4");
            Assert.AreEqual(153, SumFactorials(5), "Test #5");
            Assert.AreEqual(873, SumFactorials(6), "Test #6");
            Assert.AreEqual(43954713, SumFactorials(11), "Test #7");
        }

        [Test]
        public void Test4()
        {
            const double eps = 1e-5;
            Assert.IsTrue(Math.Abs(PowerN(1.75, 0) - 1.0) < eps, "Test #1");
            Assert.IsTrue(Math.Abs(PowerN(5.71, -3) - 0.00537145) < eps, "Test #2");
            Assert.IsTrue(Math.Abs(PowerN(2.57, 4) - 43.62470401) < eps, "Test #3");
            Assert.IsTrue(Math.Abs(PowerN(6.66, 5) - 13103.01221405) < eps, "Test #4");
            Assert.IsTrue(Math.Abs(PowerN(-1.75, 0) - 1.0) < eps, "Test #5");
            Assert.IsTrue(Math.Abs(PowerN(-7.52, -2) - 0.01768334) < eps, "Test #6");
            Assert.IsTrue(Math.Abs(PowerN(-2.57, 4) - 43.62470401) < eps, "Test #7");
            Assert.IsTrue(Math.Abs(PowerN(-6.66, 5) - (-13103.01221405)) < eps, "Test #8");
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(0, CountLocalMax(CreateList<int>()), "Test #1"); // пустой
            Assert.AreEqual(1, CountLocalMax(CreateList(5)), "Test #2"); // одноэлементный, 1 локальный максимум
            Assert.AreEqual(1, CountLocalMax(CreateList(1, 5)), "Test #3"); // двухэлементный, 1 локальный максимум
            Assert.AreEqual(1, CountLocalMax(CreateList(5, 1)), "Test #4"); // двухэлементный, 1 локальный максимум
            Assert.AreEqual(0, CountLocalMax(CreateList(1, 1)), "Test #5"); // двухэлементный, нет локальных максимумов
            Assert.AreEqual(1, CountLocalMax(CreateList(1, 2, 3)), "Test #6"); // трехэлементный, 1 локальный максимум
            Assert.AreEqual(1, CountLocalMax(CreateList(3, 2, 1)), "Test #7"); // трехэлементный, 1 локальный максимум
            Assert.AreEqual(0, CountLocalMax(CreateList(3, 3, 3)), "Test #8"); // трехэлементный, нет локальных максимумов
            Assert.AreEqual(4, CountLocalMax(CreateList(22, -5, 92, 46, -88, 69, 27, -89, -12, 26)), "Test #9"); // случайный массив
        }
    }
}