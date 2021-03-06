using Xunit;

namespace RepeatedWordTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Test for the first repeated word.
        /// </summary>
        [Fact]
        public void RepeatedWordTestOne()
        {
            string testOne = "Once upon a time, there was a brave princess who...";

            Assert.Equal("a", RepeatedWord.Program.RepeatedWord(testOne));
        }
        [Fact]
        public void RepeatedWordTestTwo()
        {
            string testTwo = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way � in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";

            Assert.Equal("it", RepeatedWord.Program.RepeatedWord(testTwo));
        }
        [Fact]
        public void RepeatedWordwithCommas()
        {
            string testThree = "It was a queer sultry summer, the summer they electrocuted the Rosenbergs, and I didn�t know what I was doing in New York...";

            Assert.Equal("summer", RepeatedWord.Program.RepeatedWord(testThree));
        }

        /// <summary>
        /// Test for empty string
        /// </summary>
        [Fact]
        public void EmptyStringTest()
        {
            string testOne = "";

            Assert.Equal("No repeated word found.", RepeatedWord.Program.RepeatedWord(testOne));
        }

        /// <summary>
        /// Test for no repeated words found
        /// </summary>
        /// <param name="input"></param>
        [Theory]
        [InlineData("one two three four five six")]
        [InlineData("seven eight nine ten eleven")]
        [InlineData("a b c d fgh ijk loop pool cat")]
        public void NoRepeatedFoundTest(string input)
        {

            Assert.Equal("No repeated word found.", RepeatedWord.Program.RepeatedWord(input));
        }
    }
}
