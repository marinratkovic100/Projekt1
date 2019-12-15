using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igre_1
{
    public partial class Igra : Form
    {
        public Igra()
        {
            InitializeComponent();
        }

        private void Igra_Load(object sender, EventArgs e)
        {
            Igra1KamenDohvati();
        }

        private void Igra1KamenDohvati()
        {
            if (Igra1kamen.Checked)
            {
                Igra1IzaberiSliku.ImageLocation = ("C:/Users/Marin/Desktop/Git - Projekti/Projekt1/Igre_1/kamen.jpg");

            }
            else if (Igra1papir.Checked)
            {
                Igra1IzaberiSliku.ImageLocation = ("C:/Users/Marin/Desktop/Git - Projekti/Projekt1/Igre_1/papir.jpg");
            }
            else if (Igra1skare.Checked)
            {
                Igra1IzaberiSliku.ImageLocation = ("C:/Users/Marin/Desktop/Git - Projekti/Projekt1/Igre_1/skare.jpg");
            }
            else
            {
                Igra1IzaberiSliku.Visible.CompareTo(false);
            }

        }

        private void Igra1kamen_CheckedChanged(object sender, EventArgs e)
        {
            Igra1KamenDohvati();
        }

        private void Igra1papir_CheckedChanged(object sender, EventArgs e)
        {
            Igra1KamenDohvati();
        }

        private void Igra1skare_CheckedChanged(object sender, EventArgs e)
        {
            Igra1KamenDohvati();
        }

        
    }
}
