using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack.Models
{
    public class Player
    {
        public  int wealth{ get;private set;}
        public string password { get; private set; }
        public Hand hand { get; private set; }    
    }
}