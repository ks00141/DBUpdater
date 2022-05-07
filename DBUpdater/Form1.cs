using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBUpdater.View;
using DBUpdater.Presenter;

namespace DBUpdater
{
    public partial class Form1 : Form, IRecipeList, IRecipeCount
    {
        public string[] RecipeList
        {
            get
            {
                ListViewItem item = lvRecipelist.SelectedItems[0];
                int columnCnt = item.SubItems.Count;
                string[] returnValue = new string[columnCnt];
                foreach(ListViewItem.ListViewSubItemCollection _value in item.SubItems)
                for(int i=0; i<columnCnt; i++)
                    {
                        returnValue[i] = item.SubItems[i].Text;
                    }
                return returnValue;
            }
            set => lvRecipelist.Items.Add(new ListViewItem(value));
        }

        public string RecipeCount { get => lblTotalCnt.Text; set => lblTotalCnt.Text = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lvRecipelist.Items.Clear();
            RecipePresenter recipePresenter = new RecipePresenter(this);
            RecipeCountPresenter recipeCountPresenter = new RecipeCountPresenter(this);
            recipePresenter.getRecipeList();
            recipeCountPresenter.getRecipeCount();
        }
    }
}
