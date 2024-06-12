using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wetterdatenauswertung
{
    public class wetterdatum
    {
        private DateTime datum;
        private double temperatur;
        private double feuchtigkeit;

        public wetterdatum(DateTime pDatum, double pTemperatur, double pFeuchtigkeit)
        {
            Datum = pDatum;
            Temperatur = pTemperatur;
            Feuchtigkeit = pFeuchtigkeit;
        }
        public wetterdatum(string pEinlesen)
        {
            string[] contentsplit = pEinlesen.Split(';');
            Datum = DateTime.Parse(contentsplit[0]);
            Temperatur = double.Parse(contentsplit[1]);
            Feuchtigkeit = double.Parse(contentsplit[2]);
        }
        public DateTime Datum
        {
            get { return datum; }
            private set { datum = value; }
        } 

        public double Temperatur
        {
            get { return temperatur; }
            set { temperatur = value; }
        }

        public double Feuchtigkeit
        {
            get { return feuchtigkeit; }
            set { feuchtigkeit = value; }
        }
        public override string ToString()
        {
            return $"{Datum.ToString("yyyy - MM - dd HH:mm:ss")} - {Temperatur} - {Feuchtigkeit}";
        }
    }
}