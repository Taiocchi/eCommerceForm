namespace eCommerceForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            Aggiungi = new Button();
            Rimuovi = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            totProdotti = new Label();
            Salva = new Button();
            Carica = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            prezzoBase = new Label();
            prezzoEffettivo = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(39, 125);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(425, 198);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(170, 55);
            label1.Name = "label1";
            label1.Size = new Size(164, 49);
            label1.TabIndex = 1;
            label1.Text = "Carrello";
            // 
            // Aggiungi
            // 
            Aggiungi.FlatStyle = FlatStyle.Flat;
            Aggiungi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Aggiungi.ForeColor = SystemColors.ControlText;
            Aggiungi.Location = new Point(518, 221);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(116, 42);
            Aggiungi.TabIndex = 2;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // Rimuovi
            // 
            Rimuovi.FlatStyle = FlatStyle.Flat;
            Rimuovi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Rimuovi.ForeColor = SystemColors.ControlText;
            Rimuovi.Location = new Point(668, 221);
            Rimuovi.Name = "Rimuovi";
            Rimuovi.Size = new Size(116, 42);
            Rimuovi.TabIndex = 3;
            Rimuovi.Text = "Rimuovi";
            Rimuovi.UseVisualStyleBackColor = true;
            Rimuovi.Click += Rimuovi_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(663, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(693, 107);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Prodotto:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // totProdotti
            // 
            totProdotti.AutoSize = true;
            totProdotti.BackColor = Color.WhiteSmoke;
            totProdotti.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            totProdotti.Location = new Point(155, 343);
            totProdotti.Name = "totProdotti";
            totProdotti.Size = new Size(157, 24);
            totProdotti.TabIndex = 9;
            totProdotti.Text = "Tot. prodotti: 0";
            // 
            // Salva
            // 
            Salva.Location = new Point(559, 326);
            Salva.Name = "Salva";
            Salva.Size = new Size(75, 23);
            Salva.TabIndex = 10;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = true;
            Salva.Click += Salva_Click;
            // 
            // Carica
            // 
            Carica.Location = new Point(646, 326);
            Carica.Name = "Carica";
            Carica.Size = new Size(75, 23);
            Carica.TabIndex = 11;
            Carica.Text = "Carica";
            Carica.UseVisualStyleBackColor = true;
            Carica.Click += Carica_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(548, 107);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 13;
            label4.Text = "Classe:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ProdottoElettronico", "ProdottoAlimentare" });
            comboBox2.Location = new Point(512, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 24);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // prezzoBase
            // 
            prezzoBase.AutoSize = true;
            prezzoBase.BackColor = Color.WhiteSmoke;
            prezzoBase.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            prezzoBase.Location = new Point(39, 398);
            prezzoBase.Name = "prezzoBase";
            prezzoBase.Size = new Size(198, 24);
            prezzoBase.TabIndex = 14;
            prezzoBase.Text = "Tot. PrezzoBase: 0";
            // 
            // prezzoEffettivo
            // 
            prezzoEffettivo.AutoSize = true;
            prezzoEffettivo.BackColor = Color.WhiteSmoke;
            prezzoEffettivo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            prezzoEffettivo.Location = new Point(275, 398);
            prezzoEffettivo.Name = "prezzoEffettivo";
            prezzoEffettivo.Size = new Size(232, 24);
            prezzoEffettivo.TabIndex = 15;
            prezzoEffettivo.Text = "Tot. PrezzoEffettivo: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(prezzoEffettivo);
            Controls.Add(prezzoBase);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(Carica);
            Controls.Add(Salva);
            Controls.Add(totProdotti);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(Rimuovi);
            Controls.Add(Aggiungi);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button Aggiungi;
        private Button Rimuovi;
        private ComboBox comboBox1;
        private Label label3;
        private Label totProdotti;
        private Button Salva;
        private Button Carica;
        private Label label4;
        private ComboBox comboBox2;
        private Label prezzoBase;
        private Label prezzoEffettivo;
    }
}
