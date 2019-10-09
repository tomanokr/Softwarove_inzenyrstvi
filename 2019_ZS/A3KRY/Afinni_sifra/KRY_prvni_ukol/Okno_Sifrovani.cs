using System;
using System.Drawing;
using System.Windows.Forms;

namespace KRY_prvni_ukol
{
    public partial class Okno_Sifrovani : Form
    {

        Prostrednicek prostrednicek;


        public Okno_Sifrovani()
        {
            InitializeComponent();

            Show();

            foreach ( char pismeno in Sifrovani.mnozina )
            {
                lW_abeceda.Items.Add( pismeno.ToString() );
                lW_abeceda.TileSize = new Size( 20, 20 );
            }
        }


        private bool PlatneHodnoty( bool sifruji )
        {
            prostrednicek = new Prostrednicek( sifruji );

            switch ( prostrednicek.KontrolaVstupnichHodnot( tB_klicA.Text, tB_klicB.Text, tB_zprava.Text ) )
            {
                case 1:
                        MessageBox.Show
                        (
                            "Vyplňte prosím všechna pole.",
                            "Chybějící vstup",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );
                        return false;

                case 2:
                        MessageBox.Show
                        (
                             "Zadejte prosím nenulové klíče.",
                             "Nulová hodnota klíče",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error
                        );
                        return false;

                case 3:
                        MessageBox.Show
                        (
                            "Zadejte prosím nenulové číslo v rozmezí -2 147 483 648 a 2 147 483 647.",
                            "Špatný formát klíče",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;

                case 4:
                        MessageBox.Show
                        (
                            "Tento klíč nelze použít pro šifrování. Zvolte prosím jiný klíč.",
                            "Nevhodný první klíč",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        l_navrhKlicu.Visible = true;
                        return false;

                case 5:
                        DialogResult okno = MessageBox.Show
                        (
                            "Zpráva obsahuje nepovolené znaky, které budou vyfitlrovány.",
                            "Upozornění",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning
                        );
                        if ( okno == DialogResult.Cancel )
                        {
                            tB_zprava.Text = "";
                            return false;
                        }
                        return true;
                default:
                        return true;
            }
        }


        private void Klik_b_zasifrovat( object sender, EventArgs e )
        {
            if ( PlatneHodnoty( true ) ) lW_sifry.Items.Add( new ListViewItem( prostrednicek.VratVystup() ) );
        }


        private void Klik_b_desifrovat( object sender, EventArgs e )
        {
            if ( PlatneHodnoty( false ) ) lW_sifry.Items.Add( new ListViewItem( prostrednicek.VratVystup() ) );

            lW_sifry.Items[ lW_sifry.Items.Count - 1 ].BackColor = Color.DimGray;
            lW_sifry.Items[lW_sifry.Items.Count - 1].ForeColor = Color.White;
        }


        private void StiskMys_lW_sifry( object sender, MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Right )
            {
                if ( lW_sifry.FocusedItem.Bounds.Contains( e.Location ) ) cMS_menu.Show( Cursor.Position );
            }
        }


        private void Klik_cMS_i_zkopirovatVstup( object sender, EventArgs e )
        {
            Clipboard.SetText( lW_sifry.FocusedItem.SubItems[ 0 ].Text );
        }


        private void Klik_cMS_i_zkopirovatVystup( object sender, EventArgs e )
        {
            Clipboard.SetText( lW_sifry.FocusedItem.SubItems[ 4 ].Text );
        }


        private void Okno_Sifrovani_Resize( object sender, EventArgs e )
        {
            lW_sifry.Width = Width - 260;
            lW_sifry.Height = Height - lW_sifry.Location.Y - 75;
            lW_sifry.Columns[ 0 ].Width = ( lW_sifry.Width - 5 ) / 4;
            lW_sifry.Columns[ 1 ].Width = ( lW_sifry.Width - 5 ) / 4;
            lW_sifry.Columns[ 2 ].Width = ( lW_sifry.Width - 5 ) / 8;
            lW_sifry.Columns[ 3 ].Width = ( lW_sifry.Width - 5 ) / 8;
            lW_sifry.Columns[ 4 ].Width = ( lW_sifry.Width - 5 ) / 4 + 3;

            lW_abeceda.Location = new Point( Width - 524 - 30, 15 );
            l_zdrojovaAbeceda.Location = new Point( lW_abeceda.Location.X - 100, 17 );
        }
    }
}
