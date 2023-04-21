namespace CatalogScolar
{
    partial class Catalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.adaugaElev = new System.Windows.Forms.Button();
            this.modificaElev = new System.Windows.Forms.Button();
            this.stergeElev = new System.Windows.Forms.Button();
            this.adaugaNota = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modificaNota = new System.Windows.Forms.Button();
            this.StergeNote = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.TextBox();
            this.cnp = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.materie = new System.Windows.Forms.ComboBox();
            this.profesor = new System.Windows.Forms.ComboBox();
            this.nota = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.vizualizareElevi = new System.Windows.Forms.Button();
            this.vizualizareNote = new System.Windows.Forms.Button();
            this.cautaElev = new System.Windows.Forms.Button();
            this.noteLaMaterie = new System.Windows.Forms.Button();
            this.vizualizareNoteElev = new System.Windows.Forms.Button();
            this.noteElevLaMaterie = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.idElev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adaugaElev
            // 
            this.adaugaElev.Location = new System.Drawing.Point(38, 300);
            this.adaugaElev.Name = "adaugaElev";
            this.adaugaElev.Size = new System.Drawing.Size(179, 58);
            this.adaugaElev.TabIndex = 1;
            this.adaugaElev.Text = "Adauga Elev";
            this.adaugaElev.UseVisualStyleBackColor = true;
            this.adaugaElev.Click += new System.EventHandler(this.adaugaElev_Click);
            // 
            // modificaElev
            // 
            this.modificaElev.Location = new System.Drawing.Point(223, 300);
            this.modificaElev.Name = "modificaElev";
            this.modificaElev.Size = new System.Drawing.Size(179, 58);
            this.modificaElev.TabIndex = 2;
            this.modificaElev.Text = "Modifica Elev";
            this.modificaElev.UseVisualStyleBackColor = true;
            this.modificaElev.Click += new System.EventHandler(this.modificaElev_Click);
            // 
            // stergeElev
            // 
            this.stergeElev.Location = new System.Drawing.Point(408, 300);
            this.stergeElev.Name = "stergeElev";
            this.stergeElev.Size = new System.Drawing.Size(179, 58);
            this.stergeElev.TabIndex = 3;
            this.stergeElev.Text = "Sterge Elev";
            this.stergeElev.UseVisualStyleBackColor = true;
            this.stergeElev.Click += new System.EventHandler(this.stergeElev_Click);
            // 
            // adaugaNota
            // 
            this.adaugaNota.Location = new System.Drawing.Point(38, 364);
            this.adaugaNota.Name = "adaugaNota";
            this.adaugaNota.Size = new System.Drawing.Size(179, 58);
            this.adaugaNota.TabIndex = 4;
            this.adaugaNota.Text = "Adauga Nota";
            this.adaugaNota.UseVisualStyleBackColor = true;
            this.adaugaNota.Click += new System.EventHandler(this.adaugaNota_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(57, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(57, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa";
            // 
            // modificaNota
            // 
            this.modificaNota.Location = new System.Drawing.Point(223, 364);
            this.modificaNota.Name = "modificaNota";
            this.modificaNota.Size = new System.Drawing.Size(179, 58);
            this.modificaNota.TabIndex = 9;
            this.modificaNota.Text = "Modifica Nota";
            this.modificaNota.UseVisualStyleBackColor = true;
            this.modificaNota.Click += new System.EventHandler(this.modificaNota_Click);
            // 
            // StergeNote
            // 
            this.StergeNote.Location = new System.Drawing.Point(408, 364);
            this.StergeNote.Name = "StergeNote";
            this.StergeNote.Size = new System.Drawing.Size(179, 58);
            this.StergeNote.TabIndex = 10;
            this.StergeNote.Text = "Sterge Nota";
            this.StergeNote.UseVisualStyleBackColor = true;
            this.StergeNote.Click += new System.EventHandler(this.StergeNote_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(603, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(603, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Profesor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(603, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Materie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(603, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 30);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nota";
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(188, 169);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(364, 26);
            this.prenume.TabIndex = 16;
            // 
            // cnp
            // 
            this.cnp.Location = new System.Drawing.Point(188, 215);
            this.cnp.Name = "cnp";
            this.cnp.Size = new System.Drawing.Size(364, 26);
            this.cnp.TabIndex = 17;
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(188, 258);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(364, 26);
            this.adresa.TabIndex = 18;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(733, 215);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(364, 26);
            this.data.TabIndex = 21;
            // 
            // materie
            // 
            this.materie.FormattingEnabled = true;
            this.materie.Items.AddRange(new object[] {
            "Matematica",
            "Romana",
            "Istorie",
            "Engleza",
            "Religie",
            "Informatica",
            "Fizica"});
            this.materie.Location = new System.Drawing.Point(733, 171);
            this.materie.Name = "materie";
            this.materie.Size = new System.Drawing.Size(364, 28);
            this.materie.TabIndex = 23;
            // 
            // profesor
            // 
            this.profesor.FormattingEnabled = true;
            this.profesor.Items.AddRange(new object[] {
            "Iordache Vasile",
            "Popescu Marius",
            "Pavelescu Cosmin",
            "Cornel Ionut "});
            this.profesor.Location = new System.Drawing.Point(733, 254);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(364, 28);
            this.profesor.TabIndex = 24;
            // 
            // nota
            // 
            this.nota.FormattingEnabled = true;
            this.nota.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nota.Location = new System.Drawing.Point(733, 126);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(364, 28);
            this.nota.TabIndex = 25;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(38, 438);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1104, 573);
            this.dataGridView.TabIndex = 26;
            // 
            // vizualizareElevi
            // 
            this.vizualizareElevi.Location = new System.Drawing.Point(593, 300);
            this.vizualizareElevi.Name = "vizualizareElevi";
            this.vizualizareElevi.Size = new System.Drawing.Size(179, 58);
            this.vizualizareElevi.TabIndex = 27;
            this.vizualizareElevi.Text = "Vizualizare Elevi";
            this.vizualizareElevi.UseVisualStyleBackColor = true;
            this.vizualizareElevi.Click += new System.EventHandler(this.vizualizareElevi_Click);
            // 
            // vizualizareNote
            // 
            this.vizualizareNote.Location = new System.Drawing.Point(593, 364);
            this.vizualizareNote.Name = "vizualizareNote";
            this.vizualizareNote.Size = new System.Drawing.Size(179, 58);
            this.vizualizareNote.TabIndex = 28;
            this.vizualizareNote.Text = "Vizualizare Note";
            this.vizualizareNote.UseVisualStyleBackColor = true;
            this.vizualizareNote.Click += new System.EventHandler(this.vizualizareNote_Click);
            // 
            // cautaElev
            // 
            this.cautaElev.Location = new System.Drawing.Point(778, 300);
            this.cautaElev.Name = "cautaElev";
            this.cautaElev.Size = new System.Drawing.Size(179, 58);
            this.cautaElev.TabIndex = 29;
            this.cautaElev.Text = "Cauta Elev";
            this.cautaElev.UseVisualStyleBackColor = true;
            this.cautaElev.Click += new System.EventHandler(this.cautaElev_Click);
            // 
            // noteLaMaterie
            // 
            this.noteLaMaterie.Location = new System.Drawing.Point(778, 364);
            this.noteLaMaterie.Name = "noteLaMaterie";
            this.noteLaMaterie.Size = new System.Drawing.Size(179, 58);
            this.noteLaMaterie.TabIndex = 30;
            this.noteLaMaterie.Text = "Vizualizare Note La Materie";
            this.noteLaMaterie.UseVisualStyleBackColor = true;
            this.noteLaMaterie.Click += new System.EventHandler(this.noteLaMaterie_Click);
            // 
            // vizualizareNoteElev
            // 
            this.vizualizareNoteElev.Location = new System.Drawing.Point(963, 300);
            this.vizualizareNoteElev.Name = "vizualizareNoteElev";
            this.vizualizareNoteElev.Size = new System.Drawing.Size(179, 58);
            this.vizualizareNoteElev.TabIndex = 31;
            this.vizualizareNoteElev.Text = "Vizualizare Note Elev";
            this.vizualizareNoteElev.UseVisualStyleBackColor = true;
            this.vizualizareNoteElev.Click += new System.EventHandler(this.vizualizareNoteElev_Click);
            // 
            // noteElevLaMaterie
            // 
            this.noteElevLaMaterie.Location = new System.Drawing.Point(963, 364);
            this.noteElevLaMaterie.Name = "noteElevLaMaterie";
            this.noteElevLaMaterie.Size = new System.Drawing.Size(179, 58);
            this.noteElevLaMaterie.TabIndex = 32;
            this.noteElevLaMaterie.Text = "Vizualizare Note Elev La Materie";
            this.noteElevLaMaterie.UseVisualStyleBackColor = true;
            this.noteElevLaMaterie.Click += new System.EventHandler(this.noteElevLaMaterie_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id.Location = new System.Drawing.Point(603, 77);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(90, 30);
            this.Id.TabIndex = 33;
            this.Id.Text = "Id Elev";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(188, 129);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(364, 26);
            this.nume.TabIndex = 15;
            // 
            // idElev
            // 
            this.idElev.Location = new System.Drawing.Point(733, 83);
            this.idElev.Name = "idElev";
            this.idElev.Size = new System.Drawing.Size(95, 26);
            this.idElev.TabIndex = 34;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 1050);
            this.Controls.Add(this.idElev);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.noteElevLaMaterie);
            this.Controls.Add(this.vizualizareNoteElev);
            this.Controls.Add(this.noteLaMaterie);
            this.Controls.Add(this.cautaElev);
            this.Controls.Add(this.vizualizareNote);
            this.Controls.Add(this.vizualizareElevi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.materie);
            this.Controls.Add(this.data);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.cnp);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StergeNote);
            this.Controls.Add(this.modificaNota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adaugaNota);
            this.Controls.Add(this.stergeElev);
            this.Controls.Add(this.modificaElev);
            this.Controls.Add(this.adaugaElev);
            this.Controls.Add(this.label1);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adaugaElev;
        private System.Windows.Forms.Button modificaElev;
        private System.Windows.Forms.Button stergeElev;
        private System.Windows.Forms.Button adaugaNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modificaNota;
        private System.Windows.Forms.Button StergeNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox cnp;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.ComboBox materie;
        private System.Windows.Forms.ComboBox profesor;
        private System.Windows.Forms.ComboBox nota;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button vizualizareElevi;
        private System.Windows.Forms.Button vizualizareNote;
        private System.Windows.Forms.Button cautaElev;
        private System.Windows.Forms.Button noteLaMaterie;
        private System.Windows.Forms.Button vizualizareNoteElev;
        private System.Windows.Forms.Button noteElevLaMaterie;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox idElev;
    }
}