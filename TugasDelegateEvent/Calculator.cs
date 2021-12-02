using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasDelegateEvent
{
    public partial class Calculator : Form
    {
        public delegate void Penghitung(int operasi, int a, int b, int hasil);
        public event Penghitung penghitung;
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Click_Proses(object sender, EventArgs e)
        {
            string operasi = OperasiPilihan.SelectedItem.ToString();
            int a = Convert.ToInt32(NilaiA.Text);
            int b = Convert.ToInt32(NilaiB.Text);
            int hasil=0;
            switch (OperasiPilihan.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            this.penghitung(OperasiPilihan.SelectedIndex, a, b, hasil);
        }
    }
}
