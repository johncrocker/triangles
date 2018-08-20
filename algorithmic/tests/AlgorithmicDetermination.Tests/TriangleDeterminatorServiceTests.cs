using AlgorithmicDetermination.Lib;
using AlgorithmicDetermination.Lib.Service;
using System;
using Xunit;

namespace AlgorithmicDetermination.Tests
{
    public class TriangleDeterminatorServiceTests
    {
        [Fact]
        public void Test_IsEquilateral_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(4, 4, 4);

            //then
            Assert.Equal(TriangleType.Equilateral, triangle);
        }

        [Fact]
        public void Test_IsIsosceles_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(4, 4, 3);

            //then
            Assert.Equal(TriangleType.Isosceles, triangle);
        }

        [Fact]
        public void Test_IsScalene_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(4, 3, 2);

            //then
            Assert.Equal(TriangleType.Scalene, triangle);
        }
    }
}

