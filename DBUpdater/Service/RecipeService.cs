using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUpdater.Service
{
    class RecipeService
    {
        DBRecipeRepository repo;

        public RecipeService()
        {
            this.repo = new DBRecipeRepository();
        }

        public ArrayList findAll()
        {
            return repo.FindAllPPID();
        }
    }
}
