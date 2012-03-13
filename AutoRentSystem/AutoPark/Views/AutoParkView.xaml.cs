using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AutoPark.ViewModels;
using Microsoft.Practices.Unity;
using ModelMock;
using ModulesInfrastructure.Views;

namespace AutoPark.Views
{
    public partial class AutoParkView : UserControl, IViewRightRegion
    {
        public List<Model> list;

        public AutoParkView()
        {
            InitializeComponent();
            list = new List<Model>()
                                     {
                                         new Model
                                             {
                                                 Id = 1,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "CX-5",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 HourRate = 300,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 2,
                                                 Make = new Make() {Id = 1, Name = "Opel"},
                                                 Name = "Antara",
                                                 EngineCapacity = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 HourRate = 400,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 3,
                                                 Make = new Make() {Id = 1, Name = "Lexus"},
                                                 Name = "Es",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 HourRate = 500,
                                                 Deposit = 1100
                                             }
                                     };
            myList.ItemsSource = list;

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
