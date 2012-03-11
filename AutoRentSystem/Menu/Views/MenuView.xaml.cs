using Microsoft.Practices.Unity;
using Menu.ModelViews;
using System.Windows.Controls;

namespace Menu.Views
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
