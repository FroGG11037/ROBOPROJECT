using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ROBOPROJECT
{
    public partial class FormRecord : Form
    {
        public FormRecord()
        {
            InitializeComponent(); 
            LoadRecords();
        }
        private void LoadRecords() //загрузка сохранённых данных
        {
            foreach (var record in SerialPortData.SavedRecords)
            {
                dataGridViewRecord.Rows.Add(record.Bottom,record.Middle,record.Top);
            }
        } 
        private void buttonRecord_Click(object sender, EventArgs e)
        {
            var record = new SerialPortData.RecordItem
            {
                Bottom = SerialPortData.MotorBottom,
                Middle = SerialPortData.MotorMiddle,
                Top = SerialPortData.MotorTop
            };
            SerialPortData.SavedRecords.Add(record);
            dataGridViewRecord.Rows.Add(record.Bottom, record.Middle, record.Top);
            dataGridViewRecord.FirstDisplayedScrollingRowIndex = dataGridViewRecord.Rows.Count - 1;
        }
    }
}
