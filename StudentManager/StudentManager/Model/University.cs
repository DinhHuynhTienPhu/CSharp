using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class University
    {
        private string _name;
        public string Name   
        {
            get { return _name; }   
            set { _name = value; }  
        }

        internal List<Department> Departments { get => _departments; set => _departments = value; }

        private List<Department> _departments  = new List<Department>();
        
    }
}
