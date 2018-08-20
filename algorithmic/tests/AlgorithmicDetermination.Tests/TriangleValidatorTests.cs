using AlgorithmicDetermination.Lib.Validator;
using System;
using Xunit;

namespace AlgorithmicDetermination.Tests
{
    public class TriangleValidatorTests
    {

        [Fact]
        public void Test_ValidatorTrapInvalidTriangle1_Ok()
        {
            //given
            ITriangleValidator validator = new TriangleValidator();

            //when
            bool isValid = validator.IsValid(-4, 4, 4);

            //then
            Assert.False(isValid);
        }

        [Fact]
        public void Test_ValidatorInvalidTriangle2_Ok()
        {
            //given
            ITriangleValidator validator = new TriangleValidator();

            //when
            bool isValid = validator.IsValid(4, -4, 4);

            //then
            Assert.False(isValid);
        }

        [Fact]
        public void Test_ValidatorInvalidTriangle3_Ok()
        {
            //given
            ITriangleValidator validator = new TriangleValidator();

            //when
            bool isValid = validator.IsValid(4, 4, -4);

            //then
            Assert.False(isValid);
        }

        [Fact]
        public void Test_ValidatorInvalidTriangle4_Ok()
        {
            //given
            ITriangleValidator validator = new TriangleValidator();

            //when
            bool isValid = validator.IsValid(-4, -4, -4);

            //then
            Assert.False(isValid);
        }
    }
}
