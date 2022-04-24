using Leltar.model;
using System;
using System.Windows.Forms;

namespace Leltar
{
    public partial class Form3 : Form
    {
        private Hiba hiba;
        private IJavitas javitasErtesito;

        public Form3()
        {
            InitializeComponent();
        }

        internal void Init(Hiba hiba, IJavitas ertesito)
        {
            this.hiba = hiba;
            this.javitasErtesito = ertesito;

            textBoxNev.Text = hiba.Bejelento.Nev;
            textBoxEmail.Text = hiba.Bejelento.Email;
            richTextBoxLeiras.Text = hiba.Leiras;

            if (hiba.Javitas != null)
            {
                textBoxFixName.Text = hiba.Javitas.Javito.Nev;
                textBoxFixEmail.Text = hiba.Javitas.Javito.Email;
                richTextBoxComment.Text = hiba.Javitas.Megjegyzes;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonFix_Click(object sender, EventArgs e)
        {
            string nev = textBoxFixName.Text;
            string email = textBoxFixEmail.Text;
            string megjegyzes = richTextBoxComment.Text;

            if (nev.Length == 0)
            {
                MessageBox.Show("A javító neve kötelező mező.");
            }
            else if (email.Length == 0)
            {
                MessageBox.Show("A javító emailcíme kötelező mező.");
            }
            else
            {
                hiba.Javitas = new Javitas
                {
                    Javito = new Szemely {
                        Nev = nev,
                        Email = email
                    },
                    Megjegyzes = megjegyzes,
                    Idopont = DateTime.Now
                };

                javitasErtesito.JavitasTortent();
                this.Close();
            }
        }
    }
}
