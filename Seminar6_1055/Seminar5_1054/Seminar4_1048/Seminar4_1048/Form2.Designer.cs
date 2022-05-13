
namespace Seminar4_1048
{
    partial class Form2
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
            this.tbStudenti = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStudenti
            // 
            this.tbStudenti.Location = new System.Drawing.Point(120, 73);
            this.tbStudenti.Multiline = true;
            this.tbStudenti.Name = "tbStudenti";
            this.tbStudenti.Size = new System.Drawing.Size(559, 113);
            this.tbStudenti.TabIndex = 0;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(390, 275);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(247, 75);
            this.btnAfiseaza.TabIndex = 1;
            this.btnAfiseaza.Text = "Afiseaza Studenti";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareTxtToolStripMenuItem,
            this.deschideTxtToolStripMenuItem,
            this.salvareBinarToolStripMenuItem,
            this.deschidereBinarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvareTxtToolStripMenuItem
            // 
            this.salvareTxtToolStripMenuItem.Name = "salvareTxtToolStripMenuItem";
            this.salvareTxtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareTxtToolStripMenuItem.Text = "Salvare Txt";
            this.salvareTxtToolStripMenuItem.Click += new System.EventHandler(this.salvareTxtToolStripMenuItem_Click);
            // 
            // deschideTxtToolStripMenuItem
            // 
            this.deschideTxtToolStripMenuItem.Name = "deschideTxtToolStripMenuItem";
            this.deschideTxtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschideTxtToolStripMenuItem.Text = "Deschide Txt";
            this.deschideTxtToolStripMenuItem.Click += new System.EventHandler(this.deschideTxtToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareBinarToolStripMenuItem.Text = "Salvare binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // deschidereBinarToolStripMenuItem
            // 
            this.deschidereBinarToolStripMenuItem.Name = "deschidereBinarToolStripMenuItem";
            this.deschidereBinarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschidereBinarToolStripMenuItem.Text = "Deschidere binar";
            this.deschidereBinarToolStripMenuItem.Click += new System.EventHandler(this.deschidereBinarToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.tbStudenti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudenti;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideTxtToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereBinarToolStripMenuItem;
    }
}