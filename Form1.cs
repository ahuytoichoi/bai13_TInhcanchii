using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_TInhcanchii
{
    public partial class Form1 : Form
    {
        string[] CanArr = { "canh", "tan", "nham", "quy", "giap", "at", "Binh", "Dinh", "Mau", "Ky" };
        string[] ChiArr = { "thin", "ty", "ngo", "mui", "than", "dau", "tuat", "hoi", "ty", "suu", "dan", "mao" };
        string TinhCan(int Nam) { return CanArr[Nam % 10]; }

        string TinhChi(int Nam) { return ChiArr[Nam % 12]; }

        string TinhCanChi(string Text) { return TinhCan(Convert.ToInt32(Text)) + "" + TinhChi(Convert.ToInt32(Text)); }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
          txtKQ.Text = TinhCanChi(txtNam.Text);
            for (int i = 1000; i < 3000; i++) 
            {
                lstNam.Items.Add(i + "-" + TinhCanChi(i.ToString()));
            }    
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
