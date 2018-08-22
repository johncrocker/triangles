using System;
using System.Collections.Generic;
using System.Text;
using PythagorasDetermination.Lib.Validator;

namespace PythagorasDetermination.Lib.Service
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
            if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2))
            {
                return TriangleType.Acute;
            }
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2))
            {
                return TriangleType.Obtuse;
            }

            return TriangleType.Right;
        }
    }
}
