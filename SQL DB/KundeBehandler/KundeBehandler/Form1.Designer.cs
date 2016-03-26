namespace KundeBehandler
{
    partial class Form1
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
            this.gruppeKunde = new System.Windows.Forms.GroupBox();
            this.numeriskSaldo = new System.Windows.Forms.NumericUpDown();
            this.tekstEtternavn = new System.Windows.Forms.TextBox();
            this.tekstFornavn = new System.Windows.Forms.TextBox();
            this.knappOppdater = new System.Windows.Forms.Button();
            this.knappLeggTil = new System.Windows.Forms.Button();
            this.knappFjern = new System.Windows.Forms.Button();
            this.listeKunder = new System.Windows.Forms.ListBox();
            this.labelID = new System.Windows.Forms.Label();
            this.gruppeKunde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeriskSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // gruppeKunde
            // 
            this.gruppeKunde.Controls.Add(this.labelID);
            this.gruppeKunde.Controls.Add(this.numeriskSaldo);
            this.gruppeKunde.Controls.Add(this.tekstEtternavn);
            this.gruppeKunde.Controls.Add(this.tekstFornavn);
            this.gruppeKunde.Controls.Add(this.knappOppdater);
            this.gruppeKunde.Enabled = false;
            this.gruppeKunde.Location = new System.Drawing.Point(195, 12);
            this.gruppeKunde.Name = "gruppeKunde";
            this.gruppeKunde.Size = new System.Drawing.Size(318, 175);
            this.gruppeKunde.TabIndex = 0;
            this.gruppeKunde.TabStop = false;
            this.gruppeKunde.Text = "Kunde";
            // 
            // numeriskSaldo
            // 
            this.numeriskSaldo.Location = new System.Drawing.Point(196, 91);
            this.numeriskSaldo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeriskSaldo.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numeriskSaldo.Name = "numeriskSaldo";
            this.numeriskSaldo.Size = new System.Drawing.Size(116, 20);
            this.numeriskSaldo.TabIndex = 3;
            // 
            // tekstEtternavn
            // 
            this.tekstEtternavn.Location = new System.Drawing.Point(196, 41);
            this.tekstEtternavn.Name = "tekstEtternavn";
            this.tekstEtternavn.Size = new System.Drawing.Size(116, 20);
            this.tekstEtternavn.TabIndex = 2;
            // 
            // tekstFornavn
            // 
            this.tekstFornavn.Location = new System.Drawing.Point(6, 41);
            this.tekstFornavn.Name = "tekstFornavn";
            this.tekstFornavn.Size = new System.Drawing.Size(116, 20);
            this.tekstFornavn.TabIndex = 1;
            // 
            // knappOppdater
            // 
            this.knappOppdater.Location = new System.Drawing.Point(6, 146);
            this.knappOppdater.Name = "knappOppdater";
            this.knappOppdater.Size = new System.Drawing.Size(306, 23);
            this.knappOppdater.TabIndex = 0;
            this.knappOppdater.Text = "Oppdater";
            this.knappOppdater.UseVisualStyleBackColor = true;
            this.knappOppdater.Click += new System.EventHandler(this.knappOppdater_Click);
            // 
            // knappLeggTil
            // 
            this.knappLeggTil.Location = new System.Drawing.Point(12, 164);
            this.knappLeggTil.Name = "knappLeggTil";
            this.knappLeggTil.Size = new System.Drawing.Size(82, 23);
            this.knappLeggTil.TabIndex = 1;
            this.knappLeggTil.Text = "Legg til";
            this.knappLeggTil.UseVisualStyleBackColor = true;
            this.knappLeggTil.Click += new System.EventHandler(this.knappLeggTil_Click);
            // 
            // knappFjern
            // 
            this.knappFjern.Location = new System.Drawing.Point(100, 164);
            this.knappFjern.Name = "knappFjern";
            this.knappFjern.Size = new System.Drawing.Size(89, 23);
            this.knappFjern.TabIndex = 2;
            this.knappFjern.Text = "Fjern";
            this.knappFjern.UseVisualStyleBackColor = true;
            this.knappFjern.Click += new System.EventHandler(this.knappFjern_Click);
            // 
            // listeKunder
            // 
            this.listeKunder.FormattingEnabled = true;
            this.listeKunder.Location = new System.Drawing.Point(12, 12);
            this.listeKunder.Name = "listeKunder";
            this.listeKunder.Size = new System.Drawing.Size(177, 147);
            this.listeKunder.TabIndex = 3;
            this.listeKunder.SelectedIndexChanged += new System.EventHandler(this.listeKunder_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, 25);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 197);
            this.Controls.Add(this.listeKunder);
            this.Controls.Add(this.knappLeggTil);
            this.Controls.Add(this.knappFjern);
            this.Controls.Add(this.gruppeKunde);
            this.Name = "Form1";
            this.Text = "Kunde Behandler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gruppeKunde.ResumeLayout(false);
            this.gruppeKunde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeriskSaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gruppeKunde;
        private System.Windows.Forms.Button knappOppdater;
        private System.Windows.Forms.Button knappLeggTil;
        private System.Windows.Forms.Button knappFjern;
        private System.Windows.Forms.ListBox listeKunder;
        private System.Windows.Forms.NumericUpDown numeriskSaldo;
        private System.Windows.Forms.TextBox tekstEtternavn;
        private System.Windows.Forms.TextBox tekstFornavn;
        private System.Windows.Forms.Label labelID;
    }
}

