
namespace Seminar4_1048
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbMatricol = new System.Windows.Forms.TextBox();
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.lvStudentiPerformanta = new System.Windows.Forms.ListView();
            this.lvStudentiMerit = new System.Windows.Forms.ListView();
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFacultate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNume1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFacultate1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedie1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "matricol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "facultate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "note";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(186, 73);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 4;
            // 
            // tbMatricol
            // 
            this.tbMatricol.Location = new System.Drawing.Point(186, 110);
            this.tbMatricol.Name = "tbMatricol";
            this.tbMatricol.Size = new System.Drawing.Size(100, 22);
            this.tbMatricol.TabIndex = 5;
            // 
            // tbFacultate
            // 
            this.tbFacultate.Location = new System.Drawing.Point(186, 150);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(100, 22);
            this.tbFacultate.TabIndex = 6;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(186, 182);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(100, 22);
            this.tbNote.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(177, 242);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(118, 33);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "adaugaStudent";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(343, 242);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(161, 33);
            this.btnAfiseaza.TabIndex = 12;
            this.btnAfiseaza.Text = "Afiseaza studenti";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.ItemHeight = 16;
            this.lbStudenti.Location = new System.Drawing.Point(334, 73);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(178, 132);
            this.lbStudenti.TabIndex = 13;
            this.lbStudenti.SelectedIndexChanged += new System.EventHandler(this.lbStudenti_SelectedIndexChanged);
            // 
            // lvStudentiPerformanta
            // 
            this.lvStudentiPerformanta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume,
            this.colFacultate,
            this.colMedie});
            this.lvStudentiPerformanta.GridLines = true;
            this.lvStudentiPerformanta.HideSelection = false;
            this.lvStudentiPerformanta.Location = new System.Drawing.Point(43, 329);
            this.lvStudentiPerformanta.Name = "lvStudentiPerformanta";
            this.lvStudentiPerformanta.Size = new System.Drawing.Size(301, 97);
            this.lvStudentiPerformanta.TabIndex = 14;
            this.lvStudentiPerformanta.UseCompatibleStateImageBehavior = false;
            this.lvStudentiPerformanta.View = System.Windows.Forms.View.Details;
            // 
            // lvStudentiMerit
            // 
            this.lvStudentiMerit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume1,
            this.colFacultate1,
            this.colMedie1});
            this.lvStudentiMerit.GridLines = true;
            this.lvStudentiMerit.HideSelection = false;
            this.lvStudentiMerit.Location = new System.Drawing.Point(362, 329);
            this.lvStudentiMerit.Name = "lvStudentiMerit";
            this.lvStudentiMerit.Size = new System.Drawing.Size(282, 97);
            this.lvStudentiMerit.TabIndex = 15;
            this.lvStudentiMerit.UseCompatibleStateImageBehavior = false;
            this.lvStudentiMerit.View = System.Windows.Forms.View.Details;
            // 
            // colNume
            // 
            this.colNume.Text = "Nume student";
            this.colNume.Width = 105;
            // 
            // colFacultate
            // 
            this.colFacultate.Text = "Facultate";
            this.colFacultate.Width = 92;
            // 
            // colMedie
            // 
            this.colMedie.Text = "Medie";
            this.colMedie.Width = 82;
            // 
            // colNume1
            // 
            this.colNume1.Text = "Nume";
            this.colNume1.Width = 85;
            // 
            // colFacultate1
            // 
            this.colFacultate1.Text = "Facultate";
            this.colFacultate1.Width = 82;
            // 
            // colMedie1
            // 
            this.colMedie1.Text = "Medie";
            this.colMedie1.Width = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.lvStudentiMerit);
            this.Controls.Add(this.lvStudentiPerformanta);
            this.Controls.Add(this.lbStudenti);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbMatricol);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbMatricol;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.ListView lvStudentiPerformanta;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader colFacultate;
        private System.Windows.Forms.ColumnHeader colMedie;
        private System.Windows.Forms.ListView lvStudentiMerit;
        private System.Windows.Forms.ColumnHeader colNume1;
        private System.Windows.Forms.ColumnHeader colFacultate1;
        private System.Windows.Forms.ColumnHeader colMedie1;
    }
}

