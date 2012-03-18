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
            //list = new List<Model>()
            //                         {
            //                             new Model
            //                                 {
            //                                     Id = 1,
            //                                     Make = new Make() {Id = 1, Name = "Mazda"},
            //                                     Name = "CX-5",
            //                                     EngineCapacity = "2",
            //                                     Seats = 5,
            //                                     DayRate = 700,
            //                                     HourRate = 300,
            //                                     Deposit = 0
            //                                 },
            //                             new Model
            //                                 {
            //                                     Id = 2,
            //                                     Make = new Make() {Id = 1, Name = "Opel"},
            //                                     Name = "Antara",
            //                                     EngineCapacity = "2.2",
            //                                     Seats = 5,
            //                                     DayRate = 900,
            //                                     HourRate = 400,
            //                                     Deposit = 0
            //                                 },
            //                             new Model
            //                                 {
            //                                     Id = 3,
            //                                     Make = new Make() {Id = 1, Name = "Lexus"},
            //                                     Name = "Es",
            //                                     EngineCapacity = "2",
            //                                     Seats = 5,
            //                                     DayRate = 1100,
            //                                     HourRate = 500,
            //                                     Deposit = 1100
            //                                 }
            //                         };
            //myList.ItemsSource = list;

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
