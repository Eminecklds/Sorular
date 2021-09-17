using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmineCekildasSoru
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string value;
        int count,cursor;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "";
            cursor = 1;
            value = textBox1.Text;
            count = value.Length;
            char[] character = value.ToCharArray();
            if (!(string.IsNullOrEmpty(value)))
            {
                if (character[0] == character[count - 1])
                {
                    listBox1.Items.Add(Convert.ToString(character[0]));
                    for (int a = 2; a <= count - 1; a++)
                    {
                        if (character[cursor] == character[a])
                        {
                            cursor = Add(character, a);
                            a++;
                        }
                    }

                }
                else
                {
                    label1.Text = "Lütfen girdiğiniz formatı kontrol ediniz.";
                }
            }
            else { label1.Text = "Lütfen uygun formatlı veri giriniz."; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private int Add(char[] character,int i)
        {
            string hyphen = "-";
            for (int x = cursor; x <= i; x++)
            {
                for(int y=x+1; y <= i; y++)
                {
                    if (character[x] == character[y])
                    {
                        if (y - x > 2)
                        {
                            listBox1.Items.Add(hyphen+Convert.ToString(character[x]));
                            hyphen += "-";
                        }
                        else { 
                        listBox1.Items.Add(hyphen + Convert.ToString(character[x]));
                        x++;
                        y++;
                        }
                    }
                }
            }

            return ++i;
        }
    }
}
