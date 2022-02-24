using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
        Queue kuyruk = new Queue();
        int sira = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }
        private void Listele()
        {
            listeSiralar.Items.Clear();
            foreach (int sira in kuyruk)
            {
                listeSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    }
}
