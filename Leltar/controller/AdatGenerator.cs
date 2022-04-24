using Leltar.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leltar.controller
{
    static class AdatGenerator
    {
        private static Szamitogep[] gepek = SzamitogepGeneralas(50);
        private static int utolsoIndex = 0;

        public static List<Terem> Letrehoz() {
            List<Terem> termek = new List<Terem>();
            termek.Add(new Terem
            {
                Epulet = 'A',
                SzobaSzam = 222,
                Elrendezes = new Elrendezes {
                    Bal = new Oldal {
                        sorok = new List<Sor> {
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(1), kovetkezoGep(2), kovetkezoGep(3) } },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(4), kovetkezoGep(5)} },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(6), kovetkezoGep(7), kovetkezoGep(8) } }
                        }
                    },
                    Jobb = new Oldal {
                        sorok = new List<Sor> {
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(9), kovetkezoGep(10), kovetkezoGep(11) } },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(12), kovetkezoGep(13)} },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(14), kovetkezoGep(15), kovetkezoGep(16) } }
                        }
                    }
                }
            });

            termek.Add(new Terem
            {
                Epulet = 'B',
                SzobaSzam = 303,
                Elrendezes = new Elrendezes
                {
                    Bal = new Oldal
                    {
                        sorok = new List<Sor> {
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(1), kovetkezoGep(2), kovetkezoGep(3) } },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(4), kovetkezoGep(5)} }
                        }
                    },
                    Jobb = new Oldal
                    {
                        sorok = new List<Sor> {
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(6), kovetkezoGep(7), kovetkezoGep(8) } },
                            new Sor{ Gepek = new List<Szamitogep> { kovetkezoGep(9), kovetkezoGep(10)} }
                         }
                    }
                }
                });

            return termek;
        }


        static Szamitogep kovetkezoGep(int teremSorszam) {
            gepek[utolsoIndex].TermenBeluliSorszam = teremSorszam;
            return gepek[utolsoIndex++];
        }

        private static Szamitogep[] SzamitogepGeneralas(int db)
        {
            Szamitogep[] gepek = new Szamitogep[db];
            for (int i = 0; i < db; i++)
            {
                gepek[i] = new Szamitogep {
                    Azonosito = $"SZG_{i + 1}",
                    Hibak = new List<Hiba> { new Hiba { 
                        Leiras = "Hiba leírása.",
                        Bejelento = new Szemely {
                            Nev = "Máté",
                            Email = "mate@gmail.com"
                        },
                        Idopont = DateTime.Now,
                        Prioritas = Prioritas.ATLAGOS
                    } }
                };
            }

            return gepek;
        }
    }
}
