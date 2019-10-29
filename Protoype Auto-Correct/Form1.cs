using System;
using System.Windows.Forms;

namespace Protoype_Auto_Correct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Search.ReadLines();
        }

        private void btnGenerateJarak1_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Correction.Masuk(tbInput.Text);
        }

        private void btnGenerateJarak2_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Correction.MasukJarakDua(tbInput.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = Correction.MasukSearch(tbInput.Text);
        }
    }
}
