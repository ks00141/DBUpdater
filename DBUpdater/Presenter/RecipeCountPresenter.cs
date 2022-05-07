using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUpdater.View;
using DBUpdater.Service;

namespace DBUpdater.Presenter
{
    public class RecipeCountPresenter
    {
        IRecipeCount recipeCountView;

        public RecipeCountPresenter(IRecipeCount view)
        {
            this.recipeCountView = view;
        }

        public void getRecipeCount()
        {
            RecipeService service = new RecipeService();
            recipeCountView.RecipeCount = service.findAll().Count.ToString();
        }
    }
}
