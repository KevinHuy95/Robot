using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces
{
    public interface IBase
    {
        string _id { get; set; }
        string _type { get; set; }
        string name { get; set; }
        string _createdby { get; set; }
        string _createdbyid { get; set; }
        DateTime _created { get; set; }
        string _modifiedbyid { get; set; }
        string _modifiedby { get; set; }
        DateTime _modified { get; set; }
        long _version { get; set; }
        string[] _encrypt { get; set; }
        entity.ace[] _acl { get; set; }
    }
}
