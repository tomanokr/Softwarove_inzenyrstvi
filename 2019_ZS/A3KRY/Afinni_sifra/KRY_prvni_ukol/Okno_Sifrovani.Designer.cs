namespace KRY_prvni_ukol
{
    partial class Okno_Sifrovani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l_zprava = new System.Windows.Forms.Label();
            this.b_zasifrovat = new System.Windows.Forms.Button();
            this.tB_klicA = new System.Windows.Forms.TextBox();
            this.tB_klicB = new System.Windows.Forms.TextBox();
            this.l_klicA = new System.Windows.Forms.Label();
            this.l_klicB = new System.Windows.Forms.Label();
            this.l_navrhKlicu = new System.Windows.Forms.Label();
            this.lW_abeceda = new System.Windows.Forms.ListView();
            this.tB_zprava = new System.Windows.Forms.RichTextBox();
            this.lW_sifry = new System.Windows.Forms.ListView();
            this.Vstupni_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filtrovany_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Klic_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Klic_B = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vystupni_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.l_zdrojovaAbeceda = new System.Windows.Forms.Label();
            this.l_nadpis = new System.Windows.Forms.Label();
            this.b_desifrovat = new System.Windows.Forms.Button();
            this.cMS_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zkopírovatVstupníTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zkopírovatVýstupníTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMS_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_zprava
            // 
            this.l_zprava.AutoSize = true;
            this.l_zprava.Location = new System.Drawing.Point(12, 45);
            this.l_zprava.Name = "l_zprava";
            this.l_zprava.Size = new System.Drawing.Size(152, 13);
            this.l_zprava.TabIndex = 0;
            this.l_zprava.Text = "Zadejte zprávu k (de)šifrování:";
            // 
            // b_zasifrovat
            // 
            this.b_zasifrovat.Location = new System.Drawing.Point(136, 219);
            this.b_zasifrovat.Name = "b_zasifrovat";
            this.b_zasifrovat.Size = new System.Drawing.Size(75, 23);
            this.b_zasifrovat.TabIndex = 2;
            this.b_zasifrovat.Text = "Zašifrovat";
            this.b_zasifrovat.UseVisualStyleBackColor = true;
            this.b_zasifrovat.Click += new System.EventHandler(this.Klik_b_zasifrovat);
            // 
            // tB_klicA
            // 
            this.tB_klicA.Location = new System.Drawing.Point(75, 135);
            this.tB_klicA.Name = "tB_klicA";
            this.tB_klicA.Size = new System.Drawing.Size(136, 20);
            this.tB_klicA.TabIndex = 1;
            // 
            // tB_klicB
            // 
            this.tB_klicB.Location = new System.Drawing.Point(75, 193);
            this.tB_klicB.Name = "tB_klicB";
            this.tB_klicB.Size = new System.Drawing.Size(136, 20);
            this.tB_klicB.TabIndex = 2;
            // 
            // l_klicA
            // 
            this.l_klicA.AutoSize = true;
            this.l_klicA.Location = new System.Drawing.Point(12, 138);
            this.l_klicA.Name = "l_klicA";
            this.l_klicA.Size = new System.Drawing.Size(57, 13);
            this.l_klicA.TabIndex = 5;
            this.l_klicA.Text = "První klíč:";
            // 
            // l_klicB
            // 
            this.l_klicB.AutoSize = true;
            this.l_klicB.Location = new System.Drawing.Point(12, 193);
            this.l_klicB.Name = "l_klicB";
            this.l_klicB.Size = new System.Drawing.Size(59, 13);
            this.l_klicB.TabIndex = 6;
            this.l_klicB.Text = "Druhý klíč:";
            // 
            // l_navrhKlicu
            // 
            this.l_navrhKlicu.AutoSize = true;
            this.l_navrhKlicu.ForeColor = System.Drawing.Color.DarkGreen;
            this.l_navrhKlicu.Location = new System.Drawing.Point(12, 166);
            this.l_navrhKlicu.Name = "l_navrhKlicu";
            this.l_navrhKlicu.Size = new System.Drawing.Size(207, 13);
            this.l_navrhKlicu.TabIndex = 7;
            this.l_navrhKlicu.Text = "Vhodné první klíče: 1, 3, 5, 7, 9, 11, 15,...";
            this.l_navrhKlicu.Visible = false;
            // 
            // lW_abeceda
            // 
            this.lW_abeceda.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lW_abeceda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lW_abeceda.GridLines = true;
            this.lW_abeceda.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lW_abeceda.HideSelection = false;
            this.lW_abeceda.LabelWrap = false;
            this.lW_abeceda.Location = new System.Drawing.Point(448, 15);
            this.lW_abeceda.MultiSelect = false;
            this.lW_abeceda.Name = "lW_abeceda";
            this.lW_abeceda.Scrollable = false;
            this.lW_abeceda.Size = new System.Drawing.Size(524, 20);
            this.lW_abeceda.TabIndex = 8;
            this.lW_abeceda.UseCompatibleStateImageBehavior = false;
            this.lW_abeceda.View = System.Windows.Forms.View.Tile;
            // 
            // tB_zprava
            // 
            this.tB_zprava.Location = new System.Drawing.Point(15, 70);
            this.tB_zprava.Name = "tB_zprava";
            this.tB_zprava.Size = new System.Drawing.Size(200, 61);
            this.tB_zprava.TabIndex = 0;
            this.tB_zprava.Text = "";
            // 
            // lW_sifry
            // 
            this.lW_sifry.CausesValidation = false;
            this.lW_sifry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Vstupni_text,
            this.Filtrovany_text,
            this.Klic_A,
            this.Klic_B,
            this.Vystupni_text});
            this.lW_sifry.FullRowSelect = true;
            this.lW_sifry.GridLines = true;
            this.lW_sifry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lW_sifry.HideSelection = false;
            this.lW_sifry.HoverSelection = true;
            this.lW_sifry.Location = new System.Drawing.Point(230, 45);
            this.lW_sifry.MultiSelect = false;
            this.lW_sifry.Name = "lW_sifry";
            this.lW_sifry.Size = new System.Drawing.Size(740, 450);
            this.lW_sifry.TabIndex = 10;
            this.lW_sifry.UseCompatibleStateImageBehavior = false;
            this.lW_sifry.View = System.Windows.Forms.View.Details;
            this.lW_sifry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StiskMys_lW_sifry);
            // 
            // Vstupni_text
            // 
            this.Vstupni_text.Text = "Vstupní text";
            this.Vstupni_text.Width = 200;
            // 
            // Filtrovany_text
            // 
            this.Filtrovany_text.Text = "Filtrovaný text";
            this.Filtrovany_text.Width = 200;
            // 
            // Klic_A
            // 
            this.Klic_A.Text = "První klíč";
            // 
            // Klic_B
            // 
            this.Klic_B.Text = "Druhý klíč";
            this.Klic_B.Width = 70;
            // 
            // Vystupni_text
            // 
            this.Vystupni_text.Text = "Vystupní text";
            this.Vystupni_text.Width = 200;
            // 
            // l_zdrojovaAbeceda
            // 
            this.l_zdrojovaAbeceda.AutoSize = true;
            this.l_zdrojovaAbeceda.Location = new System.Drawing.Point(345, 15);
            this.l_zdrojovaAbeceda.Name = "l_zdrojovaAbeceda";
            this.l_zdrojovaAbeceda.Size = new System.Drawing.Size(97, 13);
            this.l_zdrojovaAbeceda.TabIndex = 11;
            this.l_zdrojovaAbeceda.Text = "Zdrojová abeceda:";
            // 
            // l_nadpis
            // 
            this.l_nadpis.AutoSize = true;
            this.l_nadpis.Font = new System.Drawing.Font("Verdana", 14F);
            this.l_nadpis.Location = new System.Drawing.Point(7, 9);
            this.l_nadpis.Name = "l_nadpis";
            this.l_nadpis.Size = new System.Drawing.Size(325, 23);
            this.l_nadpis.TabIndex = 12;
            this.l_nadpis.Text = "Monoalfabetická substituční šifra";
            // 
            // b_desifrovat
            // 
            this.b_desifrovat.Location = new System.Drawing.Point(12, 219);
            this.b_desifrovat.Name = "b_desifrovat";
            this.b_desifrovat.Size = new System.Drawing.Size(75, 23);
            this.b_desifrovat.TabIndex = 13;
            this.b_desifrovat.Text = "Dešifrovat";
            this.b_desifrovat.UseVisualStyleBackColor = true;
            this.b_desifrovat.Click += new System.EventHandler(this.Klik_b_desifrovat);
            // 
            // cMS_menu
            // 
            this.cMS_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zkopírovatVstupníTextToolStripMenuItem,
            this.zkopírovatVýstupníTextToolStripMenuItem});
            this.cMS_menu.Name = "menu";
            this.cMS_menu.Size = new System.Drawing.Size(203, 48);
            // 
            // zkopírovatVstupníTextToolStripMenuItem
            // 
            this.zkopírovatVstupníTextToolStripMenuItem.Name = "zkopírovatVstupníTextToolStripMenuItem";
            this.zkopírovatVstupníTextToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.zkopírovatVstupníTextToolStripMenuItem.Text = "Zkopírovat vstupní text";
            this.zkopírovatVstupníTextToolStripMenuItem.Click += new System.EventHandler(this.Klik_cMS_i_zkopirovatVstup);
            // 
            // zkopírovatVýstupníTextToolStripMenuItem
            // 
            this.zkopírovatVýstupníTextToolStripMenuItem.Name = "zkopírovatVýstupníTextToolStripMenuItem";
            this.zkopírovatVýstupníTextToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.zkopírovatVýstupníTextToolStripMenuItem.Text = "Zkopírovat výstupní text";
            this.zkopírovatVýstupníTextToolStripMenuItem.Click += new System.EventHandler(this.Klik_cMS_i_zkopirovatVystup);
            // 
            // Okno_Sifrovani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.b_desifrovat);
            this.Controls.Add(this.l_nadpis);
            this.Controls.Add(this.l_zdrojovaAbeceda);
            this.Controls.Add(this.lW_sifry);
            this.Controls.Add(this.tB_zprava);
            this.Controls.Add(this.lW_abeceda);
            this.Controls.Add(this.l_navrhKlicu);
            this.Controls.Add(this.l_klicB);
            this.Controls.Add(this.l_klicA);
            this.Controls.Add(this.tB_klicB);
            this.Controls.Add(this.tB_klicA);
            this.Controls.Add(this.b_zasifrovat);
            this.Controls.Add(this.l_zprava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Okno_Sifrovani";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afinní šifra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Okno_Sifrovani_Resize);
            this.cMS_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_zprava;
        private System.Windows.Forms.Button b_zasifrovat;
        private System.Windows.Forms.TextBox tB_klicA;
        private System.Windows.Forms.TextBox tB_klicB;
        private System.Windows.Forms.Label l_klicA;
        private System.Windows.Forms.Label l_klicB;
        private System.Windows.Forms.Label l_navrhKlicu;
        private System.Windows.Forms.ListView lW_abeceda;
        private System.Windows.Forms.RichTextBox tB_zprava;
        private System.Windows.Forms.ListView lW_sifry;
        private System.Windows.Forms.Label l_zdrojovaAbeceda;
        private System.Windows.Forms.Label l_nadpis;
        private System.Windows.Forms.Button b_desifrovat;
        private System.Windows.Forms.ColumnHeader Vstupni_text;
        private System.Windows.Forms.ColumnHeader Filtrovany_text;
        private System.Windows.Forms.ColumnHeader Klic_A;
        private System.Windows.Forms.ColumnHeader Klic_B;
        private System.Windows.Forms.ColumnHeader Vystupni_text;
        private System.Windows.Forms.ContextMenuStrip cMS_menu;
        private System.Windows.Forms.ToolStripMenuItem zkopírovatVstupníTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zkopírovatVýstupníTextToolStripMenuItem;
    }
}