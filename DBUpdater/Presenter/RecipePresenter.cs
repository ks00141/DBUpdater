using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUpdater.View;
using DBUpdater.Service;

namespace DBUpdater.Presenter
{
    public class RecipePresenter
    {
        IRecipeList recipeView;

        public RecipePresenter(IRecipeList view)
        {
            this.recipeView = view;
        }

        public void getRecipeList()
        {
            RecipeService service = new RecipeService();
            foreach (Model.RecipeModel recipe in service.findAll())
            {
                recipeView.RecipeList = new string[] { recipe.Device, recipe.PPID };
            }
        }


    }
}
