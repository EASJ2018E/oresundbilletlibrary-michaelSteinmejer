using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace Oeresundbro
{
    public class Kunder
    {
        public string Nummerplade { get; set; }

        public List<Transportmiddel> Køretøjliste;

        public Kunder()
        {
            Køretøjliste = new List<Transportmiddel>();
        }

       
        public void Add(Transportmiddel trans)
        {
            Køretøjliste.Add(trans);
        }

       public double PrisSum()
       {
           double pris = 0;
            foreach (var transp in Køretøjliste)
            {
                if (transp.Nummerplade == Nummerplade)
                {
                     pris = pris + transp.Pris();
                    

                }
               
            }
            return pris;
       }
    }

    
}
