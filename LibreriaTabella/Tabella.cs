using System;
using System.Collections.Generic;

namespace LibreriaTabella
{
    public class Tabella
    {
        List<Riga> Righe = new List<Riga>();
        public void AggiungiRiga(Riga r)
        {
            Righe.Add(r);
        }
    }
}
