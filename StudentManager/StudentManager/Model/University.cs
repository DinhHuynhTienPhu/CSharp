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


        internal List<Department> Departments { get => _departments; set => _departments = value; }

        private List<Department> _departments  = new List<Department>();
        
    }
}
