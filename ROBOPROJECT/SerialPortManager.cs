using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ROBOPROJECT
{
    internal class SerialPortManager
    {
        private static SerialPort _serialPort=new SerialPort();
        public static SerialPort mySerialPort //доступ к порту
            {
            get {return _serialPort;}
            }
        public static void OpenPort(string portName) //открытие порта
        {
           if (!_serialPort.IsOpen)
             {
                try
                {
                    _serialPort.PortName = portName;
                    _serialPort.Open();
                }
                catch
                {
                    MessageBox.Show("Порт, к которому вы пытаетесь подключиться, отключён. Попробуйте обновить порты!");
                }
             }
        }
        public static void ClosePort() //закрытие порта
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }
        public static void SerialPortReset() //сброс порта
        {

        }
    }
}