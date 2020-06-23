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
    public partial class FormUsersAdd : Form
    {
        public FormUsersAdd()
        {
            InitializeComponent();
            ShowUsers();
        }

        void ShowUsers()
        {
            listViewUsers.Items.Clear();
            foreach (Users users in Program.projectForSinaptic.Users)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    users.ID.ToString(),users.FirstName,users.MiddleName,users.LastName,users.Phone,users.Position
                });
                listViewItem.Tag = users;
                listViewUsers.Items.Add(listViewItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.FirstName = textBoxFirstName.Text;
            users.MiddleName = textBoxMiddleName.Text;
            users.LastName = textBoxLastName.Text;
            users.Phone = textBoxPhone.Text;
            users.Position = textBoxPosition.Text;
            Program.projectForSinaptic.Users.Add(users);
            Program.projectForSinaptic.SaveChanges();
            ShowUsers();
        }
        
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 1)
            {
                Users users = listViewUsers.SelectedItems[0].Tag as Users;
                users.FirstName = textBoxFirstName.Text;
                users.MiddleName = textBoxMiddleName.Text;
                users.LastName = textBoxLastName.Text;
                users.Phone = textBoxPhone.Text;
                users.Position = textBoxPosition.Text;
                Program.projectForSinaptic.SaveChanges();
                ShowUsers();
            }
        }
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count == 1)
            {
                Users users = listViewUsers.SelectedItems[0].Tag as Users;
                textBoxFirstName.Text = users.FirstName;
                textBoxMiddleName.Text = users.MiddleName;
                textBoxLastName.Text = users.LastName;
                textBoxPhone.Text = users.Phone;
                textBoxPosition.Text = users.Position;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxPosition.Text = "";
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUsers.SelectedItems.Count == 1)
                {
                    Users users = listViewUsers.SelectedItems[0].Tag as Users;
                    Program.projectForSinaptic.Users.Remove(users);
                    Program.projectForSinaptic.SaveChanges();
                    ShowUsers();
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
