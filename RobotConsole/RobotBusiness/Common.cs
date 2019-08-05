using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness
{
    /// <summary>
    /// Common business class
    /// </summary>
    public class Common
    {
        /// <summary>
        /// validate Direction Position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="xUpper"></param>
        /// <param name="xLower"></param>
        /// <returns>Validates if robot is in co ordinates</returns>
        public bool validatePosition(int x, int y,int xUpper, int yupper)
        {
            if ((x < 0) || (y < 0))
                return false;
            else if ((x > xUpper) || (y > yupper))
                return false;
            else
                return true;
        }
    }
}
