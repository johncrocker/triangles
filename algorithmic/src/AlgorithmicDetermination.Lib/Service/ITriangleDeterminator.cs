using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmicDetermination.Lib.Service
{
    public interface ITriangleDeterminator
    {
        /// <summary>
        /// Given the side lengths a, b, and c, determine and return
        /// what type of triangle the lengths describe, or whether
        /// the input is invalid
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <param name="c">length of side c</param>
        /// <returns>The triangle type based on the number of matching sides passed in.</returns>
        TriangleType Determine(int a, int b, int c);
    }
}
