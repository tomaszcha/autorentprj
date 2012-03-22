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
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 KmRate = 10,
                                                 Deposit = 0, 
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 2,
                                                 Make = new Make() {Id = 2, Name = "Opel"},
                                                 Name = "Antara",
                                                 Engine = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 KmRate = 12,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 3,
                                                 Make = new Make() {Id = 3, Name = "Lexus"},
                                                 Name = "EsKKK",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 KmRate = 15,
                                                 Deposit = 1100,
                                                 Category = 1
                                             },
                                            new Model
                                             {
                                                 Id = 4,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "CX-5KKK",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 KmRate = 10,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 5,
                                                 Make = new Make() {Id = 2, Name = "Opel"},
                                                 Name = "AntaraKK",
                                                 Engine = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 KmRate = 12,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 6,
                                                 Make = new Make() {Id = 3, Name = "Lexus"},
                                                 Name = "Es",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 KmRate = 15,
                                                 Deposit = 1100,
                                                 Category = 1
                                             },
                                             new Model
                                             {
                                                 Id = 7,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "6",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 700,
                                                 KmRate = 10,
                                                 Deposit = 0, 
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 8,
                                                 Make = new Make() {Id = 2, Name = "Opel"},
                                                 Name = "Omega",
                                                 Engine = "2.2",
                                                 Seats = 5,
                                                 DayRate = 850,
                                                 KmRate = 11,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 9,
                                                 Make = new Make() {Id = 3, Name = "Lexus"},
                                                 Name = "E",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 1500,
                                                 KmRate = 17,
                                                 Deposit = 1500,
                                                 Category = 1
                                             },
                                            new Model
                                             {
                                                 Id = 10,
                                                 Make = new Make() {Id = 1, Name = "Mazda"},
                                                 Name = "2",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 600,
                                                 KmRate = 10,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 11,
                                                 Make = new Make() {Id = 2, Name = "Opel"},
                                                 Name = "AntaraKK",
                                                 Engine = "2.2",
                                                 Seats = 5,
                                                 DayRate = 900,
                                                 KmRate = 12,
                                                 Deposit = 0,
                                                 Category = 1
                                             },
                                         new Model
                                             {
                                                 Id = 12,
                                                 Make = new Make() {Id = 3, Name = "Lexus"},
                                                 Name = "Es",
                                                 Engine = "2",
                                                 Seats = 5,
                                                 DayRate = 1100,
                                                 KmRate = 15,
                                                 Deposit = 1100,
                                                 Category = 1
                                             }
                                     };
        }
    }
}
