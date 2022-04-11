namespace Automobily_SochWac
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LB_seznam = new System.Windows.Forms.ListBox();
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.BT_upravit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Barva = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_Id = new System.Windows.Forms.TextBox();
            this.LB_Barva = new System.Windows.Forms.Label();
            this.BT_smazat = new System.Windows.Forms.Button();
            this.LB_korun_ceskych = new System.Windows.Forms.Label();
            this.TB_cena = new System.Windows.Forms.TextBox();
            this.TB_vykon = new System.Windows.Forms.TextBox();
            this.CB_znacka = new System.Windows.Forms.ComboBox();
            this.CB_palivo = new System.Windows.Forms.ComboBox();
            this.LB_prvek_2 = new System.Windows.Forms.Label();
            this.LB_prvek_1 = new System.Windows.Forms.Label();
            this.RB_automaticka_prevodovka_ano = new System.Windows.Forms.RadioButton();
            this.RB_automaticka_prevodovka_ne = new System.Windows.Forms.RadioButton();
            this.TB_spotreba = new System.Windows.Forms.TextBox();
            this.DTP_rok_vyroby = new System.Windows.Forms.DateTimePicker();
            this.TB_model = new System.Windows.Forms.TextBox();
            this.LB_cena = new System.Windows.Forms.Label();
            this.LB_palivo = new System.Windows.Forms.Label();
            this.LB_vykon = new System.Windows.Forms.Label();
            this.LB_automaticka_prevodovka = new System.Windows.Forms.Label();
            this.LB_spotreba = new System.Windows.Forms.Label();
            this.LB_rok_vyroby = new System.Windows.Forms.Label();
            this.LB_model = new System.Windows.Forms.Label();
            this.LB_znacka = new System.Windows.Forms.Label();
            this.GB_2 = new System.Windows.Forms.GroupBox();
            this.BT_vypsat = new System.Windows.Forms.Button();
            this.RB_vypis = new System.Windows.Forms.RadioButton();
            this.RB_filtrace = new System.Windows.Forms.RadioButton();
            this.RB_editace = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LB_Helper = new System.Windows.Forms.ListBox();
            this.GB_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_seznam
            // 
            this.LB_seznam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LB_seznam.FormattingEnabled = true;
            this.LB_seznam.ItemHeight = 19;
            this.LB_seznam.Location = new System.Drawing.Point(12, 59);
            this.LB_seznam.Name = "LB_seznam";
            this.LB_seznam.Size = new System.Drawing.Size(224, 517);
            this.LB_seznam.TabIndex = 0;
            this.LB_seznam.SelectedIndexChanged += new System.EventHandler(this.LB_seznam_SelectedIndexChanged);
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.BT_upravit);
            this.GB_1.Controls.Add(this.label1);
            this.GB_1.Controls.Add(this.TB_Barva);
            this.GB_1.Controls.Add(this.button2);
            this.GB_1.Controls.Add(this.TB_Id);
            this.GB_1.Controls.Add(this.LB_Barva);
            this.GB_1.Controls.Add(this.BT_smazat);
            this.GB_1.Controls.Add(this.LB_korun_ceskych);
            this.GB_1.Controls.Add(this.TB_cena);
            this.GB_1.Controls.Add(this.TB_vykon);
            this.GB_1.Controls.Add(this.CB_znacka);
            this.GB_1.Controls.Add(this.CB_palivo);
            this.GB_1.Controls.Add(this.LB_prvek_2);
            this.GB_1.Controls.Add(this.LB_prvek_1);
            this.GB_1.Controls.Add(this.RB_automaticka_prevodovka_ano);
            this.GB_1.Controls.Add(this.RB_automaticka_prevodovka_ne);
            this.GB_1.Controls.Add(this.TB_spotreba);
            this.GB_1.Controls.Add(this.DTP_rok_vyroby);
            this.GB_1.Controls.Add(this.TB_model);
            this.GB_1.Controls.Add(this.LB_cena);
            this.GB_1.Controls.Add(this.LB_palivo);
            this.GB_1.Controls.Add(this.LB_vykon);
            this.GB_1.Controls.Add(this.LB_automaticka_prevodovka);
            this.GB_1.Controls.Add(this.LB_spotreba);
            this.GB_1.Controls.Add(this.LB_rok_vyroby);
            this.GB_1.Controls.Add(this.LB_model);
            this.GB_1.Controls.Add(this.LB_znacka);
            this.GB_1.Location = new System.Drawing.Point(335, 53);
            this.GB_1.Name = "GB_1";
            this.GB_1.Size = new System.Drawing.Size(459, 524);
            this.GB_1.TabIndex = 1;
            this.GB_1.TabStop = false;
            // 
            // BT_upravit
            // 
            this.BT_upravit.Location = new System.Drawing.Point(232, 402);
            this.BT_upravit.Name = "BT_upravit";
            this.BT_upravit.Size = new System.Drawing.Size(220, 50);
            this.BT_upravit.TabIndex = 32;
            this.BT_upravit.Text = "Upravit";
            this.BT_upravit.UseVisualStyleBackColor = true;
            this.BT_upravit.Click += new System.EventHandler(this.BT_upravit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(327, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID položky:";
            // 
            // TB_Barva
            // 
            this.TB_Barva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_Barva.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_Barva.Location = new System.Drawing.Point(114, 112);
            this.TB_Barva.Name = "TB_Barva";
            this.TB_Barva.Size = new System.Drawing.Size(272, 25);
            this.TB_Barva.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(447, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "Vytvořit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_Id
            // 
            this.TB_Id.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.TB_Id.Location = new System.Drawing.Point(391, 19);
            this.TB_Id.Name = "TB_Id";
            this.TB_Id.ReadOnly = true;
            this.TB_Id.Size = new System.Drawing.Size(55, 18);
            this.TB_Id.TabIndex = 30;
            // 
            // LB_Barva
            // 
            this.LB_Barva.AutoSize = true;
            this.LB_Barva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_Barva.Location = new System.Drawing.Point(30, 112);
            this.LB_Barva.Name = "LB_Barva";
            this.LB_Barva.Size = new System.Drawing.Size(60, 19);
            this.LB_Barva.TabIndex = 27;
            this.LB_Barva.Text = "Barva:";
            // 
            // BT_smazat
            // 
            this.BT_smazat.Location = new System.Drawing.Point(6, 402);
            this.BT_smazat.Name = "BT_smazat";
            this.BT_smazat.Size = new System.Drawing.Size(220, 50);
            this.BT_smazat.TabIndex = 24;
            this.BT_smazat.Text = "Smazat";
            this.BT_smazat.UseVisualStyleBackColor = true;
            this.BT_smazat.Click += new System.EventHandler(this.BT_smazat_Click);
            // 
            // LB_korun_ceskych
            // 
            this.LB_korun_ceskych.AutoSize = true;
            this.LB_korun_ceskych.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_korun_ceskych.Location = new System.Drawing.Point(356, 356);
            this.LB_korun_ceskych.Name = "LB_korun_ceskych";
            this.LB_korun_ceskych.Size = new System.Drawing.Size(30, 19);
            this.LB_korun_ceskych.TabIndex = 23;
            this.LB_korun_ceskych.Text = "Kč";
            // 
            // TB_cena
            // 
            this.TB_cena.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_cena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_cena.Location = new System.Drawing.Point(78, 357);
            this.TB_cena.Name = "TB_cena";
            this.TB_cena.Size = new System.Drawing.Size(272, 25);
            this.TB_cena.TabIndex = 22;
            // 
            // TB_vykon
            // 
            this.TB_vykon.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_vykon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_vykon.Location = new System.Drawing.Point(130, 315);
            this.TB_vykon.Name = "TB_vykon";
            this.TB_vykon.Size = new System.Drawing.Size(272, 25);
            this.TB_vykon.TabIndex = 21;
            // 
            // CB_znacka
            // 
            this.CB_znacka.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_znacka.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CB_znacka.FormattingEnabled = true;
            this.CB_znacka.Location = new System.Drawing.Point(110, 49);
            this.CB_znacka.Name = "CB_znacka";
            this.CB_znacka.Size = new System.Drawing.Size(272, 26);
            this.CB_znacka.TabIndex = 20;
            // 
            // CB_palivo
            // 
            this.CB_palivo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CB_palivo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CB_palivo.FormattingEnabled = true;
            this.CB_palivo.Location = new System.Drawing.Point(130, 280);
            this.CB_palivo.Name = "CB_palivo";
            this.CB_palivo.Size = new System.Drawing.Size(272, 26);
            this.CB_palivo.TabIndex = 19;
            // 
            // LB_prvek_2
            // 
            this.LB_prvek_2.AutoSize = true;
            this.LB_prvek_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LB_prvek_2.Location = new System.Drawing.Point(2, 380);
            this.LB_prvek_2.Name = "LB_prvek_2";
            this.LB_prvek_2.Size = new System.Drawing.Size(444, 19);
            this.LB_prvek_2.TabIndex = 18;
            this.LB_prvek_2.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // LB_prvek_1
            // 
            this.LB_prvek_1.AutoSize = true;
            this.LB_prvek_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LB_prvek_1.Location = new System.Drawing.Point(-2, 139);
            this.LB_prvek_1.Name = "LB_prvek_1";
            this.LB_prvek_1.Size = new System.Drawing.Size(444, 19);
            this.LB_prvek_1.TabIndex = 17;
            this.LB_prvek_1.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // RB_automaticka_prevodovka_ano
            // 
            this.RB_automaticka_prevodovka_ano.AutoSize = true;
            this.RB_automaticka_prevodovka_ano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RB_automaticka_prevodovka_ano.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RB_automaticka_prevodovka_ano.Location = new System.Drawing.Point(344, 240);
            this.RB_automaticka_prevodovka_ano.Name = "RB_automaticka_prevodovka_ano";
            this.RB_automaticka_prevodovka_ano.Size = new System.Drawing.Size(58, 23);
            this.RB_automaticka_prevodovka_ano.TabIndex = 16;
            this.RB_automaticka_prevodovka_ano.Text = "Ano";
            this.RB_automaticka_prevodovka_ano.UseVisualStyleBackColor = true;
            // 
            // RB_automaticka_prevodovka_ne
            // 
            this.RB_automaticka_prevodovka_ne.AutoSize = true;
            this.RB_automaticka_prevodovka_ne.Checked = true;
            this.RB_automaticka_prevodovka_ne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RB_automaticka_prevodovka_ne.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RB_automaticka_prevodovka_ne.Location = new System.Drawing.Point(237, 238);
            this.RB_automaticka_prevodovka_ne.Name = "RB_automaticka_prevodovka_ne";
            this.RB_automaticka_prevodovka_ne.Size = new System.Drawing.Size(48, 23);
            this.RB_automaticka_prevodovka_ne.TabIndex = 15;
            this.RB_automaticka_prevodovka_ne.TabStop = true;
            this.RB_automaticka_prevodovka_ne.Text = "Ne";
            this.RB_automaticka_prevodovka_ne.UseVisualStyleBackColor = true;
            // 
            // TB_spotreba
            // 
            this.TB_spotreba.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_spotreba.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_spotreba.Location = new System.Drawing.Point(130, 204);
            this.TB_spotreba.Name = "TB_spotreba";
            this.TB_spotreba.Size = new System.Drawing.Size(272, 25);
            this.TB_spotreba.TabIndex = 14;
            // 
            // DTP_rok_vyroby
            // 
            this.DTP_rok_vyroby.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.DTP_rok_vyroby.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DTP_rok_vyroby.Location = new System.Drawing.Point(130, 172);
            this.DTP_rok_vyroby.Name = "DTP_rok_vyroby";
            this.DTP_rok_vyroby.Size = new System.Drawing.Size(272, 25);
            this.DTP_rok_vyroby.TabIndex = 13;
            // 
            // TB_model
            // 
            this.TB_model.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_model.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TB_model.Location = new System.Drawing.Point(143, 81);
            this.TB_model.Name = "TB_model";
            this.TB_model.Size = new System.Drawing.Size(272, 25);
            this.TB_model.TabIndex = 12;
            // 
            // LB_cena
            // 
            this.LB_cena.AutoSize = true;
            this.LB_cena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_cena.Location = new System.Drawing.Point(17, 358);
            this.LB_cena.Name = "LB_cena";
            this.LB_cena.Size = new System.Drawing.Size(59, 19);
            this.LB_cena.TabIndex = 8;
            this.LB_cena.Text = "Cena: ";
            // 
            // LB_palivo
            // 
            this.LB_palivo.AutoSize = true;
            this.LB_palivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_palivo.Location = new System.Drawing.Point(56, 280);
            this.LB_palivo.Name = "LB_palivo";
            this.LB_palivo.Size = new System.Drawing.Size(66, 19);
            this.LB_palivo.TabIndex = 7;
            this.LB_palivo.Text = "Palivo: ";
            // 
            // LB_vykon
            // 
            this.LB_vykon.AutoSize = true;
            this.LB_vykon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_vykon.Location = new System.Drawing.Point(56, 315);
            this.LB_vykon.Name = "LB_vykon";
            this.LB_vykon.Size = new System.Drawing.Size(68, 19);
            this.LB_vykon.TabIndex = 6;
            this.LB_vykon.Text = "Výkon: ";
            // 
            // LB_automaticka_prevodovka
            // 
            this.LB_automaticka_prevodovka.AutoSize = true;
            this.LB_automaticka_prevodovka.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_automaticka_prevodovka.Location = new System.Drawing.Point(17, 240);
            this.LB_automaticka_prevodovka.Name = "LB_automaticka_prevodovka";
            this.LB_automaticka_prevodovka.Size = new System.Drawing.Size(209, 19);
            this.LB_automaticka_prevodovka.TabIndex = 5;
            this.LB_automaticka_prevodovka.Text = "Automatická převodovka: ";
            // 
            // LB_spotreba
            // 
            this.LB_spotreba.AutoSize = true;
            this.LB_spotreba.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_spotreba.Location = new System.Drawing.Point(17, 203);
            this.LB_spotreba.Name = "LB_spotreba";
            this.LB_spotreba.Size = new System.Drawing.Size(89, 19);
            this.LB_spotreba.TabIndex = 4;
            this.LB_spotreba.Text = "Spotřeba: ";
            // 
            // LB_rok_vyroby
            // 
            this.LB_rok_vyroby.AutoSize = true;
            this.LB_rok_vyroby.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_rok_vyroby.Location = new System.Drawing.Point(17, 174);
            this.LB_rok_vyroby.Name = "LB_rok_vyroby";
            this.LB_rok_vyroby.Size = new System.Drawing.Size(107, 19);
            this.LB_rok_vyroby.TabIndex = 3;
            this.LB_rok_vyroby.Text = "Rok výroby: ";
            // 
            // LB_model
            // 
            this.LB_model.AutoSize = true;
            this.LB_model.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_model.Location = new System.Drawing.Point(72, 83);
            this.LB_model.Name = "LB_model";
            this.LB_model.Size = new System.Drawing.Size(65, 19);
            this.LB_model.TabIndex = 2;
            this.LB_model.Text = "Model: ";
            // 
            // LB_znacka
            // 
            this.LB_znacka.AutoSize = true;
            this.LB_znacka.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LB_znacka.Location = new System.Drawing.Point(30, 51);
            this.LB_znacka.Name = "LB_znacka";
            this.LB_znacka.Size = new System.Drawing.Size(74, 19);
            this.LB_znacka.TabIndex = 0;
            this.LB_znacka.Text = "Značka: ";
            // 
            // GB_2
            // 
            this.GB_2.Location = new System.Drawing.Point(12, 583);
            this.GB_2.Name = "GB_2";
            this.GB_2.Size = new System.Drawing.Size(782, 146);
            this.GB_2.TabIndex = 2;
            this.GB_2.TabStop = false;
            this.GB_2.Text = "groupBox1";
            // 
            // BT_vypsat
            // 
            this.BT_vypsat.Location = new System.Drawing.Point(241, 59);
            this.BT_vypsat.Name = "BT_vypsat";
            this.BT_vypsat.Size = new System.Drawing.Size(88, 517);
            this.BT_vypsat.TabIndex = 26;
            this.BT_vypsat.Text = "VYPSAT";
            this.BT_vypsat.UseVisualStyleBackColor = true;
            this.BT_vypsat.Click += new System.EventHandler(this.BT_vypsat_Click);
            // 
            // RB_vypis
            // 
            this.RB_vypis.AutoSize = true;
            this.RB_vypis.Checked = true;
            this.RB_vypis.Location = new System.Drawing.Point(53, 30);
            this.RB_vypis.Name = "RB_vypis";
            this.RB_vypis.Size = new System.Drawing.Size(50, 17);
            this.RB_vypis.TabIndex = 27;
            this.RB_vypis.TabStop = true;
            this.RB_vypis.Text = "Výpis";
            this.RB_vypis.UseVisualStyleBackColor = true;
            this.RB_vypis.CheckedChanged += new System.EventHandler(this.RB_vypis_CheckedChanged);
            // 
            // RB_filtrace
            // 
            this.RB_filtrace.AutoSize = true;
            this.RB_filtrace.Location = new System.Drawing.Point(480, 30);
            this.RB_filtrace.Name = "RB_filtrace";
            this.RB_filtrace.Size = new System.Drawing.Size(59, 17);
            this.RB_filtrace.TabIndex = 28;
            this.RB_filtrace.Text = "Filtrace";
            this.RB_filtrace.UseVisualStyleBackColor = true;
            this.RB_filtrace.CheckedChanged += new System.EventHandler(this.RB_filtrace_CheckedChanged);
            // 
            // RB_editace
            // 
            this.RB_editace.AutoSize = true;
            this.RB_editace.Location = new System.Drawing.Point(235, 30);
            this.RB_editace.Name = "RB_editace";
            this.RB_editace.Size = new System.Drawing.Size(61, 17);
            this.RB_editace.TabIndex = 29;
            this.RB_editace.Text = "Editace";
            this.RB_editace.UseVisualStyleBackColor = true;
            this.RB_editace.CheckedChanged += new System.EventHandler(this.RB_editace_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LB_Helper
            // 
            this.LB_Helper.FormattingEnabled = true;
            this.LB_Helper.Location = new System.Drawing.Point(156, 59);
            this.LB_Helper.Name = "LB_Helper";
            this.LB_Helper.Size = new System.Drawing.Size(79, 511);
            this.LB_Helper.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 765);
            this.Controls.Add(this.LB_Helper);
            this.Controls.Add(this.RB_editace);
            this.Controls.Add(this.RB_filtrace);
            this.Controls.Add(this.RB_vypis);
            this.Controls.Add(this.BT_vypsat);
            this.Controls.Add(this.GB_2);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.LB_seznam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_1.ResumeLayout(false);
            this.GB_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_seznam;
        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.Label LB_cena;
        private System.Windows.Forms.Label LB_palivo;
        private System.Windows.Forms.Label LB_vykon;
        private System.Windows.Forms.Label LB_automaticka_prevodovka;
        private System.Windows.Forms.Label LB_spotreba;
        private System.Windows.Forms.Label LB_rok_vyroby;
        private System.Windows.Forms.Label LB_model;
        private System.Windows.Forms.Label LB_znacka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_smazat;
        private System.Windows.Forms.Label LB_korun_ceskych;
        private System.Windows.Forms.TextBox TB_cena;
        private System.Windows.Forms.TextBox TB_vykon;
        private System.Windows.Forms.ComboBox CB_znacka;
        private System.Windows.Forms.ComboBox CB_palivo;
        private System.Windows.Forms.Label LB_prvek_2;
        private System.Windows.Forms.Label LB_prvek_1;
        private System.Windows.Forms.RadioButton RB_automaticka_prevodovka_ano;
        private System.Windows.Forms.RadioButton RB_automaticka_prevodovka_ne;
        private System.Windows.Forms.TextBox TB_spotreba;
        private System.Windows.Forms.DateTimePicker DTP_rok_vyroby;
        private System.Windows.Forms.TextBox TB_model;
        private System.Windows.Forms.GroupBox GB_2;
        private System.Windows.Forms.Button BT_vypsat;
        private System.Windows.Forms.RadioButton RB_vypis;
        private System.Windows.Forms.RadioButton RB_filtrace;
        private System.Windows.Forms.RadioButton RB_editace;
        private System.Windows.Forms.TextBox TB_Barva;
        private System.Windows.Forms.Label LB_Barva;
        private System.Windows.Forms.TextBox TB_Id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox LB_Helper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_upravit;
    }
}

