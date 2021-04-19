using System.ComponentModel;

namespace DrawingBoard
{
    partial class helpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.aboutMoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (30)))), ((int) (((byte) (6)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image) (resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(771, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.label1.Location = new System.Drawing.Point(-2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drawing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whiteLabel
            // 
            this.whiteLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.whiteLabel.Location = new System.Drawing.Point(40, 100);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(720, 12);
            this.whiteLabel.TabIndex = 2;
            // 
            // tipLabel
            // 
            this.tipLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tipLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.tipLabel.Location = new System.Drawing.Point(133, 139);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(570, 235);
            this.tipLabel.TabIndex = 12;
            this.tipLabel.Text = "Tip1: 快捷键\r\n   Ctrl+N              新建\r\n   Ctrl+O              打开\r\n   Ctrl+S       " + "       保存\r\n   Ctrl+Shift+S        另存为\r\n   Ctrl+H              帮助\r\n\r\nTip2: 白板模式下，" + "程序将置顶且半透明\r\n\r\nTip3: 文本编辑输入后，在区域内点击嵌入";
            // 
            // aboutMoreLinkLabel
            // 
            this.aboutMoreLinkLabel.Font = new System.Drawing.Font("Consolas", 10F);
            this.aboutMoreLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (136)))), ((int) (((byte) (218)))));
            this.aboutMoreLinkLabel.Location = new System.Drawing.Point(701, 421);
            this.aboutMoreLinkLabel.Name = "aboutMoreLinkLabel";
            this.aboutMoreLinkLabel.Size = new System.Drawing.Size(100, 20);
            this.aboutMoreLinkLabel.TabIndex = 13;
            this.aboutMoreLinkLabel.TabStop = true;
            this.aboutMoreLinkLabel.Text = "了解更多";
            this.aboutMoreLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aboutMoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutMoreLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int) (((byte) (30)))), ((int) (((byte) (136)))), ((int) (((byte) (218)))));
            this.linkLabel1.Location = new System.Drawing.Point(603, 421);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "开源地址";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.label2.Location = new System.Drawing.Point(40, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "版本：v1.0.0";
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.aboutMoreLinkLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.whiteLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "helpForm";
            this.Text = "helpForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.LinkLabel aboutMoreLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label tipLabel;

        private System.Windows.Forms.Label whiteLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button closeBtn;

        #endregion
    }
}