using Leltar.model;
using System;
using System.IO;
using System.Windows.Forms;

namespace Leltar
{
    public partial class Form2 : Form, IJavitas
    {
        private Szamitogep gep;
        public Form2()
        {
            InitializeComponent();
            comboBoxPrioritas.Items.Add(Prioritas.ATLAGOS);
            comboBoxPrioritas.Items.Add(Prioritas.LENYEGTELEN);
            comboBoxPrioritas.Items.Add(Prioritas.SURGOS);
        }

        internal void Init(string teremFelirat, Szamitogep gep)
        {
            this.gep = gep;
            labelRoom.Text = teremFelirat;

            labelCpuId.Text = gep.Azonosito;
            labelNumberInRoom.Text = gep.TermenBeluliSorszam.ToString();
            HibakFrissitese();
        }

        private void HibakFrissitese()
        {
            listBoxHibak.Items.Clear();
            foreach (var hiba in gep.Hibak)
            {
                listBoxHibak.Items.Add(hiba);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string nev = textBoxNev.Text;
            string email = textBoxEmail.Text;
            string leiras = richTextBoxLeiras.Text;
            Prioritas? prioritas = comboBoxPrioritas.SelectedItem as Prioritas?;

            if (nev.Length == 0)
            {
                MessageBox.Show("A név kitöltése kötelező!");
            }
            else if (email.Length == 0)
            {
                MessageBox.Show("Az email kitöltése kötelező!");
            }
            else if (leiras.Length == 0)
            {
                MessageBox.Show("A hiba leírás kitöltése kötelező!");
            }
            else if (prioritas == null)
            {
                MessageBox.Show("A prioritás kitöltése kötelező!");
            }
            else
            {
                Hiba ujHiba = new Hiba
                {
                    Bejelento = new Szemely
                    {
                        Nev = textBoxNev.Text,
                        Email = textBoxEmail.Text
                    },
                    Idopont = DateTime.Now,
                    Leiras = richTextBoxLeiras.Text,
                    Prioritas = prioritas ?? Prioritas.ATLAGOS
                };
                gep.Hibak.Add(ujHiba);
                HibakFrissitese();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            StreamWriter sw = new StreamWriter(folderBrowserDialog.SelectedPath + "/" + $"{gep.Azonosito}-hibak.txt");

            foreach (var hiba in gep.Hibak)
            {
                sw.WriteLine($"{hiba.Prioritas} - {hiba.Leiras} ({hiba.Bejelento.Nev}, {hiba.Bejelento.Email}) - {hiba.Idopont}");
            }

            sw.Close();

        }

        private void listBoxHibak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHibak.SelectedIndex != -1) {
                buttonBugFix.Enabled = true;
            }
            else
            {
                buttonBugFix.Enabled = false;
            }
        }

        private void buttonBugFix_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Init(listBoxHibak.SelectedItem as Hiba, this);
            form.Show();
        }

        public void JavitasTortent()
        {
            HibakFrissitese();
        }
    }
}
