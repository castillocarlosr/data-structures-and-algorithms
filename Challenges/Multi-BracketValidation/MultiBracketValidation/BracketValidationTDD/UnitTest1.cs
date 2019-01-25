using System;
using Xunit;
using static MultiBracketValidate.Program;

namespace BracketValidationTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestForTrue()
        {

            Assert.True(MultiBracketValidation("(){}[]"));
        }

        [Fact]
        public void TestForFalse()
        {
            Assert.False(MultiBracketValidation("[({)}]"));
        }

        [Fact]
        public void TestForTruewithText()
        {
            Assert.True(MultiBracketValidation("fisrt(Hello){third}[fourth]"));
        }
    }
}
