using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmineCekildasSoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly ThreadLocal<Random> rnd
     = new ThreadLocal<Random>(() => new Random());
        HashSet<int> numbers = new HashSet<int>();
        int count,index;
        string mesaj;

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj = "";
            count = 0;
            index = 0;
            while (index!=9)
            {
                numbers.Add( rnd.Value.Next(1, 10));
                index = numbers.Count;
                count++;
            }

            foreach (int item in numbers)
            { 
                mesaj+=item+",";
            }
            snc.Text = mesaj + " Random fonksiyonu " + count + " kere çalışmıştır.";
            numbers.Clear();
        }
    }
}
