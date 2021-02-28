using System;
using System.Windows.Forms;

namespace Editor
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
            // 快捷键功能列表
            String[] shortcuts = {
                "Ctrl+N", "Ctrl+O", "Ctrl+S", "Ctrl+Shift+S",
                "Ctrl+Z", "Ctrl+Y", "Ctrl+X", "Ctrl+C", "Ctrl+V", "Ctrl+A", "Ctrl+R", "Ctrl+P", "Ctrl+M",
                "Ctrl+B", "Ctrl+H"
            };
            String[] function =
            {
                "新建", "打开", "保存", "另存为",
                "撤销", "重复", "剪切", "复制", "黏贴", "全选", "替换", "放大", "缩小",
                "编译", "高亮"
            };
            listBox1.Items.Add("快捷键");
            listBox2.Items.Add("功能");
            listBox3.Items.Add("快捷键");
            listBox4.Items.Add("功能");
            for (int i = 0; i < shortcuts.Length; i++)
            {
                if (i > shortcuts.Length / 2)
                {
                    listBox3.Items.Add(shortcuts[i]);
                    listBox4.Items.Add(function[i]);
                }
                else
                {
                    listBox1.Items.Add(shortcuts[i]);
                    listBox2.Items.Add(function[i]);
                }
            }
        }
        /*
         * 打开浏览器 跳转至介绍页面
         */
        private void aboutMoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://link2points.blog.csdn.net/");
        }
        /*
         * 关闭
         */
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}