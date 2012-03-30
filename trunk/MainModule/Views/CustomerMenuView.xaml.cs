
using System.Windows.Controls;
using ModuleInfrastracture.Views;
using Microsoft.Practices.Unity;
using MainModule.ViewModels;

namespace MainModule.Views
{
    public partial class CustomerMenuView : UserControl, IViewMenuRegion
    {
        public CustomerMenuView()
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
