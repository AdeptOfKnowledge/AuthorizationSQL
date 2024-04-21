using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class LoginForm : Form
    {
        Point NP; bool Eye = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthorizationText_MouseDown(object sender, MouseEventArgs e)
        {
            NP = new Point(e.X, e.Y);
        }

        private void AuthorizationText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - NP.X;
                this.Top += e.Y - NP.Y;
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {

        }

        private void PassShow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Password.UseSystemPasswordChar == true) { Password.UseSystemPasswordChar = false; Eye = true; }
                if (Eye == false) Password.UseSystemPasswordChar = true;
                Eye = false;
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) // Запрещаем ввод символов, отличных от букв, цифр и управляющих символов
            {
                e.Handled = true;
            }
        }
    }
}
