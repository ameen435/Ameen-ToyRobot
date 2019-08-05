using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness.Commands
{
    public static class Report
    {
        /// <summary>
        /// Print direction along with X and Y axis
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        public static string ReportCommand(int x, int y, string direction)
        {
            return x + "," + y + ", and direction is " + direction;
        }
    }
}