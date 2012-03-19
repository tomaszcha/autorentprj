using ModelMock;
using System;

namespace CustomerModule.ViewModels
{
    public class CityViewModel
    {
        #region Constructor

        public CityViewModel(City city)
        {
            Id = city.Id;
            Name = city.Name;
        }

        #endregion Constructor

        #region Fields

        #region public

        /// <summary>
        /// Unique identifier of the city
        /// </summary>
        public int Id 
        {
            get { return _id; }
            private set { _id = value; } 
        }

        /// <summary>
        /// City name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        #endregion public

        #region privare

        private int _id;

        private string _name;

        #endregion private

        #endregion Fields
    }
}
