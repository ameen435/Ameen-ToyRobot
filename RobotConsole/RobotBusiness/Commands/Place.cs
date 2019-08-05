using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBusiness.Commands
{
    public static class Place
    {
        #region Variables

        private static int xPosition = -1;
        private static int yPosition = -1;
        private static string direction = string.Empty;
        private static bool isPlaced = false;

        #endregion

        /// <summary>
        /// Place comand logic
        /// </summary>
        /// <param name="command"></param>
        /// <param name="xUpperBoundary"></param>
        /// <param name="yUpperBoundary"></param>
        /// <returns></returns>
        public static Tuple<string, int, int, string> PlaceCommand(string command, int xUpperBoundary, int yUpperBoundary)
        {
            var commonBusiness = new Common();
            string result = string.Empty;
            char[] delimiterChars = { ',', ' ' };
            string[] wordsInCommand = command.Split(delimiterChars);

            xPosition = Int32.Parse(wordsInCommand[1]);
            yPosition = Int32.Parse(wordsInCommand[2]);
            direction = wordsInCommand[3];

            if (!commonBusiness.validatePosition(xPosition, yPosition, xUpperBoundary, yUpperBoundary))
                result = $"Cannot send command as position is not valid.";
            else
                isPlaced = true;

            return Tuple.Create(result, xPosition, yPosition, direction);
        }
    }
}