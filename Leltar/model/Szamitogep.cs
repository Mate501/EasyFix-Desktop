using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.model
{
    class Szamitogep
    {
        public string Azonosito { get; set; }
        public int TermenBeluliSorszam { get; set; }
        public List<Hiba> Hibak { get; set; }
    }
}
