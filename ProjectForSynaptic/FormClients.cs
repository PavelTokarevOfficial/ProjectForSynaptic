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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowClien();
        }
        void ShowClien()
        {
            listViewClients.Items.Clear();
            foreach (Clients clients in Program.projectForSinaptic.Clients)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    clients.ID.ToString(),
                    clients.NameClient,
                    clients.Company,
                    clients.Phone
                });
                listViewItem.Tag = clients;
                listViewClients.Items.Add(listViewItem);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.NameClient = textBoxNameClient.Text;
            clients.Company = textBoxCompany.Text;
            clients.Phone = textBoxPhone.Text;
            Program.projectForSinaptic.Clients.Add(clients);
            Program.projectForSinaptic.SaveChanges();
            ShowClien();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                clients.NameClient = textBoxNameClient.Text;
                clients.Company = textBoxCompany.Text;
                clients.Phone = textBoxPhone.Text;
                Program.projectForSinaptic.SaveChanges();
                ShowClien();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                textBoxNameClient.Text = clients.NameClient;
                textBoxCompany.Text = clients.Company;
                textBoxPhone.Text = clients.Phone;
            }
            else
            {
                textBoxNameClient.Text = "";
                textBoxCompany.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                    Program.projectForSinaptic.Clients.Remove(clients);
                    Program.projectForSinaptic.SaveChanges();
                    ShowClien();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
    }
}
