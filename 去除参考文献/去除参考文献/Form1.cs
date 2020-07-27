using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 去除参考文献
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String orgText = this.orgText.Text;
            while (true)
            {
                int len = orgText.Length;

                int start = 0, end = 0;
                int i = 0;
                for (i = 0; i < len; i++)
                {
                    if (orgText.Substring(i,1) == "[")
                        start = i;
                    if (orgText.Substring(i, 1) == "]")
                    {
                        end = i;
                        orgText = orgText.Remove(start-1, end - start + 2);
                        break;
                    }
                }

                len = orgText.Length;
                start = 0;
                end = 0;
                int del = 0;
                int a = 0;
                int j = 0;
                for (j = 0; j < len-4; j++)
                {
                    if (orgText.Substring(j, 1) == "(")
                        start = j;
                    if (start != 0 && int.TryParse(orgText.Substring(j, 4), out a) == true)
                        del = 1;
                    if (orgText.Substring(j, 1) == ")" && del == 1)
                    {
                        end = j;
                        orgText = orgText.Remove(start - 1, end - start + 2);
                        break;
                    }
                }

                if (i == len && j == len-4)
                    break;
            }
            this.targetText.Text = orgText;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
