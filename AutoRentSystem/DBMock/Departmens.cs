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
    public class Departmens
    {
        public List<Department> List;
        private List<City> _cities;

        public Departmens()
        {
            _cities=new Cities().List;
            List = new List<Department>
            {
                new Department{Address="Topol", City=_cities[0], Id=1, Phone="05631456"},
                new Department{Address="Gitomerskaia", City=_cities[1], Id=2, Phone="04455464"},
                new Department{Address="Mukachevo", City=_cities[2], Id=1, Phone="056351456"}
            };
        }

    }
}
