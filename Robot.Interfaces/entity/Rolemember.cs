using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces.entity
{
    public class Rolemember
    {
        public string _id { get; set; }
        public string  name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
