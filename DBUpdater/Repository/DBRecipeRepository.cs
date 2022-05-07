using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DBUpdater
{
    class DBRecipeRepository
    {
        MySqlConnection conn = null;
        public DBRecipeRepository()
        {
            this.conn = new Repository.DBConnectorFactory().MySqlConn;
        }

        public ArrayList FindAllPPID()
        {
            ArrayList Recipes = new ArrayList();
            string query = "SELECT * FROM recipe.ppid";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ppid = rdr["ppid"].ToString();
                string device = rdr["device"].ToString();

                Recipes.Add(new Model.RecipeModel()
                {
                    Device = device,
                    PPID = ppid
                });
            }
            rdr.Close();
            conn.Close();

            return Recipes;
        }
    }
}
