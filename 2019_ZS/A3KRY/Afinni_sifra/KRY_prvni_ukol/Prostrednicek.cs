using System.Collections.Generic;

namespace KRY_prvni_ukol
{
    class Prostrednicek
    {
        private string puvodniVstup;
        private int klicA;
        private int klicB;
        private string filtrovanyVstup;
        private readonly bool sifruji;
        private string Vystup;
        private Dictionary< char, char > zakazaneZnaky = new Dictionary< char, char >
        {
            { 'Á','A' },
            { 'Č','C' },
            { 'Ď','D' },
            { 'É','E' },
            { 'Ě','E' },
            { 'Í','I' },
            { 'Ň','N' },
            { 'Ó','O' },
            { 'Ř','R' },
            { 'Š','S' },
            { 'Ť','T' },
            { 'Ú','U' },
            { 'Ů','U' },
            { 'Ý','Y' },
            { 'Ž','Z' },
            { 'Ä','A' },
            { 'Ĺ','Ľ' },
            { 'Ô','O' },
            { 'Ŕ','R' },
            { 'Ö','O' },
            { 'Ü','U' },
            { 'ẞ','S' },
            { 'Ë','E' },
            { 'Ï','I' },
            { 'Ÿ','Y' },
            { 'Ç','C' },
        };
        public string[] prevodCisel = new string[ 10 ]
        {
            "XNULAX",
            "XJEDNAX",
            "XDVAX",
            "XTRIX",
            "XCTYRIX",
            "XPETX",
            "XSESTX",
            "XSEDMX",
            "XOSMX",
            "XDEVETX"
        };


        public Prostrednicek( bool sifruji )
        {
            this.sifruji = sifruji;
        }


        public byte KontrolaVstupnichHodnot( string klicA, string klicB, string vstup )
        {
            if ( ( klicA == "" ) || ( klicB == "" ) || ( vstup == "" ) ) return 1;

            if ( klicA == "0" || klicB == "0" ) return 2;

            if ( ( !int.TryParse( klicA, out this.klicA ) ) || ( !int.TryParse( klicB, out this.klicB ) ) ) return 3;
            
            if ( !NesoudelnyKlic( this.klicA ) ) return 4;

            if ( FiltraceVstupu( sifruji, vstup ) ) return 5;

            return 0;
        }


        private bool FiltraceVstupu( bool sifrovat, string vstup )
        {
            string vstupniSlovo = "";
            bool filtr = false;
            puvodniVstup = vstup;

            vstup = vstup.ToUpper();

            for ( int i = 0; i < vstup.Length; i++ )
            {
                if ( NeniVAbecede( vstup[ i ] ) )
                {
                    if ( !zakazaneZnaky.TryGetValue( vstup[ i ], out char zmena ) )
                    {
                        if ( vstup[ i ] == ' ' ) vstupniSlovo += NahradMezeru();
                            else
                            {
                                if ( ( vstup[ i ] >= 48 ) && ( vstup[ i ] <= 57 ) ) vstupniSlovo += NahradCislo( vstup[ i ] );
                                filtr = true;
                            }
                    }
                    else vstupniSlovo += zmena;
                }
                else vstupniSlovo += vstup[i];
            }

            filtrovanyVstup = vstupniSlovo;

            return filtr;
        }


        private static bool NeniVAbecede( char pismeno )
        {
            for ( int index = 0; index < Sifrovani.Mohutnost; index++ )
            {
                if ( Sifrovani.mnozina[ index ] == pismeno ) return false;
            }

            return true;
        }


        private string NahradMezeru()
        {
            if ( sifruji ) return "XQZX";
                else return "";
        }


        private string NahradCislo( int cislo )
        {
            if ( sifruji ) return prevodCisel[ cislo - 48 ];
                else return "";
        }
       

        public bool NesoudelnyKlic( int a )
        {
            int b;

            if ( a < 0 ) a *= -1;

            if ( a > Sifrovani.Mohutnost )
            {
                b = a;
                a = Sifrovani.Mohutnost;
            }
                else b = Sifrovani.Mohutnost;
            
            do
            {
                int r = EukliduvAlgoritmus( a, b );
                b = a;
                a = r;
            }
            while ( a != 0 );

            if ( b == 1 ) return true;
                else return false;
        }


        private int EukliduvAlgoritmus( int a, int b )
        {
            int q = b / a;
            return b - q * a;
        }

        
        public string[] VratVystup()
        {
            Sifrovani sifrovani = new Sifrovani( klicA, klicB, filtrovanyVstup );

            if ( sifruji ) Vystup = sifrovani.Zasifruj();
                else FiltraceVystupu(sifrovani.Desifruj());
            
            return new string[] { puvodniVstup, filtrovanyVstup, klicA.ToString(), klicB.ToString(), Vystup };
        }


        private void FiltraceVystupu( string vystup )
        {
            string nahrada = "";
            Vystup = "";

            for ( int i = 0; i < vystup.Length; i++ )
            {
                if ( nahrada == "" )
                {
                    if ( vystup[ i ] == 'X' )
                    {
                        nahrada += vystup[ i ];
                        continue;
                    }

                    Vystup += vystup[ i ];
                    continue;
                }
                    else
                    {
                        if ( vystup[ i ] == 'X' )
                        {
                            if ( nahrada == "XQZ" ) Vystup += ' ';
                                else
                                {
                                    nahrada += vystup[ i ];
                                    for ( int cislice = 0; cislice < prevodCisel.Length; cislice++ )
                                    {
                                        if ( nahrada == prevodCisel[ cislice ] )
                                        {
                                            Vystup += cislice;
                                        }
                                    }
                                }
                                nahrada = "";
                        }
                            else nahrada += vystup[i];
                    }
            }
        }
    }
}
