using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protoype_Auto_Correct
{
    public partial class Form1 : Form
    {
        Correction cs = new Correction();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateJarak1_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = cs.Masuk(tbInput.Text);
        }

        private void btnGenerateJarak2_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = cs.MasukJarakDua(tbInput.Text);
        }
    }
}
