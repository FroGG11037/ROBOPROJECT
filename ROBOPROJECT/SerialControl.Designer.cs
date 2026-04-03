namespace ROBOPROJECT
{
    partial class SerialControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxConnection = new GroupBox();
            comboBoxPorts = new ComboBox();
            buttonStop = new Button();
            buttonUpdate = new Button();
            buttonConnect = new Button();
            groupBoxCharacteristics = new GroupBox();
            textBoxAcceleration = new TextBox();
            labelAcceleration = new Label();
            textBoxMaxSpeed = new TextBox();
            labelMaxSpeed = new Label();
            buttonApply = new Button();
            groupBoxData = new GroupBox();
            buttonResetData = new Button();
            groupBoxMotorTop = new GroupBox();
            labelMotorTopData = new Label();
            groupBoxMotorMiddle = new GroupBox();
            labelMotorMiddleData = new Label();
            groupBoxMotorBottom = new GroupBox();
            labelMotorBottomData = new Label();
            groupBoxServoMiddle = new GroupBox();
            labelServoMiddleData = new Label();
            groupBoxServo = new GroupBox();
            labelServoData = new Label();
            groupBoxConnection.SuspendLayout();
            groupBoxCharacteristics.SuspendLayout();
            groupBoxData.SuspendLayout();
            groupBoxMotorTop.SuspendLayout();
            groupBoxMotorMiddle.SuspendLayout();
            groupBoxMotorBottom.SuspendLayout();
            groupBoxServoMiddle.SuspendLayout();
            groupBoxServo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxConnection
            // 
            groupBoxConnection.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxConnection.Controls.Add(comboBoxPorts);
            groupBoxConnection.Controls.Add(buttonStop);
            groupBoxConnection.Controls.Add(buttonUpdate);
            groupBoxConnection.Controls.Add(buttonConnect);
            groupBoxConnection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxConnection.Location = new Point(0, 0);
            groupBoxConnection.Name = "groupBoxConnection";
            groupBoxConnection.Size = new Size(290, 200);
            groupBoxConnection.TabIndex = 0;
            groupBoxConnection.TabStop = false;
            groupBoxConnection.Text = "ПОДКЛЮЧЕНИЕ";
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxPorts.ForeColor = Color.Black;
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(5, 30);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(121, 29);
            comboBoxPorts.TabIndex = 3;
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStop.ForeColor = Color.Red;
            buttonStop.Location = new Point(135, 125);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(150, 70);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Экстренная\r\nостановка";
            buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(150, 70);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(135, 50);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            buttonConnect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonConnect.ForeColor = Color.Green;
            buttonConnect.Location = new Point(150, 15);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(135, 50);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // groupBoxCharacteristics
            // 
            groupBoxCharacteristics.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxCharacteristics.Controls.Add(textBoxAcceleration);
            groupBoxCharacteristics.Controls.Add(labelAcceleration);
            groupBoxCharacteristics.Controls.Add(textBoxMaxSpeed);
            groupBoxCharacteristics.Controls.Add(labelMaxSpeed);
            groupBoxCharacteristics.Controls.Add(buttonApply);
            groupBoxCharacteristics.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxCharacteristics.ForeColor = Color.Black;
            groupBoxCharacteristics.Location = new Point(0, 220);
            groupBoxCharacteristics.Name = "groupBoxCharacteristics";
            groupBoxCharacteristics.Size = new Size(320, 230);
            groupBoxCharacteristics.TabIndex = 1;
            groupBoxCharacteristics.TabStop = false;
            groupBoxCharacteristics.Text = "ХАРАКТЕРИСТИКИ";
            // 
            // textBoxAcceleration
            // 
            textBoxAcceleration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxAcceleration.ForeColor = Color.Black;
            textBoxAcceleration.Location = new Point(5, 190);
            textBoxAcceleration.Name = "textBoxAcceleration";
            textBoxAcceleration.Size = new Size(110, 29);
            textBoxAcceleration.TabIndex = 5;
            // 
            // labelAcceleration
            // 
            labelAcceleration.AutoSize = true;
            labelAcceleration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelAcceleration.ForeColor = Color.Black;
            labelAcceleration.Location = new Point(5, 130);
            labelAcceleration.Name = "labelAcceleration";
            labelAcceleration.Size = new Size(173, 42);
            labelAcceleration.TabIndex = 4;
            labelAcceleration.Text = "Ускорение\r\nв шагах/секунду²: 500";
            // 
            // textBoxMaxSpeed
            // 
            textBoxMaxSpeed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxMaxSpeed.ForeColor = Color.Black;
            textBoxMaxSpeed.Location = new Point(5, 85);
            textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            textBoxMaxSpeed.Size = new Size(110, 29);
            textBoxMaxSpeed.TabIndex = 3;
            // 
            // labelMaxSpeed
            // 
            labelMaxSpeed.AutoSize = true;
            labelMaxSpeed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelMaxSpeed.ForeColor = Color.Black;
            labelMaxSpeed.Location = new Point(5, 25);
            labelMaxSpeed.Name = "labelMaxSpeed";
            labelMaxSpeed.Size = new Size(195, 42);
            labelMaxSpeed.TabIndex = 2;
            labelMaxSpeed.Text = "Максимальная скорость\r\nв шагах: 1000";
            // 
            // buttonApply
            // 
            buttonApply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonApply.ForeColor = Color.Black;
            buttonApply.Location = new Point(180, 98);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(135, 50);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Применить";
            buttonApply.UseVisualStyleBackColor = true;
            // 
            // groupBoxData
            // 
            groupBoxData.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxData.Controls.Add(groupBoxServo);
            groupBoxData.Controls.Add(groupBoxServoMiddle);
            groupBoxData.Controls.Add(groupBoxMotorBottom);
            groupBoxData.Controls.Add(groupBoxMotorMiddle);
            groupBoxData.Controls.Add(groupBoxMotorTop);
            groupBoxData.Controls.Add(buttonResetData);
            groupBoxData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxData.ForeColor = Color.Black;
            groupBoxData.Location = new Point(345, 0);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(295, 395);
            groupBoxData.TabIndex = 2;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "ПОЛОЖЕНИЕ";
            // 
            // buttonResetData
            // 
            buttonResetData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonResetData.ForeColor = Color.Black;
            buttonResetData.Location = new Point(150, 335);
            buttonResetData.Name = "buttonResetData";
            buttonResetData.Size = new Size(135, 50);
            buttonResetData.TabIndex = 1;
            buttonResetData.Text = "Сбросить";
            buttonResetData.UseVisualStyleBackColor = true;
            // 
            // groupBoxMotorTop
            // 
            groupBoxMotorTop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorTop.Controls.Add(labelMotorTopData);
            groupBoxMotorTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorTop.ForeColor = Color.Black;
            groupBoxMotorTop.Location = new Point(5, 25);
            groupBoxMotorTop.Name = "groupBoxMotorTop";
            groupBoxMotorTop.Size = new Size(130, 110);
            groupBoxMotorTop.TabIndex = 5;
            groupBoxMotorTop.TabStop = false;
            groupBoxMotorTop.Text = "ВЕРХНИЙ МОТОР";
            // 
            // labelMotorTopData
            // 
            labelMotorTopData.AutoSize = true;
            labelMotorTopData.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMotorTopData.ForeColor = Color.Black;
            labelMotorTopData.Location = new Point(49, 50);
            labelMotorTopData.Name = "labelMotorTopData";
            labelMotorTopData.Size = new Size(32, 37);
            labelMotorTopData.TabIndex = 4;
            labelMotorTopData.Text = "0";
            // 
            // groupBoxMotorMiddle
            // 
            groupBoxMotorMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorMiddle.Controls.Add(labelMotorMiddleData);
            groupBoxMotorMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorMiddle.ForeColor = Color.Black;
            groupBoxMotorMiddle.Location = new Point(5, 150);
            groupBoxMotorMiddle.Name = "groupBoxMotorMiddle";
            groupBoxMotorMiddle.Size = new Size(130, 110);
            groupBoxMotorMiddle.TabIndex = 6;
            groupBoxMotorMiddle.TabStop = false;
            groupBoxMotorMiddle.Text = "СРЕДНИЙ МОТОР";
            // 
            // labelMotorMiddleData
            // 
            labelMotorMiddleData.AutoSize = true;
            labelMotorMiddleData.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMotorMiddleData.ForeColor = Color.Black;
            labelMotorMiddleData.Location = new Point(49, 50);
            labelMotorMiddleData.Name = "labelMotorMiddleData";
            labelMotorMiddleData.Size = new Size(32, 37);
            labelMotorMiddleData.TabIndex = 4;
            labelMotorMiddleData.Text = "0";
            // 
            // groupBoxMotorBottom
            // 
            groupBoxMotorBottom.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorBottom.Controls.Add(labelMotorBottomData);
            groupBoxMotorBottom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorBottom.ForeColor = Color.Black;
            groupBoxMotorBottom.Location = new Point(5, 275);
            groupBoxMotorBottom.Name = "groupBoxMotorBottom";
            groupBoxMotorBottom.Size = new Size(130, 110);
            groupBoxMotorBottom.TabIndex = 7;
            groupBoxMotorBottom.TabStop = false;
            groupBoxMotorBottom.Text = "СРЕДНИЙ МОТОР";
            // 
            // labelMotorBottomData
            // 
            labelMotorBottomData.AutoSize = true;
            labelMotorBottomData.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMotorBottomData.ForeColor = Color.Black;
            labelMotorBottomData.Location = new Point(49, 50);
            labelMotorBottomData.Name = "labelMotorBottomData";
            labelMotorBottomData.Size = new Size(32, 37);
            labelMotorBottomData.TabIndex = 4;
            labelMotorBottomData.Text = "0";
            // 
            // groupBoxServoMiddle
            // 
            groupBoxServoMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoMiddle.Controls.Add(labelServoMiddleData);
            groupBoxServoMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoMiddle.ForeColor = Color.Black;
            groupBoxServoMiddle.Location = new Point(155, 25);
            groupBoxServoMiddle.Name = "groupBoxServoMiddle";
            groupBoxServoMiddle.Size = new Size(130, 110);
            groupBoxServoMiddle.TabIndex = 8;
            groupBoxServoMiddle.TabStop = false;
            groupBoxServoMiddle.Text = "СРЕДНИЙ СЕРВО";
            // 
            // labelServoMiddleData
            // 
            labelServoMiddleData.AutoSize = true;
            labelServoMiddleData.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelServoMiddleData.ForeColor = Color.Black;
            labelServoMiddleData.Location = new Point(49, 50);
            labelServoMiddleData.Name = "labelServoMiddleData";
            labelServoMiddleData.Size = new Size(32, 37);
            labelServoMiddleData.TabIndex = 4;
            labelServoMiddleData.Text = "0";
            // 
            // groupBoxServo
            // 
            groupBoxServo.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServo.Controls.Add(labelServoData);
            groupBoxServo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServo.ForeColor = Color.Black;
            groupBoxServo.Location = new Point(155, 150);
            groupBoxServo.Name = "groupBoxServo";
            groupBoxServo.Size = new Size(130, 110);
            groupBoxServo.TabIndex = 9;
            groupBoxServo.TabStop = false;
            groupBoxServo.Text = "ЗАХВАТ СЕРВО";
            // 
            // labelServoData
            // 
            labelServoData.AutoSize = true;
            labelServoData.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelServoData.ForeColor = Color.Black;
            labelServoData.Location = new Point(49, 50);
            labelServoData.Name = "labelServoData";
            labelServoData.Size = new Size(32, 37);
            labelServoData.TabIndex = 4;
            labelServoData.Text = "0";
            // 
            // SerialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxData);
            Controls.Add(groupBoxCharacteristics);
            Controls.Add(groupBoxConnection);
            Name = "SerialControl";
            Size = new Size(640, 450);
            groupBoxConnection.ResumeLayout(false);
            groupBoxCharacteristics.ResumeLayout(false);
            groupBoxCharacteristics.PerformLayout();
            groupBoxData.ResumeLayout(false);
            groupBoxMotorTop.ResumeLayout(false);
            groupBoxMotorTop.PerformLayout();
            groupBoxMotorMiddle.ResumeLayout(false);
            groupBoxMotorMiddle.PerformLayout();
            groupBoxMotorBottom.ResumeLayout(false);
            groupBoxMotorBottom.PerformLayout();
            groupBoxServoMiddle.ResumeLayout(false);
            groupBoxServoMiddle.PerformLayout();
            groupBoxServo.ResumeLayout(false);
            groupBoxServo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxConnection;
        private Button buttonConnect;
        private Button buttonUpdate;
        private Button buttonStop;
        private ComboBox comboBoxPorts;
        private GroupBox groupBoxCharacteristics;
        private Button buttonApply;
        private TextBox textBoxMaxSpeed;
        private Label labelMaxSpeed;
        private TextBox textBoxAcceleration;
        private Label labelAcceleration;
        private GroupBox groupBoxData;
        private Button buttonResetData;
        private GroupBox groupBoxMotorTop;
        private Label labelMotorTopData;
        private GroupBox groupBoxMotorMiddle;
        private Label labelMotorMiddleData;
        private GroupBox groupBoxMotorBottom;
        private Label labelMotorBottomData;
        private GroupBox groupBoxServoMiddle;
        private Label labelServoMiddleData;
        private GroupBox groupBoxServo;
        private Label labelServoData;
    }
}
