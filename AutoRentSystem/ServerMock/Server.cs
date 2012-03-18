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

namespace ServerMock
{
    public class Server
    {
        #region Constructor

        public Server()
        {
            _models = new List<Model>();
        }

        #endregion Constructor

        #region Fields

        public List<Model> Models { get { return _models; } set { _models = value; } }

        private List<Model> _models;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Get list of models
        /// </summary>
        /// <param name="indexFrom">Index, starting from 0, which begins the range</param>
        /// <param name="indexTo">Index of the last element in the range</param>
        /// <returns>List of models</returns>
        public List<Model> GetModelList(int indexFrom, int indexTo)
        {
            if (indexTo >= _models.Count || indexFrom < 0) 
                throw new IndexOutOfRangeException();
            if (indexFrom > indexTo)
                throw new IndexOutOfRangeException();
            return _models.GetRange(indexFrom, indexTo - indexFrom);
        }

        public bool Insert(object item)
        {
            bool res = Commands.InsertCommand(item);
            return res;
        }


        //public List<Model>

        #endregion Methods
    }
}
