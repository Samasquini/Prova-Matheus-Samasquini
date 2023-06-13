using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2Bim
{
    public partial class Prova : Form
    {
        public Prova()
        {
            InitializeComponent();
        }

        private void Prova_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gabarito = { "a", "b", "d", "e", "c", "a", "a", "d", "e", "b" };
            string[] prova = { textBox1.Text.ToLower(), textBox2.Text.ToLower(), textBox3.Text.ToLower(), textBox4.Text.ToLower(), textBox5.Text.ToLower(), textBox6.Text.ToLower(), textBox7.Text.ToLower(), textBox8.Text.ToLower(), textBox9.Text.ToLower(), textBox10.Text.ToLower() };
            int acertos = 0;
            for (int i = 0; i < gabarito.Length; i++)
            {
                if (gabarito[i] == prova[i])
                {
                    acertos++;
                }
            }
            label12.Text = acertos.ToString();
        }
    }
}
