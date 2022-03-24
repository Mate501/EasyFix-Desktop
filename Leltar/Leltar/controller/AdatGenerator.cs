using Leltar.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leltar.controller
{
    static class AdatGenerator
    {
        public static List<Terem> Letrehoz() {
            List<Terem> termek = new List<Terem>();
            Szamitogep[] gepek = SzamitogepGeneralas(50);


            termek.Add(new Terem
            {
                Epulet = 'A',
                SzobaSzam = 222,
                Elrendezes = new Elrendezes {
                    Bal = new Oszlop {
                        sorok = new List<Sor> {
                            new Sor{ Hossz = 4 },
                            new Sor{ Hossz = 3 },
                            new Sor{ Hossz = 4 }
                        }
                    },
                    Jobb = new Oszlop {
                        sorok = new List<Sor> {
                            new Sor{ Hossz = 4 },
                            new Sor{ Hossz = 3 },
                            new Sor{ Hossz = 4 }
                        }
                    }
                },
                Szamitogepek = SzotarLetrehozas(gepek, 0, 25)
            }) ;

            termek.Add(new Terem
            {
                Epulet = 'B',
                SzobaSzam = 303,
                Elrendezes = new Elrendezes
                {
                    Bal = new Oszlop
                    {
                        sorok = new List<Sor> {
                            new Sor{ Hossz = 4 },
                            new Sor{ Hossz = 4 }
                        }
                    },
                    Jobb = new Oszlop
                    {
                        sorok = new List<Sor> {
                            new Sor{ Hossz = 4 },
                            new Sor{ Hossz = 3 },
                            new Sor{ Hossz = 4 }
                        }
                    }
                },
                Szamitogepek = SzotarLetrehozas(gepek, 25, 50)
            });
            return termek;
        }

        private static Dictionary<int, Szamitogep> SzotarLetrehozas(Szamitogep[] gepek, int mettol, int meddig)
        {
            Dictionary<int, Szamitogep> teremGepei = new Dictionary<int, Szamitogep>();
            int sorSzam = 1;
            for (int i = mettol; i < meddig; i++)
            {
                teremGepei.Add(sorSzam++, gepek[i]);
            }
            return teremGepei;
        }

        private static Szamitogep[] SzamitogepGeneralas(int db)
        {
            Szamitogep[] gepek = new Szamitogep[db];
            for (int i = 0; i < db; i++)
            {
                gepek[i] = new Szamitogep {
                    Azonosito = $"SZG_{i + 1}",
                    Hibak = new List<Hiba>()
                };
            }

            return gepek;
        }
    }
}
