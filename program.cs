using system;

namespace Rechnungserstellung
{
    class Program
        static void Main(string[] args)
        {

        }
    }



    class RechnungsDruck
    {
        DruckeSeitenKopf(/* übergebe eine Seitenanzahl */)

        DruckeRechnungskopf();

        DruckeRechnungsFuss();

        DruckePositionenKopf();

        DruckePositionsZeile();
        method rechnungsausgabe()
        {

        }
    }
    class Kunde
    {
        public string GetKundenNr();
        public string GetName();
        public string GetStrasse();
        public string GetPLZ();
        public string GetOrt();
        public Bestellung[] GetBestellungen(); // ist das falsch?
        public double GetRabatt();

    }

        class Bestellung
    {
        public string GetBestellNR();
        public string GetBestellDatum();
        public Rechnung[] GetRechnung();
        public BestellPosition[] GetBestellPositionen(/* rechne das */);
    }

        class Rechnung
    {
        public string GetRechnungsNR();
        public string GetRechnungsDatum();
    }
    }

        class BestellPosition
    {
        public string GetBestellNR();
        public int GetPosNR();
        public Artikel GetArtikel();
        public double GetEinzelPreis();
        public int getMenge();


    }

        class Artikel
    {
        public string GetArtikelNR();
        public string GetBezeichnung();
    }




}
