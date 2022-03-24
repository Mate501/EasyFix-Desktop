using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.model
{
    class Elrendezes
    {
        public Oszlop Bal { get; set; }
        public Oszlop Jobb { get; set; }
    }
    class Oszlop
    {
        public List<Sor> sorok { get; set; }
    }

    class Sor
    {
        public int Hossz { get; set; }
    }
}
