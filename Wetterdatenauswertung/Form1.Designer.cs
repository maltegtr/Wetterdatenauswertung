namespace Wetterdatenauswertung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstBoxAusgabe = new System.Windows.Forms.ListBox();
            this.btnEinlesen = new System.Windows.Forms.Button();
            this.btnSpeichernDatei = new System.Windows.Forms.Button();
            this.btnSpeichernListe = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTemperatur = new System.Windows.Forms.TextBox();
            this.txtBoxFeuchtigkeit = new System.Windows.Forms.TextBox();
            this.lblAuswertung = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpeichernDatei);
            this.groupBox1.Controls.Add(this.btnEinlesen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateioperationen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxFeuchtigkeit);
            this.groupBox2.Controls.Add(this.txtBoxTemperatur);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.btnSpeichernListe);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateieingabe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAuswertung);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 249);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auswertung";
            // 
            // lstBoxAusgabe
            // 
            this.lstBoxAusgabe.FormattingEnabled = true;
            this.lstBoxAusgabe.Location = new System.Drawing.Point(424, 12);
            this.lstBoxAusgabe.Name = "lstBoxAusgabe";
            this.lstBoxAusgabe.Size = new System.Drawing.Size(270, 251);
            this.lstBoxAusgabe.TabIndex = 4;
            // 
            // btnEinlesen
            // 
            this.btnEinlesen.Location = new System.Drawing.Point(32, 20);
            this.btnEinlesen.Name = "btnEinlesen";
            this.btnEinlesen.Size = new System.Drawing.Size(132, 36);
            this.btnEinlesen.TabIndex = 0;
            this.btnEinlesen.Text = "Einlesen Datei";
            this.btnEinlesen.UseVisualStyleBackColor = true;
            // 
            // btnSpeichernDatei
            // 
            this.btnSpeichernDatei.Location = new System.Drawing.Point(32, 58);
            this.btnSpeichernDatei.Name = "btnSpeichernDatei";
            this.btnSpeichernDatei.Size = new System.Drawing.Size(132, 36);
            this.btnSpeichernDatei.TabIndex = 1;
            this.btnSpeichernDatei.Text = "Speichern Datei";
            this.btnSpeichernDatei.UseVisualStyleBackColor = true;
            // 
            // btnSpeichernListe
            // 
            this.btnSpeichernListe.Location = new System.Drawing.Point(6, 114);
            this.btnSpeichernListe.Name = "btnSpeichernListe";
            this.btnSpeichernListe.Size = new System.Drawing.Size(188, 23);
            this.btnSpeichernListe.TabIndex = 0;
            this.btnSpeichernListe.Text = "Speichern Liste";
            this.btnSpeichernListe.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatur [°C]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feuchtigkeit [%]";
            // 
            // txtBoxTemperatur
            // 
            this.txtBoxTemperatur.Location = new System.Drawing.Point(93, 45);
            this.txtBoxTemperatur.Name = "txtBoxTemperatur";
            this.txtBoxTemperatur.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTemperatur.TabIndex = 4;
            // 
            // txtBoxFeuchtigkeit
            // 
            this.txtBoxFeuchtigkeit.Location = new System.Drawing.Point(93, 71);
            this.txtBoxFeuchtigkeit.Name = "txtBoxFeuchtigkeit";
            this.txtBoxFeuchtigkeit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFeuchtigkeit.TabIndex = 5;
            // 
            // lblAuswertung
            // 
            this.lblAuswertung.AutoSize = true;
            this.lblAuswertung.Location = new System.Drawing.Point(6, 16);
            this.lblAuswertung.Name = "lblAuswertung";
            this.lblAuswertung.Size = new System.Drawing.Size(35, 13);
            this.lblAuswertung.TabIndex = 0;
            this.lblAuswertung.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 268);
            this.Controls.Add(this.lstBoxAusgabe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpeichernDatei;
        private System.Windows.Forms.Button btnEinlesen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSpeichernListe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstBoxAusgabe;
        private System.Windows.Forms.TextBox txtBoxFeuchtigkeit;
        private System.Windows.Forms.TextBox txtBoxTemperatur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuswertung;
    }
}

