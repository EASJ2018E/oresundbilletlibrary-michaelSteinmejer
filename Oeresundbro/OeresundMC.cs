using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace Oeresundbro
{
    public class OeresundMC: Transportmiddel
    {
        public OeresundMC(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            if (nummerplade.Length >= 8)
            {
                throw new SystemException("Din nummerplade er forkert");
            }
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
        }

        public override double Pris()
        {
            return Brobizz ? 73 : 210;
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }
    }
}
