using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wetterdatenauswertung
{
    public partial class Form1 : Form
    {
        string filename = @"..\..\dateien\wetterdaten.csv";
        string inporttestfilename = @"..\..\dateien\test_wetterdaten.csv";
        string exporttestfilename = @"..\..\dateien\wetterdaten_export.csv";

        List<wetterdatum> wetterdatenliste = new List<wetterdatum>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            Import();
            foreach (var wetter in wetterdatenliste)
            {
                lstBoxAusgabe.Items.Add($"{wetter.ToString()}");
            }
        }

        private void btnSpeichernDatei_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void btnSpeichernListe_Click(object sender, EventArgs e)
        {

        }

        private void Import()
        {
            int i = 0;
            if (File.Exists(inporttestfilename))
            {
                StreamReader myFile = new StreamReader(inporttestfilename, System.Text.Encoding.Default);
                while (!myFile.EndOfStream)
                {
                    if (i == 0)
                    {
                        lstBoxAusgabe.Items.Add($"Datum - Temperatur[°C] - Feuchtigkeit[%]");
                        myFile.ReadLine();
                        i++;
                    }
                    if (i != 0)
                    {
                        wetterdatum neuesWetter = new wetterdatum(myFile.ReadLine());
                        wetterdatenliste.Add(neuesWetter);
                    }
                }
                myFile.Close();
            }
            i = 0;
        }

        private void Export()
        {
            int i = 0;
            if (File.Exists(exporttestfilename))
            {
                StreamWriter myFile = new StreamWriter(exporttestfilename);
                foreach (var content in wetterdatenliste)
                {
                    if (i == 0)
                    {
                        myFile.WriteLine("Timestamp;Temperature (Celsius);Humidity (%)"); 
                        i++;
                    }

                    if (i != 0)
                    {
                        myFile.WriteLine($"{content.Datum};{content.Temperatur};{content.Feuchtigkeit}");

                    }
                }
                myFile.Close();
                MessageBox.Show($"Daten gespeichert!");
            }
            else MessageBox.Show($"Datei nicht gefunden!");
        }

    }
}
