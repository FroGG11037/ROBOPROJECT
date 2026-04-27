namespace ROBOPROJECT
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            serialControl = new SerialControl();
            groupBoxRecord = new GroupBox();
            dataGridViewRecord = new DataGridView();
            ColumnMotorBottom = new DataGridViewTextBoxColumn();
            ColumnMotorMiddle = new DataGridViewTextBoxColumn();
            ColumnMotorTop = new DataGridViewTextBoxColumn();
            ColumnTime = new DataGridViewTextBoxColumn();
            buttonRecord = new Button();
            groupBoxRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).BeginInit();
            SuspendLayout();
            // 
            // serialControl
            // 
            serialControl.Location = new Point(10, 10);
            serialControl.Name = "serialControl";
            serialControl.Size = new Size(600, 450);
            serialControl.TabIndex = 0;
            // 
            // groupBoxRecord
            // 
            groupBoxRecord.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxRecord.Controls.Add(buttonRecord);
            groupBoxRecord.Controls.Add(dataGridViewRecord);
            groupBoxRecord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRecord.ForeColor = Color.Black;
            groupBoxRecord.Location = new Point(630, 10);
            groupBoxRecord.Name = "groupBoxRecord";
            groupBoxRecord.Size = new Size(567, 566);
            groupBoxRecord.TabIndex = 4;
            groupBoxRecord.TabStop = false;
            groupBoxRecord.Text = "ЗАПИСЬ ПОСЛЕДОВАТЕЛЬНЫХ ДЕЙСТВИЙ";
            // 
            // dataGridViewRecord
            // 
            dataGridViewRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecord.Columns.AddRange(new DataGridViewColumn[] { ColumnMotorBottom, ColumnMotorMiddle, ColumnMotorTop, ColumnTime });
            dataGridViewRecord.Location = new Point(6, 28);
            dataGridViewRecord.Name = "dataGridViewRecord";
            dataGridViewRecord.Size = new Size(556, 449);
            dataGridViewRecord.TabIndex = 0;
            // 
            // ColumnMotorBottom
            // 
            ColumnMotorBottom.HeaderText = " Нижний мотор";
            ColumnMotorBottom.Name = "ColumnMotorBottom";
            // 
            // ColumnMotorMiddle
            // 
            ColumnMotorMiddle.HeaderText = "Средний мотор";
            ColumnMotorMiddle.Name = "ColumnMotorMiddle";
            // 
            // ColumnMotorTop
            // 
            ColumnMotorTop.HeaderText = "Верхний мотор";
            ColumnMotorTop.Name = "ColumnMotorTop";
            // 
            // ColumnTime
            // 
            ColumnTime.HeaderText = "Время";
            ColumnTime.Name = "ColumnTime";
            // 
            // buttonRecord
            // 
            buttonRecord.Cursor = Cursors.Hand;
            buttonRecord.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRecord.ForeColor = Color.Black;
            buttonRecord.Location = new Point(6, 510);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(135, 50);
            buttonRecord.TabIndex = 2;
            buttonRecord.Text = "Записать";
            buttonRecord.UseVisualStyleBackColor = true;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // FormRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 251);
            ClientSize = new Size(1284, 601);
            Controls.Add(groupBoxRecord);
            Controls.Add(serialControl);
            Name = "FormRecord";
            Text = "FormRecord";
            groupBoxRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SerialControl serialControl;
        private GroupBox groupBoxRecord;
        private DataGridView dataGridViewRecord;
        private DataGridViewTextBoxColumn ColumnMotorBottom;
        private DataGridViewTextBoxColumn ColumnMotorMiddle;
        private DataGridViewTextBoxColumn ColumnMotorTop;
        private DataGridViewTextBoxColumn ColumnTime;
        private Button buttonRecord;
    }
}