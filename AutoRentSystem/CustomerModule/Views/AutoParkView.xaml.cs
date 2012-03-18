using CustomerModule.ViewModels;
using Microsoft.Practices.Unity;
using ModulesInfrastructure.Views;
using System.Windows.Controls;

namespace CustomerModule.Views
{
    public partial class AutoParkView : UserControl, IViewRightRegion
    {
       // public List<Model> list;

        public AutoParkView()
        {
            InitializeComponent();           
        }

        [Dependency]
        public IAutoParkViewModel ViewModel
        {
            get { return DataContext as IAutoParkViewModel; }
            set { DataContext = value; }
        }

        #region Implementation of IAutoParkView
        
       /* [Dependency]
        public IAutoParkViewModel ViewModel
        {
            get { return DataContext as IAutoParkViewModel; }
            set { DataContext = value; }
        }
        */
        #endregion
    }
}
