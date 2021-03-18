using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hianyzasok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Beolvasas();
            Masodik();
        }
        static List<Tanulo> tanulok = new List<Tanulo>();
        public void Beolvasas()
        {
            StreamReader ol = new StreamReader("szeptember.csv");
            ol.ReadLine();
            while (!ol.EndOfStream)
            {
                string[] a = ol.ReadLine().Split(';');
                tanulok.Add(new Tanulo(a[0],a[1],int.Parse(a[2]),int.Parse(a[3]),int.Parse(a[4])));
            }
            ol.Close();
        }
        public void Masodik()
        {
            lbKiadatok.Items.Add("Név\tOsztály\tElső nap\tUtolsó nap\t Mulasztott órás");
            foreach (var t in tanulok)
            {
                lbKiadatok.Items.Add($"{t.Nev}\t{t.Osztaly}\t{t.Elso}\t{t.Utolso}\t{t.Mulasztott}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNev.Text =="" || tbOsztaly.Text == ""|| tbMulasztott.Text ==""||tbElso.Text == ""||tbUtolso.Text =="")
            {
                MessageBox.Show("Minden adatot meg kell adni!");
            }
            else
            {
                char[] szamok = new char[] {'0','1','2','3','4','5','6','7','8','9' };
                bool van = false;
                for (int i = 0; i < tbElso.Text.Length; i++)
                {
                    if (!szamok.Contains(tbElso.Text[i]))
                    {
                        van = true;
                    }
                }
                
                for (int i = 0; i < tbUtolso.Text.Length; i++)
                {
                    if (!szamok.Contains(tbUtolso.Text[i]))
                    {
                        van = true;
                    }
                }
                for (int i = 0; i < tbMulasztott.Text.Length; i++)
                {
                    if (!szamok.Contains(tbMulasztott.Text[i]))
                    {
                        van = true;
                    }
                }
                if (van)
                {
                    MessageBox.Show("Nem számot adtál meg");
                }
                else
                {
                    if (int.Parse(tbElso.Text)<1 || int.Parse(tbUtolso.Text)>30)
                    {
                        MessageBox.Show("Hibás adat! Csak 1 és 30 közötti érték lehet!");
                    }
                    if (int.Parse(tbElso.Text) > int.Parse(tbUtolso.Text))
                    {
                        MessageBox.Show("Az uloso nap legyen nagyobb mint az első");
                    }
                    else
                    {
                        StreamWriter iro = new StreamWriter("szeptember.csv",true);
                        iro.WriteLine($"{tbNev.Text};{tbOsztaly.Text};{tbElso.Text};{tbUtolso.Text};{tbMulasztott.Text}");
                        iro.Close();
                        MessageBox.Show("Az állomány bővítése sikeres volt!");
                    }
                }
            }
        }
    }
}
