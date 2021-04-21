using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GelismisHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbislem.SelectedIndex = 0;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            decimal s1 = nudSayi1.Value;
            decimal s2 = nudSayi2.Value;

            decimal toplam = 0;

            switch (cmbislem.Text)
            {
                case "+": toplam = s1 + s2;
                break;
                case "-":toplam = s1 - s2;
                break;
                case "*":toplam = s1 * s2;
                break;
                case "/":toplam = s1 / s2;
                break;
                case "%":toplam = s1 % s2;
                break;
                default: break;

            }
            lblSonuc.Text = Convert.ToString(toplam);

        }
    }
}
