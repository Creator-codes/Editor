using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Editor
{
    public partial class Main : Form
    {
        /* 记录工作区列表的文件路径 及 文件名 */
        private ConcurrentDictionary<String, String> workplaceList = new ConcurrentDictionary<String, String>();
        /* 记录当前项目根路径 */
        private String rootPath;
        /* 记录调整第一次拖拽X值 */
        private int oldX;
        /* 记录查找到的当前位置 */
        private int curPostion = -1;
        /* 初始字体大小 */
        private float fontSize = 12;
        
        public Main()
        {
            InitializeComponent();
        }

        /*
         * 窗口拉伸
         */
        private void Main_Load(object sender, EventArgs e)
        {
            Resize += new EventHandler(MainForm_Resize);
        }
        /*
         * 调整控件高宽比例
         */
        private void MainForm_Resize(object sender, EventArgs e)
        {
            int width = ClientSize.Width;
            int height = ClientSize.Height;
            int stateLabelHeight = stateLabel.Height;
            titleLabel.Size = new Size(width - titleLabel.Location.X, titleLabel.Height);
            editText.Size = new Size(width - editText.Location.X, height - editText.Location.Y - stateLabelHeight);
            dirTreeView.Size = new Size(dirTreeView.Width, height - dirTreeView.Location.Y - stateLabelHeight);
            stateLabel.Location = new Point(0, height - stateLabelHeight);
            stateLabel.Size = new Size(width, stateLabelHeight);
            dirLabel.Location = new Point(0, stateLabel.Location.Y);
            adjustWidthLabel.Size = new Size(adjustWidthLabel.Width, editText.Height);
            replacePanel.Location = new Point(width - replacePanel.Width, replacePanel.Location.Y);
            lineNumText.Size = new Size(width - lineNumText.Location.X, editText.Height);
            outputRichTextBox.Size = new Size(width - outputRichTextBox.Location.X, height - outputRichTextBox.Location.Y - stateLabelHeight);
        }
        /*
         * 拖拽实现 调整编辑区 和 工作区 宽度
         */
        private void adjustWidthLabel_MouseDown(object sender, MouseEventArgs  e)
        {
            oldX = e.Location.X;
            adjustWidthLabel.BackColor = Color.FromArgb(76, 86, 106);
        }
        private void adjustWidthLabel_MouseUp(object sender, MouseEventArgs  e)
        {
            int adjustWidth = e.Location.X - oldX;
            int leftWidth = workplaceLabel.Width + adjustWidth;
            // left workplace
            adjustWidthLabel.Location = new Point(adjustWidthLabel.Location.X + adjustWidth, adjustWidthLabel.Location.Y);
            workplaceLabel.Size = new Size(leftWidth, workplaceLabel.Height);
            itemLabel.Size = new Size(leftWidth, itemLabel.Height);
            workplaceListBox.Size = new Size(leftWidth, mkdirBtn.Location.Y - mkdirBtn.Height);     // 使之listbox高度相对固定，而不会遮挡按键或过渡缩小
            searchList.Size = new Size(leftWidth, searchList.Height);
            itemText.Size = new Size(leftWidth, itemText.Height);
            dirTreeView.Size = new Size(leftWidth, dirTreeView.Height);
            rmWorkplaceBtn.Location = new Point(adjustWidthLabel.Location.X - rmWorkplaceBtn.Width, titleLabel.Location.Y);

            // right editor place
            titleLabel.Location = new Point(adjustWidthLabel.Location.X, titleLabel.Location.Y);
            titleLabel.Size = new Size(titleLabel.Width - adjustWidth, titleLabel.Height);
            lineNumText.Location = new Point(lineNumText.Location.X + adjustWidth, lineNumText.Location.Y);
            lineNumText.Size = new Size(lineNumText.Width - adjustWidth, lineNumText.Height);
            editText.Location = new Point(editText.Location.X + adjustWidth, editText.Location.Y);
            editText.Size = new Size(editText.Width - adjustWidth, editText.Height);
            outputRichTextBox.Location =
                new Point(outputRichTextBox.Location.X + adjustWidth, outputRichTextBox.Location.Y);
            outputRichTextBox.Size = new Size(outputRichTextBox.Width - adjustWidth, outputRichTextBox.Height);
            adjustWidthLabel.BackColor = Color.FromArgb(46, 52, 64);
        }
        /*
         * 同步编辑区 行号区 滚动
         */
        private void synScrollbar()
        {
            Point point = editText.Location;
            int index = editText.GetCharIndexFromPosition(point); 
            int line = editText.GetLineFromCharIndex(index) - 3;
            try
            {
                lineNumText.SelectionStart = lineNumText.GetFirstCharIndexFromLine(line);
                lineNumText.SelectionLength = 0;
                lineNumText.ScrollToCaret();
            }
            catch (Exception exception) {}
        }
        private void editText_VScroll(object sender, EventArgs e)
        {
            synScrollbar();
        }
        /*
         * 统计行数和字符数 及 文本保存判断   同步行号区
         *      count the number of characters except RETURN
         *      as count the Lines equal to the number of RETURN
         */
        private void editText_TextChanged(object sender, EventArgs e)
        {
            long editTextLength = editText.Text.Length;
            long linesCnt = editText.Text.Split('\n').Length;
            long charsCnt = editTextLength - linesCnt + 1;
            stateLabel.Text = String.Format("Lines={0}, Characters={1}", linesCnt, charsCnt);
            string linesCntText = "";
            for (int i = 2; i <= linesCnt; i++)
            {
                linesCntText += "\n" + i;
            }
            lineNumText.Text = "1" + linesCntText;

            String unsaved = "-unsaved";
            String title = titleLabel.Text;
            if (!title.Contains(unsaved))
            {
                titleLabel.Text += unsaved;
            }
            
            synScrollbar();
        }
        /*
         * 清理标题栏、文本区、状态栏地址  同时关闭编译 和 高亮 功能
         */
        private void clearEditor()
        {
            titleLabel.Text = "untitled";
            dirLabel.Text = "Dir:";
            editText.Text = "";
            编译CToolStripMenuItem.Enabled = false;
            高亮ToolStripMenuItem.Enabled = false;
        }
        /*
         * 重置项目列表
         */
        private void resetDirTreeView(String rootPath)
        {
            dirTreeView.Nodes.Clear();
            //根节点
            TreeNode rootNode = new TreeNode();
            rootNode.Text = rootPath;
            //递归创建节点
            createNodes(rootPath, rootNode);
            //TreeView
            dirTreeView.Nodes.Add(rootNode);
            dirTreeView.ExpandAll();
        }
        /*
         * 递归创建目录（文档）结点树  
         */
        private void createNodes(String rootFile, TreeNode rootNode)
        {
            DirectoryInfo dInfo = new DirectoryInfo(rootFile);
            //遍历当前文件系统下的所有文件和文件夹
            foreach (FileSystemInfo info in dInfo.GetFileSystemInfos())
            {
                TreeNode node = new TreeNode();
                node.Text = info.Name;
                rootNode.Nodes.Add(node);
                //文件夹
                String file = info.FullName;
                if(Directory.Exists(file))
                {
                    createNodes(file, node);
                }
            }
        }
        /*
         * 添加至工作区
         */
        private void addToWorkplace(String path, String tit)
        {
            // 加入工作区列表（以文件路径为键值），用于多文本协作及保存文件
            workplaceListBox.Items.Clear();
            workplaceList.TryAdd(path, tit);
            dirLabel.Text = path;
            // 优先放置当前文件
            // 逆序放置文件名于工作区列表中
            String[] workplaceArray = workplaceList.Values.ToArray();
            String[] pathArray = workplaceList.Keys.ToArray();
            workplaceListBox.Items.Add(tit + " | " + path);
            for (int i = workplaceArray.Length - 1; i >= 0; i--)
            {
                if (workplaceArray[i].Equals(tit))
                {
                    continue;
                }
                workplaceListBox.Items.Add(workplaceArray[i] + " | " + pathArray[i]);
            }
            
        }
        /*
         * 新建（未保存的草稿）
         *      reset the _titleLabel, _dirLabel, _editText
         */
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 之前文件如未保存，则保存
            if (titleLabel.Text.LastIndexOf("-unsaved") + "-unsaved".Length == titleLabel.Text.Length)
            {
                保存SToolStripMenuItem_Click(sender, e);
            }

            clearEditor();
        }
        /*
         * 打开目录
         *      build _dirTreeView
         *      if it is a directory then named the _itemLabel
         */
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if ( (int)folderBrowserDialog.ShowDialog() == 1)
            {
                String rootFile = folderBrowserDialog.SelectedPath;
                resetDirTreeView(rootFile);
                rootPath = rootFile;
                // 启动文件操作控件
                mkdirBtn.Enabled = true;
                mkfiBtn.Enabled = true;
                mvBtn.Enabled = true;
                rmBtn.Enabled = true;
                // 刷新按键可视化
                refreshBtn.Visible = true;
            }
        }
        /*
         * 读取文件内容至编辑区 同时 允许启用编译 和 高亮 功能
         */
        private void editTextReader(String filePath)
        {
            编译CToolStripMenuItem.Enabled = true;
            高亮ToolStripMenuItem.Enabled = true;
            
            editText.Text = "";
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            try
            {
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                String strLine = streamReader.ReadLine();
                while (strLine != null)
                {
                    editText.Text += strLine + "\n";
                    strLine = streamReader.ReadLine();
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
            fileStream.Close();
            streamReader.Close();
        }
        /*
         * 打开选中文档结点
         *      get the root node path order by order
         *      set the _titleLabel
         *      open the file by path and fill up with the _editText
         */
        private void dirTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 寻根 以及 拼接路径
            List<String> list = new List<String>();
            StringBuilder path = new StringBuilder();
            TreeNode node = dirTreeView.SelectedNode;
            while (node.Parent != null)
            {
                list.Add(node.Text);
                node = node.Parent;
            }
            list.Add(node.Text);
            path.Append(list[list.Count - 1]);
            for (int i = list.Count - 2; i >= 0; i--)
            {
                path.Append("\\");
                path.Append(list[i]);
            }
            
            // 设置标题及目录名 并 打开文件 同时加入工作区列表
            String tit = list[0];
            String filePath = path.ToString();
            if (File.Exists(filePath))
            {
                titleLabel.Text = String.Format("{0}-unsaved", tit);
                editTextReader(filePath);
                // 加入工作区
                addToWorkplace(filePath, tit);
                // 当前是文件？项目标题显示上选中的文件的当前所在一级目录
                filePath = filePath.Substring(0, filePath.LastIndexOf("\\"));
            }
            itemLabel.Text = String.Format("Item:{0}", filePath);
        }
        /*
         * 保存未命名文件 或 另存为文件，同时加入工作区 设置标题
         *      save as new file, reset the _titleLabel, _dirLabel, workplaceListBox(add it to the workplaceList as well) 
         */
        private void saveUntitled()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                String fileName = saveFileDialog.FileName;
                editText.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                // 加入工作区 及 设置标题
                dirLabel.Text = fileName;
                int i = fileName.LastIndexOf("\\") + 1;
                titleLabel.Text = fileName.Substring(i);
                addToWorkplace(fileName, titleLabel.Text);
            }
        }
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveUntitled();
        }
        /*
         * 保存文件
         *      change the "unsaved" text in _titleLabel
         *      if 'workplaceList' is null, chose a path to save the untitled file, as it done, add the path in 'workplaceList'
         *      save the file, path is in a unVisible dirListBox
         */
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text.Equals("untitled") || titleLabel.Text.Equals("untitled-unsaved"))
            {
                saveUntitled();
            }
            else
            {
                String path = dirLabel.Text;
                File.Delete(path);
                File.AppendAllText(path, editText.Text, Encoding.UTF8);
            }

            String title = titleLabel.Text;
            int i = title.LastIndexOf("-unsaved");
            if (i > 0)
            {
                titleLabel.Text = title.Substring(0, i);
            }
        }
        /*
         * 清空工作区列表 及 编辑区、标题区
         *      when remove the workplaceListBox
         *      clear the _titleLabel, _editText, dirLabel 
         */
        private void rmWorkplaceBtn_Click(object sender, EventArgs e)
        {
            if ( (int)MessageBox.Show("确定清除工作区？",
                                    "提醒",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Exclamation ) == 1)
            {
                workplaceList.Clear();
                workplaceListBox.Items.Clear();
                
                clearEditor();
            }
        }
        /*
         * 关闭程序
         */
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否关闭", "关闭", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        /*
         * 撤销
         */
        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.Undo();
        }
        /*
         * 重复
         */
        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.Redo();
        }
        /*
         * 剪切
         */
        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.Cut();
        }
        /*
         * 复制
         */
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.Copy();
        }
        /*
         * 黏贴
         */
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.Paste();
        }
        /*
         * 全选
         */
        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editText.SelectAll();
        }
        /*
         * 替换（及查找功能）
         */
        private void 替换RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replacePanel.Visible = true;
        }
        /*
         * 关闭替换窗口
         */
        private void ClosePanelBtn_Click(object sender, EventArgs e)
        {
            replacePanel.Visible = false;
        }
        /*
         * 搜索功能
         */
        private void searchWords()
        {
            String searchText = this.searchText.Text;
            String editText = this.editText.Text;
            this.editText.Select(0, editText.Length);
            this.editText.SelectionBackColor = Color.FromArgb(46, 52, 64);
            int index = editText.IndexOf(searchText);
            int cnt = 0;
            while (index >= 0 && searchText.Length > 0)
            {
                this.editText.Select(index, searchText.Length);
                this.editText.SelectionBackColor = Color.FromArgb(56, 203, 123);
                index = editText.IndexOf(searchText, index + 1);
                cnt++;
            }
            cntLabel.Text = String.Format("Count: {0}",cnt.ToString());
            // 复位
            if (searchText.Length == 0)
            {
                curPostion = -1;
            }
        }
        /*
         * 搜索框
         *      turn the color of search words
         *      count the number
         */
        private void searchText_TextChanged(object sender, EventArgs e)
        {
            searchWords();
        }
        /*
         * 查找下一个
         */
        private void findNextBtn_Click(object sender, EventArgs e)
        {
            searchWords();

            String editText = this.editText.Text;
            String searchText = this.searchText.Text;
            curPostion = editText.IndexOf(searchText, curPostion + 1);
            if (curPostion >= 0)
            {
                this.editText.Select(curPostion, searchText.Length);
                this.editText.SelectionBackColor = Color.Coral;
            }
        }
        /*
         * 替换
         */
        private void replaceBtn_Click(object sender, EventArgs e)
        {
            String searchText = this.searchText.Text;
            String replaceText = this.replaceText.Text;
            String editText = this.editText.Text;
            if (replaceAllCheckBox.Checked)
            {
                this.editText.Text = editText.Replace(searchText, replaceText);
            }
            else if (curPostion >= 0 && editText.Contains(searchText))
            {
                this.editText.Text = editText.Substring(0, curPostion) + replaceText +
                                     editText.Substring(curPostion + searchText.Length);
            }
        }
        /*
         * 搜索框、替换框全选
         */
        private void selectAll_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox) sender).SelectAll();
            }
        }
        /*
         * 编辑区 同 行号区 字体放大缩小
         */
        private void setFontSize()
        {
            editText.Font = new Font(editText.Font.FontFamily, fontSize);
            lineNumText.Font = new Font(lineNumText.Font.FontFamily, fontSize);
        }
        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (editText.Font.Size < 30)
            { 
                fontSize += 2;
                setFontSize();
            }
        }
        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             if (editText.Font.Size > 5)
             {
                 fontSize -= 2;
                 setFontSize();
             }
         }                      
        /*
         * 显现搜索工作区文本框
         */
        private void workplaceLabel_Click(object sender, EventArgs e)
        { 
            searchList.Visible = true;
        }
        /*
         * 搜索工作区列表
         */
        private void searchList_TextChanged(object sender, EventArgs e)
        {
            workplaceListBox.Items.Clear();
            String[] keys = workplaceList.Keys.ToArray();
            int i = 0;
            foreach (String value in workplaceList.Values)
            {
                if (value.ToUpper().Contains(searchList.Text.ToUpper()))
                {
                    workplaceListBox.Items.Add(value + "\\" + keys[i]);
                }
                i++;
            }
        }
        /*
         * 项目文件操作
         */
        private void projectOperations(int type)
        {
            // 删除按键触发下 无需复现输入文本框
            itemText.Visible = type != 4 ? true : false; 
            String newItem = itemText.Text;
            String oldItemPath = itemLabel.Text.Substring("Item:".Length);
            String path = oldItemPath + "\\" + newItem;
            String selectItem = dirTreeView.SelectedNode.Text;

            if ((newItem.Length > 0 || type == 4) && path.Length > 0 && selectItem.Length > 0)
            {
                if (type == 1 && !Directory.Exists(path))
                {
                    // 新建目录
                    Directory.CreateDirectory(path);
                } 
                else if (type == 2 && !File.Exists(path))
                {
                    // 新建文件
                    File.Create(path);
                }
                else if (type == 3)
                {
                    String newItemPath = path.Substring(0, path.LastIndexOf(selectItem)) + newItem;
                    // 路径以选中结点为结尾，说明是目录，反，为文件
                    // 目录重命名   不能修改项目的根路径
                    if (oldItemPath.EndsWith(selectItem) && !Directory.Exists(newItemPath) && oldItemPath != rootPath)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(oldItemPath);
                        directoryInfo.MoveTo(newItemPath);
                    }
                    // 文件重命名
                    else if (!File.Exists(path))
                    {
                        FileInfo fileInfo = new FileInfo(oldItemPath);
                        fileInfo.MoveTo(path);
                    }
                }
                else if (type == 4)
                {
                    // 删除目录
                    if (oldItemPath.EndsWith(selectItem) && oldItemPath != rootPath)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(oldItemPath);
                        directoryInfo.Delete(true);
                    }
                    // 删除文件
                    else
                    {
                        FileInfo fileInfo = new FileInfo(oldItemPath + "\\" + selectItem);
                        fileInfo.Delete();
                    }
                }
                resetDirTreeView(rootPath);
            }
        }
        /*
         * 创建目录 并 重新刷新项目树
         */
        private void mkdirBtn_Click(object sender, EventArgs e)
        {
            projectOperations(1);
        }
        /*
         * 创建文件 并 重新刷新项目树
         */
        private void mkfiBtn_Click(object sender, EventArgs e)
        {
            projectOperations(2);
        }
        /*
         * 重命名
         */
        private void mvBtn_Click(object sender, EventArgs e)
        {
            projectOperations(3);
        }
        /*
         * 删除
         */
        private void rmBtn_Click(object sender, EventArgs e)
        {
            projectOperations(4);
        }
        /*
         * 失去焦点文本输入框不可视
         */
        private void TextBox_Unvisible(object sender, EventArgs e)
        {
            ((TextBox) sender).Visible = false;
            if ((TextBox) sender == searchList)
            {
                addToWorkplace(dirLabel.Text, titleLabel.Text);
            }
        }
        /*
         * 手动刷新项目区
         */
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            resetDirTreeView(rootPath);
        }
        /*
         * 工作区操作
         *   打开
         *   移除
         */
        private void workListBoxOperation(int type)
        {
            String selectedItem = workplaceListBox.SelectedItem.ToString();
            String seg = " | ";
            int segPos = selectedItem.IndexOf(seg);
            String item = selectedItem.Substring(0, segPos);
            String filePath = selectedItem.Substring(segPos + seg.Length);
            
            // 工作区文件如果存在则打开，反，则移除出  以实现与文件区的异步处理
            if (type == 1 && File.Exists(filePath))
            {
                titleLabel.Text = item;
                dirLabel.Text = filePath;
                editTextReader(filePath);
            }
            else
            {
                workplaceList.TryRemove(filePath, out item);
                workplaceListBox.Items.Clear();
                String[] workplaceArray = workplaceList.Values.ToArray();
                String[] pathArray = workplaceList.Keys.ToArray();
                for (int i = workplaceArray.Length - 1; i >= 0; i--)
                {
                    workplaceListBox.Items.Add(workplaceArray[i] + seg + pathArray[i]);
                }

                clearEditor();
            }
        }
        /*
         * 单选工作区文件打开
         */
        private void workplaceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            workListBoxOperation(1);
        }
        /*
         * 双击选工作区文件移除
         */
        private void workplaceListBox_DoubleClick(object sender, EventArgs e)
        {
            workListBoxOperation(2);
        }
        /*
         * 编译  调用终端（显示结果） 或 打开浏览器
         *      show result in the _outputRichTextBox
         */
        private void 编译CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String dir = dirLabel.Text;
            int i = dir.LastIndexOf("\\"), j = dir.IndexOf("\\");
            String file = dir.Substring(i + 1);
            String drive = dir.Substring(0, j);
            dir = dir.Substring(0, i);
            
            // 语言判断
            int k = file.LastIndexOf(".") + 1;
            String suffix = file.Substring(k);
            String tool = "";
            
            // PYTHON JAVA C++ C
            switch (suffix)
            {
                case "py":
                    tool = "python " + file;
                    break;
                case "java":
                    tool = "javac " + file + "&java " + file;
                    break;
                case "cpp":
                    tool = "g++ " + file + " -o " + file + ".exe &\n" + file + ".exe";
                    break;
                case "c":
                    tool = "gcc " + file + " -o " + file + ".exe &\n" + file + ".exe";
                    break;
            }
            
            if (tool.Length > 0)
            {
                try
                {
                    //cmd命令
                    String cmd = drive + "&cd " + dir + "&" + tool + "&exit";
                    using (Process process = new Process())
                    {
                        process.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.RedirectStandardError = true;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                
                        process.StandardInput.WriteLine(cmd);
                        process.StandardInput.AutoFlush = true;
                
                        outputRichTextBox.Text = process.StandardOutput.ReadToEnd();
                        process.StandardInput.AutoFlush = true;

                        process.WaitForExit();
                        process.Close();
                    }
                    // 显示结果
                    outputRichTextBox.Visible = true;
                    outputRichTextBox.Focus();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            
            // HTML PHP 打开浏览器
            if (suffix.Equals("html") || suffix.Equals("php"))
            {
                openBrowser(dirLabel.Text);
            }
        }
        /*
         * 输出区失去焦点不可视
         */
        private void outputRichTextBox_Leave(object sender, EventArgs e)
        {
            ((RichTextBox) sender).Visible = false;
        }
        /*
         * 高亮当前代码
         */
        private void 高亮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String unsaved = "-unsaved";
            String title = titleLabel.Text;
            if (title.Contains(unsaved))
            {
                title = title.Substring(0, title.LastIndexOf(unsaved));
            }

            LanguageStyle lan = new LanguageStyle();
            lan.language(title.Substring(title.LastIndexOf(".") + 1), editText);
        }
        /*
         * 打开浏览器
         */
        private void openBrowser(String addr)
        {
            Process.Start(addr);
        }
        /*
         * 开源地址：GitHub
         */
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openBrowser("https://github.com/Creator-codes/Editor/blob/e_v1.0.0/README.md");
        }
        /*
         * 打开关于窗口
         */
        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new aboutForm().ShowDialog();
        }
        /*
         * 右键菜单
         *  翻译   网络请求
         */
        private void 翻译TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String text = editText.SelectedText;
            outputRichTextBox.Visible = true;
            outputRichTextBox.Text = "翻译内容：" + text + "\n结果：";
            try
            {
                String url = "http://fanyi.youdao.com/translate?&doctype=json&type=AUTO&i=" + text;
                HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
                req.KeepAlive = false;
                req.Timeout = 30 * 1000;
                req.Method = "GET";
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                req.Host = "fanyi.youdao.com";
                
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                if (res.StatusCode != HttpStatusCode.OK)
                {
                    return;
                }

                using (StreamReader streamReader = new StreamReader(res.GetResponseStream()))
                {
                    JObject jObject = (JObject)JsonConvert.DeserializeObject(streamReader.ReadToEnd());
                    JArray translateRes = (JArray)JsonConvert.DeserializeObject(jObject["translateResult"].ToString());
                    JArray Res = (JArray)JsonConvert.DeserializeObject(translateRes[0].ToString());
                    JObject tgt = JObject.Parse(Res[0].ToString());
                    outputRichTextBox.Text += tgt["tgt"].ToString();
                }
            } catch (Exception) {}
        }
    } 
}