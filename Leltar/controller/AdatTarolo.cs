using Leltar.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.controller
{
    class AdatTarolo
    {
        
        private static AdatTarolo adatok = new AdatTarolo();
        public static AdatTarolo Adatok
        {
            get { return adatok; }
        }

        private List<Terem> termek;

        private AdatTarolo()
        {
            termek = AdatGenerator.Letrehoz();
        }

        public List<Terem> Termek()
        {
            return termek;
        }

        public Szamitogep Gep(string azonosito)
        {
            foreach (var terem in termek)
            {
                Szamitogep keresettGep = Gep(azonosito, terem.Elrendezes.Bal);
                if (keresettGep != null)
                {
                    return keresettGep;
                }


                keresettGep = Gep(azonosito, terem.Elrendezes.Jobb);
                if (keresettGep != null)
                {
                    return keresettGep;
                }
            }

            return null;
        }

        private Szamitogep Gep(string azonosito, Oldal oldal)
        {
            foreach (var sorok in oldal.sorok)
            {
                foreach (var gep in sorok.Gepek)
                {
                    if (gep.Azonosito == azonosito)
                    {
                        return gep;
                    }
                }
            }
            return null;
        }
    }
}
