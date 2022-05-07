using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using MySql.Data.MySqlClient;

namespace DBUpdater.Repository
{
    class DBConnectorFactory
    {
        private StringBuilder strArg;

        private MySqlConnection conn;
        public MySqlConnection MySqlConn
        {
            get
            {
                this.conn = new MySqlConnection(this.strArg.ToString());
                return this.conn;
            }
        }
        public DBConnectorFactory()
        {
            using (StreamReader file = File.OpenText("dbConfig.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                strArg = new StringBuilder();
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
            }
        }
    }
}
