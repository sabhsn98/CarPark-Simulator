using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class TicketValidator
        
    {
        private string displaymessage;
        
        
        public void ClearMessage()
        {
           displaymessage = string.empty();
            
        }
        
        public void CarArrived()
        {
            displaymessage = "Please insert your ticket.";
        }
        
        public void TicketEntered()
        {
            displaymessage = "Thank you, drive safely.";
            //call to validate the ticket
            //remvove it from activetickets. 
        
    }
}
