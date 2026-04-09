namespace ROBOPROJECT
{
    partial class FormManual
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
            groupBoxManual = new GroupBox();
            groupBoxMotorBottom = new GroupBox();
            radioButtonBackwardMotorBottom = new RadioButton();
            radioButtonForwardMotorBottom = new RadioButton();
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
            buttonManualMotors = new Button();
            groupBoxMotorMiddle = new GroupBox();
            radioButtonBackwardMotorMiddle = new RadioButton();
            radioButtonForwardMotorMiddle = new RadioButton();
            textBoxMaxSpeed = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBoxManual.SuspendLayout();
            groupBoxMotorBottom.SuspendLayout();
            groupBoxServoGripper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarServoGripperSpeed).BeginInit();
            groupBoxServoMiddle.SuspendLayout();
            groupBoxMotorTop.SuspendLayout();
            groupBoxMotorMiddle.SuspendLayout();
            SuspendLayout();
            // 
            // serialControl
            // 
            serialControl.Location = new Point(10, 10);
            serialControl.Name = "serialControl";
            serialControl.Size = new Size(600, 450);
            serialControl.TabIndex = 0;
            // 
            // groupBoxManual
            // 
            groupBoxManual.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxManual.Controls.Add(groupBoxMotorBottom);
            groupBoxManual.Controls.Add(groupBoxServoGripper);
            groupBoxManual.Controls.Add(buttonManualMotors);
            groupBoxManual.Controls.Add(groupBoxServoMiddle);
            groupBoxManual.Controls.Add(groupBoxMotorTop);
            groupBoxManual.Controls.Add(groupBoxMotorMiddle);
            groupBoxManual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxManual.ForeColor = Color.Black;
            groupBoxManual.Location = new Point(626, 12);
            groupBoxManual.Name = "groupBoxManual";
            groupBoxManual.Size = new Size(500, 585);
            groupBoxManual.TabIndex = 4;
            groupBoxManual.TabStop = false;
            groupBoxManual.Text = "РУЧНОЕ УПРАВЛЕНИЕ";
            // 
            // groupBoxMotorBottom
            // 
            groupBoxMotorBottom.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorBottom.Controls.Add(textBox2);
            groupBoxMotorBottom.Controls.Add(radioButtonBackwardMotorBottom);
            groupBoxMotorBottom.Controls.Add(radioButtonForwardMotorBottom);
            groupBoxMotorBottom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorBottom.ForeColor = Color.Black;
            groupBoxMotorBottom.Location = new Point(5, 280);
            groupBoxMotorBottom.Name = "groupBoxMotorBottom";
            groupBoxMotorBottom.Size = new Size(213, 110);
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
            // groupBoxServoGripper
            // 
            groupBoxServoGripper.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoGripper.Controls.Add(trackBarServoGripperSpeed);
            groupBoxServoGripper.Controls.Add(radioButtonBackwardServoGripper);
            groupBoxServoGripper.Controls.Add(radioButtonForwardServoGripper);
            groupBoxServoGripper.Controls.Add(buttonHoldServoGripper);
            groupBoxServoGripper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoGripper.ForeColor = Color.Black;
            groupBoxServoGripper.Location = new Point(251, 395);
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
            groupBoxServoMiddle.Location = new Point(5, 415);
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
            groupBoxMotorTop.Controls.Add(textBoxMaxSpeed);
            groupBoxMotorTop.Controls.Add(radioButtonBackwardMotorTop);
            groupBoxMotorTop.Controls.Add(radioButtonForwardMotorTop);
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
            // buttonManualMotors
            // 
            buttonManualMotors.Cursor = Cursors.Hand;
            buttonManualMotors.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualMotors.ForeColor = Color.Black;
            buttonManualMotors.Location = new Point(240, 207);
            buttonManualMotors.Name = "buttonManualMotors";
            buttonManualMotors.Size = new Size(135, 50);
            buttonManualMotors.TabIndex = 1;
            buttonManualMotors.Text = "Выполнить";
            buttonManualMotors.UseVisualStyleBackColor = true;
            // 
            // groupBoxMotorMiddle
            // 
            groupBoxMotorMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorMiddle.Controls.Add(textBox1);
            groupBoxMotorMiddle.Controls.Add(radioButtonBackwardMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(radioButtonForwardMotorMiddle);
            groupBoxMotorMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorMiddle.ForeColor = Color.Black;
            groupBoxMotorMiddle.Location = new Point(5, 150);
            groupBoxMotorMiddle.Name = "groupBoxMotorMiddle";
            groupBoxMotorMiddle.Size = new Size(190, 110);
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
            // textBoxMaxSpeed
            // 
            textBoxMaxSpeed.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxMaxSpeed.ForeColor = Color.Black;
            textBoxMaxSpeed.Location = new Point(100, 45);
            textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            textBoxMaxSpeed.Size = new Size(90, 29);
            textBoxMaxSpeed.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(88, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 29);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(100, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(90, 29);
            textBox2.TabIndex = 4;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 251);
            ClientSize = new Size(1204, 601);
            Controls.Add(groupBoxManual);
            Controls.Add(serialControl);
            Name = "FormManual";
            Text = "FormManual";
            groupBoxManual.ResumeLayout(false);
            groupBoxMotorBottom.ResumeLayout(false);
            groupBoxMotorBottom.PerformLayout();
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

        private SerialControl serialControl;
        private GroupBox groupBoxManual;
        private GroupBox groupBoxMotorBottom;
        private RadioButton radioButtonBackwardMotorBottom;
        private RadioButton radioButtonForwardMotorBottom;
        private Button buttonHoldMotorBottom;
        private GroupBox groupBoxHoldCharacteristics;
        private TextBox textBoxInterval;
        private TextBox textBoxStepsPerInterval;
        private Label labelStepsPerInterval;
        private Button buttonApply;
        private Label labelInterval;
        private GroupBox groupBoxServoGripper;
        private TrackBar trackBarServoGripperSpeed;
        private RadioButton radioButtonBackwardServoGripper;
        private RadioButton radioButtonForwardServoGripper;
        private Button buttonHoldServoGripper;
        private GroupBox groupBoxServoMiddle;
        private RadioButton radioButtonBackwardServoMiddle;
        private RadioButton radioButtonForwardServoMiddle;
        private Button buttonHoldServoMiddle;
        private GroupBox groupBoxMotorTop;
        private RadioButton radioButtonBackwardMotorTop;
        private RadioButton radioButtonForwardMotorTop;
        private Button buttonManualMotors;
        private GroupBox groupBoxMotorMiddle;
        private RadioButton radioButtonBackwardMotorMiddle;
        private RadioButton radioButtonForwardMotorMiddle;
        private TextBox textBox2;
        private TextBox textBoxMaxSpeed;
        private TextBox textBox1;
        private Button buttonHoldMotorMiddle;
    }
}