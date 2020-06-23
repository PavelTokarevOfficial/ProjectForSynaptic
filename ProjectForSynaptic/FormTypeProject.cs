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
    public partial class FormTypeProject : Form
    {
        public FormTypeProject()
        {
            InitializeComponent();
            ShowTypeProject();
        }
        void ShowTypeProject()
        {
            listViewTypeProject.Items.Clear();
            foreach(TypeProject typeProject in Program.projectForSinaptic.TypeProject)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    typeProject.ID.ToString(),
                    typeProject.NameTypeProject
                });
                listViewItem.Tag = typeProject;
                listViewTypeProject.Items.Add(listViewItem);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TypeProject typeProject = new TypeProject();
            typeProject.NameTypeProject = textBoxTypeProject.Text;
            Program.projectForSinaptic.TypeProject.Add(typeProject);
            Program.projectForSinaptic.SaveChanges();
            ShowTypeProject();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTypeProject.SelectedItems.Count == 1)
            {
                TypeProject typeProject = listViewTypeProject.SelectedItems[0].Tag as TypeProject;
                typeProject.NameTypeProject = textBoxTypeProject.Text;
                Program.projectForSinaptic.SaveChanges();
                ShowTypeProject();
            }
        }
        private void listViewTypeProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTypeProject.SelectedItems.Count==1)
            {
                TypeProject typeProject = listViewTypeProject.SelectedItems[0].Tag as TypeProject;
                textBoxTypeProject.Text = typeProject.NameTypeProject;

            }
            else
            {
                textBoxTypeProject.Text = "";
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTypeProject.SelectedItems.Count == 1)
                {
                    TypeProject typeProject = listViewTypeProject.SelectedItems[0].Tag as TypeProject;
                    Program.projectForSinaptic.TypeProject.Remove(typeProject);
                    Program.projectForSinaptic.SaveChanges();
                    ShowTypeProject();
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
