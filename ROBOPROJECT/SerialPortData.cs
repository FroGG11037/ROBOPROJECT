using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOPROJECT
{
    internal class SerialPortData
    {
        private static uint _maxSpeed = 1000;
        public static uint MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
        private static uint _acceleration = 500;
        public static uint Acceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; }
        }
        private static int _motorBottom = 0;
        private static int _motorMiddle = 0;
        private static int _motorTop = 0;
        private static uint _servoMiddle = 0;
        private static int _servo = 0;
        public static int MotorBottom
        {
            get { return _motorBottom; }
            set
            {
                _motorBottom += value;
            }
        }
        public static int MotorMiddle
        {
            get { return _motorMiddle; }
            set
            {
                _motorMiddle += value;
            }
        }
        public static int MotorTop
        {
            get { return _motorTop; }
            set
            {
                _motorTop += value;
            }
        }

        public static uint ServoMiddle
        {
            get { return _servoMiddle; }
            set
            {
                _servoMiddle = value;
            }
        }
        public static int Servo
        {
            get { return _servo; }
            set
            {
                _servo += value;
            }
        }
    }
}
