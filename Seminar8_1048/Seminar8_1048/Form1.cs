using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar8_1048
{
    public partial class Form1 : Form
    {
        List<Produs> listaProduse = new List<Produs>();
        List<TextBox> listaTB = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            listaTB.Add(tbDenumire);
            listaTB.Add(tbPret);
            listaTB.Add(tbCantitate);
            listaTB.Add(tbValoare);
            tbCantitate.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
            tbPret.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
        }

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >='0' && e.KeyChar<='9'||e.KeyChar==(char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAdaugaLinie_Click(object sender, EventArgs e)
        {
            int X = listaTB[0].Location.X;
            int Y = listaTB[listaTB.Count - 1].Location.Y;
            int distantaTB = listaTB[1].Location.X - listaTB[0].Location.X;

            for(int i=0; i<4; i++)
            {
                TextBox tb = new TextBox();
                tb.Location = new Point(X, Y + 30);
                X += distantaTB;
                tb.Width = tbDenumire.Width;
                if(i==1||i==2)
                {
                    tb.KeyPress += new KeyPressEventHandler(tbCifre_KeyPress);
                }
                if(i==3)
                {
                    tb.ReadOnly = true;
                }
                listaTB.Add(tb);
                this.Controls.Add(tb);
            }
        }

        private void btnCalculeazaTotal_Click(object sender, EventArgs e)
        {
            int totalComanda = 0;

            for(int i=0; i<listaTB.Count; i+=4)
            {
                if(listaTB[i].Text=="")
                {
                    errorProvider1.SetError(listaTB[i], "Introduceti denumirea!");
                } else if(listaTB[i+1].Text=="")
                {
                    errorProvider1.SetError(listaTB[i + 1], "Introduceti pretul");
                } else if(listaTB[i+2].Text=="")
                {
                    errorProvider1.SetError(listaTB[i + 2], "Introduceti cantitatea");
                }
                else
                {
                    errorProvider1.Clear();
                    string denumire = listaTB[i].Text;
                    int pret = Convert.ToInt32(listaTB[i + 1].Text);
                    int cantitate = Convert.ToInt32(listaTB[i + 2].Text);

                    Produs p = new Produs(denumire, pret, cantitate);
                    listaProduse.Add(p);

                    int valoare = pret * cantitate;
                    totalComanda += valoare;
                    listaTB[i + 3].Text = valoare.ToString();

                    ListViewItem listViewItem = new ListViewItem(p.Denumire);
                    listViewItem.SubItems.Add(p.Pret.ToString());
                    listViewItem.SubItems.Add(p.Cantitate.ToString());
                    listViewItem.SubItems.Add(valoare.ToString());
                    lvProduse.Items.Add(listViewItem);
                }
                tbValoareTotala.Text = totalComanda.ToString();
            }
        }

        private void tbComanda_Click(object sender, EventArgs e)
        {
            string dataComanda = dtpData.Value.ToString("dd-MM-yyyy");
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            saveFileDialog1.FileName = "Comanda_" + dataComanda;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(dataComanda);
                foreach (Produs p in listaProduse)
                {
                    sw.WriteLine(p.Denumire + " " + p.Pret + " " + p.Cantitate);
                }
                sw.WriteLine("Valoare comanda: " + tbValoareTotala.Text);
                sw.Close();
            }
            this.Close();
        }
    }
}
