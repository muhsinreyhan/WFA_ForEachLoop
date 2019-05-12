using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ForEachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;
        private void Button1_Click(object sender, EventArgs e)
        {
            lstIkıyeBolunmeyen.Items.Clear();
            lstIkıyeBolunen.Items.Clear();

            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };
            
                foreach(int sayi in dizi)
            {
                if (sayi % 2 == 0)
                {
                    lstIkıyeBolunen.Items.Add(sayi);
                }
                else
                {
                    lstIkıyeBolunmeyen.Items.Add(sayi);
                }
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    count++;
                }

                lblSonuc.Text = count.ToString();
            }
        }
        Random rnd = new Random();
        private void Button12_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                }
            }
        }
    }
}
