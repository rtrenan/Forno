using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testeconnect
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
             
       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempo1v.Clear();
            tempo2v.Clear();
            tempo3v.Clear();
            tempo4v.Clear();
            tempo5v.Clear();

            setv1.Clear();
            setv2.Clear();
            setv3.Clear();
            setv4.Clear();
            setv5.Clear();
        }
    }
}
