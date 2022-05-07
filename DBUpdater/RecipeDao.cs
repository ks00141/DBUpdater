using System;
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
    class RecipeDao
    {
        public event EventHandler<Model.RecipeModel> LoadData;

        string query;
        MySqlConnection conn = null;
        public RecipeDao()
        {
            this.query = "SELECT * FROM recipe.ppid";
            conn = new MySqlConnection(DbArg());
        }

        private string DbArg()
        {

            using (StreamReader file = File.OpenText("dbConfig.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                StringBuilder strArg = new StringBuilder();
                strArg.Append("Server=");
                strArg.Append(json["ip"].ToString());
                strArg.Append(";Port=");
                strArg.Append(json["port"].ToString());
                strArg.Append(";Uid=");
                strArg.Append(json["id"].ToString());
                strArg.Append(";Pwd=");
                strArg.Append(json["pw"].ToString());
                strArg.Append(";Database=");
                strArg.Append(json["database"].ToString());

                return strArg.ToString();
            }
        }

        public void Select()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ppid = rdr["ppid"].ToString();
                string device = rdr["device"].ToString();

                if(LoadData != null)
                {
                    LoadData(this, new Model.RecipeModel()
                    {
                        PPID=ppid, 
                        Device=device
                    }
                    );
                }
            }
            rdr.Close();
            conn.Close();
        }
    }
}
