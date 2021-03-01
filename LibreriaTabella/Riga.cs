using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaTabella
{
    public class Riga
    {
        List<Cella> Celle = new List<Cella>();
        public void AggiungiCella(Cella c)
        {
            Celle.Add(c);
        }
    }
}
