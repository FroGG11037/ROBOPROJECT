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
            components = new System.ComponentModel.Container();
            serialControl = new SerialControl();
            groupBoxManual = new GroupBox();
            groupBoxExecuteAll = new GroupBox();
            buttonExecuteAll = new Button();
            checkBoxManualStopServoGripper = new CheckBox();
            groupBoxStop = new GroupBox();
            comboBoxInterval = new ComboBox();
            labelStop = new Label();
            groupBoxServoGripper = new GroupBox();
            buttonManualStopServoGripper = new Button();
            textBoxValueServoGripper = new TextBox();
            buttonManualServoGripper = new Button();
            radioButtonCloseServoGripper = new RadioButton();
            radioButtonOpenServoGripper = new RadioButton();
            labelValueServoGripper = new Label();
            groupBoxServoMiddle = new GroupBox();
            radioButtonRightServoMiddle = new RadioButton();
            radioButtonLeftServoMiddle = new RadioButton();
            textBoxValueServoMiddle = new TextBox();
            buttonManualServoMiddle = new Button();
            labelValueServoMiddle = new Label();
            groupBoxMotorTop = new GroupBox();
            radioButtonBackwardMotorTop = new RadioButton();
            radioButtonForwardMotorTop = new RadioButton();
            textBoxStepsMotorTop = new TextBox();
            buttonManualMotorTop = new Button();
            groupBoxMotorMiddle = new GroupBox();
            radioButtonBackwardMotorMiddle = new RadioButton();
            radioButtonForwardMotorMiddle = new RadioButton();
            textBoxStepsMotorMiddle = new TextBox();
            buttonManualMotorMiddle = new Button();
            groupBoxMotorBottom = new GroupBox();
            radioButtonBackwardMotorBottom = new RadioButton();
            radioButtonForwardMotorBottom = new RadioButton();
            textBoxStepsMotorBottom = new TextBox();
            buttonManualMotorBottom = new Button();
            timerStop = new System.Windows.Forms.Timer(components);
            groupBoxManual.SuspendLayout();
            groupBoxExecuteAll.SuspendLayout();
            groupBoxStop.SuspendLayout();
            groupBoxServoGripper.SuspendLayout();
            groupBoxServoMiddle.SuspendLayout();
            groupBoxMotorTop.SuspendLayout();
            groupBoxMotorMiddle.SuspendLayout();
            groupBoxMotorBottom.SuspendLayout();
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
            groupBoxManual.Controls.Add(groupBoxExecuteAll);
            groupBoxManual.Controls.Add(groupBoxServoGripper);
            groupBoxManual.Controls.Add(groupBoxServoMiddle);
            groupBoxManual.Controls.Add(groupBoxMotorTop);
            groupBoxManual.Controls.Add(groupBoxMotorMiddle);
            groupBoxManual.Controls.Add(groupBoxMotorBottom);
            groupBoxManual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxManual.ForeColor = Color.Black;
            groupBoxManual.Location = new Point(630, 10);
            groupBoxManual.Name = "groupBoxManual";
            groupBoxManual.Size = new Size(645, 450);
            groupBoxManual.TabIndex = 4;
            groupBoxManual.TabStop = false;
            groupBoxManual.Text = "РУЧНОЕ УПРАВЛЕНИЕ";
            // 
            // groupBoxExecuteAll
            // 
            groupBoxExecuteAll.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxExecuteAll.Controls.Add(buttonExecuteAll);
            groupBoxExecuteAll.Controls.Add(checkBoxManualStopServoGripper);
            groupBoxExecuteAll.Controls.Add(groupBoxStop);
            groupBoxExecuteAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxExecuteAll.ForeColor = Color.Black;
            groupBoxExecuteAll.Location = new Point(330, 280);
            groupBoxExecuteAll.Name = "groupBoxExecuteAll";
            groupBoxExecuteAll.Size = new Size(310, 164);
            groupBoxExecuteAll.TabIndex = 21;
            groupBoxExecuteAll.TabStop = false;
            groupBoxExecuteAll.Text = "ВЫПОЛНИТЬ";
            // 
            // buttonExecuteAll
            // 
            buttonExecuteAll.Cursor = Cursors.Hand;
            buttonExecuteAll.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExecuteAll.ForeColor = Color.Black;
            buttonExecuteAll.Location = new Point(155, 90);
            buttonExecuteAll.Name = "buttonExecuteAll";
            buttonExecuteAll.Size = new Size(150, 70);
            buttonExecuteAll.TabIndex = 19;
            buttonExecuteAll.Text = "Выполнить одновременно";
            buttonExecuteAll.UseVisualStyleBackColor = true;
            buttonExecuteAll.Click += buttonExecuteAll_Click;
            // 
            // checkBoxManualStopServoGripper
            // 
            checkBoxManualStopServoGripper.AutoSize = true;
            checkBoxManualStopServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxManualStopServoGripper.Location = new Point(10, 25);
            checkBoxManualStopServoGripper.Name = "checkBoxManualStopServoGripper";
            checkBoxManualStopServoGripper.Size = new Size(281, 25);
            checkBoxManualStopServoGripper.TabIndex = 20;
            checkBoxManualStopServoGripper.Text = "Использовать остановку захвата?";
            checkBoxManualStopServoGripper.UseVisualStyleBackColor = true;
            checkBoxManualStopServoGripper.CheckedChanged += checkBoxManualStopServoGripper_CheckedChanged;
            // 
            // groupBoxStop
            // 
            groupBoxStop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxStop.Controls.Add(comboBoxInterval);
            groupBoxStop.Controls.Add(labelStop);
            groupBoxStop.Enabled = false;
            groupBoxStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxStop.ForeColor = Color.Black;
            groupBoxStop.Location = new Point(5, 35);
            groupBoxStop.Name = "groupBoxStop";
            groupBoxStop.Size = new Size(130, 125);
            groupBoxStop.TabIndex = 21;
            groupBoxStop.TabStop = false;
            // 
            // comboBoxInterval
            // 
            comboBoxInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxInterval.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            comboBoxInterval.ForeColor = Color.Black;
            comboBoxInterval.FormattingEnabled = true;
            comboBoxInterval.Items.AddRange(new object[] { "1000", "2000", "3000", "4000" });
            comboBoxInterval.Location = new Point(5, 15);
            comboBoxInterval.Name = "comboBoxInterval";
            comboBoxInterval.Size = new Size(121, 29);
            comboBoxInterval.TabIndex = 4;
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelStop.ForeColor = Color.Black;
            labelStop.Location = new Point(13, 50);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(105, 63);
            labelStop.TabIndex = 6;
            labelStop.Text = "Время в мс, \r\nкогда захват\r\nостановится";
            // 
            // groupBoxServoGripper
            // 
            groupBoxServoGripper.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoGripper.Controls.Add(buttonManualStopServoGripper);
            groupBoxServoGripper.Controls.Add(textBoxValueServoGripper);
            groupBoxServoGripper.Controls.Add(buttonManualServoGripper);
            groupBoxServoGripper.Controls.Add(radioButtonCloseServoGripper);
            groupBoxServoGripper.Controls.Add(radioButtonOpenServoGripper);
            groupBoxServoGripper.Controls.Add(labelValueServoGripper);
            groupBoxServoGripper.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoGripper.ForeColor = Color.Black;
            groupBoxServoGripper.Location = new Point(330, 155);
            groupBoxServoGripper.Name = "groupBoxServoGripper";
            groupBoxServoGripper.Size = new Size(310, 125);
            groupBoxServoGripper.TabIndex = 18;
            groupBoxServoGripper.TabStop = false;
            groupBoxServoGripper.Text = "ЗАХВАТ СЕРВО";
            // 
            // buttonManualStopServoGripper
            // 
            buttonManualStopServoGripper.Cursor = Cursors.Hand;
            buttonManualStopServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualStopServoGripper.ForeColor = Color.Red;
            buttonManualStopServoGripper.Location = new Point(195, 70);
            buttonManualStopServoGripper.Name = "buttonManualStopServoGripper";
            buttonManualStopServoGripper.Size = new Size(110, 50);
            buttonManualStopServoGripper.TabIndex = 4;
            buttonManualStopServoGripper.Text = "Остановить";
            buttonManualStopServoGripper.UseVisualStyleBackColor = true;
            buttonManualStopServoGripper.Click += buttonManualStopServoGripper_Click;
            // 
            // textBoxValueServoGripper
            // 
            textBoxValueServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxValueServoGripper.ForeColor = Color.Black;
            textBoxValueServoGripper.Location = new Point(100, 45);
            textBoxValueServoGripper.Name = "textBoxValueServoGripper";
            textBoxValueServoGripper.Size = new Size(90, 29);
            textBoxValueServoGripper.TabIndex = 3;
            // 
            // buttonManualServoGripper
            // 
            buttonManualServoGripper.Cursor = Cursors.Hand;
            buttonManualServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualServoGripper.ForeColor = Color.Black;
            buttonManualServoGripper.Location = new Point(195, 15);
            buttonManualServoGripper.Name = "buttonManualServoGripper";
            buttonManualServoGripper.Size = new Size(110, 50);
            buttonManualServoGripper.TabIndex = 1;
            buttonManualServoGripper.Text = "Вращать";
            buttonManualServoGripper.UseVisualStyleBackColor = true;
            buttonManualServoGripper.Click += buttonManualServoGripper_Click;
            // 
            // radioButtonCloseServoGripper
            // 
            radioButtonCloseServoGripper.AutoSize = true;
            radioButtonCloseServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonCloseServoGripper.Location = new Point(10, 30);
            radioButtonCloseServoGripper.Name = "radioButtonCloseServoGripper";
            radioButtonCloseServoGripper.Size = new Size(101, 25);
            radioButtonCloseServoGripper.TabIndex = 2;
            radioButtonCloseServoGripper.TabStop = true;
            radioButtonCloseServoGripper.Text = "Закрытие";
            radioButtonCloseServoGripper.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpenServoGripper
            // 
            radioButtonOpenServoGripper.AutoSize = true;
            radioButtonOpenServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonOpenServoGripper.Location = new Point(10, 70);
            radioButtonOpenServoGripper.Name = "radioButtonOpenServoGripper";
            radioButtonOpenServoGripper.Size = new Size(103, 25);
            radioButtonOpenServoGripper.TabIndex = 3;
            radioButtonOpenServoGripper.TabStop = true;
            radioButtonOpenServoGripper.Text = "Открытие";
            radioButtonOpenServoGripper.UseVisualStyleBackColor = true;
            // 
            // labelValueServoGripper
            // 
            labelValueServoGripper.AutoSize = true;
            labelValueServoGripper.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelValueServoGripper.ForeColor = Color.Black;
            labelValueServoGripper.Location = new Point(115, 25);
            labelValueServoGripper.Name = "labelValueServoGripper";
            labelValueServoGripper.Size = new Size(51, 21);
            labelValueServoGripper.TabIndex = 5;
            labelValueServoGripper.Text = "0 - 90";
            // 
            // groupBoxServoMiddle
            // 
            groupBoxServoMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxServoMiddle.Controls.Add(radioButtonRightServoMiddle);
            groupBoxServoMiddle.Controls.Add(radioButtonLeftServoMiddle);
            groupBoxServoMiddle.Controls.Add(textBoxValueServoMiddle);
            groupBoxServoMiddle.Controls.Add(buttonManualServoMiddle);
            groupBoxServoMiddle.Controls.Add(labelValueServoMiddle);
            groupBoxServoMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxServoMiddle.ForeColor = Color.Black;
            groupBoxServoMiddle.Location = new Point(330, 25);
            groupBoxServoMiddle.Name = "groupBoxServoMiddle";
            groupBoxServoMiddle.Size = new Size(310, 110);
            groupBoxServoMiddle.TabIndex = 17;
            groupBoxServoMiddle.TabStop = false;
            groupBoxServoMiddle.Text = "СРЕДНИЙ СЕРВО";
            // 
            // radioButtonRightServoMiddle
            // 
            radioButtonRightServoMiddle.AutoSize = true;
            radioButtonRightServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonRightServoMiddle.Location = new Point(10, 70);
            radioButtonRightServoMiddle.Name = "radioButtonRightServoMiddle";
            radioButtonRightServoMiddle.Size = new Size(84, 25);
            radioButtonRightServoMiddle.TabIndex = 3;
            radioButtonRightServoMiddle.TabStop = true;
            radioButtonRightServoMiddle.Text = "Вправо";
            radioButtonRightServoMiddle.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeftServoMiddle
            // 
            radioButtonLeftServoMiddle.AutoSize = true;
            radioButtonLeftServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButtonLeftServoMiddle.Location = new Point(10, 30);
            radioButtonLeftServoMiddle.Name = "radioButtonLeftServoMiddle";
            radioButtonLeftServoMiddle.Size = new Size(75, 25);
            radioButtonLeftServoMiddle.TabIndex = 2;
            radioButtonLeftServoMiddle.TabStop = true;
            radioButtonLeftServoMiddle.Text = "Влево";
            radioButtonLeftServoMiddle.UseVisualStyleBackColor = true;
            // 
            // textBoxValueServoMiddle
            // 
            textBoxValueServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxValueServoMiddle.ForeColor = Color.Black;
            textBoxValueServoMiddle.Location = new Point(100, 45);
            textBoxValueServoMiddle.Name = "textBoxValueServoMiddle";
            textBoxValueServoMiddle.Size = new Size(90, 29);
            textBoxValueServoMiddle.TabIndex = 3;
            // 
            // buttonManualServoMiddle
            // 
            buttonManualServoMiddle.Cursor = Cursors.Hand;
            buttonManualServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualServoMiddle.ForeColor = Color.Black;
            buttonManualServoMiddle.Location = new Point(195, 35);
            buttonManualServoMiddle.Name = "buttonManualServoMiddle";
            buttonManualServoMiddle.Size = new Size(110, 50);
            buttonManualServoMiddle.TabIndex = 1;
            buttonManualServoMiddle.Text = "Выполнить";
            buttonManualServoMiddle.UseVisualStyleBackColor = true;
            buttonManualServoMiddle.Click += buttonManualServoMiddle_Click;
            // 
            // labelValueServoMiddle
            // 
            labelValueServoMiddle.AutoSize = true;
            labelValueServoMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelValueServoMiddle.ForeColor = Color.Black;
            labelValueServoMiddle.Location = new Point(115, 25);
            labelValueServoMiddle.Name = "labelValueServoMiddle";
            labelValueServoMiddle.Size = new Size(51, 21);
            labelValueServoMiddle.TabIndex = 2;
            labelValueServoMiddle.Text = "0 - 90";
            // 
            // groupBoxMotorTop
            // 
            groupBoxMotorTop.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorTop.Controls.Add(radioButtonBackwardMotorTop);
            groupBoxMotorTop.Controls.Add(radioButtonForwardMotorTop);
            groupBoxMotorTop.Controls.Add(textBoxStepsMotorTop);
            groupBoxMotorTop.Controls.Add(buttonManualMotorTop);
            groupBoxMotorTop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorTop.ForeColor = Color.Black;
            groupBoxMotorTop.Location = new Point(5, 25);
            groupBoxMotorTop.Name = "groupBoxMotorTop";
            groupBoxMotorTop.Size = new Size(310, 110);
            groupBoxMotorTop.TabIndex = 15;
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
            // textBoxStepsMotorTop
            // 
            textBoxStepsMotorTop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxStepsMotorTop.ForeColor = Color.Black;
            textBoxStepsMotorTop.Location = new Point(100, 45);
            textBoxStepsMotorTop.Name = "textBoxStepsMotorTop";
            textBoxStepsMotorTop.Size = new Size(90, 29);
            textBoxStepsMotorTop.TabIndex = 3;
            // 
            // buttonManualMotorTop
            // 
            buttonManualMotorTop.Cursor = Cursors.Hand;
            buttonManualMotorTop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualMotorTop.ForeColor = Color.Black;
            buttonManualMotorTop.Location = new Point(195, 35);
            buttonManualMotorTop.Name = "buttonManualMotorTop";
            buttonManualMotorTop.Size = new Size(110, 50);
            buttonManualMotorTop.TabIndex = 1;
            buttonManualMotorTop.Text = "Выполнить";
            buttonManualMotorTop.UseVisualStyleBackColor = true;
            buttonManualMotorTop.Click += buttonManualMotorTop_Click;
            // 
            // groupBoxMotorMiddle
            // 
            groupBoxMotorMiddle.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorMiddle.Controls.Add(radioButtonBackwardMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(radioButtonForwardMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(textBoxStepsMotorMiddle);
            groupBoxMotorMiddle.Controls.Add(buttonManualMotorMiddle);
            groupBoxMotorMiddle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorMiddle.ForeColor = Color.Black;
            groupBoxMotorMiddle.Location = new Point(5, 155);
            groupBoxMotorMiddle.Name = "groupBoxMotorMiddle";
            groupBoxMotorMiddle.Size = new Size(310, 110);
            groupBoxMotorMiddle.TabIndex = 14;
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
            // textBoxStepsMotorMiddle
            // 
            textBoxStepsMotorMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxStepsMotorMiddle.ForeColor = Color.Black;
            textBoxStepsMotorMiddle.Location = new Point(100, 45);
            textBoxStepsMotorMiddle.Name = "textBoxStepsMotorMiddle";
            textBoxStepsMotorMiddle.Size = new Size(90, 29);
            textBoxStepsMotorMiddle.TabIndex = 3;
            // 
            // buttonManualMotorMiddle
            // 
            buttonManualMotorMiddle.Cursor = Cursors.Hand;
            buttonManualMotorMiddle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualMotorMiddle.ForeColor = Color.Black;
            buttonManualMotorMiddle.Location = new Point(195, 35);
            buttonManualMotorMiddle.Name = "buttonManualMotorMiddle";
            buttonManualMotorMiddle.Size = new Size(110, 50);
            buttonManualMotorMiddle.TabIndex = 1;
            buttonManualMotorMiddle.Text = "Выполнить";
            buttonManualMotorMiddle.UseVisualStyleBackColor = true;
            buttonManualMotorMiddle.Click += buttonManualMotorMiddle_Click;
            // 
            // groupBoxMotorBottom
            // 
            groupBoxMotorBottom.BackColor = Color.FromArgb(231, 238, 255);
            groupBoxMotorBottom.Controls.Add(radioButtonBackwardMotorBottom);
            groupBoxMotorBottom.Controls.Add(radioButtonForwardMotorBottom);
            groupBoxMotorBottom.Controls.Add(textBoxStepsMotorBottom);
            groupBoxMotorBottom.Controls.Add(buttonManualMotorBottom);
            groupBoxMotorBottom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxMotorBottom.ForeColor = Color.Black;
            groupBoxMotorBottom.Location = new Point(5, 280);
            groupBoxMotorBottom.Name = "groupBoxMotorBottom";
            groupBoxMotorBottom.Size = new Size(310, 110);
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
            // textBoxStepsMotorBottom
            // 
            textBoxStepsMotorBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBoxStepsMotorBottom.ForeColor = Color.Black;
            textBoxStepsMotorBottom.Location = new Point(100, 45);
            textBoxStepsMotorBottom.Name = "textBoxStepsMotorBottom";
            textBoxStepsMotorBottom.Size = new Size(90, 29);
            textBoxStepsMotorBottom.TabIndex = 3;
            // 
            // buttonManualMotorBottom
            // 
            buttonManualMotorBottom.Cursor = Cursors.Hand;
            buttonManualMotorBottom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonManualMotorBottom.ForeColor = Color.Black;
            buttonManualMotorBottom.Location = new Point(195, 35);
            buttonManualMotorBottom.Name = "buttonManualMotorBottom";
            buttonManualMotorBottom.Size = new Size(110, 50);
            buttonManualMotorBottom.TabIndex = 1;
            buttonManualMotorBottom.Text = "Выполнить";
            buttonManualMotorBottom.UseVisualStyleBackColor = true;
            buttonManualMotorBottom.Click += buttonManualMotorBottom_Click;
            // 
            // timerStop
            // 
            timerStop.Interval = 1000;
            // 
            // FormManual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 251);
            ClientSize = new Size(1284, 601);
            Controls.Add(groupBoxManual);
            Controls.Add(serialControl);
            Name = "FormManual";
            Text = "FormManual";
            groupBoxManual.ResumeLayout(false);
            groupBoxExecuteAll.ResumeLayout(false);
            groupBoxExecuteAll.PerformLayout();
            groupBoxStop.ResumeLayout(false);
            groupBoxStop.PerformLayout();
            groupBoxServoGripper.ResumeLayout(false);
            groupBoxServoGripper.PerformLayout();
            groupBoxServoMiddle.ResumeLayout(false);
            groupBoxServoMiddle.PerformLayout();
            groupBoxMotorTop.ResumeLayout(false);
            groupBoxMotorTop.PerformLayout();
            groupBoxMotorMiddle.ResumeLayout(false);
            groupBoxMotorMiddle.PerformLayout();
            groupBoxMotorBottom.ResumeLayout(false);
            groupBoxMotorBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SerialControl serialControl;
        private Button buttonManualMotorBottom;
        private GroupBox groupBoxHoldCharacteristics;
        private TextBox textBoxInterval;
        private TextBox textBoxStepsMotorBottom;
        private Label labelValueServoMiddle;
        private Button buttonApply;
        private Label labelInterval;
        private GroupBox groupBoxManual;
        private GroupBox groupBoxMotorBottom;
        private RadioButton radioButtonBackwardMotorBottom;
        private RadioButton radioButtonForwardMotorBottom;
        private GroupBox groupBoxMotorMiddle;
        private RadioButton radioButtonBackwardMotorMiddle;
        private RadioButton radioButtonForwardMotorMiddle;
        private TextBox textBoxStepsMotorMiddle;
        private Button buttonManualMotorMiddle;
        private GroupBox groupBoxMotorTop;
        private RadioButton radioButtonBackwardMotorTop;
        private RadioButton radioButtonForwardMotorTop;
        private TextBox textBoxStepsMotorTop;
        private Button buttonManualMotorTop;
        private GroupBox groupBoxServoMiddle;
        private RadioButton radioButtonRightServoMiddle;
        private RadioButton radioButtonLeftServoMiddle;
        private TextBox textBoxValueServoMiddle;
        private Button buttonManualServoMiddle;
        private GroupBox groupBoxServoGripper;
        private RadioButton radioButtonOpenServoGripper;
        private RadioButton radioButtonCloseServoGripper;
        private TextBox textBoxValueServoGripper;
        private Button buttonManualServoGripper;
        private Button buttonManualStopServoGripper;
        private Button buttonExecuteAll;
        private Label labelValueServoGripper;
        private GroupBox groupBoxExecuteAll;
        private CheckBox checkBoxManualStopServoGripper;
        private GroupBox groupBoxStop;
        private ComboBox comboBoxInterval;
        private Label labelStop;
        private System.Windows.Forms.Timer timerStop;
    }
}