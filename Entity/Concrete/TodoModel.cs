using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class TodoModel
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool isDone { get; set; }
    }
}
