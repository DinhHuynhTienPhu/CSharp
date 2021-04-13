using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class Department:University
    {


        private List<Class> _classes = new List<Class>();

        internal List<Class> Classes { get => _classes; set => _classes = value; }
    }
}
