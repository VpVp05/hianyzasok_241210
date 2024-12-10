namespace hianyzasok_241210
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
            rtbadatok = new RichTextBox();
            label1 = new Label();
            dgvtabla = new DataGridView();
            Nev = new DataGridViewTextBoxColumn();
            Osztaly = new DataGridViewTextBoxColumn();
            Hanyadik = new DataGridViewTextBoxColumn();
            Igazolt = new DataGridViewTextBoxColumn();
            Nemigazolt = new DataGridViewTextBoxColumn();
            Osszeshianyzas = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbosszeshiany = new Label();
            label8 = new Label();
            lborak = new Label();
            label10 = new Label();
            rtbtanulok = new RichTextBox();
            btmentes = new Button();
            txnev = new TextBox();
            txosztaly = new TextBox();
            txigazolt = new TextBox();
            txnigazolt = new TextBox();
            cbnap = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvtabla).BeginInit();
            SuspendLayout();
            // 
            // rtbadatok
            // 
            rtbadatok.Location = new Point(12, 39);
            rtbadatok.Name = "rtbadatok";
            rtbadatok.ReadOnly = true;
            rtbadatok.Size = new Size(789, 214);
            rtbadatok.TabIndex = 0;
            rtbadatok.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Adatok";
            // 
            // dgvtabla
            // 
            dgvtabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtabla.Columns.AddRange(new DataGridViewColumn[] { Nev, Osztaly, Hanyadik, Igazolt, Nemigazolt, Osszeshianyzas });
            dgvtabla.Location = new Point(13, 259);
            dgvtabla.Name = "dgvtabla";
            dgvtabla.ReadOnly = true;
            dgvtabla.Size = new Size(788, 270);
            dgvtabla.TabIndex = 2;
            // 
            // Nev
            // 
            Nev.HeaderText = "Név";
            Nev.Name = "Nev";
            Nev.ReadOnly = true;
            // 
            // Osztaly
            // 
            Osztaly.HeaderText = "Osztály";
            Osztaly.Name = "Osztaly";
            Osztaly.ReadOnly = true;
            // 
            // Hanyadik
            // 
            Hanyadik.HeaderText = "Hányadik";
            Hanyadik.Name = "Hanyadik";
            Hanyadik.ReadOnly = true;
            // 
            // Igazolt
            // 
            Igazolt.HeaderText = "Igazolt";
            Igazolt.Name = "Igazolt";
            Igazolt.ReadOnly = true;
            // 
            // Nemigazolt
            // 
            Nemigazolt.HeaderText = "Nem igazolt";
            Nemigazolt.Name = "Nemigazolt";
            Nemigazolt.ReadOnly = true;
            // 
            // Osszeshianyzas
            // 
            Osszeshianyzas.HeaderText = "Összes hiányzás";
            Osszeshianyzas.Name = "Osszeshianyzas";
            Osszeshianyzas.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(826, 55);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(826, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Osztály:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(826, 145);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Hányadikán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(826, 192);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Igazolt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(826, 240);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 7;
            label6.Text = "Nem igazolt:";
            // 
            // lbosszeshiany
            // 
            lbosszeshiany.AutoSize = true;
            lbosszeshiany.Location = new Point(826, 290);
            lbosszeshiany.Name = "lbosszeshiany";
            lbosszeshiany.Size = new Size(172, 15);
            lbosszeshiany.TabIndex = 8;
            lbosszeshiany.Text = "Összes hiányzása adott napon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(879, 349);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 9;
            label8.Text = "Legtöbb hiányzás";
            // 
            // lborak
            // 
            lborak.AutoSize = true;
            lborak.Location = new Point(879, 388);
            lborak.Name = "lborak";
            lborak.Size = new Size(74, 15);
            lborak.TabIndex = 10;
            lborak.Text = "Órák száma:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1331, 354);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 11;
            label10.Text = "Tanulók:";
            // 
            // rtbtanulok
            // 
            rtbtanulok.Location = new Point(1331, 388);
            rtbtanulok.Name = "rtbtanulok";
            rtbtanulok.ReadOnly = true;
            rtbtanulok.Size = new Size(128, 124);
            rtbtanulok.TabIndex = 12;
            rtbtanulok.Text = "";
            // 
            // btmentes
            // 
            btmentes.BackColor = Color.White;
            btmentes.Location = new Point(1329, 55);
            btmentes.Name = "btmentes";
            btmentes.Size = new Size(130, 201);
            btmentes.TabIndex = 13;
            btmentes.Text = "Mentés";
            btmentes.UseVisualStyleBackColor = false;
            // 
            // txnev
            // 
            txnev.Location = new Point(898, 52);
            txnev.Name = "txnev";
            txnev.Size = new Size(294, 23);
            txnev.TabIndex = 14;
            // 
            // txosztaly
            // 
            txosztaly.Location = new Point(898, 95);
            txosztaly.Name = "txosztaly";
            txosztaly.Size = new Size(100, 23);
            txosztaly.TabIndex = 15;
            // 
            // txigazolt
            // 
            txigazolt.Location = new Point(898, 192);
            txigazolt.Name = "txigazolt";
            txigazolt.Size = new Size(76, 23);
            txigazolt.TabIndex = 16;
            // 
            // txnigazolt
            // 
            txnigazolt.Location = new Point(909, 237);
            txnigazolt.Name = "txnigazolt";
            txnigazolt.Size = new Size(76, 23);
            txnigazolt.TabIndex = 17;
            // 
            // cbnap
            // 
            cbnap.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnap.FormattingEnabled = true;
            cbnap.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cbnap.Location = new Point(909, 142);
            cbnap.Name = "cbnap";
            cbnap.Size = new Size(76, 23);
            cbnap.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 532);
            Controls.Add(cbnap);
            Controls.Add(txnigazolt);
            Controls.Add(txigazolt);
            Controls.Add(txosztaly);
            Controls.Add(txnev);
            Controls.Add(btmentes);
            Controls.Add(rtbtanulok);
            Controls.Add(label10);
            Controls.Add(lborak);
            Controls.Add(label8);
            Controls.Add(lbosszeshiany);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvtabla);
            Controls.Add(label1);
            Controls.Add(rtbadatok);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Mulasztások - szeptember hónap";
            ((System.ComponentModel.ISupportInitialize)dgvtabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbadatok;
        private Label label1;
        private DataGridView dgvtabla;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Osztaly;
        private DataGridViewTextBoxColumn Hanyadik;
        private DataGridViewTextBoxColumn Igazolt;
        private DataGridViewTextBoxColumn Nemigazolt;
        private DataGridViewTextBoxColumn Osszeshianyzas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbosszeshiany;
        private Label label8;
        private Label lborak;
        private Label label10;
        private RichTextBox rtbtanulok;
        private Button btmentes;
        private TextBox txnev;
        private TextBox txosztaly;
        private TextBox txigazolt;
        private TextBox txnigazolt;
        private ComboBox cbnap;
    }
}
