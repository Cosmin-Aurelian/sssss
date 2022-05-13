using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4_1048
{
    public partial class Form1 : Form
    {
        Student s;
        List<Student> listaStudenti;
        public Form1()
        {
            listaStudenti = new List<Student>();
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("S-a apasat dublu click!");
        }

        private string creazaAfisareLB(Student s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s.Medie);
            sb.Append(" - ");
            sb.Append(s.Nume);
            sb.Append(" - ");
            sb.Append(s.Facultate);
            return sb.ToString();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                int matricol = Convert.ToInt32(tbMatricol.Text);
                string facultate = tbFacultate.Text;
                string[] vector = tbNote.Text.Split(',');
                int[] vectorInt = new int[vector.Length];
                for (int i = 0; i < vector.Length; i++)
                {
                    vectorInt[i] = Convert.ToInt32(vector[i]);
                }

                s = new Student(nume, matricol, facultate, vectorInt);

                s.calculeazaMedia();
                listaStudenti.Add(s);
                lbStudenti.Items.Add(creazaAfisareLB(s));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                tbMatricol.Clear();
                tbFacultate.Clear();
                tbNume.Clear();
                tbNote.Clear();

            }

        }
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaStudenti);
            form2.Show();
        }

        private void lbStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbStudenti.SelectedIndex;
            Student s = listaStudenti[index];
            if(s.Medie > 9.5)
            {
                afiseazaMB("Performanta", s);
            } else if (s.Medie > 8.5 && s.Medie < 9.5)
            {
                afiseazaMB("Merit", s);
            }
            else
            {
                MessageBox.Show("Nu poate primi bursa!");
            }
        }

        private void afiseazaMB(string bursa, Student s)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            string mesaj = "Acordati bursa de " + bursa + "?";
            DialogResult result = MessageBox.Show(mesaj, "Salvare student", buttons, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                switch(bursa)
                {
                    case "Merit":
                        ListViewItem listViewItem = new ListViewItem(s.Nume);
                        listViewItem.SubItems.Add(s.Facultate);
                        listViewItem.SubItems.Add(s.Medie.ToString());
                        lvStudentiMerit.Items.Add(listViewItem);
                        break;
                    case "Performanta":
                        ListViewItem listViewItem1 = new ListViewItem(s.Nume);
                        listViewItem1.SubItems.Add(s.Facultate);
                        listViewItem1.SubItems.Add(s.Medie.ToString());
                        lvStudentiPerformanta.Items.Add(listViewItem1);
                        break;
                }
            }
        }
    }
}
