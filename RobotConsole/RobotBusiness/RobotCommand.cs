using RobotBusiness.Commands;
using System;

namespace RobotBusiness
{
    /// <summary>
    /// RobotCommand - Instanciates commands to be called for robot
    /// </summary>
    public class RobotCommand
    {
        private int xAxisUpper = -1;
        private int yUpperBoundary = -1;
        private bool isPlaced = false;


        #region Private variables to hold location during execution
        private string CurrentDirection = string.Empty;
        private int x = 0;
        private int y = 0;
        #endregion

        // 5 x 5 square tabletop default value ( constructor for test)
        public RobotCommand()
        {
            xAxisUpper = 5;
            yUpperBoundary = 5;
        }

        // Custom size initialization for tests.
        public RobotCommand(int sizeOfX, int sizeOfY)
        {
            xAxisUpper = sizeOfX;
            yUpperBoundary = sizeOfY;
        }

        /// <summary>
        /// Set up command class for Robot
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string InitializeCommands(string input)
        {
            string command = input.ToUpper();
            string result = string.Empty;
            Tuple<string, int, int, string> resultTuple = null;
            try
            {
                //check for first comaand PLACE
                // using tuple to reuse calculated values
                if (command.Contains("PLACE"))
                {
                    resultTuple = Place.PlaceCommand(command, xAxisUpper, yUpperBoundary);
                    result = resultTuple.Item1;
                    x = resultTuple.Item2;
                    y = resultTuple.Item3;
                    CurrentDirection = resultTuple.Item4;
                    isPlaced = true;
                }

                else if (!isPlaced)
                    result = $"Robot not placed, cannot process command {command}";

                else if (command.Contains("LEFT"))
                    CurrentDirection = Left.LeftCommand(CurrentDirection);

                else if (command.Contains("RIGHT"))
                    CurrentDirection = Right.RightCommand(CurrentDirection);

                else if (command.Contains("REPORT"))
                    result = Report.ReportCommand(x, y, CurrentDirection);

                else if (command.Contains("MOVE"))
                {
                    resultTuple = Move.MoveCommand(x, y, CurrentDirection,
                        xUpper: xAxisUpper, yUpper: yUpperBoundary);
                    result = resultTuple.Item1;
                    x = resultTuple.Item2;
                    y = resultTuple.Item3;
                    CurrentDirection = resultTuple.Item4;
                }

                else
                    result = "Invalid command format";
            }
            catch (Exception ex)
            {
                result = ex.Message + $"use valid command format";
            }

            return result;
        }
    }
}