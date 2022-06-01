using Robot.Interfaces.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Interfaces
{
    public class WorkflowInstance : apibase, IWorkflowInstance
    {
        public Dictionary<string, object> Parameters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, object> Bookmarks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string _id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string correlationId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string queuename { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string InstanceId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string WorkflowId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string caller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string xml { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string owner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ownerid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string host { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string fqdn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string errormessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string errorsource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isCompleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool hasError { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string state { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Exception Exception { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Stopwatch runWatch { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Dictionary<string, WorkflowInstanceValueType> Variables { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ResumeBookmark(string bookmarkName, object value)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
