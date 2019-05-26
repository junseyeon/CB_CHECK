using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;  // 메시지 버튼 옵션 설정 
        MessageBoxIcon mbi;     // 메시지 버튼 아이콘 설정

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
                mbb = MessageBoxButtons.OK;     // [확인] 버튼
            else if (this.radioButton3.Checked)
                mbb = MessageBoxButtons.OKCancel;// [확인/취소] 버튼
            else if (this.radioButton4.Checked)
                mbb = MessageBoxButtons.YesNo;  // [예/아니오] 버튼

            if (this.radioButton5.Checked)
                mbi = MessageBoxIcon.Error;         // 에러 아이콘
            else if (this.radioButton6.Checked)
                mbi = MessageBoxIcon.Information;   // 정보 아이콘
            else if (this.radioButton7.Checked)
                mbi = MessageBoxIcon.Question;      // 질문 아이콘

            MessageBox.Show("메시지 박스를 확인하세요", "알림", mbb, mbi);
                
        }
    }
}
