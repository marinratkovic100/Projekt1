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

        }


        private int Igra1()
        {




            int rezultat = 0;


            
            Random nasumicno = new Random();
            int nasumicnoSlika = nasumicno.Next(3);
            
            if (nasumicnoSlika.Equals(0))
            {
                Igra1AutomatskiSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\kamenprotivnik.png");
                if (Igra1kamen.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\kamen.jpg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\nerijeseno.png");
                    rezultat = rezultat;
                }
                if (Igra1papir.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\papir.jpeg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\pobjednik.png");
                    rezultat++;
                }
                if (Igra1skare.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\skare.png");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\guitnik.png");
                    rezultat = 0;
                }
              
            }
            if (nasumicnoSlika.Equals(1))
            {
                Igra1AutomatskiSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\papirprotivnik.png");
                if (Igra1kamen.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\kamen.jpg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\guitnik.png");
                    rezultat = 0;
                }
                if (Igra1papir.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\papir.jpeg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\nerijeseno.png");
                    rezultat = rezultat;
                }
                if (Igra1skare.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\skare.png");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\pobjednik.png");
                    rezultat++;
                }
               
            }
            if (nasumicnoSlika.Equals(2))
            {
                Igra1AutomatskiSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\skareprotivnik.png");
                if (Igra1kamen.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\kamen.jpg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\pobjednik.png");
                    rezultat++;
                }
                if (Igra1papir.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\papir.jpeg");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\guitnik.png");
                    rezultat = 0;
                }
                if (Igra1skare.Checked)
                {
                    Igra1IzaberiSliku.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\skare.png");
                    Igra1RezultatSlika.Image = new Bitmap(@"C:\Users\Marin\Desktop\Git-Projekti\Projekt1\Projekt1\Igre_1\nerijeseno.png");
                    rezultat = rezultat;
                }
               
            }
            else
            {

            }
              
             
            Igra1Rezultat.Text = rezultat.ToString();


            return rezultat;

        }

        private void BodoviSveukupnoo()
        {
            int a = Igra1();
            BodoviTrenutniIgra1.Text = a.ToString();
            
        }

        private void Igraj1_Click(object sender, EventArgs e)
        {
           
            Igra1();

        }

        /*

        private void Igraj2_Click(object sender, EventArgs e)
        {
            
            if (Igra2ListaBrojeva = Igra2NasumicniBroj)
            {
                int a = 1;
                Igra2Rezultat ++;

            }
        }
        */


    }
}
