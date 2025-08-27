using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class demo
    {
        #region Properties
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
