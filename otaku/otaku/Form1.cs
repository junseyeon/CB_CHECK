using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otaku
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;
        MessageBoxIcon mbi;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Final_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
                mbb = MessageBoxButtons.OK;
        }
    }
}
