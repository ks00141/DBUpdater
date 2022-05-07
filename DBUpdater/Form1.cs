using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBUpdater
{
    public partial class Form1 : Form
    {
        RecipeDao dao;
        public Form1()
        {
            InitializeComponent();
            this.dao = new RecipeDao();
            dao.LoadData += addListBox;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lvRecipelist.Items.Clear();
            dao.Select();
        }

        private void addListBox(object sender, Model.RecipeModel model)
        {
            string[] arg = new string[] { model.Device, model.PPID };
            ListViewItem lvi = new ListViewItem(arg);
            lvRecipelist.Items.Add(lvi);
        }

        
    }
}
