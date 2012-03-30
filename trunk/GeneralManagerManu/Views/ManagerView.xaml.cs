using System.Windows.Controls;
using ModuleInfrastracture.Views;
using GeneralManagerManu.ViewModels;
using Microsoft.Practices.Unity;

namespace GeneralManagerManu.Views
{
    public partial class generalManagerView : UserControl, IViewMenuRegion
    {
        public generalManagerView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IManagerViewModel ViewModel
        {
            get { return DataContext as IManagerViewModel; }
            set { DataContext = value; }
        } 
    }
}
