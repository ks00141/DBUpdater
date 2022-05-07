using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUpdater.Model
{
    class RecipeModel
    {
        public string Device { get; set; }

        private string ppid;
        public string PPID
        {
            get
            {
                return this.ppid;
            }
            set
            {
                this.ppid = value.Replace('\\','/');
            }
        }
    }
}
