using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ServerMock;
using ModelMock;

namespace TestProtocol
{
    [TestFixture]
    public class TestModel
    {

        #region Initialize

        [TestFixtureSetUp]
        void Init()
        {
            _server = new Server();
            CreateModelList();
        }          

        #endregion Initialize

        #region Fields

        private Server _server;

        private List<Model> _models;

        #endregion Fiields


        [Test, TestCase(0,3)]
        public void GetModelListTest(int indexFrom, int indexTo)
        {
            _server.GetModelList(indexFrom, indexTo);

            //Assert.AreEqual(true, CompareMathods.Compare<Model>(_server.Models, _models));
        }

        #region Fill test DB

        private void CreateModelList()
        {
            _server.Models = new List<Model> {
                new Model                      
                {
                    Id = 1,
                    Make = new Make() {Id = 1, Name = "Mazda"},
                    Name = "CX-5",
                    Engine = "2",
                    Seats = 5,
                    DayRate = 700,
                    KmRate = 10,
                    Deposit = 0
                },
                new Model
                    {
                        Id = 2,
                        Make = new Make() {Id = 1, Name = "Opel"},
                        Name = "Antara",
                        Engine = "2.2",
                        Seats = 5,
                        DayRate = 900,
                        KmRate = 12,
                        Deposit = 0
                    },
                new Model
                    {
                        Id = 3,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 1100,
                        KmRate = 15,
                        Deposit = 1100
                    },
                new Model
                    {
                        Id = 4,
                        Make = new Make() {Id = 1, Name = "Lexus"},
                        Name = "Es4",
                        Engine = "2",
                        Seats = 5,
                        DayRate = 2000,
                        KmRate = 20,
                        Deposit = 3000
                    }
            };

        }

        //private void CreateModelList()
        //{
        //    _server.Models = new List<Model> {
        //        new Model                      
        //        {
        //            Id = 1,
        //            Make = new Make() {Id = 1, Name = "Mazda"},
        //            Name = "CX-5",
        //            EngineCapacity = "2",
        //            Seats = 5,
        //            DayRate = 700,
        //            KmRate = 10,
        //            Deposit = 0
        //        },
        //        new Model
        //            {
        //                Id = 2,
        //                Make = new Make() {Id = 1, Name = "Opel"},
        //                Name = "Antara",
        //                EngineCapacity = "2.2",
        //                Seats = 5,
        //                DayRate = 900,
        //                KmRate = 12,
        //                Deposit = 0
        //            },
        //        new Model
        //            {
        //                Id = 3,
        //                Make = new Make() {Id = 1, Name = "Lexus"},
        //                Name = "Es",
        //                EngineCapacity = "2",
        //                Seats = 5,
        //                DayRate = 1100,
        //                KmRate = 15,
        //                Deposit = 1100
        //            },
        //        new Model
        //            {
        //                Id = 4,
        //                Make = new Make() {Id = 1, Name = "Lexus"},
        //                Name = "Es4",
        //                EngineCapacity = "2",
        //                Seats = 5,
        //                DayRate = 2000,
        //                KmRate = 20,
        //                Deposit = 3000
        //            }
        //    };

        //}

        #endregion Fill test DB

    }
}
