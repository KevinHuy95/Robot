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
        private System.Activities.Activity _activity = null;
        public long current_version { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string queue { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public string Xaml { get { return GetProperty<string>(); } set { _activity = null; SetProperty(value); } }
        public string projectid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string RelativeFilename
        {
            get
            {
                if (Project == null) return Filename;
                if (string.IsNullOrEmpty(Project.Path)) return Filename;
                string lastFolderName = System.IO.Path.GetFileName(Project.Path);
                return System.IO.Path.Combine(lastFolderName, Filename);
            }
        }

        public string IDOrRelativeFilename
        {
            get
            {
                if (string.IsNullOrEmpty(_id)) return RelativeFilename;
                return _id;
            }
        }

        public string FilePath
        {
            get
            {
                return System.IO.Path.Combine(Project.Path, Filename);
            }
        }

        public string Filename { get { return GetProperty<string>(); } set { SetProperty(value); } }
        public bool Serializable { get { return GetProperty<bool>(); } set { SetProperty(value); } }
        private string _ProjectAndName;
        public string ProjectAndName
        {
            get
            {
                if (Project == null)
                {
                    if (!string.IsNullOrEmpty(_ProjectAndName)) return _ProjectAndName;
                    return name;
                }
                return Project.name + "/" + name;
            }
            set
            {
                _ProjectAndName = value;
            }
        }
        public bool IsSelected { get { return GetProperty<bool>(); } set { SetProperty(value); } }
        public List<WorkflowInstance> Instances
        {

        }
        private string laststate = "unloaded";
        public string State
        {
            get
            {
                string state = laststate;
            }
    }
}
