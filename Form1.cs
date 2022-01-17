using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Övning4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnÖppnaFil_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgÖppnaFil.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                StreamReader läsare = new StreamReader(inStröm);

                tbxFörnamn.Text = läsare.ReadLine();
                tbxEfternamn.Text = läsare.ReadLine();
                tbxEpost.Text = läsare.ReadLine();
                tbxTelefonnummer.Text = läsare.ReadLine();
                

                /*
                string filText = läsare.ReadToEnd();
                tbxDokument.Text = filText;
                */

                läsare.Dispose();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSparaFil_Click(object sender, EventArgs e)
        {
            //Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgSparaFil.ShowDialog();

            if(resultat == DialogResult.OK)
            {
                //Öppna ström
                FileStream utStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                //Skapa skrivare
                StreamWriter skrivare = new StreamWriter(utStröm);

                //Skriv en rad text i taget
                skrivare.WriteLine(tbxFörnamn.Text);
                skrivare.WriteLine(tbxEfternamn.Text);
                skrivare.WriteLine(tbxEpost.Text);
                skrivare.WriteLine(tbxTelefonnummer.Text);

                //Stäng Filen
                skrivare.Dispose();
            }
        }
    }
}
