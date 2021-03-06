using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.model
{
    class Hiba
    {
        public String Leiras { get; set; }
        public Szemely Bejelento { get; set; }
        public Prioritas Prioritas { get; set; }
        public DateTime Idopont { get; set; }
        public Javitas Javitas { get; set; }

        public override string ToString()
        {
            if (Javitas == null)
            {
                return $"{Bejelento.Nev} - {Leiras}";
            }
            else
            {
                return $"{Bejelento.Nev} - {Leiras} (Javítva)";
            }
        }
    }
}
