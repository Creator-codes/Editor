using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Editor
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编译CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高亮ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开源SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stateLabel = new System.Windows.Forms.Label();
            this.dirTreeView = new System.Windows.Forms.TreeView();
            this.mkdirBtn = new System.Windows.Forms.Button();
            this.mkfiBtn = new System.Windows.Forms.Button();
            this.mvBtn = new System.Windows.Forms.Button();
            this.rmBtn = new System.Windows.Forms.Button();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lineNumText = new System.Windows.Forms.RichTextBox();
            this.editText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.翻译TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rmWorkplaceBtn = new System.Windows.Forms.Button();
            this.workplaceListBox = new System.Windows.Forms.ListBox();
            this.adjustWidthLabel = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.replacePanel = new System.Windows.Forms.Panel();
            this.cntLabel = new System.Windows.Forms.Label();
            this.replaceAllCheckBox = new System.Windows.Forms.CheckBox();
            this.ClosePanelBtn = new System.Windows.Forms.Button();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceText = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.itemText = new System.Windows.Forms.TextBox();
            this.searchList = new System.Windows.Forms.TextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.replacePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.新建NToolStripMenuItem, this.打开OToolStripMenuItem, this.toolStripSeparator, this.保存SToolStripMenuItem, this.另存为AToolStripMenuItem, this.toolStripSeparator2, this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(240, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) (((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) | System.Windows.Forms.Keys.S)));
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            this.另存为AToolStripMenuItem.Click += new System.EventHandler(this.另存为AToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.撤消UToolStripMenuItem, this.重复RToolStripMenuItem, this.toolStripSeparator3, this.剪切TToolStripMenuItem, this.复制CToolStripMenuItem, this.粘贴PToolStripMenuItem, this.toolStripSeparator4, this.全选AToolStripMenuItem, this.替换RToolStripMenuItem, this.toolStripSeparator1, this.放大ToolStripMenuItem, this.缩小ToolStripMenuItem});
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            this.撤消UToolStripMenuItem.Click += new System.EventHandler(this.撤消UToolStripMenuItem_Click);
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            this.重复RToolStripMenuItem.Click += new System.EventHandler(this.重复RToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            this.剪切TToolStripMenuItem.Click += new System.EventHandler(this.剪切TToolStripMenuItem_Click);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.复制CToolStripMenuItem_Click);
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            this.粘贴PToolStripMenuItem.Click += new System.EventHandler(this.粘贴PToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            this.全选AToolStripMenuItem.Click += new System.EventHandler(this.全选AToolStripMenuItem_Click);
            // 
            // 替换RToolStripMenuItem
            // 
            this.替换RToolStripMenuItem.Name = "替换RToolStripMenuItem";
            this.替换RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.替换RToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.替换RToolStripMenuItem.Text = "替换(&R)";
            this.替换RToolStripMenuItem.Click += new System.EventHandler(this.替换RToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.放大ToolStripMenuItem.Text = "放大(&P)";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.缩小ToolStripMenuItem.Text = "缩小(&D)";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.编译CToolStripMenuItem, this.高亮ToolStripMenuItem});
            this.工具TToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 编译CToolStripMenuItem
            // 
            this.编译CToolStripMenuItem.Enabled = false;
            this.编译CToolStripMenuItem.Name = "编译CToolStripMenuItem";
            this.编译CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.编译CToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.编译CToolStripMenuItem.Text = "编译(&C)";
            this.编译CToolStripMenuItem.Click += new System.EventHandler(this.编译CToolStripMenuItem_Click);
            // 
            // 高亮ToolStripMenuItem
            // 
            this.高亮ToolStripMenuItem.Enabled = false;
            this.高亮ToolStripMenuItem.Name = "高亮ToolStripMenuItem";
            this.高亮ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.高亮ToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.高亮ToolStripMenuItem.Text = "高亮(&H)";
            this.高亮ToolStripMenuItem.Click += new System.EventHandler(this.高亮ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.开源SToolStripMenuItem, this.toolStripSeparator5, this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 开源SToolStripMenuItem
            // 
            this.开源SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.gitHubToolStripMenuItem});
            this.开源SToolStripMenuItem.Name = "开源SToolStripMenuItem";
            this.开源SToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.开源SToolStripMenuItem.Text = "开源(&S)";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.文件FToolStripMenuItem, this.编辑EToolStripMenuItem, this.工具TToolStripMenuItem, this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (171)))), ((int) (((byte) (177)))), ((int) (((byte) (186)))));
            this.stateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.stateLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.stateLabel.Location = new System.Drawing.Point(0, 730);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(1082, 20);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "Lines=1, Characters=0";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dirTreeView
            // 
            this.dirTreeView.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.dirTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dirTreeView.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dirTreeView.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.dirTreeView.Location = new System.Drawing.Point(0, 282);
            this.dirTreeView.Name = "dirTreeView";
            this.dirTreeView.Size = new System.Drawing.Size(200, 446);
            this.dirTreeView.TabIndex = 6;
            this.dirTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirTreeView_AfterSelect);
            // 
            // mkdirBtn
            // 
            this.mkdirBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mkdirBtn.BackgroundImage")));
            this.mkdirBtn.Enabled = false;
            this.mkdirBtn.FlatAppearance.BorderSize = 0;
            this.mkdirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.mkdirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mkdirBtn.Location = new System.Drawing.Point(10, 210);
            this.mkdirBtn.Margin = new System.Windows.Forms.Padding(0);
            this.mkdirBtn.Name = "mkdirBtn";
            this.mkdirBtn.Size = new System.Drawing.Size(40, 40);
            this.mkdirBtn.TabIndex = 7;
            this.mkdirBtn.UseVisualStyleBackColor = true;
            this.mkdirBtn.Click += new System.EventHandler(this.mkdirBtn_Click);
            // 
            // mkfiBtn
            // 
            this.mkfiBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mkfiBtn.BackgroundImage")));
            this.mkfiBtn.Enabled = false;
            this.mkfiBtn.FlatAppearance.BorderSize = 0;
            this.mkfiBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.mkfiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mkfiBtn.Location = new System.Drawing.Point(55, 210);
            this.mkfiBtn.Margin = new System.Windows.Forms.Padding(0);
            this.mkfiBtn.Name = "mkfiBtn";
            this.mkfiBtn.Size = new System.Drawing.Size(40, 40);
            this.mkfiBtn.TabIndex = 8;
            this.mkfiBtn.UseVisualStyleBackColor = true;
            this.mkfiBtn.Click += new System.EventHandler(this.mkfiBtn_Click);
            // 
            // mvBtn
            // 
            this.mvBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("mvBtn.BackgroundImage")));
            this.mvBtn.Enabled = false;
            this.mvBtn.FlatAppearance.BorderSize = 0;
            this.mvBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.mvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvBtn.Location = new System.Drawing.Point(100, 210);
            this.mvBtn.Margin = new System.Windows.Forms.Padding(0);
            this.mvBtn.Name = "mvBtn";
            this.mvBtn.Size = new System.Drawing.Size(40, 40);
            this.mvBtn.TabIndex = 9;
            this.mvBtn.UseVisualStyleBackColor = true;
            this.mvBtn.Click += new System.EventHandler(this.mvBtn_Click);
            // 
            // rmBtn
            // 
            this.rmBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("rmBtn.BackgroundImage")));
            this.rmBtn.Enabled = false;
            this.rmBtn.FlatAppearance.BorderSize = 0;
            this.rmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.rmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmBtn.Location = new System.Drawing.Point(145, 210);
            this.rmBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rmBtn.Name = "rmBtn";
            this.rmBtn.Size = new System.Drawing.Size(40, 40);
            this.rmBtn.TabIndex = 10;
            this.rmBtn.UseVisualStyleBackColor = true;
            this.rmBtn.Click += new System.EventHandler(this.rmBtn_Click);
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.workplaceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workplaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.workplaceLabel.Location = new System.Drawing.Point(0, 28);
            this.workplaceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(200, 30);
            this.workplaceLabel.TabIndex = 11;
            this.workplaceLabel.Text = "Workplace";
            this.workplaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workplaceLabel.Click += new System.EventHandler(this.workplaceLabel_Click);
            // 
            // itemLabel
            // 
            this.itemLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.itemLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.itemLabel.Location = new System.Drawing.Point(0, 252);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(200, 30);
            this.itemLabel.TabIndex = 12;
            this.itemLabel.Text = "Item:";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (144)))), ((int) (((byte) (226)))));
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.titleLabel.Location = new System.Drawing.Point(200, 28);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(882, 30);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "untitled";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineNumText
            // 
            this.lineNumText.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (52)))), ((int) (((byte) (64)))));
            this.lineNumText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lineNumText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (144)))), ((int) (((byte) (226)))));
            this.lineNumText.Location = new System.Drawing.Point(205, 58);
            this.lineNumText.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumText.Name = "lineNumText";
            this.lineNumText.ReadOnly = true;
            this.lineNumText.Size = new System.Drawing.Size(822, 669);
            this.lineNumText.TabIndex = 23;
            this.lineNumText.Text = "1";
            // 
            // editText
            // 
            this.editText.AcceptsTab = true;
            this.editText.AutoWordSelection = true;
            this.editText.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (52)))), ((int) (((byte) (64)))));
            this.editText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editText.ContextMenuStrip = this.contextMenuStrip1;
            this.editText.DetectUrls = false;
            this.editText.EnableAutoDragDrop = true;
            this.editText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.editText.Location = new System.Drawing.Point(260, 58);
            this.editText.Margin = new System.Windows.Forms.Padding(0);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(822, 669);
            this.editText.TabIndex = 15;
            this.editText.Text = "";
            this.editText.WordWrap = false;
            this.editText.VScroll += new System.EventHandler(this.editText_VScroll);
            this.editText.TextChanged += new System.EventHandler(this.editText_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.翻译TToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 28);
            // 
            // 翻译TToolStripMenuItem
            // 
            this.翻译TToolStripMenuItem.Name = "翻译TToolStripMenuItem";
            this.翻译TToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.翻译TToolStripMenuItem.Text = "翻译(&T)";
            this.翻译TToolStripMenuItem.Click += new System.EventHandler(this.翻译TToolStripMenuItem_Click);
            // 
            // rmWorkplaceBtn
            // 
            this.rmWorkplaceBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.rmWorkplaceBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("rmWorkplaceBtn.BackgroundImage")));
            this.rmWorkplaceBtn.FlatAppearance.BorderSize = 0;
            this.rmWorkplaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmWorkplaceBtn.Location = new System.Drawing.Point(170, 28);
            this.rmWorkplaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rmWorkplaceBtn.Name = "rmWorkplaceBtn";
            this.rmWorkplaceBtn.Size = new System.Drawing.Size(30, 29);
            this.rmWorkplaceBtn.TabIndex = 16;
            this.rmWorkplaceBtn.UseVisualStyleBackColor = false;
            this.rmWorkplaceBtn.Click += new System.EventHandler(this.rmWorkplaceBtn_Click);
            // 
            // workplaceListBox
            // 
            this.workplaceListBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.workplaceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workplaceListBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.workplaceListBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.workplaceListBox.FormattingEnabled = true;
            this.workplaceListBox.ItemHeight = 23;
            this.workplaceListBox.Location = new System.Drawing.Point(0, 58);
            this.workplaceListBox.Margin = new System.Windows.Forms.Padding(0);
            this.workplaceListBox.Name = "workplaceListBox";
            this.workplaceListBox.Size = new System.Drawing.Size(200, 138);
            this.workplaceListBox.TabIndex = 17;
            this.workplaceListBox.SelectedIndexChanged += new System.EventHandler(this.workplaceListBox_SelectedIndexChanged);
            this.workplaceListBox.DoubleClick += new System.EventHandler(this.workplaceListBox_DoubleClick);
            // 
            // adjustWidthLabel
            // 
            this.adjustWidthLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (52)))), ((int) (((byte) (64)))));
            this.adjustWidthLabel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.adjustWidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adjustWidthLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.adjustWidthLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.adjustWidthLabel.Location = new System.Drawing.Point(200, 58);
            this.adjustWidthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.adjustWidthLabel.Name = "adjustWidthLabel";
            this.adjustWidthLabel.Size = new System.Drawing.Size(5, 673);
            this.adjustWidthLabel.TabIndex = 18;
            this.adjustWidthLabel.Text = "1";
            this.adjustWidthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.adjustWidthLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adjustWidthLabel_MouseDown);
            this.adjustWidthLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adjustWidthLabel_MouseUp);
            // 
            // dirLabel
            // 
            this.dirLabel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (171)))), ((int) (((byte) (177)))), ((int) (((byte) (186)))));
            this.dirLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirLabel.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dirLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.dirLabel.Location = new System.Drawing.Point(0, 730);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(430, 20);
            this.dirLabel.TabIndex = 19;
            this.dirLabel.Text = "Dir:";
            this.dirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replacePanel
            // 
            this.replacePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replacePanel.Controls.Add(this.cntLabel);
            this.replacePanel.Controls.Add(this.replaceAllCheckBox);
            this.replacePanel.Controls.Add(this.ClosePanelBtn);
            this.replacePanel.Controls.Add(this.replaceBtn);
            this.replacePanel.Controls.Add(this.findNextBtn);
            this.replacePanel.Controls.Add(this.label2);
            this.replacePanel.Controls.Add(this.label1);
            this.replacePanel.Controls.Add(this.replaceText);
            this.replacePanel.Controls.Add(this.searchText);
            this.replacePanel.Location = new System.Drawing.Point(866, 58);
            this.replacePanel.Name = "replacePanel";
            this.replacePanel.Size = new System.Drawing.Size(216, 150);
            this.replacePanel.TabIndex = 20;
            this.replacePanel.Visible = false;
            // 
            // cntLabel
            // 
            this.cntLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cntLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.cntLabel.Location = new System.Drawing.Point(0, 120);
            this.cntLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cntLabel.Name = "cntLabel";
            this.cntLabel.Size = new System.Drawing.Size(172, 30);
            this.cntLabel.TabIndex = 9;
            this.cntLabel.Text = "Count: 0";
            this.cntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replaceAllCheckBox
            // 
            this.replaceAllCheckBox.FlatAppearance.BorderSize = 0;
            this.replaceAllCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceAllCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.replaceAllCheckBox.Location = new System.Drawing.Point(106, 60);
            this.replaceAllCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.replaceAllCheckBox.Name = "replaceAllCheckBox";
            this.replaceAllCheckBox.Size = new System.Drawing.Size(66, 30);
            this.replaceAllCheckBox.TabIndex = 8;
            this.replaceAllCheckBox.Text = "All";
            this.replaceAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClosePanelBtn
            // 
            this.ClosePanelBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("ClosePanelBtn.BackgroundImage")));
            this.ClosePanelBtn.FlatAppearance.BorderSize = 0;
            this.ClosePanelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.ClosePanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosePanelBtn.Location = new System.Drawing.Point(176, 120);
            this.ClosePanelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ClosePanelBtn.Name = "ClosePanelBtn";
            this.ClosePanelBtn.Size = new System.Drawing.Size(30, 30);
            this.ClosePanelBtn.TabIndex = 7;
            this.ClosePanelBtn.UseVisualStyleBackColor = true;
            this.ClosePanelBtn.Click += new System.EventHandler(this.ClosePanelBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("replaceBtn.BackgroundImage")));
            this.replaceBtn.FlatAppearance.BorderSize = 0;
            this.replaceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.replaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceBtn.Location = new System.Drawing.Point(176, 60);
            this.replaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(30, 30);
            this.replaceBtn.TabIndex = 5;
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // findNextBtn
            // 
            this.findNextBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("findNextBtn.BackgroundImage")));
            this.findNextBtn.FlatAppearance.BorderSize = 0;
            this.findNextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.findNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findNextBtn.Location = new System.Drawing.Point(176, 0);
            this.findNextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(30, 30);
            this.findNextBtn.TabIndex = 4;
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.findNextBtn_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (237)))), ((int) (((byte) (235)))), ((int) (((byte) (233)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replaceText
            // 
            this.replaceText.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.replaceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.replaceText.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.replaceText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (235)))), ((int) (((byte) (237)))), ((int) (((byte) (239)))));
            this.replaceText.Location = new System.Drawing.Point(0, 90);
            this.replaceText.Margin = new System.Windows.Forms.Padding(0);
            this.replaceText.Name = "replaceText";
            this.replaceText.Size = new System.Drawing.Size(215, 30);
            this.replaceText.TabIndex = 1;
            this.replaceText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectAll_KeyUp);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (203)))), ((int) (((byte) (123)))));
            this.searchText.Location = new System.Drawing.Point(0, 30);
            this.searchText.Margin = new System.Windows.Forms.Padding(0);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(215, 30);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectAll_KeyUp);
            // 
            // itemText
            // 
            this.itemText.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.itemText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemText.Font = new System.Drawing.Font("Consolas", 19F);
            this.itemText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (232)))), ((int) (((byte) (207)))));
            this.itemText.Location = new System.Drawing.Point(0, 252);
            this.itemText.Margin = new System.Windows.Forms.Padding(0);
            this.itemText.Name = "itemText";
            this.itemText.Size = new System.Drawing.Size(200, 38);
            this.itemText.TabIndex = 0;
            this.itemText.Visible = false;
            this.itemText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectAll_KeyUp);
            this.itemText.Leave += new System.EventHandler(this.TextBox_Unvisible);
            // 
            // searchList
            // 
            this.searchList.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.searchList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchList.Font = new System.Drawing.Font("Consolas", 19F);
            this.searchList.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (204)))), ((int) (((byte) (232)))), ((int) (((byte) (207)))));
            this.searchList.Location = new System.Drawing.Point(0, 28);
            this.searchList.Margin = new System.Windows.Forms.Padding(0);
            this.searchList.Name = "searchList";
            this.searchList.Size = new System.Drawing.Size(200, 38);
            this.searchList.TabIndex = 22;
            this.searchList.Visible = false;
            this.searchList.TextChanged += new System.EventHandler(this.searchList_TextChanged);
            this.searchList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.selectAll_KeyUp);
            this.searchList.Leave += new System.EventHandler(this.TextBox_Unvisible);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (77)))), ((int) (((byte) (81)))));
            this.outputRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputRichTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.outputRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (203)))), ((int) (((byte) (123)))));
            this.outputRichTextBox.Location = new System.Drawing.Point(205, 466);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(877, 265);
            this.outputRichTextBox.TabIndex = 24;
            this.outputRichTextBox.Text = "";
            this.outputRichTextBox.Visible = false;
            this.outputRichTextBox.Leave += new System.EventHandler(this.outputRichTextBox_Leave);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (76)))), ((int) (((byte) (86)))), ((int) (((byte) (106)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(2, 282);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(16, 16);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Visible = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (56)))), ((int) (((byte) (56)))), ((int) (((byte) (56)))));
            this.ClientSize = new System.Drawing.Size(1082, 750);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.searchList);
            this.Controls.Add(this.rmWorkplaceBtn);
            this.Controls.Add(this.itemText);
            this.Controls.Add(this.replacePanel);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.adjustWidthLabel);
            this.Controls.Add(this.workplaceListBox);
            this.Controls.Add(this.workplaceLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.editText);
            this.Controls.Add(this.lineNumText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.dirTreeView);
            this.Controls.Add(this.rmBtn);
            this.Controls.Add(this.mvBtn);
            this.Controls.Add(this.mkfiBtn);
            this.Controls.Add(this.mkdirBtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.replacePanel.ResumeLayout(false);
            this.replacePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 翻译TToolStripMenuItem;

        private System.Windows.Forms.Button refreshBtn;

        private System.Windows.Forms.RichTextBox outputRichTextBox;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;

        private System.Windows.Forms.RichTextBox lineNumText;

        private System.Windows.Forms.ToolStripMenuItem 高亮ToolStripMenuItem;

        private System.Windows.Forms.TextBox searchList;

        private System.Windows.Forms.TextBox itemText;

        private System.Windows.Forms.Label cntLabel;

        private System.Windows.Forms.CheckBox replaceAllCheckBox;

        private System.Windows.Forms.Button ClosePanelBtn;

        private System.Windows.Forms.Button replaceBtn;

        private System.Windows.Forms.Button findNextBtn;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox replaceText;

        private System.Windows.Forms.TextBox searchText;

        private System.Windows.Forms.Panel replacePanel;

        private System.Windows.Forms.ToolStripMenuItem 替换RToolStripMenuItem;

        private System.Windows.Forms.Label dirLabel;

        private System.Windows.Forms.Label adjustWidthLabel;

        private System.Windows.Forms.ListBox workplaceListBox;

        private System.Windows.Forms.Button rmWorkplaceBtn;

        private System.Windows.Forms.RichTextBox editText;

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.Label itemLabel;

        private System.Windows.Forms.Button mkfiBtn;
        private System.Windows.Forms.Button mvBtn;
        private System.Windows.Forms.Button rmBtn;

        private System.Windows.Forms.Button mkdirBtn;

        private System.Windows.Forms.TreeView dirTreeView;

        private System.Windows.Forms.Label stateLabel;

        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开源SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编译CToolStripMenuItem;

        #endregion
    }
}