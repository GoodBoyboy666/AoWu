using System;
using System.Linq.Expressions;
using System.Text;
namespace 嗷呜语言翻译器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ct = 0;
        private void translate_btn_Click(object sender, EventArgs e)
        {
            translated_textbox.Text = "";
            char[] Splited_text = source_textbox.Text.ToCharArray();
            string trated_text = "";
            
            for(int i=0; i<Splited_text.Length;i++)
            {
                int mid;
                trated_text += Splited_text[i];//断点测试所用
                mid = (int)Splited_text[i];//转换为ASCII（？）
                //转换为四进制
               string qua= Quaternary(mid);
               char[] chars= qua.ToCharArray();
               while (chars.Length <8)//补齐8位
                {
                    Array.Resize(ref chars, chars.Length + 1);
                    for (int a = chars.Length-1; a > 0; a--)
                    {
                        chars[a] = chars[a - 1];
                    }
                    chars[0]= '0';
                }
                string aowu = "";
               for(int a=0;a<chars.Length;a++)//开始翻译
                {
                    switch (chars[a])
                    {
                        case '0':
                            aowu += "嗷";
                            break;
                        case '1':
                            aowu += "呜";
                            break;
                        case '2':
                            aowu += "~";
                            break;
                        case '3':
                            aowu += " ";
                            break;
                    }
                }
                translated_textbox.Text += aowu;
            }
        }

        private string Quaternary(int str)
        {
            //十进制转四进制
            string num = "";
            while(str> 0)
            {
                num += str % 4;
                str /= 4;
            }
            //字符串倒序
            char[] a=num.ToCharArray();
            num = "";
            for(int i=a.Length; i>0;i--)
            {
                num+= a[i-1];
            }
            return num;
        }

        private void restore_btn_Click(object sender, EventArgs e)
        {
            source_textbox.Text = string.Empty;
            char[] chars=translated_textbox.Text.ToCharArray();
            for(int i=0;i<chars.Length;i+=8)
            {
                source_textbox.Text += restore(translated_textbox.Text.Substring(i,8));
            }
        }

        private string restore(string str)
        {
            string ret = "";//待转换的四进制
            char[] a=str.ToCharArray();//嗷呜翻译为四进制
            for(int i=0;i<a.Length;i++)
            {
                switch (a[i])
                {
                    case '嗷':
                        ret += "0";
                        break;
                    case '呜':
                        ret += "1";
                        break;
                    case '~':
                        ret += "2";
                        break;
                    case ' ':
                        ret += "3";
                        break;
                }
            }
            //四进制转十进制
            char[] b= ret.ToCharArray();
            int numdecimal = 0;
            for(int i = 0; i < b.Length; i++)
            {
                string mid = b[i].ToString();
                numdecimal += int.Parse(mid) * (int)Math.Pow(4, b.Length - (i + 1));
            }
            return ((char)numdecimal).ToString();//翻译为原文并返回
            
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(translated_textbox.Text);
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            translated_textbox.Text= string.Empty;
        }

        private void sor_clean_btn_Click(object sender, EventArgs e)
        {
            source_textbox.Text= string.Empty;
        }

        private void sor_copy_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(source_textbox.Text);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab =new about();
            ab.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ct == 5)
            {
                MessageBox.Show("这么有毅力？看来还是低估你了");
                MessageBox.Show("恭喜你发现小彩蛋");//玩反编译发现的不算，(白眼)
                MessageBox.Show("然鹅我也没准备啥小彩蛋鸭");
                MessageBox.Show("算了给你看看我的主页吧(不准嫌弃)");
                System.Diagnostics.Process.Start("explorer.exe", "https://www.goodboyboy.top");
            }
            else
            {
                MessageBox.Show("我预判了你的预判~");
                ct++;
            }
        }

        private void 介绍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            介绍 js =new 介绍();
            js.ShowDialog();
        }
    }
}