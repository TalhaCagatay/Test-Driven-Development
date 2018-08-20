using System;

namespace Hesaplayici
{
    public class MaasHesaplayici
    {
        const int birYildaToplamSaat = 2080;

        public decimal GetYillikKazanc(decimal saatlikUcret) => birYildaToplamSaat * saatlikUcret;
        public decimal GetSaatlikKazanc(int yillikKazanc) => yillikKazanc / birYildaToplamSaat;

    }
}
