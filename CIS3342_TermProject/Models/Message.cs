using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS3342_TermProject.Models
{
    public class Message
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public String Content { get; set; }
        public DateTime DateSent { get; set; }
        public String SenderName { get; set; }
        public String ReceiverName { get; set; }
    }
}