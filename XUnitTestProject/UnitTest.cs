using System;
using Xunit;
using Codewars;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestCountBits()
        {
            Assert.Equal(0, Kata.CountBits(0));
            Assert.Equal(1, Kata.CountBits(4));
            Assert.Equal(3, Kata.CountBits(7));
            Assert.Equal(2, Kata.CountBits(9));
            Assert.Equal(2, Kata.CountBits(10));
        }
        [Fact]
        public void TestDescendingOrder()
        {
            Assert.Equal(54421, Kata.DescendingOrder(21445));
            Assert.Equal(654321, Kata.DescendingOrder(145263));
            Assert.Equal(987654321, Kata.DescendingOrder(123456789));
        }
        [Fact]
        public void TestDuplicateEncode()
        {
            Assert.Equal("(((", Kata.DuplicateEncode("din"));
            Assert.Equal("()()()", Kata.DuplicateEncode("recede"));
            Assert.Equal(")())())", Kata.DuplicateEncode("Success"));
            Assert.Equal("))((", Kata.DuplicateEncode("(( @"));
        }
        [Fact]
        public void TestDuplicateCount()
        {
            Assert.Equal(0, Kata.DuplicateCount("abcde"));
            Assert.Equal(2, Kata.DuplicateCount("aabbcde"));
            Assert.Equal(2, Kata.DuplicateCount("aabBcde"));
            Assert.Equal(1, Kata.DuplicateCount("indivisibility"));
            Assert.Equal(2, Kata.DuplicateCount("Indivisibilities"));
            Assert.Equal(2, Kata.DuplicateCount("aA11"));
            Assert.Equal(2, Kata.DuplicateCount("ABBA"));
        }
        [Fact]
        public void TestFindEvenIndex()
        {
            Assert.Equal(3, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.Equal(1, Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.Equal(-1, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.Equal(3, Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}
