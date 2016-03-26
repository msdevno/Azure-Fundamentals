namespace StorageQueueDemo
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
            this.gruppeTilkobling = new System.Windows.Forms.GroupBox();
            this.tekstQueueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tekstConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gruppeBehandler = new System.Windows.Forms.GroupBox();
            this.knappLastInn = new System.Windows.Forms.Button();
            this.knappFjern = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listeMeldinger = new System.Windows.Forms.ListBox();
            this.knappLeggTil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tekstMelding = new System.Windows.Forms.TextBox();
            this.knappKobleTil = new System.Windows.Forms.Button();
            this.gruppeTilkobling.SuspendLayout();
            this.gruppeBehandler.SuspendLayout();
            this.SuspendLayout();
            // 
            // gruppeTilkobling
            // 
            this.gruppeTilkobling.Controls.Add(this.knappKobleTil);
            this.gruppeTilkobling.Controls.Add(this.tekstQueueName);
            this.gruppeTilkobling.Controls.Add(this.label2);
            this.gruppeTilkobling.Controls.Add(this.tekstConnectionString);
            this.gruppeTilkobling.Controls.Add(this.label1);
            this.gruppeTilkobling.Location = new System.Drawing.Point(12, 12);
            this.gruppeTilkobling.Name = "gruppeTilkobling";
            this.gruppeTilkobling.Size = new System.Drawing.Size(615, 113);
            this.gruppeTilkobling.TabIndex = 0;
            this.gruppeTilkobling.TabStop = false;
            this.gruppeTilkobling.Text = "Tilkobling";
            // 
            // tekstQueueName
            // 
            this.tekstQueueName.Location = new System.Drawing.Point(9, 81);
            this.tekstQueueName.Name = "tekstQueueName";
            this.tekstQueueName.Size = new System.Drawing.Size(443, 20);
            this.tekstQueueName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QueueName";
            // 
            // tekstConnectionString
            // 
            this.tekstConnectionString.Location = new System.Drawing.Point(9, 32);
            this.tekstConnectionString.Name = "tekstConnectionString";
            this.tekstConnectionString.Size = new System.Drawing.Size(600, 20);
            this.tekstConnectionString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ConnectionString\r\n";
            // 
            // gruppeBehandler
            // 
            this.gruppeBehandler.Controls.Add(this.knappLastInn);
            this.gruppeBehandler.Controls.Add(this.knappFjern);
            this.gruppeBehandler.Controls.Add(this.label4);
            this.gruppeBehandler.Controls.Add(this.listeMeldinger);
            this.gruppeBehandler.Controls.Add(this.knappLeggTil);
            this.gruppeBehandler.Controls.Add(this.label3);
            this.gruppeBehandler.Controls.Add(this.tekstMelding);
            this.gruppeBehandler.Enabled = false;
            this.gruppeBehandler.Location = new System.Drawing.Point(12, 131);
            this.gruppeBehandler.Name = "gruppeBehandler";
            this.gruppeBehandler.Size = new System.Drawing.Size(615, 193);
            this.gruppeBehandler.TabIndex = 1;
            this.gruppeBehandler.TabStop = false;
            this.gruppeBehandler.Text = "Behandler";
            // 
            // knappLastInn
            // 
            this.knappLastInn.Location = new System.Drawing.Point(382, 164);
            this.knappLastInn.Name = "knappLastInn";
            this.knappLastInn.Size = new System.Drawing.Size(70, 23);
            this.knappLastInn.TabIndex = 6;
            this.knappLastInn.Text = "Last Inn";
            this.knappLastInn.UseVisualStyleBackColor = true;
            this.knappLastInn.Click += new System.EventHandler(this.knappLastInn_Click);
            // 
            // knappFjern
            // 
            this.knappFjern.Location = new System.Drawing.Point(458, 164);
            this.knappFjern.Name = "knappFjern";
            this.knappFjern.Size = new System.Drawing.Size(151, 23);
            this.knappFjern.TabIndex = 5;
            this.knappFjern.Text = "Fjern alle meldinger";
            this.knappFjern.UseVisualStyleBackColor = true;
            this.knappFjern.Click += new System.EventHandler(this.knappFjern_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Queue";
            // 
            // listeMeldinger
            // 
            this.listeMeldinger.FormattingEnabled = true;
            this.listeMeldinger.Location = new System.Drawing.Point(382, 32);
            this.listeMeldinger.Name = "listeMeldinger";
            this.listeMeldinger.Size = new System.Drawing.Size(227, 121);
            this.listeMeldinger.TabIndex = 3;
            // 
            // knappLeggTil
            // 
            this.knappLeggTil.Location = new System.Drawing.Point(9, 58);
            this.knappLeggTil.Name = "knappLeggTil";
            this.knappLeggTil.Size = new System.Drawing.Size(196, 23);
            this.knappLeggTil.TabIndex = 2;
            this.knappLeggTil.Text = "Legg til melding";
            this.knappLeggTil.UseVisualStyleBackColor = true;
            this.knappLeggTil.Click += new System.EventHandler(this.knappLeggTil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Melding";
            // 
            // tekstMelding
            // 
            this.tekstMelding.Location = new System.Drawing.Point(9, 32);
            this.tekstMelding.Name = "tekstMelding";
            this.tekstMelding.Size = new System.Drawing.Size(196, 20);
            this.tekstMelding.TabIndex = 0;
            // 
            // knappKobleTil
            // 
            this.knappKobleTil.Location = new System.Drawing.Point(458, 79);
            this.knappKobleTil.Name = "knappKobleTil";
            this.knappKobleTil.Size = new System.Drawing.Size(151, 23);
            this.knappKobleTil.TabIndex = 7;
            this.knappKobleTil.Text = "Koble til";
            this.knappKobleTil.UseVisualStyleBackColor = true;
            this.knappKobleTil.Click += new System.EventHandler(this.knappKobleTil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 336);
            this.Controls.Add(this.gruppeBehandler);
            this.Controls.Add(this.gruppeTilkobling);
            this.Name = "Form1";
            this.Text = "StorageQueue Demo";
            this.gruppeTilkobling.ResumeLayout(false);
            this.gruppeTilkobling.PerformLayout();
            this.gruppeBehandler.ResumeLayout(false);
            this.gruppeBehandler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gruppeTilkobling;
        private System.Windows.Forms.TextBox tekstQueueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tekstConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gruppeBehandler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tekstMelding;
        private System.Windows.Forms.Button knappLeggTil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listeMeldinger;
        private System.Windows.Forms.Button knappLastInn;
        private System.Windows.Forms.Button knappFjern;
        private System.Windows.Forms.Button knappKobleTil;
    }
}

