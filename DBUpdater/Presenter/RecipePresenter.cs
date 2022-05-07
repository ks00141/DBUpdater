using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUpdater.Presenter
{
    class RecipePresenter
    {
        public event EventHandler<string[]> AddRecipeListHandler;
        public event EventHandler<int> RecipeCountHandler;
        Service.RecipeService service;

        public RecipePresenter()
        {
            this.service = new Service.RecipeService();
        }

        public void getRecipeList()
        {
            int count = 0;
            foreach(Model.RecipeModel recipe in service.findAll())
            {
                AddRecipeListHandler?.Invoke(
                    this,
                    new string[] {recipe.Device, recipe.PPID }
                    );
                count++;
            }
            RecipeCountHandler?.Invoke(this, count);
            
        }


    }
}
