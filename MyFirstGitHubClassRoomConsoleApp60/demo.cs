using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class demo
    {
        #region Instances
        int _id = 0;
        #endregion
        #region Properties
        public int ID 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor
        public demo(string name, string description)
        {
            _id++;
            Name = name;
            Description = description;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"ID: {_id}\nName: {Name}\nDescription: {Description}";
        }
        #endregion
    }
}
