using Robot.Interfaces;
using System;
using System.Activities;
using System.Activities.Debugger;
using System.Activities.Presentation.Model;
using System.Activities.Presentation.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robot.Views
{
    /// <summary>
    /// Interaction logic for WFDesigner.xaml
    /// </summary>
    public partial class WFDesigner : UserControl, System.ComponentModel.INotifyPropertyChanged, IDesigner
    {
        public DelegateCommand DockAsDocumentCommand = new DelegateCommand((e) => { }, (e) => false);
        public DelegateCommand AutoHideCommand { get; set; } = new DelegateCommand((e) => { }, (e) => false);
        public bool CanClose { get; set; } = true;
        public bool CanHide { get; set; } = false;
        public Dictionary<ModelItem, SourceLocation> _modelLocationMapping = new Dictionary<ModelItem, SourceLocation>();
        public Dictionary<string, SourceLocation> _sourceLocationMapping = new Dictionary<string, SourceLocation>();
        public Dictionary<string, Activity> _activityIdMapping = new Dictionary<string, Activity>();
        public Dictionary<Activity, SourceLocation> _activitysourceLocationMapping = new Dictionary<Activity, SourceLocation>();
        public Dictionary<string, ModelItem> _activityIdModelItemMapping = new Dictionary<string, ModelItem>();
        private string SelectedVariableName = null;
        private Selection selection = null;
        private readonly MenuItem runthis;
        private readonly MenuItem runFromHere;
        private readonly MenuItem comment;
        private readonly MenuItem uncomment;
        public bool BreakPointhit { get; set; }
        public bool Singlestep { get; set; }
        public bool SlowMotion { get; set; }
        public bool VisualTracking { get; set; }

        public WFDesigner()
        {
            InitializeComponent();
        }

        public IWorkflow Workflow { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool VisualTracking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool SlowMotion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDictionary<System.Activities.Debugger.SourceLocation, System.Activities.Presentation.Debug.BreakpointTypes> BreakpointLocations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void forceHasChanged(bool value)
        {
            throw new NotImplementedException();
        }

        public System.Activities.Argument GetArgument(string Name, bool add, Type type)
        {
            throw new NotImplementedException();
        }

        public System.Activities.DynamicActivityProperty GetArgumentOf<T>(string Name, bool add)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.KeyedCollection<string, System.Activities.DynamicActivityProperty> GetParameters()
        {
            throw new NotImplementedException();
        }

        public System.Activities.Variable GetVariable(string Name, Type type)
        {
            throw new NotImplementedException();
        }

        public System.Activities.Variable<T> GetVariableOf<T>(string Name)
        {
            throw new NotImplementedException();
        }

        public List<System.Activities.Presentation.Model.ModelItem> GetWorkflowActivities()
        {
            throw new NotImplementedException();
        }

        public void IdleOrComplete(IWorkflowInstance instance, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnVisualTracking(IWorkflowInstance Instance, string ActivityId, string ChildActivityId, string State)
        {
            throw new NotImplementedException();
        }

        public void Run(bool VisualTracking, bool SlowMotion, IWorkflowInstance instance)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
