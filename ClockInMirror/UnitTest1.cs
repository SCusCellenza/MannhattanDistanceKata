namespace ClockInMirror
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("12:00", Kata.WhatIsTheTime("12:00"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("11:00", Kata.WhatIsTheTime("01:00"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("05:25", Kata.WhatIsTheTime("06:35"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("11:59", Kata.WhatIsTheTime("12:01"));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal("02:00", Kata.WhatIsTheTime("10:00"));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal("12:01", Kata.WhatIsTheTime("11:59"));
        }
    }
}