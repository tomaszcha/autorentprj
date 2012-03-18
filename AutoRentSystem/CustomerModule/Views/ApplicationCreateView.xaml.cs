using Microsoft.Practices.Unity;
using ModulesInfrastructure.Views;
using System.Windows.Controls;
using CustomerModule.ViewModels;

namespace CustomerModule.Views
{
    public partial class ApplicationCreateView : UserControl, IViewLeftRegion
    {
        public ApplicationCreateView()
        {
            InitializeComponent();
        }

        [Dependency]
        public IApplicationCreateViewModel ViewModel
        {
            get { return DataContext as IApplicationCreateViewModel; }
            set { DataContext = value; }
        }
    }
}
