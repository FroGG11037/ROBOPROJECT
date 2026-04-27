namespace ROBOPROJECT
{
    partial class FormHold
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
            components = new System.ComponentModel.Container();
            groupBoxHold = new GroupBox();
            groupBoxMotorBottom = new GroupBox();
            radioButtonBackwardMotorBottom = new RadioButton();
            radioButtonForwardMotorBottom = new RadioButton();
            buttonHoldMotorBottom = new Button();
            groupBoxHoldCharacteristics = new GroupBox();
            textBoxInterval = new TextBox();
            textBoxStepsPerInterval = new TextBox();
            labelStepsPerInterval = new Label();
            buttonApply = new Button();
            labelInterval = new Label();
            groupBoxServoGripper = new GroupBox();
            trackBarServoGripperSpeed = new TrackBar();
            radioButtonBackwardServoGripper = new RadioButton();
            radioButtonForwardServoGripper = new RadioButton();
            buttonHoldServoGripper = new Button();
            groupBoxServoMiddle = new GroupBox();
            radioButtonBackwardServoMiddle = new RadioButton();
            radioButtonForwardServoMiddle = new RadioButton();
            buttonHoldServoMiddle = new Button();
            groupBoxMotorTop = new GroupBox();
            radioButtonBackwardMotorTop = new RadioButton();
            radioButtonForwardMotorTop = new RadioButton();
            buttonHoldMotorTop = new Button();
            groupBoxMotorMiddle = new GroupBox();
            radioButtonBackwardMotorMiddle = new RadioButton();
            radioButtonForwardMotorMiddle = new RadioButton();
            buttonHoldMotorMiddle = new Button();
            serialControl = new SerialControl();
            timerHold = new System.Windows.Forms.Timer(components);
            groupBoxHold.SuspendLayout();
            groupBoxMotorBottom.SuspendLayout();
            groupBoxHoldCharacteristics.SuspendLayout();
            groupBoxServoGripper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarServoGripperSpeed).BeginInit();
            groupBoxServoMiddle.SuspendLayout();
            groupBoxMotorTop.SuspendLayout();
            groupBoxMotorMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHold
            // 
            groupBoxHold.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxHold.Controls.Add(groupBoxMotorBottom);
            groupBoxHold.Controls.Add(groupBoxHoldCharacteristics);
            groupBoxHold.Controls.Add(groupBoxServoGripper);
            groupBoxHold.Controls.Add(groupBoxServoMiddle);
            groupBoxHold.Controls.Add(groupBoxMotorTop);
            groupBoxHold.Controls.Add(groupBoxMotorMiddle);
            groupBoxHold.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxHold.ForeColor = Color.Black;
            groupBoxHold.Location = new Point(630, 10);
            groupBoxHold.Name = "groupBoxHold";
            groupBoxHold.Size = new Size(500, 566);
            groupBoxHold.TabIndex = 3;
            groupBoxHold.TabStop = false;
            groupBoxHold.Text = "УПРАВЛЕНИЕ ПО ЗАЖАТИЮ";
            // 
            // groupBoxMotorBottom
            // 
            groupBoxMotorBottom.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorBottom.Controls.Add(radioButtonBackwardMotorBottom);
            groupBoxMotorBottom.Controls.Add(radioButtonForwardMotorBottom);
            groupBoxMotorBottom.Controls.Add(buttonHoldMotorBottom);
            groupBoxMotorBottom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorBottom.ForeColor = Color.Black;
            groupBoxMotorBottom.Location = new Point(5, 280);
            groupBoxMotorBottom.Name = "groupBoxMotorBottom";
            groupBoxMotorBottom.Size = new Size(240, 110);
            groupBoxMotorBottom.TabIndex = 13;
            groupBoxMotorBottom.TabStop = false;
            groupBoxMotorBottom.Text = "НИЖНИЙ МОТОР";
            // 
            // radioButtonBackwardMotorBottom
            // 
            radioButtonBackwardMotorBottom.AutoSize = true;
            radioButtonBackwardMotorBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonBackwardMotorBottom.Location = new Point(10, 70);
            radioButtonBackwardMotorBottom.Name = "radioButtonBackwardMotorBottom";
            radioButtonBackwardMotorBottom.Size = new Size(72, 25);
            radioButtonBackwardMotorBottom.TabIndex = 3;
            radioButtonBackwardMotorBottom.TabStop = true;
            radioButtonBackwardMotorBottom.Text = "Назад";
            radioButtonBackwardMotorBottom.UseVisualStyleBackColor = true;
            // 
            // radioButtonForwardMotorBottom
            // 
            radioButtonForwardMotorBottom.AutoSize = true;
            radioButtonForwardMotorBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonForwardMotorBottom.Location = new Point(10, 30);
            radioButtonForwardMotorBottom.Name = "radioButtonForwardMotorBottom";
            radioButtonForwardMotorBottom.Size = new Size(84, 25);
            radioButtonForwardMotorBottom.TabIndex = 2;
            radioButtonForwardMotorBottom.TabStop = true;
            radioButtonForwardMotorBottom.Text = "Вперёд";
            radioButtonForwardMotorBottom.UseVisualStyleBackColor = true;
            // 
            // buttonHoldMotorBottom
            // 
            buttonHoldMotorBottom.Cursor = Cursors.Hand;
            buttonHoldMotorBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHoldMotorBottom.ForeColor = Color.Black;
            buttonHoldMotorBottom.Location = new Point(100, 45);
            buttonHoldMotorBottom.Name = "buttonHoldMotorBottom";
            buttonHoldMotorBottom.Size = new Size(135, 50);
            buttonHoldMotorBottom.TabIndex = 1;
            buttonHoldMotorBottom.Text = "Зажмите";
            buttonHoldMotorBottom.UseVisualStyleBackColor = true;
            buttonHoldMotorBottom.MouseDown += buttonHoldMotorBottom_MouseDown;
            buttonHoldMotorBottom.MouseUp += buttonHoldMotorBottom_MouseUp;
            // 
            // groupBoxHoldCharacteristics
            // 
            groupBoxHoldCharacteristics.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxHoldCharacteristics.Controls.Add(textBoxInterval);
            groupBoxHoldCharacteristics.Controls.Add(textBoxStepsPerInterval);
            groupBoxHoldCharacteristics.Controls.Add(labelStepsPerInterval);
            groupBoxHoldCharacteristics.Controls.Add(buttonApply);
            groupBoxHoldCharacteristics.Controls.Add(labelInterval);
            groupBoxHoldCharacteristics.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxHoldCharacteristics.ForeColor = Color.Black;
            groupBoxHoldCharacteristics.Location = new Point(254, 340);
            groupBoxHoldCharacteristics.Name = "groupBoxHoldCharacteristics";
            groupBoxHoldCharacteristics.Size = new Size(240, 220);
            groupBoxHoldCharacteristics.TabIndex = 12;
            groupBoxHoldCharacteristics.TabStop = false;
            groupBoxHoldCharacteristics.Text = "НАСТРОЙКА";
            // 
            // textBoxInterval
            // 
            textBoxInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxInterval.ForeColor = Color.Black;
            textBoxInterval.Location = new Point(5, 180);
            textBoxInterval.Name = "textBoxInterval";
            textBoxInterval.Size = new Size(90, 29);
            textBoxInterval.TabIndex = 5;
            // 
            // textBoxStepsPerInterval
            // 
            textBoxStepsPerInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxStepsPerInterval.ForeColor = Color.Black;
            textBoxStepsPerInterval.Location = new Point(5, 80);
            textBoxStepsPerInterval.Name = "textBoxStepsPerInterval";
            textBoxStepsPerInterval.Size = new Size(90, 29);
            textBoxStepsPerInterval.TabIndex = 3;
            // 
            // labelStepsPerInterval
            // 
            labelStepsPerInterval.AutoSize = true;
            labelStepsPerInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelStepsPerInterval.ForeColor = Color.Black;
            labelStepsPerInterval.Location = new Point(5, 25);
            labelStepsPerInterval.Name = "labelStepsPerInterval";
            labelStepsPerInterval.Size = new Size(151, 42);
            labelStepsPerInterval.TabIndex = 2;
            labelStepsPerInterval.Text = "Количество шагов\r\nза интервал: 10";
            // 
            // buttonApply
            // 
            buttonApply.Cursor = Cursors.Hand;
            buttonApply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonApply.ForeColor = Color.Black;
            buttonApply.Location = new Point(100, 90);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(135, 50);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Применить";
            buttonApply.UseVisualStyleBackColor = true;
            // 
            // labelInterval
            // 
            labelInterval.AutoSize = true;
            labelInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelInterval.ForeColor = Color.Black;
            labelInterval.Location = new Point(5, 125);
            labelInterval.Name = "labelInterval";
            labelInterval.Size = new Size(145, 42);
            labelInterval.TabIndex = 4;
            labelInterval.Text = "Значение\r\nинтервала: 100 мс";
            // 
            // groupBoxServoGripper
            // 
            groupBoxServoGripper.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoGripper.Controls.Add(trackBarServoGripperSpeed);
            groupBoxServoGripper.Controls.Add(radioButtonBackwardServoGripper);
            groupBoxServoGripper.Controls.Add(radioButtonForwardServoGripper);
            groupBoxServoGripper.Controls.Add(buttonHoldServoGripper);
            groupBoxServoGripper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoGripper.ForeColor = Color.Black;
            groupBoxServoGripper.Location = new Point(255, 150);
            groupBoxServoGripper.Name = "groupBoxServoGripper";
            groupBoxServoGripper.Size = new Size(240, 170);
            groupBoxServoGripper.TabIndex = 11;
            groupBoxServoGripper.TabStop = false;
            groupBoxServoGripper.Text = "ЗАХВАТ СЕРВО";
            // 
            // trackBarServoGripperSpeed
            // 
            trackBarServoGripperSpeed.LargeChange = 10;
            trackBarServoGripperSpeed.Location = new Point(6, 119);
            trackBarServoGripperSpeed.Maximum = 100;
            trackBarServoGripperSpeed.Name = "trackBarServoGripperSpeed";
            trackBarServoGripperSpeed.Size = new Size(230, 45);
            trackBarServoGripperSpeed.TabIndex = 4;
            trackBarServoGripperSpeed.Value = 1;
            // 
            // radioButtonBackwardServoGripper
            // 
            radioButtonBackwardServoGripper.AutoSize = true;
            radioButtonBackwardServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonBackwardServoGripper.Location = new Point(10, 70);
            radioButtonBackwardServoGripper.Name = "radioButtonBackwardServoGripper";
            radioButtonBackwardServoGripper.Size = new Size(72, 25);
            radioButtonBackwardServoGripper.TabIndex = 3;
            radioButtonBackwardServoGripper.TabStop = true;
            radioButtonBackwardServoGripper.Text = "Назад";
            radioButtonBackwardServoGripper.UseVisualStyleBackColor = true;
            // 
            // radioButtonForwardServoGripper
            // 
            radioButtonForwardServoGripper.AutoSize = true;
            radioButtonForwardServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonForwardServoGripper.Location = new Point(10, 30);
            radioButtonForwardServoGripper.Name = "radioButtonForwardServoGripper";
            radioButtonForwardServoGripper.Size = new Size(84, 25);
            radioButtonForwardServoGripper.TabIndex = 2;
            radioButtonForwardServoGripper.TabStop = true;
            radioButtonForwardServoGripper.Text = "Вперёд";
            radioButtonForwardServoGripper.UseVisualStyleBackColor = true;
            // 
            // buttonHoldServoGripper
            // 
            buttonHoldServoGripper.Cursor = Cursors.Hand;
            buttonHoldServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHoldServoGripper.ForeColor = Color.Black;
            buttonHoldServoGripper.Location = new Point(100, 45);
            buttonHoldServoGripper.Name = "buttonHoldServoGripper";
            buttonHoldServoGripper.Size = new Size(135, 50);
            buttonHoldServoGripper.TabIndex = 1;
            buttonHoldServoGripper.Text = "Зажмите";
            buttonHoldServoGripper.UseVisualStyleBackColor = true;
            // 
            // groupBoxServoMiddle
            // 
            groupBoxServoMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoMiddle.Controls.Add(radioButtonBackwardServoMiddle);
            groupBoxServoMiddle.Controls.Add(radioButtonForwardServoMiddle);
            groupBoxServoMiddle.Controls.Add(buttonHoldServoMiddle);
            groupBoxServoMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoMiddle.ForeColor = Color.Black;
            groupBoxServoMiddle.Location = new Point(255, 25);
            groupBoxServoMiddle.Name = "groupBoxServoMiddle";
            groupBoxServoMiddle.Size = new Size(240, 110);
            groupBoxServoMiddle.TabIndex = 10;
            groupBoxServoMiddle.TabStop = false;
            groupBoxServoMiddle.Text = "СРЕДНИЙ СЕРВО";
            // 
            // radioButtonBackwardServoMiddle
            // 
            radioButtonBackwardServoMiddle.AutoSize = true;
            radioButtonBackwardServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonBackwardServoMiddle.Location = new Point(10, 70);
            radioButtonBackwardServoMiddle.Name = "radioButtonBackwardServoMiddle";
            radioButtonBackwardServoMiddle.Size = new Size(72, 25);
            radioButtonBackwardServoMiddle.TabIndex = 3;
            radioButtonBackwardServoMiddle.TabStop = true;
            radioButtonBackwardServoMiddle.Text = "Назад";
            radioButtonBackwardServoMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButtonForwardServoMiddle
            // 
            radioButtonForwardServoMiddle.AutoSize = true;
            radioButtonForwardServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonForwardServoMiddle.Location = new Point(10, 30);
            radioButtonForwardServoMiddle.Name = "radioButtonForwardServoMiddle";
            radioButtonForwardServoMiddle.Size = new Size(84, 25);
            radioButtonForwardServoMiddle.TabIndex = 2;
            radioButtonForwardServoMiddle.TabStop = true;
            radioButtonForwardServoMiddle.Text = "Вперёд";
            radioButtonForwardServoMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonHoldServoMiddle
            // 
            buttonHoldServoMiddle.Cursor = Cursors.Hand;
            buttonHoldServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHoldServoMiddle.ForeColor = Color.Black;
            buttonHoldServoMiddle.Location = new Point(100, 45);
            buttonHoldServoMiddle.Name = "buttonHoldServoMiddle";
            buttonHoldServoMiddle.Size = new Size(135, 50);
            buttonHoldServoMiddle.TabIndex = 1;
            buttonHoldServoMiddle.Text = "Зажмите";
            buttonHoldServoMiddle.UseVisualStyleBackColor = true;
            // 
            // groupBoxMotorTop
            // 
            groupBoxMotorTop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorTop.Controls.Add(radioButtonBackwardMotorTop);
            groupBoxMotorTop.Controls.Add(radioButtonForwardMotorTop);
            groupBoxMotorTop.Controls.Add(buttonHoldMotorTop);
            groupBoxMotorTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorTop.ForeColor = Color.Black;
            groupBoxMotorTop.Location = new Point(5, 25);
            groupBoxMotorTop.Name = "groupBoxMotorTop";
            groupBoxMotorTop.Size = new Size(240, 110);
            groupBoxMotorTop.TabIndex = 9;
            groupBoxMotorTop.TabStop = false;
            groupBoxMotorTop.Text = "ВЕРХНИЙ МОТОР";
            // 
            // radioButtonBackwardMotorTop
            // 
            radioButtonBackwardMotorTop.AutoSize = true;
            radioButtonBackwardMotorTop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonBackwardMotorTop.Location = new Point(10, 70);
            radioButtonBackwardMotorTop.Name = "radioButtonBackwardMotorTop";
            radioButtonBackwardMotorTop.Size = new Size(72, 25);
            radioButtonBackwardMotorTop.TabIndex = 3;
            radioButtonBackwardMotorTop.TabStop = true;
            radioButtonBackwardMotorTop.Text = "Назад";
            radioButtonBackwardMotorTop.UseVisualStyleBackColor = true;
            // 
            // radioButtonForwardMotorTop
            // 
            radioButtonForwardMotorTop.AutoSize = true;
            radioButtonForwardMotorTop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonForwardMotorTop.Location = new Point(10, 30);
            radioButtonForwardMotorTop.Name = "radioButtonForwardMotorTop";
            radioButtonForwardMotorTop.Size = new Size(84, 25);
            radioButtonForwardMotorTop.TabIndex = 2;
            radioButtonForwardMotorTop.TabStop = true;
            radioButtonForwardMotorTop.Text = "Вперёд";
            radioButtonForwardMotorTop.UseVisualStyleBackColor = true;
            // 
            // buttonHoldMotorTop
            // 
            buttonHoldMotorTop.Cursor = Cursors.Hand;
            buttonHoldMotorTop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHoldMotorTop.ForeColor = Color.Black;
            buttonHoldMotorTop.Location = new Point(100, 45);
            buttonHoldMotorTop.Name = "buttonHoldMotorTop";
            buttonHoldMotorTop.Size = new Size(135, 50);
            buttonHoldMotorTop.TabIndex = 1;
            buttonHoldMotorTop.Text = "Зажмите";
            buttonHoldMotorTop.UseVisualStyleBackColor = true;
            buttonHoldMotorTop.MouseDown += buttonHoldMotorTop_MouseDown;
            buttonHoldMotorTop.MouseUp += buttonHoldMotorTop_MouseUp;
            // 
            // groupBoxMotorMiddle
            // 
            groupBoxMotorMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorMiddle.Controls.Add(radioButtonBackwardMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(radioButtonForwardMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(buttonHoldMotorMiddle);
            groupBoxMotorMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorMiddle.ForeColor = Color.Black;
            groupBoxMotorMiddle.Location = new Point(5, 150);
            groupBoxMotorMiddle.Name = "groupBoxMotorMiddle";
            groupBoxMotorMiddle.Size = new Size(240, 110);
            groupBoxMotorMiddle.TabIndex = 8;
            groupBoxMotorMiddle.TabStop = false;
            groupBoxMotorMiddle.Text = "СРЕДНИЙ МОТОР";
            // 
            // radioButtonBackwardMotorMiddle
            // 
            radioButtonBackwardMotorMiddle.AutoSize = true;
            radioButtonBackwardMotorMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonBackwardMotorMiddle.Location = new Point(10, 70);
            radioButtonBackwardMotorMiddle.Name = "radioButtonBackwardMotorMiddle";
            radioButtonBackwardMotorMiddle.Size = new Size(72, 25);
            radioButtonBackwardMotorMiddle.TabIndex = 3;
            radioButtonBackwardMotorMiddle.TabStop = true;
            radioButtonBackwardMotorMiddle.Text = "Назад";
            radioButtonBackwardMotorMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButtonForwardMotorMiddle
            // 
            radioButtonForwardMotorMiddle.AutoSize = true;
            radioButtonForwardMotorMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonForwardMotorMiddle.Location = new Point(10, 30);
            radioButtonForwardMotorMiddle.Name = "radioButtonForwardMotorMiddle";
            radioButtonForwardMotorMiddle.Size = new Size(84, 25);
            radioButtonForwardMotorMiddle.TabIndex = 2;
            radioButtonForwardMotorMiddle.TabStop = true;
            radioButtonForwardMotorMiddle.Text = "Вперёд";
            radioButtonForwardMotorMiddle.UseVisualStyleBackColor = true;
            // 
            // buttonHoldMotorMiddle
            // 
            buttonHoldMotorMiddle.Cursor = Cursors.Hand;
            buttonHoldMotorMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHoldMotorMiddle.ForeColor = Color.Black;
            buttonHoldMotorMiddle.Location = new Point(100, 45);
            buttonHoldMotorMiddle.Name = "buttonHoldMotorMiddle";
            buttonHoldMotorMiddle.Size = new Size(135, 50);
            buttonHoldMotorMiddle.TabIndex = 1;
            buttonHoldMotorMiddle.Text = "Зажмите";
            buttonHoldMotorMiddle.UseVisualStyleBackColor = true;
            buttonHoldMotorMiddle.MouseDown += buttonHoldMotorMiddle_MouseDown;
            buttonHoldMotorMiddle.MouseUp += buttonHoldMotorMiddle_MouseUp;
            // 
            // serialControl
            // 
            serialControl.Location = new Point(10, 10);
            serialControl.Name = "serialControl";
            serialControl.Size = new Size(600, 450);
            serialControl.TabIndex = 4;
            // 
            // FormHold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 251);
            ClientSize = new Size(1284, 601);
            Controls.Add(serialControl);
            Controls.Add(groupBoxHold);
            Name = "FormHold";
            Text = "FormHold";
            groupBoxHold.ResumeLayout(false);
            groupBoxMotorBottom.ResumeLayout(false);
            groupBoxMotorBottom.PerformLayout();
            groupBoxHoldCharacteristics.ResumeLayout(false);
            groupBoxHoldCharacteristics.PerformLayout();
            groupBoxServoGripper.ResumeLayout(false);
            groupBoxServoGripper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarServoGripperSpeed).EndInit();
            groupBoxServoMiddle.ResumeLayout(false);
            groupBoxServoMiddle.PerformLayout();
            groupBoxMotorTop.ResumeLayout(false);
            groupBoxMotorTop.PerformLayout();
            groupBoxMotorMiddle.ResumeLayout(false);
            groupBoxMotorMiddle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxHold;
        private GroupBox groupBoxMotorMiddle;
        private RadioButton radioButtonBackwardMotorMiddle;
        private RadioButton radioButtonForwardMotorMiddle;
        private Button buttonHoldMotorMiddle;
        private GroupBox groupBoxMotorTop;
        private RadioButton radioButtonBackwardMotorTop;
        private RadioButton radioButtonForwardMotorTop;
        private Button buttonHoldMotorTop;
        private GroupBox groupBoxServoGripper;
        private RadioButton radioButtonBackwardServoGripper;
        private RadioButton radioButtonForwardServoGripper;
        private Button buttonHoldServoGripper;
        private GroupBox groupBoxServoMiddle;
        private RadioButton radioButtonBackwardServoMiddle;
        private RadioButton radioButtonForwardServoMiddle;
        private Button buttonHoldServoMiddle;
        private GroupBox groupBoxHoldCharacteristics;
        private TextBox textBoxInterval;
        private Label labelInterval;
        private TextBox textBoxStepsPerInterval;
        private Label labelStepsPerInterval;
        private Button buttonApply;
        private GroupBox groupBoxMotorBottom;
        private RadioButton radioButtonBackwardMotorBottom;
        private RadioButton radioButtonForwardMotorBottom;
        private Button buttonHoldMotorBottom;
        private SerialControl serialControl;
        private TrackBar trackBarServoGripperSpeed;
        private System.Windows.Forms.Timer timerHold;
    }
}