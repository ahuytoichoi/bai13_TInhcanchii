using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_TInhcanchii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "canh", "tan", "nham", "quy", "giap", "at", "Binh", "Dinh", "Mau", "Ky" };
            string[] chiArr = { "thin", "ty", "ngo", "mui", "than", "dau", "tuat", "hoi", "ty", "suu","dan","mao"};
            string giaitretrave = canArr[Convert.ToInt32(txtNam.Text) % 10] + "" + chiArr[Convert.ToInt32(txtNam.Text) % 12];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
