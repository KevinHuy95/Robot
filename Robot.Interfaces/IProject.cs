using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces
{
    public interface IProject
    {
        bool IsExpanded { get; set; }
        bool disable_local_caching { get; set; }
        string Path { get; set; }
        ObservableCollection<IWorkflow> Workflows { get; set; }
        Newtonsoft.Json.Linq.JObject dependencies { get; set; }
    }
}
