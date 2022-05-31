using Robot.Interfaces.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces
{
    public class Workflow : apibase, IWorkflow
    {
        public IProject Project { get; set; }
        public long current_version { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string queue { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string Xaml { get { return GetProperty<string>(); } set { _activity = null; SetProperty(value); } }
        public string projectid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string RelativeFilename => throw new NotImplementedException();

        public string IDOrRelativeFilename => throw new NotImplementedException();

        public string FilePath
        {
            get
            {
                return System.IO.Path.Combine(Project.Path, Filename);
            }
        }

        public string Filename { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public bool Serializable { get { return GetProperty<bool>(); } set { SetProperty(value); } }
    }
}
