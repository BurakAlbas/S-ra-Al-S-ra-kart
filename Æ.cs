using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aaa
{
    public partial class Form1 : Form
    {
        Stack yigin = new Stack();
        public Form1()
        {
            InitializeComponent();
        }
        private void Listele()
        {
            listeStack.Items.Clear();
            foreach (string eleman in yigin)
            {
                listeStack.Items.Add(eleman);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }

        private void txtAdSoyAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnÇıkart_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }
}
