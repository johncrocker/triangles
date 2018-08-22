using System;
using System.Collections.Generic;
using System.Text;

namespace PythagorasDetermination.Lib.Validator
{
    public interface ITriangleValidator
    {
        /// <summary>
        /// Given the side lengths a, b, and c, determine if the triangle is valid
        /// </summary>
        /// <param name="a">length of side a</param>
        /// <param name="b">length of side b</param>
        /// <param name="c">length of side c</param>
        /// <returns>true if valid, otherwise false</returns>
        bool IsValid(int a, int b, int c);
    }
}
