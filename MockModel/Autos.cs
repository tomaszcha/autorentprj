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
using System.Collections.Generic;

namespace MockModel
{
    public class Autos
    {
        public List<Auto> List;
        public Autos()
        {
            List = new List<Auto>
            {
                new Auto{ Number = "AA6145DA", ModelName = "Opel Omega", BodyType = 1, 
                    InsuranceNumber="12111121111", Class = 1, Year = 2009, Mileage = 7000, 
                    Engine = 3, ColorGroup = "White", DayRate = 760, KmRate = 17 },
               new Auto{ Number = "AA1112DA", ModelName = "Opel Astra", BodyType = 1, 
                    InsuranceNumber="22222245454", Class = 1, Year = 2006, Mileage = 9000, 
                    Engine = 2, ColorGroup = "Beige", DayRate = 730, KmRate = 16 },
               new Auto{ Number = "AA3352DA", ModelName = "Ford Cietra", BodyType = 1, 
                    InsuranceNumber="12333331313", Class = 1, Year = 2011, Mileage = 1000, 
                    Engine = 3, ColorGroup = "Blue", DayRate = 700, KmRate = 18 },
               new Auto{ Number = "AA1717DA", ModelName = "Mazda 6", BodyType = 1, 
                    InsuranceNumber="78789797897", Class = 3, Year = 2010, Mileage = 5000, 
                    Engine = 4, ColorGroup = "Green", DayRate = 900, KmRate = 21 },
               new Auto{ Number = "AA4412DA", ModelName = "BMW X6", BodyType = 2, 
                    InsuranceNumber="5645687998", Class = 3, Year = 2011, Mileage = 1500, 
                    Engine = 5, ColorGroup = "White", DayRate = 2000, KmRate = 25, Advance = 2000 }
            };
        }      
    }
}
