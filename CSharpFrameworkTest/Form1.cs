using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFrameworkTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
         * 日期修改后的变化 系统核心代码
         */
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            int month = monthCalendar1.SelectionStart.Month;
            int day = monthCalendar1.SelectionStart.Day;
            judgeConstellation(month, day);
        }

        private void judgeConstellation(int month, int day)
        {
            String[] starArr = {"魔羯座","水瓶座", "双鱼座", "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座" };
            int[] dayArr = { 22, 20, 19, 21, 21, 21, 22, 23, 23, 23, 23, 22 };
            int number = (month + 10) % 12;
            int index = month;
            if (day < dayArr[index-1])
            {
                number = (number + 11) % 12;
                index = index - 1;
            }
            if (number == 0)
            {
                number = 12;
            }
            label1.Text = starArr[index];
            pictureBox2.ImageLocation = "D:\\VisualBasic\\CSharpFrameworkTest\\CSharpFrameworkTest\\images\\" + number + ".png";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // do nothing
        }
    }
}
