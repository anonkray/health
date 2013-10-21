using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = ("ผลลัพธ์" + Environment.NewLine);
    //เพศ
            if (radioButton1.Checked == true)
            {
                ans = ans + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                ans = ans + "เพศ : หญิง" + Environment.NewLine;
            }
    //อายุ
            if (radioButton3.Checked == true)
            {
                ans = ans + "อายุ : 10-20 ปี" + Environment.NewLine;
            }
            else if (radioButton4.Checked == true)
            {
                ans = ans + "อายุ : 20-30 ปี" + Environment.NewLine;
            }
            else 
            {
                ans = ans + "อายุ : มากกว่า 30 ปี" + Environment.NewLine;
            }
    //สมรส
            if (radioButton6.Checked == true)
            {
                ans = ans + "สถานภาพสมรส : โสด" + Environment.NewLine;
            }
            else if (radioButton7.Checked == true)
            {
                ans = ans + "สถานภาพสมรส : สมรส" + Environment.NewLine;
            }
            else if (radioButton8.Checked == true)
            {
                ans = ans + "สถานภาพสมรส : แยกกันอยู่" + Environment.NewLine;
            }
            else
            {
                ans = ans + "สถานภาพสมรส : หม้าย/อย่า" + Environment.NewLine;
            }
    //ระดับการศึกษา
            ans = ans + "ระดับการศึกษา : ";
            if (radioButton10.Checked == true)
            {
                ans = ans + "ต่ำกว่าปริญญาตรี" + Environment.NewLine;
            }
            else if (radioButton11.Checked == true)
            {
                ans = ans + "ปริญญาตรี" + Environment.NewLine;
            }
            else
            {
                ans = ans + "สูงกว่าปริญญาตรี" + Environment.NewLine;
            }
    //ออกกำลังกาย
            ans = ans + "ปัจจุบันท่านออกกำลังกายด้วยวิธี : ";
            if (radioButton13.Checked == true)
            {
                ans = ans + "เดิน" + Environment.NewLine;
            }
            else if (radioButton14.Checked == true)
            {
                ans = ans + "วิ่งเหยาะๆ" + Environment.NewLine;
            }
            else if (radioButton15.Checked == true)
            {
                ans = ans + "เต้นแอโรบิค" + Environment.NewLine;
            }
            else
            {
                ans = ans + "ปั่นจักรยาน" + Environment.NewLine;
            }

             MessageBox.Show(ans,"รายการที่เลือก");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
