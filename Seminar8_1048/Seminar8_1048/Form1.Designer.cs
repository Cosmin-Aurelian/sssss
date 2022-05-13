
namespace Seminar8_1048
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
            this.components = new System.ComponentModel.Container();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.btnAdaugaLinie = new System.Windows.Forms.Button();
            this.btnCalculeazaTotal = new System.Windows.Forms.Button();
            this.lvProduse = new System.Windows.Forms.ListView();
            this.colDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tbValoareTotala = new System.Windows.Forms.TextBox();
            this.tbComanda = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(27, 50);
            this.dtpData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(151, 20);
            this.dtpData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantitate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valoare";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(17, 257);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(76, 20);
            this.tbDenumire.TabIndex = 5;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(116, 256);
            this.tbPret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(76, 20);
            this.tbPret.TabIndex = 6;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(234, 256);
            this.tbCantitate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(76, 20);
            this.tbCantitate.TabIndex = 7;
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(337, 256);
            this.tbValoare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.ReadOnly = true;
            this.tbValoare.Size = new System.Drawing.Size(76, 20);
            this.tbValoare.TabIndex = 8;
            // 
            // btnAdaugaLinie
            // 
            this.btnAdaugaLinie.Location = new System.Drawing.Point(440, 255);
            this.btnAdaugaLinie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdaugaLinie.Name = "btnAdaugaLinie";
            this.btnAdaugaLinie.Size = new System.Drawing.Size(96, 19);
            this.btnAdaugaLinie.TabIndex = 9;
            this.btnAdaugaLinie.Text = "Adauga linie";
            this.btnAdaugaLinie.UseVisualStyleBackColor = true;
            this.btnAdaugaLinie.Click += new System.EventHandler(this.btnAdaugaLinie_Click);
            // 
            // btnCalculeazaTotal
            // 
            this.btnCalculeazaTotal.Location = new System.Drawing.Point(440, 293);
            this.btnCalculeazaTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculeazaTotal.Name = "btnCalculeazaTotal";
            this.btnCalculeazaTotal.Size = new System.Drawing.Size(96, 19);
            this.btnCalculeazaTotal.TabIndex = 10;
            this.btnCalculeazaTotal.Text = "Calculeaza total";
            this.btnCalculeazaTotal.UseVisualStyleBackColor = true;
            this.btnCalculeazaTotal.Click += new System.EventHandler(this.btnCalculeazaTotal_Click);
            // 
            // lvProduse
            // 
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDenumire,
            this.colPret,
            this.colCantitate,
            this.colValoare});
            this.lvProduse.GridLines = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location = new System.Drawing.Point(248, 24);
            this.lvProduse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvProduse.Name = "lvProduse";
            this.lvProduse.Size = new System.Drawing.Size(288, 172);
            this.lvProduse.TabIndex = 11;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View = System.Windows.Forms.View.Details;
            // 
            // colDenumire
            // 
            this.colDenumire.Text = "Denumire";
            this.colDenumire.Width = 82;
            // 
            // colPret
            // 
            this.colPret.DisplayIndex = 2;
            this.colPret.Text = "Pret";
            // 
            // colCantitate
            // 
            this.colCantitate.DisplayIndex = 1;
            this.colCantitate.Text = "Cantitate";
            this.colCantitate.Width = 77;
            // 
            // colValoare
            // 
            this.colValoare.Text = "Valoare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valoare totala";
            // 
            // tbValoareTotala
            // 
            this.tbValoareTotala.Location = new System.Drawing.Point(603, 99);
            this.tbValoareTotala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbValoareTotala.Name = "tbValoareTotala";
            this.tbValoareTotala.ReadOnly = true;
            this.tbValoareTotala.Size = new System.Drawing.Size(110, 20);
            this.tbValoareTotala.TabIndex = 13;
            // 
            // tbComanda
            // 
            this.tbComanda.Location = new System.Drawing.Point(603, 255);
            this.tbComanda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbComanda.Name = "tbComanda";
            this.tbComanda.Size = new System.Drawing.Size(128, 57);
            this.tbComanda.TabIndex = 14;
            this.tbComanda.Text = "Comanda";
            this.tbComanda.UseVisualStyleBackColor = true;
            this.tbComanda.Click += new System.EventHandler(this.tbComanda_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 442);
            this.Controls.Add(this.tbComanda);
            this.Controls.Add(this.tbValoareTotala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.btnCalculeazaTotal);
            this.Controls.Add(this.btnAdaugaLinie);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Button btnAdaugaLinie;
        private System.Windows.Forms.Button btnCalculeazaTotal;
        private System.Windows.Forms.ListView lvProduse;
        private System.Windows.Forms.ColumnHeader colDenumire;
        private System.Windows.Forms.ColumnHeader colPret;
        private System.Windows.Forms.ColumnHeader colCantitate;
        private System.Windows.Forms.ColumnHeader colValoare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValoareTotala;
        private System.Windows.Forms.Button tbComanda;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

