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
        Presenter.RecipePresenter presenter;
        public Form1()
        {
            InitializeComponent();
            this.presenter = new Presenter.RecipePresenter();
            presenter.AddRecipeListHandler += addListBox;
            presenter.RecipeCountHandler += showCount;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lvRecipelist.Items.Clear();
            presenter.getRecipeList();
        }

        private void addListBox(object sender, string[] arg)
        {
            ListViewItem lvi = new ListViewItem(arg);
            lvRecipelist.Items.Add(lvi);
        }

        private void showCount(object sender, int count)
        {
            lblTotalCnt.Text = count.ToString();
        }
        
    }
}
