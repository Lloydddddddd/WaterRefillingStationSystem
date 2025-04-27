using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WaterRefillingStationSystem.Forms;

namespace WaterRefillingStationSystem.Forms2
{
    public partial class FormLogIn : DevExpress.XtraEditors.XtraForm
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            bool isPasswordHidden = textEdit4.Properties.PasswordChar == '*';
            btnPasswordReveal.Text = "Show Password";
        }

        private void simpleButtonLogIn_Click(object sender, EventArgs e)
        {
            MainForm2 mainForm2 = new MainForm2();
            mainForm2.ShowDialog();
            this.Hide();
        }

        private void btnPasswordReveal_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void TogglePasswordVisibility()
        {
            bool isPasswordHidden = textEdit4.Properties.UseSystemPasswordChar;
            textEdit4.Properties.UseSystemPasswordChar = !isPasswordHidden;
            btnPasswordReveal.Text = isPasswordHidden ? "Hide Password" : "Show Password";
        }
    }
}