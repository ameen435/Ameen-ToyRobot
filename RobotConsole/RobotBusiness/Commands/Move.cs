using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness.Commands
{
    public static class Move
    {
        public static Tuple<string, int, int, string> MoveCommand(int x, int y, string direction, int xUpper, int yUpper)
        {
            var result = string.Empty;
            var commonBusiness = new Common();
            int originalX = x;
            int originalY = y;

            switch (direction)
            {
                case "NORTH":
                case "N":
                    y++; break;
                case "SOUTH":
                case "S":
                    y--; break;
                case "EAST":
                case "E":
                    x++; break;
                case "WEST":
                case "W":
                    x--; break;
            }

            if (!commonBusiness.validatePosition(x,y,xUpper,yUpper))
            {
                x = originalX;
                y = originalY;
                result = $"Cannot send command as position is not valid.";
            }

            return Tuple.Create(result,x,y,direction);
        }

    }
}