using Microsoft.Practices.Unity;
using CustomerModule.ModelViews;
using System.Windows.Controls;

namespace CustomerModule.Views
{
    public partial class MenuView : UserControl, IMenuView
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
