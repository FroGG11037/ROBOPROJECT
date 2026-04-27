using System;
using System.Collections.Generic;
using System.Text;

namespace ROBOPROJECT
{
    internal class SerialPortData
    {
        public static List<RecordItem> SavedRecords { get; set; } = new List<RecordItem>(); 
        public class RecordItem
        {
            public int Bottom { get; set; }
            public int Middle { get; set; }
            public int Top { get; set; }
        }
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
        private static uint _servoMiddle = 90;
        private static uint _servo = 90;

        public static event EventHandler DataChanged;

        public static int MotorBottom
        {
            get { return _motorBottom; }
            set
            {
                    _motorBottom += value;
                DataChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static int MotorMiddle
        {
            get { return _motorMiddle; }
            set
            {
                _motorMiddle += value;
                DataChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static int MotorTop
        {
            get { return _motorTop; }
            set
            {
                _motorTop += value;
                DataChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static uint ServoMiddle
        {
            get { return _servoMiddle; }
            set
            {
                _servoMiddle = value;
                DataChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static uint Servo
        {
            get { return _servo; }
            set
            {
                _servo = value;
                DataChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static void ResetMotors()
        {
            _motorBottom = 0;
            _motorMiddle = 0;
            _motorTop = 0;
            DataChanged?.Invoke(null, EventArgs.Empty);
        }

    }
}
