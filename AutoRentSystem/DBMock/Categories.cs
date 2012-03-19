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
    public class Categories
    {
        public List<Category> List;

        public Categories()
        {
            List = new List<Category>
            {
                new Category{Id=0, Deposit=0, Name="Economy"},
                new Category{Id=1, Deposit=0, Name="Middle"},
                new Category{Id=2, Deposit=2000, Name="Premium"},
            };
        }

    }
}
