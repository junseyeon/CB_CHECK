using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;

        string[] mList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int[] teaTime = new int[] { 2, 3, 5, 2 };

        int pickListIndex;
        bool ready = false;

        string orgStr = "";     //선택 결과 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<mList.Length; i++)
            {
                this.comboBox1.Items.Add(mList[i]);
            }
            if(comboBox1.Items.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(ready == true)
            {
                CountOrgNum = Convert.ToInt32(teaTime[pickListIndex]*60);
                this.textBox1.ReadOnly = true;
                this.timer1.Enabled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBox1.Text != "")
            {
                pickListIndex = this.comboBox1.SelectedIndex;
                ready = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int bun;
            int cho;

            if(CountOrgNum < 1)
            {
                this.timer1.Enabled = false;
                this.textBox1.Text = "";
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CountOrgNum--;
                bun = CountOrgNum / 60;
                cho = CountOrgNum % 60;
                this.textBox1.Text = Convert.ToString(bun +"분 " + cho +"초 남았습니다!" );
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.timer1.Enabled = false;
     
            this.comboBox1.Focus();
        }
    }
}
