using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_hashing_com_deslocamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int CalculoHash(string hash)
        {
            string s = hash;
            int j = 0;
            foreach (char c in s)
            {
                j += Convert.ToInt32(c);
            }

            return j;

        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            string chave = textBox1.Text;
            int calc = 0;

            for (int i = 0; i < chave.Length; i++)
            {
                int asc = 0;
                if (i > 7)
                {
                    asc = (byte)(chave[i] << i - 7);
                    calc += asc;
                }
                else
                {
                    asc = (byte)(chave[i] << i);
                    calc += asc;
                }
            }
            int teste = calc % 7;
            switch (teste)
            {
                case 0:
                    txtResto0.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 1:
                    txtResto1.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 2:
                    txtResto2.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 3:
                    txtResto3.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 4:
                    txtResto4.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 5:
                    txtResto5.Text += " " + chave + " - " + calc.ToString();
                    break;
                case 6:
                    txtResto6.Text += " " + chave + " - " + calc.ToString();
                    break;
            }
        }
    }
}
