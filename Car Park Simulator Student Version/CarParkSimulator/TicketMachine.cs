using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketMachine
        private string displaymessage
        
    {
    
      //public void AssignCarPark()
        //{
           //needs main carpark class to function
      //  }

    
    
    
      public void PrintTicket()
        {
            displaymessage = "Thank you, enjoy your stay.";
            //Ticket Dispensing
            //add it to the to list of active tickets
     
        }
          public void CarArrived()
        {
           displaymessage = "Please press to get a ticket.";
        }

        public void ClearMessage()
        {
            displaymessage = string.Empty; //clear the meassage on the ticket machine
        }
        
       public string displaymessage
       {
          return displaymessage;
       
       }

    
    }
}
