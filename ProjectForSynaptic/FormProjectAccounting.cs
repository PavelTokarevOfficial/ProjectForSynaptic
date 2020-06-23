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
    public partial class FormProjectAccounting : Form
    {
        public FormProjectAccounting()
        {   //вывод в комбобоксы
            InitializeComponent();
            ShowComboboxProjects();
            ShowComboboxUsers();
            ShowComboboxPrice();
            ShowComboboxType();
            ShowComboboxClients();

            //Вывод в таблици
            ShowlistViewNewChallenge();
            ShowlistViewInWork();
            ShowlistViewReview();
            ShowlistViewTesting();
            ShowlistViewReady();
        }
        void ShowComboboxProjects()
        {
            comboBoxProjects.Items.Clear();
            foreach(Projects projects in Program.projectForSinaptic.Projects)
            {
                string[] item = { projects.ID.ToString() + ".", projects.NameProject };
                comboBoxProjects.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxUsers()
        {
            comboBoxUsers.Items.Clear();
            foreach (Users users in Program.projectForSinaptic.Users)
            {
                string[] item = {users.ID.ToString()+".",users.FirstName,users.MiddleName,users.LastName,users.Position,users.Phone};
                comboBoxUsers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxPrice()
        {
            comboBoxPrice.Items.Clear();
            foreach(PriceList priceList in Program.projectForSinaptic.PriceList)
            {
                string[] item = { priceList.ID.ToString() + ".", priceList.ProjectСomplexity, priceList.Price };
                comboBoxPrice.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxType()
        {
            comboBoxType.Items.Clear();
            foreach (TypeProject typeProject in Program.projectForSinaptic.TypeProject)
            {
                string[] item = {typeProject.ID.ToString()+".",typeProject.NameTypeProject};
                comboBoxType.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboboxClients()
        {
            comboBoxClient.Items.Clear();
            foreach(Clients clients in Program.projectForSinaptic.Clients)
            {
                string[] item = { clients.ID.ToString()+".",clients.NameClient,clients.Company};
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowlistViewNewChallenge()
        {
            listViewNewChallenge.Items.Clear();
            foreach (ProjectAccounting projectAccounting in Program.projectForSinaptic.ProjectAccounting)
            {
                if (projectAccounting.Status == "New")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        projectAccounting.ID.ToString(),
                        projectAccounting.IDProject.ToString() + ". "+projectAccounting.Projects.NameProject,
                        projectAccounting.IDClient.ToString()+". "+projectAccounting.Clients.NameClient+" Компания:"+projectAccounting.Clients.Company+" Телефон:"+projectAccounting.Clients.Phone,
                        projectAccounting.IDType.ToString()+". "+projectAccounting.TypeProject.NameTypeProject,
                        projectAccounting.IDUser.ToString()+". "+projectAccounting.Users.FirstName+" "+ projectAccounting.Users.MiddleName+" "+projectAccounting.Users.LastName+" ("+projectAccounting.Users.Position+") "+projectAccounting.Users.Phone,
                        projectAccounting.IDPrice.ToString()+". "+projectAccounting.PriceList.Price
                    });
                    item.Tag = projectAccounting;
                    listViewNewChallenge.Items.Add(item);
                }
            }
            listViewNewChallenge.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowlistViewInWork()
        {
            listViewInWork.Items.Clear();
            foreach (ProjectAccounting projectAccounting in Program.projectForSinaptic.ProjectAccounting)
            {
                if (projectAccounting.Status == "InWork")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        projectAccounting.ID.ToString(),
                        projectAccounting.IDProject.ToString() + ". "+projectAccounting.Projects.NameProject,
                        projectAccounting.IDClient.ToString()+". "+projectAccounting.Clients.NameClient+" Компания:"+projectAccounting.Clients.Company+" Телефон:"+projectAccounting.Clients.Phone,
                        projectAccounting.IDType.ToString()+". "+projectAccounting.TypeProject.NameTypeProject,
                        projectAccounting.IDUser.ToString()+". "+projectAccounting.Users.FirstName+" "+ projectAccounting.Users.MiddleName+" "+projectAccounting.Users.LastName+" ("+projectAccounting.Users.Position+") "+projectAccounting.Users.Phone,
                        projectAccounting.IDPrice.ToString()+". "+projectAccounting.PriceList.Price
                    });
                    item.Tag = projectAccounting;
                    listViewInWork.Items.Add(item);
                }
            }
            listViewInWork.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowlistViewReview()
        {
            listViewReview.Items.Clear();
            foreach (ProjectAccounting projectAccounting in Program.projectForSinaptic.ProjectAccounting)
            {
                if (projectAccounting.Status == "Review")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        projectAccounting.ID.ToString(),
                        projectAccounting.IDProject.ToString() + ". "+projectAccounting.Projects.NameProject,
                        projectAccounting.IDClient.ToString()+". "+projectAccounting.Clients.NameClient+" Компания:"+projectAccounting.Clients.Company+" Телефон:"+projectAccounting.Clients.Phone,
                        projectAccounting.IDType.ToString()+". "+projectAccounting.TypeProject.NameTypeProject,
                        projectAccounting.IDUser.ToString()+". "+projectAccounting.Users.FirstName+" "+ projectAccounting.Users.MiddleName+" "+projectAccounting.Users.LastName+" ("+projectAccounting.Users.Position+") "+projectAccounting.Users.Phone,
                        projectAccounting.IDPrice.ToString()+". "+projectAccounting.PriceList.Price
                    });
                    item.Tag = projectAccounting;
                    listViewReview.Items.Add(item);
                }
            }
            listViewReview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowlistViewTesting()
        {
            listViewTesting.Items.Clear();
            foreach (ProjectAccounting projectAccounting in Program.projectForSinaptic.ProjectAccounting)
            {
                if (projectAccounting.Status == "Testing")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        projectAccounting.ID.ToString(),
                        projectAccounting.IDProject.ToString() + ". "+projectAccounting.Projects.NameProject,
                        projectAccounting.IDClient.ToString()+". "+projectAccounting.Clients.NameClient+" Компания:"+projectAccounting.Clients.Company+" Телефон:"+projectAccounting.Clients.Phone,
                        projectAccounting.IDType.ToString()+". "+projectAccounting.TypeProject.NameTypeProject,
                        projectAccounting.IDUser.ToString()+". "+projectAccounting.Users.FirstName+" "+ projectAccounting.Users.MiddleName+" "+projectAccounting.Users.LastName+" ("+projectAccounting.Users.Position+") "+projectAccounting.Users.Phone,
                        projectAccounting.IDPrice.ToString()+". "+projectAccounting.PriceList.Price
                    });
                    item.Tag = projectAccounting;
                    listViewTesting.Items.Add(item);
                }
            }
            listViewTesting.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowlistViewReady()
        {
            listViewReady.Items.Clear();
            foreach (ProjectAccounting projectAccounting in Program.projectForSinaptic.ProjectAccounting)
            {
                if (projectAccounting.Status == "Ready")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        projectAccounting.ID.ToString(),
                        projectAccounting.IDProject.ToString() + ". "+projectAccounting.Projects.NameProject,
                        projectAccounting.IDClient.ToString()+". "+projectAccounting.Clients.NameClient+" Компания:"+projectAccounting.Clients.Company+" Телефон:"+projectAccounting.Clients.Phone,
                        projectAccounting.IDType.ToString()+". "+projectAccounting.TypeProject.NameTypeProject,
                        projectAccounting.IDUser.ToString()+". "+projectAccounting.Users.FirstName+" "+ projectAccounting.Users.MiddleName+" "+projectAccounting.Users.LastName+" ("+projectAccounting.Users.Position+") "+projectAccounting.Users.Phone,
                        projectAccounting.IDPrice.ToString()+". "+projectAccounting.PriceList.Price
                    });
                    item.Tag = projectAccounting;
                    listViewReady.Items.Add(item);
                }
            }
            listViewReady.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxProjects.SelectedItem!=null&& comboBoxUsers.SelectedItem!=null&&comboBoxPrice.SelectedItem!=null&&comboBoxType.SelectedItem!=null) 
            {
                ProjectAccounting projectAccounting = new ProjectAccounting();
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser= Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient= Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.Text;
                Program.projectForSinaptic.ProjectAccounting.Add(projectAccounting);
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewNewChallenge();
                ShowlistViewInWork();
                ShowlistViewReview();
                ShowlistViewTesting();
                ShowlistViewReady();
            }
            else
            {
                MessageBox.Show("Данные не выбраны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReady1_Click(object sender, EventArgs e)
        {
            if (listViewNewChallenge.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewNewChallenge.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.Status = "InWork";
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewNewChallenge();
                ShowlistViewInWork();
            }
            else
            {
                MessageBox.Show("Строчка не выбрана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReady2_Click(object sender, EventArgs e)
        {
            if (listViewInWork.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewInWork.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.Status = "Review";
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewInWork();
                ShowlistViewReview();
            }
            else
            {
                MessageBox.Show("Строчка не выбрана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonReady3_Click(object sender, EventArgs e)
        {
            if (listViewReview.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewReview.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.Status = "Testing";
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewReview();
                ShowlistViewTesting();
            }
            else
            {
                MessageBox.Show("Строчка не выбрана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonReady4_Click(object sender, EventArgs e)
        {
            if (listViewTesting.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewTesting.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.Status = "Ready";
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewTesting();
                ShowlistViewReady();
            }
            else
            {
                MessageBox.Show("Строчка не выбрана", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReady.SelectedItems.Count == 1)
                {
                    ProjectAccounting projectAccounting = listViewReady.SelectedItems[0].Tag as ProjectAccounting;
                    Program.projectForSinaptic.ProjectAccounting.Remove(projectAccounting);
                    Program.projectForSinaptic.SaveChanges();
                    ShowlistViewReady();

                    comboBoxProjects.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    comboBoxType.SelectedItem = null;
                    comboBoxUsers.SelectedItem = null;
                    comboBoxPrice.SelectedItem = null;
                    comboBoxType.SelectedItem = null;
                    comboBoxStatus.SelectedItem = null;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listViewNewChallenge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNewChallenge.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewNewChallenge.SelectedItems[0].Tag as ProjectAccounting;
                comboBoxProjects.SelectedIndex = comboBoxProjects.FindString(projectAccounting.IDProject.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(projectAccounting.IDClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxUsers.SelectedIndex = comboBoxUsers.FindString(projectAccounting.IDUser.ToString());
                comboBoxPrice.SelectedIndex = comboBoxPrice.FindString(projectAccounting.IDPrice.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxStatus.Text = projectAccounting.Status;
            }
            else
            {
                comboBoxProjects.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxUsers.SelectedItem = null;
                comboBoxPrice.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        

















        private void listViewInWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInWork.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewInWork.SelectedItems[0].Tag as ProjectAccounting;
                comboBoxProjects.SelectedIndex = comboBoxProjects.FindString(projectAccounting.IDProject.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(projectAccounting.IDClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxUsers.SelectedIndex = comboBoxUsers.FindString(projectAccounting.IDUser.ToString());
                comboBoxPrice.SelectedIndex = comboBoxPrice.FindString(projectAccounting.IDPrice.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxStatus.Text = projectAccounting.Status;
            }
            else
            {
                comboBoxProjects.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxUsers.SelectedItem = null;
                comboBoxPrice.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void listViewReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReview.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewReview.SelectedItems[0].Tag as ProjectAccounting;
                comboBoxProjects.SelectedIndex = comboBoxProjects.FindString(projectAccounting.IDProject.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(projectAccounting.IDClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxUsers.SelectedIndex = comboBoxUsers.FindString(projectAccounting.IDUser.ToString());
                comboBoxPrice.SelectedIndex = comboBoxPrice.FindString(projectAccounting.IDPrice.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxStatus.Text = projectAccounting.Status;
            }
            else
            {
                comboBoxProjects.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxUsers.SelectedItem = null;
                comboBoxPrice.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void listViewTesting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTesting.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewTesting.SelectedItems[0].Tag as ProjectAccounting;
                comboBoxProjects.SelectedIndex = comboBoxProjects.FindString(projectAccounting.IDProject.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(projectAccounting.IDClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxUsers.SelectedIndex = comboBoxUsers.FindString(projectAccounting.IDUser.ToString());
                comboBoxPrice.SelectedIndex = comboBoxPrice.FindString(projectAccounting.IDPrice.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxStatus.Text = projectAccounting.Status;
            }
            else
            {
                comboBoxProjects.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxUsers.SelectedItem = null;
                comboBoxPrice.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void listViewReady_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReady.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewReady.SelectedItems[0].Tag as ProjectAccounting;
                comboBoxProjects.SelectedIndex = comboBoxProjects.FindString(projectAccounting.IDProject.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(projectAccounting.IDClient.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxUsers.SelectedIndex = comboBoxUsers.FindString(projectAccounting.IDUser.ToString());
                comboBoxPrice.SelectedIndex = comboBoxPrice.FindString(projectAccounting.IDPrice.ToString());
                comboBoxType.SelectedIndex = comboBoxType.FindString(projectAccounting.IDType.ToString());
                comboBoxStatus.Text = projectAccounting.Status;
            }
            else
            {
                comboBoxProjects.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxUsers.SelectedItem = null;
                comboBoxPrice.SelectedItem = null;
                comboBoxType.SelectedItem = null;
                comboBoxStatus.SelectedItem = null;
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            if (listViewNewChallenge.SelectedItems.Count==1)
            {
                ProjectAccounting projectAccounting = listViewNewChallenge.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.SelectedItem.ToString();
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewNewChallenge();
            }
        }

        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            if (listViewInWork.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewInWork.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.SelectedItem.ToString();
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewInWork();
            }
        }

        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            if (listViewReview.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewReview.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.SelectedItem.ToString();
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewReview();
            }
        }

        private void buttonEdit4_Click(object sender, EventArgs e)
        {
            if (listViewTesting.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewTesting.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.SelectedItem.ToString();
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewTesting();
            }
        }

        private void buttonEdit5_Click(object sender, EventArgs e)
        {
            if (listViewReady.SelectedItems.Count == 1)
            {
                ProjectAccounting projectAccounting = listViewReady.SelectedItems[0].Tag as ProjectAccounting;
                projectAccounting.IDProject = Convert.ToInt32(comboBoxProjects.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDType = Convert.ToInt32(comboBoxType.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDUser = Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.IDPrice = Convert.ToInt32(comboBoxPrice.SelectedItem.ToString().Split('.')[0]);
                projectAccounting.Status = comboBoxStatus.SelectedItem.ToString();
                Program.projectForSinaptic.SaveChanges();
                ShowlistViewReady();
            }
        }
    }
}
