using System;
using System.Collections.Generic;
using System.Text;

namespace Partiel_Cs_MONIER
{
    public class Log
    {
        //Propriétés
        public string Message { get; set; }
        public DateTime Date  { get; set; }
        public string Niveau  { get; set; }
       

        public Log()
        {
            //Constructeur vide
        }

        //Constructeur
        public Log(string message, string date, string niveau)
        {
            Message = message;
            Date    = date;
            Niveau  = niveau;
        }
    }

    


}
