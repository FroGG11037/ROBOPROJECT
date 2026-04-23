namespace ROBOPROJECT
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelSideMenu = new Panel();
            panelRecord = new Panel();
            buttonRecord = new Button();
            panelBacklight3 = new Panel();
            panelManualMenu = new Panel();
            buttonManual = new Button();
            panelBacklight2 = new Panel();
            panelHoldMenu = new Panel();
            buttonHold = new Button();
            panelBacklight1 = new Panel();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            labelLogo = new Label();
            panelMain = new Panel();
            labelGreeting = new Label();
            panelSideMenu.SuspendLayout();
            panelRecord.SuspendLayout();
            panelManualMenu.SuspendLayout();
            panelHoldMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(231, 238, 255);
            panelSideMenu.Controls.Add(panelRecord);
            panelSideMenu.Controls.Add(panelManualMenu);
            panelSideMenu.Controls.Add(panelHoldMenu);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(225, 640);
            panelSideMenu.TabIndex = 0;
            // 
            // panelRecord
            // 
            panelRecord.BackColor = Color.FromArgb(208, 218, 255);
            panelRecord.Controls.Add(buttonRecord);
            panelRecord.Controls.Add(panelBacklight3);
            panelRecord.Dock = DockStyle.Top;
            panelRecord.Location = new Point(0, 285);
            panelRecord.Name = "panelRecord";
            panelRecord.Size = new Size(225, 80);
            panelRecord.TabIndex = 6;
            // 
            // buttonRecord
            // 
            buttonRecord.BackColor = Color.FromArgb(208, 218, 255);
            buttonRecord.Cursor = Cursors.Hand;
            buttonRecord.Dock = DockStyle.Fill;
            buttonRecord.FlatAppearance.BorderSize = 0;
            buttonRecord.FlatStyle = FlatStyle.Flat;
            buttonRecord.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            buttonRecord.ForeColor = Color.Black;
            buttonRecord.Image = (Image)resources.GetObject("buttonRecord.Image");
            buttonRecord.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRecord.Location = new Point(8, 0);
            buttonRecord.Name = "buttonRecord";
            buttonRecord.Size = new Size(217, 80);
            buttonRecord.TabIndex = 2;
            buttonRecord.Text = "Запись";
            buttonRecord.TextAlign = ContentAlignment.MiddleRight;
            buttonRecord.UseVisualStyleBackColor = false;
            buttonRecord.Click += buttonRecord_Click;
            // 
            // panelBacklight3
            // 
            panelBacklight3.BackColor = Color.FromArgb(2, 100, 254);
            panelBacklight3.Dock = DockStyle.Left;
            panelBacklight3.Location = new Point(0, 0);
            panelBacklight3.Name = "panelBacklight3";
            panelBacklight3.Size = new Size(8, 80);
            panelBacklight3.TabIndex = 0;
            panelBacklight3.Visible = false;
            // 
            // panelManualMenu
            // 
            panelManualMenu.BackColor = Color.FromArgb(208, 218, 255);
            panelManualMenu.Controls.Add(buttonManual);
            panelManualMenu.Controls.Add(panelBacklight2);
            panelManualMenu.Dock = DockStyle.Top;
            panelManualMenu.Location = new Point(0, 205);
            panelManualMenu.Name = "panelManualMenu";
            panelManualMenu.Size = new Size(225, 80);
            panelManualMenu.TabIndex = 4;
            // 
            // buttonManual
            // 
            buttonManual.BackColor = Color.FromArgb(208, 218, 255);
            buttonManual.Cursor = Cursors.Hand;
            buttonManual.Dock = DockStyle.Fill;
            buttonManual.FlatAppearance.BorderSize = 0;
            buttonManual.FlatStyle = FlatStyle.Flat;
            buttonManual.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            buttonManual.ForeColor = Color.Black;
            buttonManual.Image = (Image)resources.GetObject("buttonManual.Image");
            buttonManual.ImageAlign = ContentAlignment.MiddleLeft;
            buttonManual.Location = new Point(8, 0);
            buttonManual.Name = "buttonManual";
            buttonManual.Size = new Size(217, 80);
            buttonManual.TabIndex = 2;
            buttonManual.Text = "Ручное";
            buttonManual.TextAlign = ContentAlignment.MiddleRight;
            buttonManual.UseVisualStyleBackColor = false;
            buttonManual.Click += buttonManual_Click;
            // 
            // panelBacklight2
            // 
            panelBacklight2.BackColor = Color.FromArgb(2, 100, 254);
            panelBacklight2.Dock = DockStyle.Left;
            panelBacklight2.Location = new Point(0, 0);
            panelBacklight2.Name = "panelBacklight2";
            panelBacklight2.Size = new Size(8, 80);
            panelBacklight2.TabIndex = 0;
            panelBacklight2.Visible = false;
            // 
            // panelHoldMenu
            // 
            panelHoldMenu.BackColor = Color.FromArgb(208, 218, 255);
            panelHoldMenu.Controls.Add(buttonHold);
            panelHoldMenu.Controls.Add(panelBacklight1);
            panelHoldMenu.Dock = DockStyle.Top;
            panelHoldMenu.Location = new Point(0, 125);
            panelHoldMenu.Name = "panelHoldMenu";
            panelHoldMenu.Size = new Size(225, 80);
            panelHoldMenu.TabIndex = 5;
            // 
            // buttonHold
            // 
            buttonHold.BackColor = Color.FromArgb(208, 218, 255);
            buttonHold.BackgroundImageLayout = ImageLayout.None;
            buttonHold.Cursor = Cursors.Hand;
            buttonHold.Dock = DockStyle.Fill;
            buttonHold.FlatAppearance.BorderSize = 0;
            buttonHold.FlatStyle = FlatStyle.Flat;
            buttonHold.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            buttonHold.ForeColor = Color.Black;
            buttonHold.Image = (Image)resources.GetObject("buttonHold.Image");
            buttonHold.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHold.Location = new Point(8, 0);
            buttonHold.Name = "buttonHold";
            buttonHold.Size = new Size(217, 80);
            buttonHold.TabIndex = 2;
            buttonHold.Text = "Удержание";
            buttonHold.TextAlign = ContentAlignment.MiddleRight;
            buttonHold.UseVisualStyleBackColor = false;
            buttonHold.Click += buttonHold_Click;
            // 
            // panelBacklight1
            // 
            panelBacklight1.BackColor = Color.FromArgb(2, 100, 254);
            panelBacklight1.Dock = DockStyle.Left;
            panelBacklight1.Location = new Point(0, 0);
            panelBacklight1.Name = "panelBacklight1";
            panelBacklight1.Size = new Size(8, 80);
            panelBacklight1.TabIndex = 0;
            panelBacklight1.Visible = false;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Controls.Add(labelLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(225, 125);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(10, 22);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(80, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            labelLogo.ForeColor = Color.Black;
            labelLogo.Location = new Point(95, 22);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(127, 74);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "Добрый\r\nкола";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(labelGreeting);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(225, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1300, 640);
            panelMain.TabIndex = 1;
            // 
            // labelGreeting
            // 
            labelGreeting.Dock = DockStyle.Fill;
            labelGreeting.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelGreeting.Location = new Point(0, 0);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(1300, 640);
            labelGreeting.TabIndex = 0;
            labelGreeting.Text = "Добро пожаловать!\r\nВыберите режим работы";
            labelGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 251);
            ClientSize = new Size(1525, 640);
            Controls.Add(panelMain);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Управление роботом";
            panelSideMenu.ResumeLayout(false);
            panelRecord.ResumeLayout(false);
            panelManualMenu.ResumeLayout(false);
            panelHoldMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Label labelLogo;
        private Button buttonManual;
        private Panel panelManualMenu;
        private Panel panelBacklight2;
        private Panel panelHoldMenu;
        private Button buttonHold;
        private Panel panelBacklight1;
        private Panel panelRecord;
        private Button buttonRecord;
        private Panel panelBacklight3;
        private Panel panelMain;
        private Label labelGreeting;
    }
}
