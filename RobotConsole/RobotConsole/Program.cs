using NLog;
using RobotBusiness;
using System;

namespace RobotConsole
{
    class Program
    {
        /// <summary>
        /// instance of logger 
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Starting point of console APP 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var robotCommand = string.Empty;
            logger.Info("set up logger!!");
            Console.WriteLine("Welcome to Robot Console!!");

            RobotCommand robotCommandClass = new RobotCommand();

            while (true)
            {

                Console.WriteLine("Please Enter Commond to move the robot");
                robotCommand = Console.ReadLine();

                Console.WriteLine($"Command is {robotCommand}");

                Console.WriteLine(robotCommandClass.InitializeCommands(robotCommand.ToUpper()));
                Console.WriteLine();
            }
        }
    }
}
