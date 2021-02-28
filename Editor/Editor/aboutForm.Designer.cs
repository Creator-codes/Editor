using System.ComponentModel;

namespace Editor
{
    partial class aboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.whiteLabel = new System.Windows.Forms.Label();
            this.aboutMoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.icoLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whiteLabel
            // 
            this.whiteLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.whiteLabel.Location = new System.Drawing.Point(40, 100);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(720, 12);
            this.whiteLabel.TabIndex = 0;
            // 
            // aboutMoreLinkLabel
            // 
            this.aboutMoreLinkLabel.Font = new System.Drawing.Font("Consolas", 10F);
            this.aboutMoreLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (136)))), ((int) (((byte) (218)))));
            this.aboutMoreLinkLabel.Location = new System.Drawing.Point(680, 470);
            this.aboutMoreLinkLabel.Name = "aboutMoreLinkLabel";
            this.aboutMoreLinkLabel.Size = new System.Drawing.Size(100, 20);
            this.aboutMoreLinkLabel.TabIndex = 1;
            this.aboutMoreLinkLabel.TabStop = true;
            this.aboutMoreLinkLabel.Text = "了解更多";
            this.aboutMoreLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutMoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutMoreLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(30, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "版本：v1.0.0";
            // 
            // icoLabel
            // 
            this.icoLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.icoLabel.Location = new System.Drawing.Point(120, 10);
            this.icoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.icoLabel.Name = "icoLabel";
            this.icoLabel.Size = new System.Drawing.Size(560, 75);
            this.icoLabel.TabIndex = 4;
            this.icoLabel.Text = "Editor";
            this.icoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 15F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(110, 145);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(145, 261);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Consolas", 15F);
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(255, 145);
            this.listBox2.Margin = new System.Windows.Forms.Padding(0);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(145, 261);
            this.listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("Consolas", 15F);
            this.listBox3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 29;
            this.listBox3.Location = new System.Drawing.Point(400, 145);
            this.listBox3.Margin = new System.Windows.Forms.Padding(0);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(145, 261);
            this.listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Consolas", 15F);
            this.listBox4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 29;
            this.listBox4.Location = new System.Drawing.Point(545, 145);
            this.listBox4.Margin = new System.Windows.Forms.Padding(0);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(145, 261);
            this.listBox4.TabIndex = 9;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (65)))));
            this.closeBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (30)))), ((int) (((byte) (6)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(770, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tipLabel.Location = new System.Drawing.Point(120, 415);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(570, 50);
            this.tipLabel.TabIndex = 11;
            this.tipLabel.Text = "Tip1: 点击workplace可以搜索工作区项目\r\nTip2: 项目区操作由按键触发，当输入之后，同样由对应按键实现功能";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (65)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.icoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutMoreLinkLabel);
            this.Controls.Add(this.whiteLabel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "aboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label tipLabel;

        private System.Windows.Forms.Button closeBtn;

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label icoLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.LinkLabel aboutMoreLinkLabel;

        private System.Windows.Forms.Label whiteLabel;

        #endregion
    }
}