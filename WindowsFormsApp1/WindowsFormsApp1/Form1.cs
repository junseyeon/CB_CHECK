using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("얘..얘들아","이대형 선생님이 말하시길...",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


// C:\Users\Mirim\source\repos\WindowsFormsApp1 에서 빌드를 release로 배포할때 디버그 x 