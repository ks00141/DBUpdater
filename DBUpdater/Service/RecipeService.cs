using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUpdater.Repository;

namespace DBUpdater.Service
{
    public class RecipeService
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
