using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForSynaptic
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUsersAdd formUsersAdd = new FormUsersAdd();
            formUsersAdd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPriceList priceList = new FormPriceList();
            priceList.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTypeProject formTypeProject = new FormTypeProject();
            formTypeProject.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormProjects formProjects = new FormProjects();
            formProjects.Show();
            this.Hide();
        }

        private void buttonVihod_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProjectAccounting formProjectAccounting = new FormProjectAccounting();
            formProjectAccounting.Show();
            this.Hide();
        }
    }
}
