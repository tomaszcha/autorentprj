using System.Collections.Generic;
using ModelMock;

namespace DBMock
{
    public class Models
    {
        public List<Model> List;
        public Models()
        {
            List = new List<Model>()
                                     {
                                         new Model
                                             {
                                                 Id = 1,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "CX-5",
                                                 EngineCapacity = "2",
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
                                                 EngineCapacity = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 KmRate = 12,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 3,
                                                 Make = new Make() {Id = 1, Name = "Lexus"},
                                                 Name = "EsKKK",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 KmRate = 15,
                                                 Deposit = 1100
                                             },
                                            new Model
                                             {
                                                 Id = 1,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "CX-5KKK",
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 KmRate = 10,
                                                 Deposit = 0
                                             },
                                         new Model
                                             {
                                                 Id = 2,
                                                 Make = new Make() {Id = 1, Name = "Opel"},
                                                 Name = "AntaraKK",
                                                 EngineCapacity = "2.2",
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
                                                 EngineCapacity = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 KmRate = 15,
                                                 Deposit = 1100
                                             }
                                     };
        }
    }
}
