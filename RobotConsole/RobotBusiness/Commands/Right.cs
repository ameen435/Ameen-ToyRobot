using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness.Commands
{
    public static class Right
    {
        public static string RightCommand(string direction)
        {
            switch (direction)
            {
                case "NORTH":
                case "N":
                    return "EAST";
                case "S":
                case "SOUTH":
                    return "WEST";
                case "E":
                case "EAST":
                    return "SOUTH"; 
                case "W":
                case "WEST":
                    return  "NORTH"; 
            }

            return string.Empty;
        }
    }
}