using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class Class:Department
    {
        internal List<Student> Students { get; set; } = new List<Student>();

    }
}
