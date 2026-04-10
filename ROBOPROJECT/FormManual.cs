using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ROBOPROJECT
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }
        uint oldValueServoMiddle = 90;
        uint oldValueServoGripper = 90;

        private void buttonManualMotorBottom_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxStepsMotorBottom.Text, out uint valueMotorBottom) && valueMotorBottom != 0)
                {
                    if (radioButtonForwardMotorBottom.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"Z{valueMotorBottom}");
                        SerialPortData.MotorBottom = (int)valueMotorBottom;
                    }
                    if (radioButtonBackwardMotorBottom.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"Z-{valueMotorBottom}");
                        SerialPortData.MotorBottom = (int)-valueMotorBottom;
                    }
                }
            }
        }

        private void buttonManualMotorMiddle_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxStepsMotorMiddle.Text, out uint valueMotorMiddle) && valueMotorMiddle != 0)
                {
                    if (radioButtonForwardMotorMiddle.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"A{valueMotorMiddle}");
                        SerialPortData.MotorMiddle = (int)valueMotorMiddle;
                    }
                    if (radioButtonBackwardMotorMiddle.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"A-{valueMotorMiddle}");
                        SerialPortData.MotorMiddle = (int)-valueMotorMiddle;
                    }
                }
            }
        }

        private void buttonManualMotorTop_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxStepsMotorTop.Text, out uint valueMotorTop) && valueMotorTop != 0)
                {
                    if (radioButtonForwardMotorTop.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"Q{valueMotorTop}");
                        SerialPortData.MotorTop = (int)valueMotorTop;
                    }
                    if (radioButtonBackwardMotorTop.Checked)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"Q-{valueMotorTop}");
                        SerialPortData.MotorTop = (int)-valueMotorTop;
                    }
                }
            }
        }

        private void buttonManualServoMiddle_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxValueServoMiddle.Text, out uint valueServoMiddle) && valueServoMiddle <= 90)
                {
                    if (radioButtonLeftServoMiddle.Checked && valueServoMiddle != oldValueServoMiddle)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"W{valueServoMiddle}");
                        SerialPortData.ServoMiddle = valueServoMiddle;
                        oldValueServoMiddle = SerialPortData.ServoMiddle;
                    }
                    if (radioButtonRightServoMiddle.Checked && valueServoMiddle + 90 != oldValueServoMiddle)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"W{valueServoMiddle + 90}");
                        SerialPortData.ServoMiddle = valueServoMiddle + 90;
                        oldValueServoMiddle = SerialPortData.ServoMiddle;
                    }
                }
            }
        }

        private void buttonManualServoGripper_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxValueServoGripper.Text, out uint valueServoGripper) && valueServoGripper <= 90)
                {
                    if (radioButtonCloseServoGripper.Checked && valueServoGripper != oldValueServoGripper)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"S{valueServoGripper}");
                        SerialPortData.Servo = valueServoGripper;
                        oldValueServoGripper = SerialPortData.Servo;
                    }
                    if (radioButtonOpenServoGripper.Checked && valueServoGripper + 90 != oldValueServoGripper)
                    {
                        SerialPortManager.mySerialPort.WriteLine($"S{valueServoGripper + 90}");
                        SerialPortData.Servo = valueServoGripper + 90;
                        oldValueServoGripper = SerialPortData.Servo;
                    }
                }
            }
        }

        private void buttonManualStopServoGripper_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (oldValueServoGripper != 90)
                {
                    SerialPortManager.mySerialPort.WriteLine("S90");
                    SerialPortData.Servo = 90;
                    oldValueServoGripper = SerialPortData.Servo;
                }
            }
        }

        private void buttonExecuteAll_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                buttonManualMotorBottom_Click(this, EventArgs.Empty);
                buttonManualMotorMiddle_Click(this, EventArgs.Empty);
                buttonManualMotorTop_Click(this, EventArgs.Empty);
                buttonManualServoMiddle_Click(this, EventArgs.Empty);
                buttonManualServoGripper_Click(this, EventArgs.Empty);
                if (checkBoxManualStopServoGripper.Checked&& int.TryParse(comboBoxInterval.Text, out int interval))
                {
                    timerStop.Interval = interval;
                    timerStop.Tick += TimerTick;
                    timerStop.Start();
                }
            }
        }

        private void TimerTick(object sender, EventArgs e) //остановка захвата по таймеру
        {
            timerStop.Stop();
            timerStop.Tick -= TimerTick;
            buttonManualStopServoGripper_Click(this, EventArgs.Empty);
        }

        private void checkBoxManualStopServoGripper_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManualStopServoGripper.Checked)
            {
                groupBoxStop.Enabled=true;
                comboBoxInterval.SelectedIndex = 0;
            }
            else
            {
                groupBoxStop.Enabled = false;
            }
        }
    }
}