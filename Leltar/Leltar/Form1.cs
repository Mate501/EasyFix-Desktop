using Leltar.controller;
using Leltar.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leltar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var termek = AdatGenerator.Letrehoz();
            foreach (var terem in termek)
            {
                listBoxTermek.Items.Add(terem);
            }
        }

        private void listBoxTermek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terem kivalasztott = listBoxTermek.SelectedItem as Terem;
            oszlopFrissites(panelBal, kivalasztott.Elrendezes.Bal);
            oszlopFrissites(panelJobb, kivalasztott.Elrendezes.Jobb);
        }

        private void oszlopFrissites(Panel panel, Oszlop oszlop)
        {
            panel.Controls.Clear();
            var magassag = panel.Size.Height;
            int padding = 30;
            for (int i = 0; i < oszlop.sorok.Count; i++)
            {
                Sor sor = oszlop.sorok[i];
                Button button = new Button();
                magassag -= (button.Height + padding);
                button.Location = new Point(0, magassag);
                panel.Controls.Add(button);
            }
        }
    }
}
