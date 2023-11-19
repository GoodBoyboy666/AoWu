using System;
using System.Linq.Expressions;
using System.Security.Cryptography;
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
            if (source_textbox.Text != string.Empty)
            {
                translated_textbox.Text = "";
                char[] text_hash = Quaternary(Convert.ToInt32(GetHashString(source_textbox.Text).Substring(0, 4), 16)).ToCharArray();//校验位前四位并转化为4进制
                Toeight(ref text_hash);//补齐八位
                string aowu_hash = Toaowu(text_hash);//将hash转换为嗷呜语
                translated_textbox.Text = aowu_hash + Maintranslate(source_textbox.Text);
            }
            else
            {
                MessageBox.Show("请输入需要翻译的内容");
            }
        }
        #region ToAowu主逻辑
        private string Maintranslate(string text)
        {
            string translated_text = "";
            char[] Splited_text = text.ToCharArray();//将内容拆分为单个字
            //string trated_text = "";

            for (int i = 0; i < Splited_text.Length; i++)
            {
                int mid;
                //trated_text += Splited_text[i];//断点测试所用
                mid = (int)Splited_text[i];//转换为Unicode                                           
                string qua = Quaternary(mid);//转换为四进制
                char[] chars = qua.ToCharArray();
                Toeight(ref chars);
                translated_text += Toaowu(chars);
            }
            return translated_text;
        }

        private void Toeight(ref char[] chars)//向前补齐8位
        {
            while (chars.Length < 8)
            {
                Array.Resize(ref chars, chars.Length + 1);
                for (int a = chars.Length - 1; a > 0; a--)
                {
                    chars[a] = chars[a - 1];
                }
                chars[0] = '0';
            }
        }

        private string Toaowu(char[] chars)
        {
            string aowu = "";
            for (int a = 0; a < chars.Length; a++)//开始翻译
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
                        aowu += "嘤";
                        break;
                }
            }
            return aowu;
        }
        private string Quaternary(int str)//十进制转换为四进制
        {
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
        #endregion
        //计算字符串hash
        #region 计算hash
        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create(); 
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
        //https://blog.csdn.net/m0_37981481/article/details/81539554
        #endregion

        private void restore_btn_Click(object sender, EventArgs e)
        {
            if (translated_textbox.Text != string.Empty)
            {
                source_textbox.Text = string.Empty;
                char[] chars = translated_textbox.Text.ToCharArray();
                //获取校验位
                string hashcode="";
                try
                {
                    hashcode = translated_textbox.Text.Substring(0, 8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                string hex_hash = Convert.ToString(AowuTovDecimal(hashcode), 16).ToUpper();
                while (hex_hash.Length < 4)
                {
                    hex_hash = "0" + hex_hash;
                }
                ////////
                string origintext = "";
                for (int i = 8; i < chars.Length; i += 8)//数据位读取
                {
                    try
                    {
                        origintext += restore(translated_textbox.Text.Substring(i, 8));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                source_textbox.Text = origintext;
                //数据位hash生成
                string text_hash = GetHashString(source_textbox.Text).Substring(0, 4);
                if (text_hash != hex_hash)
                {
                    MessageBox.Show("数据校验出错！");
                }
                //Console.ReadKey();
            }
            else
            {
                MessageBox.Show("请输入需要翻译的内容");
            }
        }
        #region ToNormalLanguage主逻辑
        private string restore(string str)
        {
            
            return ((char)AowuTovDecimal(str)).ToString();//翻译为原文并返回
            
        }

        private int AowuTovDecimal(string str)
        {
            string ret = "";//待转换的四进制
            char[] a = str.ToCharArray();//嗷呜翻译为四进制
            for (int i = 0; i < a.Length; i++)
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
                    case '嘤':
                        ret += "3";
                        break;
                }
            }
            //四进制转十进制
            char[] b = ret.ToCharArray();
            int numdecimal = 0;
            for (int i = 0; i < b.Length; i++)
            {
                string mid = b[i].ToString();
                numdecimal += int.Parse(mid) * (int)Math.Pow(4, b.Length - (i + 1));
            }
            return numdecimal;
        }
        #endregion
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