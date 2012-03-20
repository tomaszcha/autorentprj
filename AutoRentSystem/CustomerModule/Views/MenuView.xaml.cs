using Microsoft.Practices.Unity;
using CustomerModule.ModelViews;
using System.Windows.Controls;
using ModulesInfrastructure.Views;

namespace CustomerModule.Views
{
    public partial class MenuView : UserControl, IViewMenuRegion
    {
        public MenuView()
        {
            InitializeComponent();
        }
        [Dependency]
        public IMenuViewModel ViewModel
        {
            get { return DataContext as IMenuViewModel; }
            set { DataContext = value; }
        }
    }
}
