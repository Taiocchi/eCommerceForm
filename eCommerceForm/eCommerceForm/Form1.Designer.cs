﻿namespace eCommerceForm
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
            label2 = new Label();
            Salva = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(62, 131);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 198);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 62);
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
            Aggiungi.Location = new Point(444, 267);
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
            Rimuovi.Location = new Point(594, 267);
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
            comboBox1.Items.AddRange(new object[] { "Lampadina - 13579", "Lampadina - 13580", "Lampadina - 13581", "Lampadina - 13582", "Lampadina - 13583", "Lampadina - 13584", "Televisore - 13579", "Televisore - 13580", "Televisore - 13581", "Televisore - 13582", "Televisore - 13583", "Televisore - 13584" });
            comboBox1.Location = new Point(507, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 163);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Prodotto:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 369);
            label2.Name = "label2";
            label2.Size = new Size(157, 24);
            label2.TabIndex = 9;
            label2.Text = "Tot. prodotti: 0";
            // 
            // Salva
            // 
            Salva.Location = new Point(539, 381);
            Salva.Name = "Salva";
            Salva.Size = new Size(75, 23);
            Salva.TabIndex = 10;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = true;
            Salva.Click += Salva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(Salva);
            Controls.Add(label2);
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
        private Label label2;
        private Button Salva;
    }
}
