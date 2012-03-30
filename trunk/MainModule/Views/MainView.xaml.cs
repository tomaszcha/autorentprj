using System.Windows.Controls;
using ModuleInfrastracture.Views;
using Microsoft.Practices.Unity;
using MainModule.ViewModels;

namespace MainModule.Views
{
    public partial class MainView : UserControl, IViewRightRegion
    {
        public MainView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IMainViewModel ViewModel
        {
            get { return DataContext as IMainViewModel; }
            set { DataContext = value; }
        } 
    }
}
