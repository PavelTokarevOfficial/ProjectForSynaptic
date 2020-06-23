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
    public partial class FormPriceList : Form
    {
        public FormPriceList()
        {
            InitializeComponent();
            ShowPrice();
        }
        void ShowPrice()
        {
            listViewPrice.Items.Clear();
            foreach(PriceList priceList in Program.projectForSinaptic.PriceList)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    priceList.ID.ToString(),
                    priceList.ProjectСomplexity,
                    priceList.Price
                });
                listViewItem.Tag = priceList;
                listViewPrice.Items.Add(listViewItem);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PriceList priceList = new PriceList();
            priceList.ProjectСomplexity = textBoxProjectСomplexity.Text;
            priceList.Price = textBoxPrice.Text;
            Program.projectForSinaptic.PriceList.Add(priceList);
            Program.projectForSinaptic.SaveChanges();
            ShowPrice();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPrice.SelectedItems.Count == 1)
                {
                    PriceList priceList = listViewPrice.SelectedItems[0].Tag as PriceList;
                    Program.projectForSinaptic.PriceList.Remove(priceList);
                    Program.projectForSinaptic.SaveChanges();
                    ShowPrice();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPrice.SelectedItems.Count == 1)
            {
                PriceList priceList = listViewPrice.SelectedItems[0].Tag as PriceList;
                priceList.ProjectСomplexity = textBoxProjectСomplexity.Text;
                priceList.Price = textBoxPrice.Text;
                Program.projectForSinaptic.SaveChanges();
                ShowPrice();
            }
        }
        private void listViewPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPrice.SelectedItems.Count==1)
            {
                PriceList priceList = listViewPrice.SelectedItems[0].Tag as PriceList;
                textBoxProjectСomplexity.Text = priceList.ProjectСomplexity;
                textBoxPrice.Text = priceList.Price;
            }
            else
            {
                textBoxProjectСomplexity.Text = "";
                textBoxPrice.Text = "";
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
