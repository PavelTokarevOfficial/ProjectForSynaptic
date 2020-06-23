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
    public partial class FormProjects : Form
    {
        public FormProjects()
        {
            InitializeComponent();
            ShowProjects();
        }
        void ShowProjects()
        {
            listViewProjects.Items.Clear();
            foreach (Projects projects in Program.projectForSinaptic.Projects)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    projects.ID.ToString(),
                    projects.NameProject,
                    
                });
                listViewItem.Tag = projects;
                listViewProjects.Items.Add(listViewItem);   
                  
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            projects.NameProject = textBoxNewChallenge.Text;
            
            Program.projectForSinaptic.Projects.Add(projects);
            Program.projectForSinaptic.SaveChanges();
            ShowProjects();

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count == 1)
            {
                Projects projects = listViewProjects.SelectedItems[0].Tag as Projects;
                projects.NameProject = textBoxNewChallenge.Text;
                Program.projectForSinaptic.SaveChanges();
                ShowProjects();
            }
        }

        private void listViewProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProjects.SelectedItems.Count == 1)
            {
                Projects projects = listViewProjects.SelectedItems[0].Tag as Projects;
                textBoxNewChallenge.Text = projects.NameProject;  
            }
            else
            {
                textBoxNewChallenge.Text = "";
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProjects.SelectedItems.Count == 1)
                {
                    Projects projects = listViewProjects.SelectedItems[0].Tag as Projects;
                    Program.projectForSinaptic.Projects.Remove(projects);
                    Program.projectForSinaptic.SaveChanges();
                    ShowProjects();

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
