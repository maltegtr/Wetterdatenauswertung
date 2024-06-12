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
        /*double durchschnittstemperatur;
        double durchschnittsfeuchtigkeit;
        double maximaltemperatur;
        double minimaltemperatur;
        int temperatur0_10;
        int temperatur10_20;
        int temperatur20_30;
        int feuchtigkeit80;
        */


        List<wetterdatum> wetterdatenliste = new List<wetterdatum>();


        public Form1()
        {
            InitializeComponent();
            lblAuswertung.Visible = false;
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
            try
            {
                wetterdatum neuesWetter = new wetterdatum(dateTimePicker1.Value, double.Parse(txtBoxTemperatur.Text), double.Parse(txtBoxFeuchtigkeit.Text));
                wetterdatenliste.Add(neuesWetter);
                lstBoxAusgabe.Items.Add(neuesWetter.ToString());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl für die Temperatur und die Feuchtigkeit ein.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ein Fehler ist aufgetreten:\r\n{ex.Message}");
            }
           
        }
        private void btnAuswertung_Click(object sender, EventArgs e)
        {
            lblAuswertung.Visible = true;
            lblAuswertung.Text = null;
            lblAuswertung.Text += $"Durchschnittstemperatur: {Durchschnittstemperatur().ToString("##.##")}°C\r\n";
            lblAuswertung.Text += $"Durchschnittsfeuchtigkeit:{Durchschnittsfeuchtigkeit().ToString("##.##")}%\r\n";
            lblAuswertung.Text += $"Maximaltemperatur: {Maximaltemperatur().ToString("##.##")}°C\r\n";
            lblAuswertung.Text += $"Minimaltemperatur: {Minimaltemperatur().ToString("##.##")}°C\r\n";
            lblAuswertung.Text += $"\r\n" + $"0-10°C: {Temperatur_0_10()} Tage\r\n";
            lblAuswertung.Text += $"10-20°C: {Temperatur_10_20()} Tage\r\n";
            lblAuswertung.Text += $"20-30°C: {Temperatur_20_30()} Tage\r\n";
            lblAuswertung.Text += $"\r\nTage mit Luftfeuchtigkeit >79%: {Feuchtigkeit_80()} Tage\r\n";
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
        private double Durchschnittstemperatur()
        {
            double durschnittstemperatur = 0;
            int i = 0;
            foreach (var content in wetterdatenliste)
            {
                durschnittstemperatur += content.Temperatur;
                i++;
            }
            durschnittstemperatur = durschnittstemperatur / i;
            return durschnittstemperatur;
        }
        private double Durchschnittsfeuchtigkeit()
        {
            double durchschnittsfeuchtigkeit = 0;
            int i = 0;
            foreach (var content in wetterdatenliste)
            {
                durchschnittsfeuchtigkeit += content.Feuchtigkeit;
                i++;
            }
            durchschnittsfeuchtigkeit = durchschnittsfeuchtigkeit / i;
            return durchschnittsfeuchtigkeit;
        }

        private double Maximaltemperatur()
        {
            double maximaltemperatur = 0;
            int i = 0;
            foreach (var content in wetterdatenliste)
            {
                if (i != 0)
                {
                    maximaltemperatur = content.Temperatur;
                    i++;
                }
                else if (content.Temperatur > maximaltemperatur) maximaltemperatur = content.Temperatur;
            }
            return maximaltemperatur;
        }
        private double Minimaltemperatur()
        {
            double minimaltemperatur = 0;
            int i = 0;
            foreach (var content in wetterdatenliste)
            {
                if (i != 0)
                {
                    minimaltemperatur = content.Temperatur;
                    i++;
                }
                else if (content.Temperatur < minimaltemperatur) minimaltemperatur = content.Temperatur;
            }
            return minimaltemperatur;
        }
        private int Temperatur_0_10()
        {
            int tage = 0;
            foreach (var content in wetterdatenliste)
            {
                if (content.Temperatur >= 0 && content.Temperatur <= 10) tage++;
            }
            return tage;
        }
        private int Temperatur_10_20()
        {
            int tage = 0;
            foreach (var content in wetterdatenliste)
            {
                if (content.Temperatur >= 10 && content.Temperatur <= 20) tage++;
            }
            return tage;
        }

        private int Temperatur_20_30()
        {
            int tage = 0;
            foreach (var content in wetterdatenliste)
            {
                if (content.Temperatur >= 20 && content.Temperatur <= 30) tage++;
            }
            return tage;
        }

        private int Feuchtigkeit_80()
        {
            int tage = 0;
            foreach (var content in wetterdatenliste)
            {
                if (content.Feuchtigkeit > 79) tage++;
            }
            return tage;
        }
    }
}
