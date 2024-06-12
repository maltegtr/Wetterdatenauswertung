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
        public DateTime Datum
        {
            get { return datum; }
            set { }
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
            return $"{Datum} - {Temperatur} - {Feuchtigkeit}";
        }
    }
}