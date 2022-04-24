using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.model
{
    class Elrendezes
    {
        public Oldal Bal { get; set; }
        public Oldal Jobb { get; set; }
    }
    class Oldal
    {
        public List<Sor> sorok { get; set; }
    }

    class Sor
    {
        public List<Szamitogep> Gepek { get; set; }
    }
}
