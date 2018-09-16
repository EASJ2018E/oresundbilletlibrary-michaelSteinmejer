using System;
using BilletLibrary;

namespace Oeresundbro
{
    public class Oeresundbil: Transportmiddel
    {
        public Oeresundbil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
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
            return Brobizz ? 161 : 410;
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }
    }
}
