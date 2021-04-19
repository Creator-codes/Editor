namespace DrawingBoard
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.brushBtn = new System.Windows.Forms.ToolStripButton();
            this.eraserBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.lineBtn = new System.Windows.Forms.ToolStripButton();
            this.rectBtn = new System.Windows.Forms.ToolStripButton();
            this.triBtn = new System.Windows.Forms.ToolStripButton();
            this.ellipseBtn = new System.Windows.Forms.ToolStripButton();
            this.pointToBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorBtn = new System.Windows.Forms.ToolStripButton();
            this.sizeAdjustBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.penSize_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.penSize_6 = new System.Windows.Forms.ToolStripMenuItem();
            this.penSize_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteboardBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.textBox = new System.Windows.Forms.ToolStripTextBox();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.新建NToolStripMenuItem, this.打开OToolStripMenuItem, this.保存ToolStripMenuItem, this.另存为AToolStripMenuItem, this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (165)))), ((int) (((byte) (165)))), ((int) (((byte) (170)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.brushBtn, this.eraserBtn, this.toolStripButton3, this.lineBtn, this.rectBtn, this.triBtn, this.ellipseBtn, this.pointToBtn, this.toolStripButton1, this.colorBtn, this.sizeAdjustBtn, this.whiteboardBtn, this.toolStripLabel1, this.toolStripButton2, this.textBtn, this.clearBtn, this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(1143, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(39, 575);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // brushBtn
            // 
            this.brushBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (120)))), ((int) (((byte) (165)))), ((int) (((byte) (170)))));
            this.brushBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brushBtn.Image = ((System.Drawing.Image) (resources.GetObject("brushBtn.Image")));
            this.brushBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushBtn.Name = "brushBtn";
            this.brushBtn.Size = new System.Drawing.Size(38, 20);
            this.brushBtn.Text = "toolStripButton1";
            this.brushBtn.Click += new System.EventHandler(this.brushBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraserBtn.Image = ((System.Drawing.Image) (resources.GetObject("eraserBtn.Image")));
            this.eraserBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(38, 20);
            this.eraserBtn.Text = "toolStripButton1";
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(38, 6);
            // 
            // lineBtn
            // 
            this.lineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineBtn.Image = ((System.Drawing.Image) (resources.GetObject("lineBtn.Image")));
            this.lineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(38, 20);
            this.lineBtn.Text = "toolStripButton1";
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectBtn.Image = ((System.Drawing.Image) (resources.GetObject("rectBtn.Image")));
            this.rectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(38, 20);
            this.rectBtn.Text = "toolStripButton1";
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // triBtn
            // 
            this.triBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triBtn.Image = ((System.Drawing.Image) (resources.GetObject("triBtn.Image")));
            this.triBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triBtn.Name = "triBtn";
            this.triBtn.Size = new System.Drawing.Size(38, 20);
            this.triBtn.Text = "toolStripButton4";
            this.triBtn.Click += new System.EventHandler(this.triBtn_Click);
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseBtn.Image = ((System.Drawing.Image) (resources.GetObject("ellipseBtn.Image")));
            this.ellipseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(38, 20);
            this.ellipseBtn.Text = "toolStripButton2";
            this.ellipseBtn.Click += new System.EventHandler(this.ellipseBtn_Click);
            // 
            // pointToBtn
            // 
            this.pointToBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pointToBtn.Image = ((System.Drawing.Image) (resources.GetObject("pointToBtn.Image")));
            this.pointToBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pointToBtn.Name = "pointToBtn";
            this.pointToBtn.Size = new System.Drawing.Size(38, 20);
            this.pointToBtn.Text = "toolStripButton5";
            this.pointToBtn.Click += new System.EventHandler(this.pointToBtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 6);
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.White;
            this.colorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorBtn.Image = ((System.Drawing.Image) (resources.GetObject("colorBtn.Image")));
            this.colorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(38, 20);
            this.colorBtn.Text = "toolStripButton2";
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // sizeAdjustBtn
            // 
            this.sizeAdjustBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sizeAdjustBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.penSize_2, this.penSize_6, this.penSize_10});
            this.sizeAdjustBtn.Image = ((System.Drawing.Image) (resources.GetObject("sizeAdjustBtn.Image")));
            this.sizeAdjustBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sizeAdjustBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sizeAdjustBtn.Name = "sizeAdjustBtn";
            this.sizeAdjustBtn.Size = new System.Drawing.Size(38, 20);
            this.sizeAdjustBtn.Text = "Size";
            this.sizeAdjustBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.sizeAdjustBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // penSize_2
            // 
            this.penSize_2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (120)))), ((int) (((byte) (165)))), ((int) (((byte) (170)))));
            this.penSize_2.Name = "penSize_2";
            this.penSize_2.Size = new System.Drawing.Size(96, 24);
            this.penSize_2.Text = "2";
            this.penSize_2.Click += new System.EventHandler(this.sizeMenuItem_Click);
            // 
            // penSize_6
            // 
            this.penSize_6.Name = "penSize_6";
            this.penSize_6.Size = new System.Drawing.Size(96, 24);
            this.penSize_6.Text = "6";
            this.penSize_6.Click += new System.EventHandler(this.sizeMenuItem_Click);
            // 
            // penSize_10
            // 
            this.penSize_10.Name = "penSize_10";
            this.penSize_10.Size = new System.Drawing.Size(96, 24);
            this.penSize_10.Text = "10";
            this.penSize_10.Click += new System.EventHandler(this.sizeMenuItem_Click);
            // 
            // whiteboardBtn
            // 
            this.whiteboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.whiteboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.whiteboardBtn.Image = ((System.Drawing.Image) (resources.GetObject("whiteboardBtn.Image")));
            this.whiteboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.whiteboardBtn.Name = "whiteboardBtn";
            this.whiteboardBtn.Size = new System.Drawing.Size(38, 20);
            this.whiteboardBtn.Text = "toolStripButton2";
            this.whiteboardBtn.Click += new System.EventHandler(this.whiteboardBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(38, 20);
            this.toolStripLabel1.Text = "白板";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(38, 6);
            // 
            // textBtn
            // 
            this.textBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.textBox});
            this.textBtn.Image = ((System.Drawing.Image) (resources.GetObject("textBtn.Image")));
            this.textBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(38, 20);
            this.textBtn.Text = "toolStripButton4";
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 27);
            // 
            // clearBtn
            // 
            this.clearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image) (resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(38, 20);
            this.clearBtn.Text = "toolStripButton4";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(38, 20);
            this.toolStripButton4.Text = "清空";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (62)))), ((int) (((byte) (89)))), ((int) (((byte) (62)))));
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 28);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1143, 575);
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "画板";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;

        private System.Windows.Forms.ToolStripTextBox textBox;
        private System.Windows.Forms.ToolStripSplitButton textBtn;

        private System.Windows.Forms.ToolStripButton pointToBtn;

        private System.Windows.Forms.ToolStripMenuItem penSize_2;
        private System.Windows.Forms.ToolStripMenuItem penSize_6;
        private System.Windows.Forms.ToolStripMenuItem penSize_10;

        private System.Windows.Forms.ToolStripLabel toolStripButton4;

        private System.Windows.Forms.ToolStripButton clearBtn;

        private System.Windows.Forms.ToolStripSeparator toolStripButton2;

        private System.Windows.Forms.ToolStripSplitButton sizeAdjustBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStripButton whiteboardBtn;
        
        private System.Windows.Forms.PictureBox picBox;

        private System.Windows.Forms.ToolStripButton colorBtn;

        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripButton triBtn;

        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripButton ellipseBtn;

        private System.Windows.Forms.ToolStripButton rectBtn;

        private System.Windows.Forms.ToolStripButton lineBtn;

        private System.Windows.Forms.ToolStripButton eraserBtn;

        private System.Windows.Forms.ToolStripButton brushBtn;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}