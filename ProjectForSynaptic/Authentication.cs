using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForSynaptic
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            bool key = false;
            if (textBoxLogin.Text != "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach(Authentitation authentitation in Program.projectForSinaptic.Authentitation)
                {
                    if(textBoxPassword.Text==authentitation.Password&&textBoxLogin.Text==authentitation.Login)
                    key = true;
                }
            }
            if (key==true)
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
