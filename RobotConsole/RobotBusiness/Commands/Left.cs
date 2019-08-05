using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness.Commands
{
    public static class Left
    {
        public static string LeftCommand(string direction)
        {
            switch (direction)
            {
                case "NORTH":
                case "N":
                    return direction = "WEST";
                case "SOUTH":
                case "S":
                    return direction = "EAST";
                case "EAST":
                case "E":
                    return direction = "NORTH";
                case "WEST":
                case "W":
                    return direction = "SOUTH";
            }

            return string.Empty;
        }
    }
}