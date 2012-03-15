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

namespace ModulesInfrastructure.ViewModels
{
    public class CategoryViewModel : ViewModelBase
    {
        #region Data

        #region public

        /// <summary>
        /// Unique identifier of the auto category
        /// </summary>
        public int Id 
        {
            get { return _id; }
            private set { _id = value; }
        }  

        /// <summary>
        /// Category name
        /// </summary>
        public string Name 
        {
            get { return _name; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    _name = value;
            }
        }   

        /// <summary>
        /// The need to make a deposit for the category
        /// </summary>
        public float Deposit 
        {
            get { return _deposit; }
            set 
            {
                if (value >= 0)
                {
                    _deposit = value;
                }
            } 
        }

        #endregion public

        #region private

        private int _id;

        private string _name;

        private float _deposit;

        #endregion private

        #endregion Data
    }
}
