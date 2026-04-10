using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ROBOPROJECT
{
    public partial class SerialControl : UserControl
    {
        public SerialControl()
        {
            InitializeComponent();
            UpdatePortStatus();
            UpdateCharacteristics();
            UpdateData(null, EventArgs.Empty);
            SerialPortData.DataChanged += UpdateData;
            Disposed += Unsubscribtion;
        }
        uint oldMaxSpeed = 1000;
        uint oldAcceleration = 500;
        private void UpdatePortStatus() //обновление состояния кнопок подключения
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                comboBoxPorts.Enabled = false;
                groupBoxCharacteristics.Enabled = true;
                groupBoxData.Enabled = true;
                buttonConnect.Text = "Отключиться";
                buttonConnect.ForeColor = Color.Red;
                if (!comboBoxPorts.Items.Contains(SerialPortManager.mySerialPort.PortName))
                {
                    comboBoxPorts.Items.Add(SerialPortManager.mySerialPort.PortName);
                }
                comboBoxPorts.Text = SerialPortManager.mySerialPort.PortName;
            }
            else
            {
                comboBoxPorts.Enabled = true;
                groupBoxCharacteristics.Enabled = false;
                groupBoxData.Enabled = false;
                buttonConnect.Text = "Подключиться";
                buttonConnect.ForeColor = Color.Green;
            }
        }

        private void UpdateCharacteristics() //обновление состояния характеристик
        {
            labelMaxSpeed.Text = "Максимальная скорость\r\nв шагах: " + SerialPortData.MaxSpeed;
            labelAcceleration.Text = "Ускорение\r\nв шагах/секунду²: " + SerialPortData.Acceleration;
        }

        private void UpdateData(object sender, EventArgs e) //обновление состояния положения
        {
            labelMotorTopData.Text = SerialPortData.MotorTop.ToString();
            labelMotorMiddleData.Text = SerialPortData.MotorMiddle.ToString();
            labelMotorBottomData.Text = SerialPortData.MotorBottom.ToString();
            labelServoMiddleData.Text = SerialPortData.ServoMiddle.ToString();
            labelServoData.Text = SerialPortData.Servo.ToString();
        }

        private void Unsubscribtion(object sender, EventArgs e) //отписка от события при закрытии user control
        {
            SerialPortData.DataChanged -= UpdateData;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!SerialPortManager.mySerialPort.IsOpen)
            {
                if (!string.IsNullOrWhiteSpace(comboBoxPorts.Text))
                {
                    SerialPortManager.OpenPort(comboBoxPorts.Text);
                    MessageBox.Show("Подключено успешно!");
                    UpdatePortStatus();
                }
                else
                {
                    MessageBox.Show("Выберите порт!");
                }
            }
            else
            {
                SerialPortManager.ClosePort();
                MessageBox.Show("Отключено успешно!");
                UpdatePortStatus();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.Clear();
            if (ports.Length > 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Не удалось найти порты!");
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                string stop = "E";
                SerialPortManager.mySerialPort.WriteLine(stop);
                SerialPortData.ServoMiddle = 90;
                SerialPortData.Servo = 90;
            }
            else
            {
                MessageBox.Show("Проверьте подключение к порту!");
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (SerialPortManager.mySerialPort.IsOpen)
            {
                if (uint.TryParse(textBoxMaxSpeed.Text, out uint maxSpeed) && maxSpeed > 0 && maxSpeed != oldMaxSpeed)
                {
                    SerialPortManager.mySerialPort.WriteLine($"R{maxSpeed}");
                    SerialPortData.MaxSpeed = maxSpeed;
                    oldMaxSpeed = SerialPortData.MaxSpeed;
                    UpdateCharacteristics();
                }
                if (uint.TryParse(textBoxAcceleration.Text, out uint acceleration) && acceleration > 0 && acceleration != oldAcceleration)
                {
                    SerialPortManager.mySerialPort.WriteLine($"T{acceleration}");
                    SerialPortData.Acceleration = acceleration;
                    oldAcceleration = SerialPortData.Acceleration;
                    UpdateCharacteristics();
                }
            }
        }

        private void buttonResetData_Click(object sender, EventArgs e)
        {
            SerialPortData.ResetMotors();
        }
    }
}