using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using ModelMock;
using System.Collections.Generic;

namespace DBMock
{
    public class Cities
    {
        public List<City> List;

        public Cities()
        {
            List = new List<City>
            {
                new City{Id=1, Name="Dnepropetrovsk"},
                new City{Id=2, Name="Kiev"},
                new City{Id=3, Name="Livov"}
            };
        }
    }
}
