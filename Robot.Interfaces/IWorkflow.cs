using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces
{
    public interface IWorkflow: INotifyPropertyChanged, IBase
    {
        long current_version { get; set; }
        string queue { get; set; }
        string Xaml { get; set; }
        string projectid { get; set; }
        string RelativeFilename { get; }
        string IDOrRelativeFilename { get; }
        string FilePath { get; }
        string Filename { get; set; }
        bool Serializable { get; set; }
    }
    public enum worflowparamerterdirection
    {
        @in = 0,
        @out = 1,
        inout = 2,
    }
    public class workflowparameter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public worflowparamerterdirection direction { get; set; }
    }
}
