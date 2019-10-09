using System;

namespace KRY_prvni_ukol
{
    /// <summary>
    /// AFINNI SIFRA - monoalfabeticka symetricka sifra
    /// 
    /// autor: Kristyna Tomanova
    /// predmet: Kryptologie
    /// vyucujici: Ing. Milan Oulehla
    /// 
    /// rozmezi: 25.09.2019 - 5.10.2019
    /// doba zpracovani: cca 11,5 hodin
    /// </summary>


    class Sifrovani
    {
        private readonly int klicA;

        private readonly int klicB;

        private int inverzniPrvek;

        public string VstupniSlovo { get; protected set; } = "";

        public static char[] mnozina = new char[ 26 ]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M',
            'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        public const byte Mohutnost = 26;


        public Sifrovani( int klicA, int klicB, string vstup )
        {
            this.klicA = klicA;
            this.klicB = klicB;
            VstupniSlovo = vstup;
        }

        
        public static int VratModulo( long delenec, int delitel )
        {
            int modulo = Convert.ToInt16( delenec % delitel );

            while ( modulo < 0 ) modulo += delitel;
            return modulo;
        }


        public string Zasifruj()
        {
            string vystup = "";

            byte pocetZnaku = 0;

            for ( int i = 0; i < VstupniSlovo.Length; i++ )
            {
                int modulo = VratModulo( ( klicA * Array.IndexOf( mnozina, VstupniSlovo[ i ] ) ) + klicB, Mohutnost );
                vystup += mnozina[ modulo ];

                pocetZnaku++;

                if ( pocetZnaku == 5 )
                {
                    vystup += ' ';
                    pocetZnaku = 0;
                }
            }

            return vystup;
        }


        private int NajdiInverzniPrvek()
        {
            int a = Mohutnost;
            int b = klicA;
            int inverze = 0;
            int next_inverze = 1;

            if ( klicA > Mohutnost )
            {
                a = klicA;
                b = Mohutnost;
                inverze = 1;
                next_inverze = 0;
            }

            while ( b > 0 )
            {
                int q = a / b;
                int tmp = next_inverze;
                next_inverze = inverze - ( q * next_inverze );
                inverze = tmp;

                tmp = b;
                b = VratModulo( a, b );
                a = tmp;
            }

            return inverze;
        }


        public string Desifruj()
        {
            inverzniPrvek = NajdiInverzniPrvek();

            string vystup = "";

            if ( inverzniPrvek != 0 )
            {
                for ( int i = 0; i < VstupniSlovo.Length; i++ )
                {
                    vystup += mnozina[ VratModulo( ( Array.IndexOf( mnozina, VstupniSlovo[ i ] ) - klicB ) * inverzniPrvek, Mohutnost ) ];
                }
            }

            return vystup;
        }
    }
}
 