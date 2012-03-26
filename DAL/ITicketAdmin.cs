using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public interface ITicketAdmin
    {
        int AddTicket(Ticket ticket);
        void SetTicketState(short state);
        void EditTicket();
        void RejectTicket();
        void DeleteTicket();
        void ProcessTicket();
        List<Ticket> GetTicketList();
        void ReassignTicket();
        void CloseTicket();
    }
}
