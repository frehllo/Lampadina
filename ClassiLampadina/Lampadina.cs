using System;

namespace ClassiLampadina
{
    public class Lampadina
    {
        public string Stato { get; set; }
        public int Click_massimi { get; set; }
        public int N_click { get; set; }

        public Lampadina(string s, int c)
        {
            Stato = s;
            Click_massimi = c;
        }

        public string Click()
        {
            N_click++;
                if (N_click > Click_massimi)
                {
                    Stato = "ROTTA";
                }
                else if(Stato == "ACCESA")
                {
                    Stato = "SPENTA";
                }
                else if (Stato == "SPENTA")
                {
                    Stato = "ACCESA";
                }
            return Stato;
        }
        public string Descrizione()
        {
            return Stato;
        }


    }
}
