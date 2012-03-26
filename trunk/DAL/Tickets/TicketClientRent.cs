using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL.Tickets
{
    public class TicketClientRent : ITicketAdmin
    {
        #region Members ITicketAdmin

        public int AddTicket(Ticket ticket)
        {
            AutoRentEntities autorent = new AutoRentEntities();
            autorent.AddToTicket(ticket);
            return 0;
            //return autorent.Ticket;
        }

        public void SetTicketState(short state)
        {
            throw new NotImplementedException();
        }

        public void EditTicket()
        {
            throw new NotImplementedException();
        }

        public void RejectTicket()
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket()
        {
            throw new NotImplementedException();
        }

        public void ProcessTicket()
        {
            throw new NotImplementedException();
        }

        public List<Model.Ticket> GetTicketList()
        {
            throw new NotImplementedException();
        }

        public void ReassignTicket()
        {
            throw new NotImplementedException();
        }

        public void CloseTicket()
        {
            throw new NotImplementedException();
        }

        #endregion Members ITicketAdmin
    }
}
