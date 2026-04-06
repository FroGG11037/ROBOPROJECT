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
        public static bool IsPortOpen //проверка открыт ли порт
        {
           get { return _serialPort.IsOpen; }
        }
        public static void OpenPort(string portName) //открытие порта
        {
           if (!_serialPort.IsOpen)
                {
                    _serialPort.PortName = portName;
                    _serialPort.Open();
                }
        }
        public static void ClosePort() //закрытие порта
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }
    }
}