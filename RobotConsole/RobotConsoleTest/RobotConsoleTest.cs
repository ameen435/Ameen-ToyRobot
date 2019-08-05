using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotBusiness;

namespace RobotTest
{
    [TestClass]
    public class RobotConsoleTest
    {
        /// <summary>
        /// Command to place and from 0,0 North sending move command and reading back using report
        /// </summary>
        [TestMethod]
        public void Robot_Report_0_0_North()
        {
            var robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 0,0,NORTH");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("REPORT");
            //assert
            Assert.AreEqual("0,1, and direction is NORTH", result);
        }


        /// <summary>
        /// Command to place and from 0,0 North sending move command and reading back using report
        /// </summary>
        [TestMethod]
        public void Robot_10Commands()
        {
            RobotCommand robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 0,0,NORTH");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("RIGHT");
            result = robot.InitializeCommands("LEFT");
            result = robot.InitializeCommands("RIGHT");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("REPORT");
            Assert.AreEqual("2,3, and direction is EAST", result);
        }

        /// <summary>
        /// Test for 0,0 North and then command to view LEFT and read using Report
        /// </summary>
        [TestMethod]
        public void Robot_Test_0_0_North()
        {
            var robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 0,0,NORTH");
            result = robot.InitializeCommands("LEFT");
            result = robot.InitializeCommands("REPORT");
            Assert.AreEqual("0,0, and direction is WEST", result);
        }

        /// <summary>
        /// Test for direction 1_2_East followed by MOVE, LEFT and Report
        /// </summary>
        [TestMethod]
        public void Robot_Test_1_2_East()
        {
            var robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 1,2,EAST");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("LEFT");
            result = robot.InitializeCommands("MOVE");
            result = robot.InitializeCommands("REPORT");
            Assert.AreEqual("3,3, and direction is NORTH", result);
        }

        /// <summary>
        /// Robot Not Placed and command sent to report.
        /// </summary>
        [TestMethod]
        public void RobotNotPlaced()
        {
            var robot = new RobotCommand();
            var command = "REPORT";
            var result = robot.InitializeCommands(command);
            Assert.AreEqual($"Robot not placed, cannot process command { command}", result);
        }

        /// <summary>
        /// Wrong direction for Robot
        /// </summary>
        [TestMethod]
        public void RobotInWrongDirection()
        {
            var robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 0,0,NORTH");
            Assert.AreEqual(string.Empty, result);
        }

        /// <summary>
        /// Basic start up command to prove it works and reading the movement
        /// </summary>
        [TestMethod]
        public void RobotReportAfterBeingPlaced()
        {
            var robot = new RobotCommand();
            var result = robot.InitializeCommands("PLACE 0,0,NORTH");
            result = robot.InitializeCommands("REPORT");
            Assert.AreEqual("0,0, and direction is NORTH", result);
        }
    }
}