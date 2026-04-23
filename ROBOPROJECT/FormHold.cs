using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ROBOPROJECT
{
    public partial class FormHold : Form
    {
        public FormHold()
        {
            InitializeComponent();
            timerHold.Tick += TimerTick;
        }
        char Sender = '0';
        int stepsPerInterval = 10;
        private void buttonHoldMotorBottom_KeyDown(object sender, KeyEventArgs e)
        {
           Sender= 'B';
            timerHold.Start();
        }

        private void buttonHoldMotorBottom_KeyUp(object sender, KeyEventArgs e)
        {
            timerHold.Stop();
            Sender = '0';
        }

        private void buttonHoldMotorMiddle_KeyDown(object sender, KeyEventArgs e)
        {
            Sender = 'M';
            timerHold.Start();
        }

        private void buttonHoldMotorMiddle_KeyUp(object sender, KeyEventArgs e)
        {
            timerHold.Stop();
            Sender = '0';
        }

        private void buttonHoldMotorTop_KeyDown(object sender, KeyEventArgs e)
        {
            Sender = 'T';
            timerHold.Start();
        }

        private void buttonHoldMotorTop_KeyUp(object sender, KeyEventArgs e)
        {
            timerHold.Stop();
            Sender = '0';
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                switch (Sender)
                {
                    case 'B':
                        if (radioButtonForwardMotorBottom.Checked) 
                       SerialPortManager.mySerialPort.WriteLine($"Z{stepsPerInterval}");
                        if (radioButtonBackwardMotorBottom.Checked)
                        SerialPortManager.mySerialPort.WriteLine($"Z-{stepsPerInterval}");
                        break;
                    case 'M':
                        if (radioButtonForwardMotorMiddle.Checked)
                            SerialPortManager.mySerialPort.WriteLine($"A{stepsPerInterval}");
                        if (radioButtonBackwardMotorMiddle.Checked)
                            SerialPortManager.mySerialPort.WriteLine($"A-{stepsPerInterval}");
                        break;
                    case 'T':
                        if (radioButtonForwardMotorTop.Checked)
                            SerialPortManager.mySerialPort.WriteLine($"Q{stepsPerInterval}");
                        if (radioButtonBackwardMotorTop.Checked)
                            SerialPortManager.mySerialPort.WriteLine($"Q-{stepsPerInterval}");
                        break;
                }
            }
        }
    }
}
