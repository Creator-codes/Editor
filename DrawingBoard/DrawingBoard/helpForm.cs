using System;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class helpForm : Form
    {
        public helpForm()
        {
            InitializeComponent();
        }

        /*
         * 关闭
         */
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Creator-codes/Editor/blob/d_v1.0.0/README.md");
        }

        private void aboutMoreLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://link2points.blog.csdn.net/article/details/115840463");
        }
    }
}