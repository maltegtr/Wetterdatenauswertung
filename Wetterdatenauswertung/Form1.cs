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
        //string inporttestfilename = @"..\..\dateien\test_wetterdaten.csv";
        //string exporttestfilename = @"..\..\dateien\wetterdaten_export.csv";


        List<wetterdatum> wetterdatenliste = new List<wetterdatum>();


        public Form1()
        {
            InitializeComponent();
            lstBoxAusgabe.Items.Add($"Datum - Temperatur[°C] - Feuchtigkeit[%]");
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
            wetterdatum neuesWetter = new wetterdatum(dateTimePicker1.Value,double.Parse(txtBoxTemperatur.Text), double.Parse(txtBoxFeuchtigkeit.Text));
            wetterdatenliste.Add(neuesWetter);
            lstBoxAusgabe.Items.Add(neuesWetter.ToString());
        }

        private void Import()
        {
            int i = 0;
            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename, System.Text.Encoding.Default);
                while (!myFile.EndOfStream)
                {
                    if (i == 0)
                    {
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
            if (File.Exists(filename))
            {
                StreamWriter myFile = new StreamWriter(filename);
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
