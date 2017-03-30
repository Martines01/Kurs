namespace WindowsFormsKurs
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDaten = new System.Windows.Forms.Button();
            this.comboBoxKurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKursID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxTeilnehmerID = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonKurs = new System.Windows.Forms.Button();
            this.buttonTeilnehmer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxKurs = new System.Windows.Forms.GroupBox();
            this.groupBoxTeilnehmer = new System.Windows.Forms.GroupBox();
            this.groupBoxKurs.SuspendLayout();
            this.groupBoxTeilnehmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDaten
            // 
            this.buttonDaten.Location = new System.Drawing.Point(17, 31);
            this.buttonDaten.Name = "buttonDaten";
            this.buttonDaten.Size = new System.Drawing.Size(671, 23);
            this.buttonDaten.TabIndex = 0;
            this.buttonDaten.Text = "Daten anzeigen";
            this.buttonDaten.UseVisualStyleBackColor = true;
            this.buttonDaten.Click += new System.EventHandler(this.buttonDaten_Click);
            // 
            // comboBoxKurs
            // 
            this.comboBoxKurs.FormattingEnabled = true;
            this.comboBoxKurs.Location = new System.Drawing.Point(19, 17);
            this.comboBoxKurs.Name = "comboBoxKurs";
            this.comboBoxKurs.Size = new System.Drawing.Size(295, 21);
            this.comboBoxKurs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // textBoxKursID
            // 
            this.textBoxKursID.Location = new System.Drawing.Point(107, 61);
            this.textBoxKursID.Name = "textBoxKursID";
            this.textBoxKursID.Size = new System.Drawing.Size(100, 20);
            this.textBoxKursID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bezeichnung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nachname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vorname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBoxTeilnehmerID
            // 
            this.textBoxTeilnehmerID.Location = new System.Drawing.Point(112, 62);
            this.textBoxTeilnehmerID.Name = "textBoxTeilnehmerID";
            this.textBoxTeilnehmerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeilnehmerID.TabIndex = 12;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(112, 96);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachname.TabIndex = 13;
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(112, 130);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(100, 20);
            this.textBoxVorname.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(112, 173);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 15;
            // 
            // buttonKurs
            // 
            this.buttonKurs.Location = new System.Drawing.Point(19, 217);
            this.buttonKurs.Name = "buttonKurs";
            this.buttonKurs.Size = new System.Drawing.Size(295, 23);
            this.buttonKurs.TabIndex = 16;
            this.buttonKurs.Text = "Kurs.csv";
            this.buttonKurs.UseVisualStyleBackColor = true;
            // 
            // buttonTeilnehmer
            // 
            this.buttonTeilnehmer.Location = new System.Drawing.Point(14, 218);
            this.buttonTeilnehmer.Name = "buttonTeilnehmer";
            this.buttonTeilnehmer.Size = new System.Drawing.Size(295, 23);
            this.buttonTeilnehmer.TabIndex = 17;
            this.buttonTeilnehmer.Text = "Teilnehmer.csv";
            this.buttonTeilnehmer.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // groupBoxKurs
            // 
            this.groupBoxKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxKurs.Controls.Add(this.buttonKurs);
            this.groupBoxKurs.Controls.Add(this.textBox2);
            this.groupBoxKurs.Controls.Add(this.textBox1);
            this.groupBoxKurs.Controls.Add(this.label3);
            this.groupBoxKurs.Controls.Add(this.label2);
            this.groupBoxKurs.Controls.Add(this.textBoxKursID);
            this.groupBoxKurs.Controls.Add(this.label1);
            this.groupBoxKurs.Controls.Add(this.comboBoxKurs);
            this.groupBoxKurs.Location = new System.Drawing.Point(17, 64);
            this.groupBoxKurs.Name = "groupBoxKurs";
            this.groupBoxKurs.Size = new System.Drawing.Size(334, 260);
            this.groupBoxKurs.TabIndex = 19;
            this.groupBoxKurs.TabStop = false;
            this.groupBoxKurs.Text = "Kurs";
            // 
            // groupBoxTeilnehmer
            // 
            this.groupBoxTeilnehmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxTeilnehmer.Controls.Add(this.comboBox1);
            this.groupBoxTeilnehmer.Controls.Add(this.buttonTeilnehmer);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxEmail);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxVorname);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxNachname);
            this.groupBoxTeilnehmer.Controls.Add(this.textBoxTeilnehmerID);
            this.groupBoxTeilnehmer.Controls.Add(this.label7);
            this.groupBoxTeilnehmer.Controls.Add(this.label6);
            this.groupBoxTeilnehmer.Controls.Add(this.label5);
            this.groupBoxTeilnehmer.Controls.Add(this.label4);
            this.groupBoxTeilnehmer.Location = new System.Drawing.Point(364, 63);
            this.groupBoxTeilnehmer.Name = "groupBoxTeilnehmer";
            this.groupBoxTeilnehmer.Size = new System.Drawing.Size(324, 270);
            this.groupBoxTeilnehmer.TabIndex = 20;
            this.groupBoxTeilnehmer.TabStop = false;
            this.groupBoxTeilnehmer.Text = "Teilnehmer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 354);
            this.Controls.Add(this.groupBoxTeilnehmer);
            this.Controls.Add(this.groupBoxKurs);
            this.Controls.Add(this.buttonDaten);
            this.Name = "Form1";
            this.Text = "ADO Beispiel 2";
            this.groupBoxKurs.ResumeLayout(false);
            this.groupBoxKurs.PerformLayout();
            this.groupBoxTeilnehmer.ResumeLayout(false);
            this.groupBoxTeilnehmer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDaten;
        private System.Windows.Forms.ComboBox comboBoxKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKursID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxTeilnehmerID;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonKurs;
        private System.Windows.Forms.Button buttonTeilnehmer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxKurs;
        private System.Windows.Forms.GroupBox groupBoxTeilnehmer;
    }
}

