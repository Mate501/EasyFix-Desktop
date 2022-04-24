using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.model
{
    class Terem
    {
        public char Epulet { get; set; }
        public int SzobaSzam { get; set; }
        public Elrendezes Elrendezes { get; set; }

        public override string ToString()
        {
            return $"{SzobaSzam} - {Epulet} épület";
        }
    } 
}
