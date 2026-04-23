namespace ROBOPROJECT
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        private Form activeForm = null;
        private void openForm(Form childForm) //открытие форм
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false; //не главное окно
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonHold_Click(object sender, EventArgs e)
        {
            panelBacklight1.Visible = true;
            panelBacklight2.Visible = false;
            panelBacklight3.Visible = false;
            buttonHold.ForeColor = Color.FromArgb(2, 100, 254);
            buttonManual.ForeColor = Color.Black;
            buttonRecord.ForeColor = Color.Black;
            openForm(new FormHold());
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            panelBacklight1.Visible = false;
            panelBacklight2.Visible = true;
            panelBacklight3.Visible = false;
            buttonManual.ForeColor = Color.FromArgb(2, 100, 254);
            buttonHold.ForeColor = Color.Black;
            buttonRecord.ForeColor = Color.Black;
            openForm(new FormManual());
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            panelBacklight1.Visible = false;
            panelBacklight2.Visible = false;
            panelBacklight3.Visible = true;
            buttonManual.ForeColor = Color.Black;
            buttonHold.ForeColor = Color.Black;
            buttonRecord.ForeColor = Color.FromArgb(2, 100, 254);
            openForm(new FormRecord());
        }
    }
}
