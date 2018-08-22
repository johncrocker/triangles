using System;
using PythagorasDetermination.Lib;
using PythagorasDetermination.Lib.Service;
using Xunit;

namespace PythagorasDetermination.Tests
{
    public class TriangleDeterminatorServiceTests
    {
        [Fact]
        public void Test_IsAcute_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(5, 6, 7);

            //then
            Assert.Equal(TriangleType.Acute, triangle);
        }

        [Fact]
        public void Test_IsObtuse_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(5, 10, 14);

            //then
            Assert.Equal(TriangleType.Obtuse, triangle);
        }

        [Fact]
        public void Test_IsRight_Ok()
        {
            //given
            ITriangleDeterminator service = new TriangleDeterminatorService();

            //when
            TriangleType triangle = service.Determine(12, 35, 37);

            //then
            Assert.Equal(TriangleType.Right, triangle);
        }
    }
}

