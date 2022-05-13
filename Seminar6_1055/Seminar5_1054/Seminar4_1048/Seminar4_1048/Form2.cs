using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4_1048
{
    public partial class Form2 : Form
    {
        List<Student> listaStudenti;
        public Form2(List<Student> listaStudenti)
        {
            this.listaStudenti = listaStudenti;
            InitializeComponent();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            string mesajAfisare = "";
            foreach(Student s in listaStudenti)
            {
                mesajAfisare += s.ToString() + Environment.NewLine;
            }
            tbStudenti.Text = mesajAfisare;
        }

        private void salvareTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt"; //ca la extensie sa apara doar txt
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach(Student s in listaStudenti)
                {
                    sw.WriteLine(s.ToString());
                }
                sw.Close();
                tbStudenti.Clear();
            }


        }

        private void deschideTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbStudenti.Text += sr.ReadToEnd();
                sr.Close();
            }
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaStudenti);
            fs.Close();
            tbStudenti.Clear();
            MessageBox.Show("S-a salvat fisierul serializat!");
        }

        private void deschidereBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Student> listaStudentiDeserializati = (List<Student>)bf.Deserialize(fs);
            foreach(Student s in listaStudentiDeserializati)
            {
                tbStudenti.Text += s.ToString() + Environment.NewLine;
            }
            fs.Close();
        }
    }
}
