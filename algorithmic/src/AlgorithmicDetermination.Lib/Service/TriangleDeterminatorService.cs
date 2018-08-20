using AlgorithmicDetermination.Lib.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmicDetermination.Lib.Service
{
    public class TriangleDeterminatorService : ITriangleDeterminator
    {

        private ITriangleValidator _validator;

        public TriangleDeterminatorService(ITriangleValidator validator)
        {
            _validator = validator;
        }

        public TriangleDeterminatorService() : this(new TriangleValidator())
        {

        }

        /// <summary>
        /// Given the side lengths a, b, and c, determine and return
        /// what type of triangle the lengths describe.
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <param name="c">length of side c</param>
        /// <returns>The triangle type based on the number of matching sides passed in.</returns>
        public TriangleType Determine(int a, int b, int c)
        {
            if (!_validator.IsValid(a, b, c))
            {
                throw new ArgumentException("Not a valid triangle");
            }

            if (a == b && a == c)
            {
                return TriangleType.Equilateral;
            }
            else if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }
    }
}
