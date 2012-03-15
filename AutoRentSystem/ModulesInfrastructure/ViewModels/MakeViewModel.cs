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
using System.ComponentModel;
using System.Windows.Input;
using ModelMock;

namespace ModulesInfrastructure.ViewModels
{
    public class MakeViewModel : ViewModelBase, IDataErrorInfo
    {

        #region Constructor

        public MakeViewModel(Make make)
        {
            _id = make.Id;
            _name = make.Name;
        }

        #endregion Constructor

        #region Data

        #region public

        /// <summary>
        /// Unique identifier of the make
        /// </summary>
        public int Id 
        {
            get { return _id; }
            private set { _id = value; } 
        }   

        /// <summary>
        /// Name of the make 
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

        #region private

        private int _id;

        private string _name;

        #endregion private

        #endregion Data

        #region Public Methods

        public bool IsNull()
        {
            return String.IsNullOrEmpty(_name);
        }

        #endregion Public Method

        #region IDataErrorInfo members

        public string Error
        {
            get { return (this as IDataErrorInfo).Error; }
        }

        public string this[string columnName]
        {
            get 
            {
                string error = (this as IDataErrorInfo)[columnName];

                //CommandManager.InvalidateRequerySuggested();
                return error;
            }
        }

        #endregion IDataErrorInfo members
    }
}
