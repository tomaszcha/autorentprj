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
using ModulesInfrastructure.ViewModels;


namespace CustomerModule.ViewModels
{
    public class ConditionalOfRentalViewModel : ViewModelBase, IConditionalOfRentalViewModel
    {
        string _conditionsHead;
        string _conditions;
        string _includePriceHead;
        string _includePrice;
        string _excludePriceHead;
        string _excludePrice;
        string _addFeesHead;
        string _addFees;
        

        public ConditionalOfRentalViewModel()
        {
            ConditionsHead = "Interstate cars are available for hire to anyone who:";
            Conditions = "      Is at least 21 years old  \n      Has a minimum of 2 years driving experience \n      Has a valid passport, insuarance and driving license";
            IncludePriceHead = "Our prices include:";
            IncludePrice = "      Car rental \n      Technical checkup";
            ExcludePriceHead = "Our prices exclude:";
            ExcludePrice = "      Fuel cost \n      Parking expenses \n      Fines \n      Tires repair";
            AddFeesHead = "Additional fees";
            AddFees = "      Car wash (if the vehicle is returned dirty) \n      Fuel (if the vehicle is returned with less fuel than was supplied at the time of collection)";
        }

        public string ConditionsHead
        {
            get { return _conditionsHead; }
            set
            {
                _conditionsHead = value;
                OnPropertyChanged("ConditionsHead"); 
            }
        }

        public string Conditions
        {
            get { return _conditions; }
            set
            {
                _conditions = value;
                OnPropertyChanged("Conditions");
            }
        }

        public string IncludePriceHead
        {
            get { return _includePriceHead; }
            set
            {
                _includePriceHead = value;
                OnPropertyChanged("IncludePriceHead"); 
            }
        }

        public string IncludePrice
        {
            get { return _includePrice; }
            set
            {
                _includePrice = value;
                OnPropertyChanged("IncludePrice");
            }
        }

        public string ExcludePriceHead
        {
            get { return _excludePriceHead; }
            set
            {
                _excludePriceHead = value;
                OnPropertyChanged("ExcludePriceHead");
            }
        }

        public string ExcludePrice
        {
            get { return _excludePrice; }
            set
            {
                _excludePrice = value;
                OnPropertyChanged("ExcludePrice");
            }
        }

        public string AddFeesHead
        {
            get { return _addFeesHead; }
            set
            {
                _addFeesHead = value;
                OnPropertyChanged("AddFeesHead");
            }
        }

        public string AddFees
        {
            get { return _addFees; }
            set
            {
                _addFees = value;
                OnPropertyChanged("AddFees");
            }
        }


    }
}
