namespace projekat_programiranje
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
            this.kvizoviText = new System.Windows.Forms.Label();
            this.KvizoviLista = new System.Windows.Forms.ListView();
            this.deskripcijaText = new System.Windows.Forms.Label();
            this.imeKvizaText = new System.Windows.Forms.TextBox();
            this.deskripcijaKvizaText = new System.Windows.Forms.TextBox();
            this.pokreniBTN = new System.Windows.Forms.Button();
            this.pitanjeKvizText = new System.Windows.Forms.Label();
            this.poeniTXT = new System.Windows.Forms.Label();
            this.odgovor1 = new System.Windows.Forms.Button();
            this.odgovor2 = new System.Windows.Forms.Button();
            this.odgovor3 = new System.Windows.Forms.Button();
            this.odgovor4 = new System.Windows.Forms.Button();
            this.ukupnoPoena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kvizoviText
            // 
            this.kvizoviText.AutoSize = true;
            this.kvizoviText.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.kvizoviText.Location = new System.Drawing.Point(105, 59);
            this.kvizoviText.Name = "kvizoviText";
            this.kvizoviText.Size = new System.Drawing.Size(176, 46);
            this.kvizoviText.TabIndex = 0;
            this.kvizoviText.Text = "Kvizovi";
            // 
            // KvizoviLista
            // 
            this.KvizoviLista.HideSelection = false;
            this.KvizoviLista.Location = new System.Drawing.Point(113, 108);
            this.KvizoviLista.MultiSelect = false;
            this.KvizoviLista.Name = "KvizoviLista";
            this.KvizoviLista.Size = new System.Drawing.Size(249, 213);
            this.KvizoviLista.TabIndex = 1;
            this.KvizoviLista.UseCompatibleStateImageBehavior = false;
            this.KvizoviLista.SelectedIndexChanged += new System.EventHandler(this.KvizoviLista_SelectedIndexChanged);
            // 
            // deskripcijaText
            // 
            this.deskripcijaText.AutoSize = true;
            this.deskripcijaText.Font = new System.Drawing.Font("Cooper Black", 24F);
            this.deskripcijaText.Location = new System.Drawing.Point(439, 59);
            this.deskripcijaText.Name = "deskripcijaText";
            this.deskripcijaText.Size = new System.Drawing.Size(256, 46);
            this.deskripcijaText.TabIndex = 2;
            this.deskripcijaText.Text = "Deskripcija";
            // 
            // imeKvizaText
            // 
            this.imeKvizaText.Location = new System.Drawing.Point(447, 128);
            this.imeKvizaText.Name = "imeKvizaText";
            this.imeKvizaText.Size = new System.Drawing.Size(248, 22);
            this.imeKvizaText.TabIndex = 3;
            this.imeKvizaText.Text = "Ime";
            // 
            // deskripcijaKvizaText
            // 
            this.deskripcijaKvizaText.Location = new System.Drawing.Point(447, 166);
            this.deskripcijaKvizaText.Name = "deskripcijaKvizaText";
            this.deskripcijaKvizaText.Size = new System.Drawing.Size(248, 22);
            this.deskripcijaKvizaText.TabIndex = 4;
            this.deskripcijaKvizaText.Text = "Deskripcija";
            // 
            // pokreniBTN
            // 
            this.pokreniBTN.Enabled = false;
            this.pokreniBTN.Location = new System.Drawing.Point(528, 230);
            this.pokreniBTN.Name = "pokreniBTN";
            this.pokreniBTN.Size = new System.Drawing.Size(88, 37);
            this.pokreniBTN.TabIndex = 5;
            this.pokreniBTN.Text = "Pokreni";
            this.pokreniBTN.UseVisualStyleBackColor = true;
            this.pokreniBTN.Click += new System.EventHandler(this.pokreniBTN_Click);
            // 
            // pitanjeKvizText
            // 
            this.pitanjeKvizText.Enabled = false;
            this.pitanjeKvizText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitanjeKvizText.Location = new System.Drawing.Point(95, 34);
            this.pitanjeKvizText.Name = "pitanjeKvizText";
            this.pitanjeKvizText.Size = new System.Drawing.Size(923, 91);
            this.pitanjeKvizText.TabIndex = 6;
            this.pitanjeKvizText.Text = "Pitanje";
            this.pitanjeKvizText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pitanjeKvizText.Visible = false;
            // 
            // poeniTXT
            // 
            this.poeniTXT.AutoSize = true;
            this.poeniTXT.Enabled = false;
            this.poeniTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poeniTXT.Location = new System.Drawing.Point(774, 162);
            this.poeniTXT.Name = "poeniTXT";
            this.poeniTXT.Size = new System.Drawing.Size(34, 25);
            this.poeniTXT.TabIndex = 7;
            this.poeniTXT.Text = "10";
            this.poeniTXT.Visible = false;
            // 
            // odgovor1
            // 
            this.odgovor1.Enabled = false;
            this.odgovor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odgovor1.Location = new System.Drawing.Point(34, 321);
            this.odgovor1.Name = "odgovor1";
            this.odgovor1.Size = new System.Drawing.Size(484, 198);
            this.odgovor1.TabIndex = 9;
            this.odgovor1.Text = "button1";
            this.odgovor1.UseVisualStyleBackColor = true;
            this.odgovor1.Visible = false;
            this.odgovor1.Click += new System.EventHandler(this.odgovor1_Click);
            // 
            // odgovor2
            // 
            this.odgovor2.Enabled = false;
            this.odgovor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odgovor2.Location = new System.Drawing.Point(577, 321);
            this.odgovor2.Name = "odgovor2";
            this.odgovor2.Size = new System.Drawing.Size(484, 198);
            this.odgovor2.TabIndex = 10;
            this.odgovor2.Text = "button2";
            this.odgovor2.UseVisualStyleBackColor = true;
            this.odgovor2.Visible = false;
            this.odgovor2.Click += new System.EventHandler(this.odgovor2_Click);
            // 
            // odgovor3
            // 
            this.odgovor3.Enabled = false;
            this.odgovor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odgovor3.Location = new System.Drawing.Point(34, 543);
            this.odgovor3.Name = "odgovor3";
            this.odgovor3.Size = new System.Drawing.Size(484, 198);
            this.odgovor3.TabIndex = 11;
            this.odgovor3.Text = "button3";
            this.odgovor3.UseVisualStyleBackColor = true;
            this.odgovor3.Visible = false;
            this.odgovor3.Click += new System.EventHandler(this.odgovor3_Click);
            // 
            // odgovor4
            // 
            this.odgovor4.Enabled = false;
            this.odgovor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odgovor4.Location = new System.Drawing.Point(577, 543);
            this.odgovor4.Name = "odgovor4";
            this.odgovor4.Size = new System.Drawing.Size(484, 198);
            this.odgovor4.TabIndex = 12;
            this.odgovor4.Text = "button4";
            this.odgovor4.UseVisualStyleBackColor = true;
            this.odgovor4.Visible = false;
            this.odgovor4.Click += new System.EventHandler(this.odgovor4_Click);
            // 
            // ukupnoPoena
            // 
            this.ukupnoPoena.AutoSize = true;
            this.ukupnoPoena.Enabled = false;
            this.ukupnoPoena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ukupnoPoena.Location = new System.Drawing.Point(774, 187);
            this.ukupnoPoena.Name = "ukupnoPoena";
            this.ukupnoPoena.Size = new System.Drawing.Size(34, 25);
            this.ukupnoPoena.TabIndex = 13;
            this.ukupnoPoena.Text = "10";
            this.ukupnoPoena.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.ukupnoPoena);
            this.Controls.Add(this.odgovor4);
            this.Controls.Add(this.odgovor3);
            this.Controls.Add(this.odgovor2);
            this.Controls.Add(this.odgovor1);
            this.Controls.Add(this.poeniTXT);
            this.Controls.Add(this.pitanjeKvizText);
            this.Controls.Add(this.pokreniBTN);
            this.Controls.Add(this.deskripcijaKvizaText);
            this.Controls.Add(this.imeKvizaText);
            this.Controls.Add(this.deskripcijaText);
            this.Controls.Add(this.KvizoviLista);
            this.Controls.Add(this.kvizoviText);
            this.Name = "Form1";
            this.Text = "Kvizzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label kvizoviText;
        public System.Windows.Forms.ListView KvizoviLista;
        public System.Windows.Forms.Label deskripcijaText;
        public System.Windows.Forms.TextBox imeKvizaText;
        public System.Windows.Forms.TextBox deskripcijaKvizaText;
        public System.Windows.Forms.Button pokreniBTN;
        private System.Windows.Forms.Label pitanjeKvizText;
        private System.Windows.Forms.Label poeniTXT;
        private System.Windows.Forms.Button odgovor1;
        private System.Windows.Forms.Button odgovor2;
        private System.Windows.Forms.Button odgovor3;
        private System.Windows.Forms.Button odgovor4;
        private System.Windows.Forms.Label ukupnoPoena;
    }
}

