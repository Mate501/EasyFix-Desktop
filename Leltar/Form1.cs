using Leltar.controller;
using Leltar.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Leltar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var tarolo =AdatTarolo.Adatok;
            foreach (var terem in tarolo.Termek())
            {
                listBoxTermek.Items.Add(terem);
            }
        }

        private void listBoxTermek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Terem kivalasztott = listBoxTermek.SelectedItem as Terem;
            oszlopBalFrissites(kivalasztott.Elrendezes.Bal);
            oszlopJobbFrissites(kivalasztott.Elrendezes.Jobb);
        }

        private void oszlopJobbFrissites(Oldal oszlop)
        {
            panelJobb.Controls.Clear();
            Button button = new Button { Height = 40, Width = 120 };
            int padding = 30;
            var magassag = panelJobb.Size.Height - button.Height;
            foreach (Sor sor in oszlop.sorok)
            {
                var szelesseg =  panelJobb.Width - button.Width;
                for (int i = 0; i < sor.Gepek.Count; i++)
                {
                    button = new Button { Height = 40, Width = 120 };
                    button.Text = sor.Gepek[i].TermenBeluliSorszam.ToString();
                    button.Tag = sor.Gepek[i];
                    button.Click += gombnyomas;
                    button.Location = new Point(szelesseg, magassag);
                    szelesseg -= (button.Width);
                    panelJobb.Controls.Add(button);
                }
                magassag -= (button.Height + padding);
                
            }
        }

        private void gombnyomas(object sender, EventArgs e)
        {
            Form2 ujForm = new Form2();
            Szamitogep gep = (sender as Button).Tag as Szamitogep;
            ujForm.Init(listBoxTermek.SelectedItem.ToString(), gep);
            ujForm.Show();
        }

        private void oszlopBalFrissites(Oldal oszlop)
        {
            panelBal.Controls.Clear();
            Button button = new Button { Height = 40, Width = 120 };
            int padding = 30;
            var magassag = panelBal.Size.Height - button.Height;
            foreach (Sor sor in oszlop.sorok)
            {
                var szelesseg = 0;
                for (int i = 0; i < sor.Gepek.Count; i++)
                {
                    button = new Button { Height = 40, Width = 120 };
                    button.Text = sor.Gepek[i].TermenBeluliSorszam.ToString();
                    button.Tag = sor.Gepek[i];
                    button.Click += gombnyomas;
                    button.Location = new Point(szelesseg, magassag);
                    szelesseg += (button.Width);
                    panelBal.Controls.Add(button);
                }
                magassag -= (button.Height + padding);

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int panelBalStart = listBoxTermek.Location.X + listBoxTermek.Width + 15;
            panelBal.Width = (Width - panelBalStart) / 2;
            panelBal.Location = new Point(panelBalStart, panelBal.Location.Y);
            panelJobb.Width = (Width - panelBalStart) / 2;
            panelJobb.Location = new Point(panelBal.Location.X + panelBal.Width, panelJobb.Location.Y);
            button1.Location = new Point(panelBalStart + 
                (Width - panelBalStart) / 2 - button1.Width / 2, button1.Location.Y);

            if (listBoxTermek.SelectedItem != null)
            {
                Terem kivalasztott = listBoxTermek.SelectedItem as Terem;
                oszlopBalFrissites(kivalasztott.Elrendezes.Bal);
                oszlopJobbFrissites(kivalasztott.Elrendezes.Jobb);
            }
        }
    }
}
