using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class mainForm : Form
    {
        // 画入缓存
        private Graphics bitGraphics;
        private Bitmap bitmap;
        // 记录选区
        private Bitmap setAreaBitmap;

        private Pen pen;

        // 记录操作 撤销栈 恢复栈
        private Stack undoStack = new Stack();

        private Stack redoStack = new Stack();

        // 样式
        Color penColor = Color.Azure;

        private int penShape = 2;

        // 坐标（最后一次坐标）
        private int x = 0, y = 0;
        // 开始坐标
        private Point startPoint;
        // 获取选区开始坐标 选区结束坐标
        private Point getAreaStartPoint, getAreaEndPoint;

        // 判断是否绘画 及其操作
        private bool isPaint = false;
        private bool isBrush = true;
        private bool isEraser = false;
        private bool isLine = false;
        private bool isRect = false, isFillRect = false;
        private bool isTri = false, isFillTri = false;
        private bool isElli = false, isFillElli = false;
        private bool isPointTo = false;

        private bool isTxt = false;
        // 选区按键 放置选区触发标志
        private bool isAreaBtn = false;

        // 是否黏贴
        private bool isPaste = false;
        
        // 文件路径
        private string filePath = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // 初始化图片及图片大小
            bitmap = new Bitmap(Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            // bitGraphics = Graphics.FromImage(bitmap);
            // bitGraphics.DrawRectangle(new Pen(Color.FromArgb(62, 89, 62)),0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            clearPicBox();
            // 初始化画板
            // picBox.Image = bitmap;
            // 设置笔鼠标图标
            Bitmap cursor = (Bitmap) Bitmap.FromFile("brush.png");
            SetCursor(cursor, new Point(30, 30));

            // 开始记录
            undoStack.Push(new Bitmap(bitmap));
        }
        
        /*
         * 设置鼠标样式
         */
        public void SetCursor(Bitmap cursor, Point hotPoint)
        {
            int hotX = hotPoint.X;
            int hotY = hotPoint.Y;
            Bitmap myNewCursor = new Bitmap(cursor.Width * 2 - hotX, cursor.Height * 2 - hotY);
            Graphics g = Graphics.FromImage(myNewCursor);
            g.Clear(Color.FromArgb(0, 0, 0, 0));
            g.DrawImage(cursor, cursor.Width - hotX, cursor.Height - hotY, cursor.Width,
                cursor.Height);
            picBox.Cursor = new Cursor(myNewCursor.GetHicon());

            g.Dispose();
            myNewCursor.Dispose();
        }

        /*
         * 清空界面
         */
        private void clearPicBox()
        {
            bitGraphics = Graphics.FromImage(bitmap);
            bitGraphics.Clear(Color.FromArgb(62, 89, 62));
            bitGraphics.DrawRectangle(new Pen(Color.FromArgb(62, 89, 62)),0, 0, Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);

            //初始化画板
            picBox.Image = bitmap;
        }
        /*
         * 操作初始化
         *  撤销栈、恢复栈清空
         *  撤销栈开始记录
         */
        private void initOpt()
        {
            // 操作清零
            undoStack.Clear();
            redoStack.Clear();
            undoStack.Push(bitmap);
            optState();
        }
        /*
         * 操作状态判断
         */
        private void optState()
        {
            撤销ToolStripMenuItem.Enabled = undoStack.Count > 1 ? true : false;
            恢复ToolStripMenuItem.Enabled = redoStack.Count > 0 ? true : false;
        }

        /*
         * 文件操作
         *  新建
         *  打开
         *  保存
         *  另存为
         *  撤销
         *  恢复
         *  复制
         *  剪切
         *  黏贴
         */
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否保存", "提示", MessageBoxButtons.YesNo))
            {
                另存为AToolStripMenuItem_Click(null, null);
            }
            clearPicBox();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //图像打开格式
            openFileDialog.Filter = "(png)|*.png|(jpg)|*.jpg"; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                bitmap = new Bitmap(filePath);
                picBox.Image = bitmap;
                bitGraphics = Graphics.FromImage(bitmap);

                Text += "  " + filePath + " - 副本";
                // 操作初始化
                initOpt();
            }
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath.Equals(""))
            {
                另存为AToolStripMenuItem_Click(null, null);
            }
            else
            {
                File.Delete(filePath);
                bitmap.Save(filePath, ImageFormat.Png);
            }
            
            Text += "  " + filePath;
            // 操作初始化
            initOpt();
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(png)|*.png|(jpg)|*.jpg"; //图像保存方式为      
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                bitmap.Save(filePath, ImageFormat.Png);
            }
            
            Text += "  " + filePath;
            // 操作初始化
            initOpt();
        }

        /*
         * 帮助
         *  打开帮助窗口
         */
        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new helpForm().ShowDialog();
        }

        /*
         * 撤销
         */
        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap record = (Bitmap) undoStack.Pop();
            redoStack.Push(record);
            // record.Dispose();
            // 取出再上一个状态 显示出来 再压回去
            Bitmap preRecord = (Bitmap) undoStack.Pop();
            picBox.Image = preRecord;
            
            bitmap = new Bitmap(preRecord);
            bitGraphics = Graphics.FromImage(bitmap);
            
            undoStack.Push(preRecord);
            optState();
        }

        /*
         * 恢复
         */
        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap record = (Bitmap) redoStack.Pop();
            undoStack.Push(record);
            picBox.Image = record;
            
            bitmap = new Bitmap(record);
            bitGraphics = Graphics.FromImage(bitmap);
            
            optState();
        }
        
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            剪切ToolStripMenuItem.Enabled = 复制ToolStripMenuItem.Enabled;
            复制ToolStripMenuItem.Enabled = !复制ToolStripMenuItem.Enabled;
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            复制ToolStripMenuItem.Enabled = 剪切ToolStripMenuItem.Enabled;
            剪切ToolStripMenuItem.Enabled = !剪切ToolStripMenuItem.Enabled;
        }
        
        /*
         * 黏贴
         */
        private void paste(int x, int y)
        {
            IDataObject iDataObject = Clipboard.GetDataObject();
            if (iDataObject.GetDataPresent(DataFormats.Bitmap))
            {
                bitmap = new Bitmap(picBox.Image);
                bitGraphics = Graphics.FromImage(bitmap);
                bitGraphics.DrawImage((Bitmap) iDataObject.GetData(DataFormats.Bitmap), x, y);
                picBox.Image = bitmap;
            }
        }
        
        private void 黏贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPaste = true;
        }
        
        /*
         * 工具操作
         *  工具初始化 initTools
         *  画笔 brushBtn_Click
         *  橡皮 eraserBtn_Click
         *  直线 lineBtn_Click
         *  矩形 rectBtn_Click
         *  三角 triBtn_Click
         *  椭圆 ellipseBtn_Click
         *  指向 pointToBtn_Click
         *  实心矩形 fillRectBtn_Click
         *  实心三角 fillTriBtn_Click
         *  实心椭圆 fillElliBtn_Click
         *  颜色板 colorBtn_Click
         *  大小 sizeMenuItem_Click
         *  文字 textBtn_Click
         *  选区 areaBtn_Click
         *  清空白板按键 clearBtn_Click
         *  白板模式 whiteboardBtn_Click
         */
        private void initTools()
        {
            isPaint = false;
            isBrush = false;
            isEraser = false;
            isLine = false;
            isRect = false;
            isTri = false;
            isElli = false;
            isPointTo = false;
            isFillRect = false;
            isFillTri = false;
            isFillElli = false;
            isTxt = false;
            isAreaBtn = false;
            剪切ToolStripMenuItem.Enabled = false;
            复制ToolStripMenuItem.Enabled = false;

            // 设置十字鼠标样式
            picBox.Cursor = Cursors.Cross;

            brushBtn.BackColor = Color.FromArgb(165, 165, 170);
            eraserBtn.BackColor = Color.FromArgb(165, 165, 170);
            lineBtn.BackColor = Color.FromArgb(165, 165, 170);
            rectBtn.BackColor = Color.FromArgb(165, 165, 170);
            triBtn.BackColor = Color.FromArgb(165, 165, 170);
            ellipseBtn.BackColor = Color.FromArgb(165, 165, 170);
            pointToBtn.BackColor = Color.FromArgb(165, 165, 170);
            fillRectBtn.BackColor = Color.FromArgb(165, 165, 170);
            fillTriBtn.BackColor = Color.FromArgb(165, 165, 170);
            fillElliBtn.BackColor = Color.FromArgb(165, 165, 170);
            textBtn.BackColor = Color.FromArgb(165, 165, 170);
        }

        private void brushBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isBrush = true;
            // 设置笔鼠标图标
            Bitmap cursor = (Bitmap) Bitmap.FromFile("brush.png");
            SetCursor(cursor, new Point(30, 30));

            brushBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void eraserBtn_Click(object sender, EventArgs e)
        {
            initTools();
            // 设置橡皮鼠标图标
            Bitmap cursor = (Bitmap) Bitmap.FromFile("eraser.png");
            SetCursor(cursor, new Point(30, 30));

            isEraser = true;
            eraserBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isLine = true;
            lineBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void rectBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isRect = true;
            rectBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void triBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isTri = true;
            triBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void ellipseBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isElli = true;
            ellipseBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void pointToBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isPointTo = true;
            pointToBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void fillRectBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isFillRect = true;
            fillRectBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void fillTriBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isFillTri = true;
            fillTriBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void fillElliBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isFillElli = true;
            fillElliBtn.BackColor = Color.FromArgb(120, 165, 170);
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
            }

            colorBtn.BackColor = penColor;
        }

        private void sizeMenuItem_Click(object sender, EventArgs e)
        {
            penSize_2.BackColor = Color.FromArgb(165, 165, 170);
            penSize_6.BackColor = Color.FromArgb(165, 165, 170);
            penSize_10.BackColor = Color.FromArgb(165, 165, 170);
            ((ToolStripMenuItem) sender).BackColor = Color.FromArgb(120, 165, 170);
            penShape = Convert.ToInt32(sender.ToString());
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            initTools();
            // 设置文字鼠标图标
            Bitmap cursor = (Bitmap) Bitmap.FromFile("words.png");
            SetCursor(cursor, new Point(30, 30));

            textBtn.BackColor = Color.FromArgb(120, 165, 170);
            isTxt = true;
        }

        private void areaBtn_Click(object sender, EventArgs e)
        {
            initTools();
            areaBtn.BackColor = Color.FromArgb(120, 165, 170);
            isAreaBtn = true;
        }
        
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearPicBox();
        }

        private void whiteboardBtn_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            Opacity = Opacity == 1 ? 0.5 : 1;
        }

        
        /*
         * 绘图
         */
        /*
         * 同时画矩形和椭圆
         */
        private Rectangle makeRectangle(Point startPoint, Point endPoint)
        {
            int top, left, bottom, right;
            top = startPoint.Y <= endPoint.Y ? startPoint.Y : endPoint.Y;
            left = startPoint.X <= endPoint.X ? startPoint.X : endPoint.X;
            bottom = startPoint.Y > endPoint.Y ? startPoint.Y : endPoint.Y;
            right = startPoint.X > endPoint.X ? startPoint.X : endPoint.X;
            return new Rectangle(left, top, right - left, bottom - top);
        }

        /*
         * 画三角
         */
        private Point[] makeTriangle(Point startPoint, Point endPoint)
        {
            Point p1 = new Point(startPoint.X, startPoint.Y);
            Point p2 = new Point(startPoint.X, endPoint.Y);
            Point p3 = new Point(endPoint.X, endPoint.Y);
            return new[] {p1, p2, p3};
        }

        /*
         * 画指向
         */
        private void makePointTo(Point startPoint, Point endPoint)
        {
            pen.CustomEndCap = new AdjustableArrowCap(12, 12, false);
            bitGraphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
        }

        
        /*
         * 鼠标绘图
         */
        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isPaste)
                {
                    paste(e.X, e.Y);
                    isPaste = false;
                }
                
                x = e.X;
                y = e.Y;
                startPoint = new Point(x, y);
                pen = new Pen(penColor, penShape);
                isPaint = true;

                if (isTxt)
                {
                    Font font = new Font("宋体", penShape + 20);
                    Brush brush = new SolidBrush(penColor);

                    bitGraphics.DrawString(textBox.Text, font, brush, x, y);
                    textBox.Text = "";
                }

                if (复制ToolStripMenuItem.Enabled || 剪切ToolStripMenuItem.Enabled)
                {
                    // 剪切操作 选区重绘
                    if (!剪切ToolStripMenuItem.Enabled)
                    {
                        Rectangle rectangle = makeRectangle(getAreaStartPoint, getAreaEndPoint);
                        bitGraphics.FillRectangle(new SolidBrush(Color.FromArgb(62, 89, 62)), rectangle);
                    }
                    
                    //黏贴
                    paste(e.X, e.Y);
                }
            }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint && e.Button == MouseButtons.Left)
            {
                Graphics picGraphics = picBox.CreateGraphics();
                bitGraphics.SmoothingMode = SmoothingMode.HighQuality;
                picGraphics.SmoothingMode = SmoothingMode.HighQuality;

                if (isBrush)
                {
                    picGraphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
                    bitGraphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
                }

                if (isEraser)
                {
                    picGraphics.DrawLine(new Pen(Color.FromArgb(62, 89, 62), penShape), new Point(x, y),
                        new Point(e.X, e.Y));
                    bitGraphics.DrawLine(new Pen(Color.FromArgb(62, 89, 62), penShape), new Point(x, y),
                        new Point(e.X, e.Y));
                }

                // 以虚线刷新重绘
                if (!isBrush && !isEraser)
                {
                    picBox.Invalidate();
                    picBox.Update();
                    pen.DashStyle = DashStyle.Dash;
                }

                if (isLine)
                {
                    picGraphics.DrawLine(pen, startPoint.X, startPoint.Y, e.X, e.Y);
                }

                if (isRect || isFillRect || isAreaBtn)
                {
                    Rectangle rectangle = makeRectangle(startPoint, new Point(x, y));
                    picGraphics.DrawRectangle(pen, rectangle);
                }

                if (isTri || isFillTri)
                {
                    picGraphics.DrawPolygon(pen, makeTriangle(startPoint, new Point(x, y)));
                }

                if (isElli || isFillElli)
                {
                    Rectangle ellipse = makeRectangle(startPoint, new Point(x, y));
                    picGraphics.DrawEllipse(pen, ellipse);
                }

                if (isPointTo)
                {
                    pen.CustomEndCap = new AdjustableArrowCap(12, 12, false);
                    picGraphics.DrawLine(pen, startPoint.X, startPoint.Y, x, y);
                }

                x = e.X;
                y = e.Y;
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bitGraphics.SmoothingMode = SmoothingMode.HighQuality;
                // 实心
                pen.DashStyle = DashStyle.Solid;
                SolidBrush solidBrush = new SolidBrush(penColor);

                if (isLine)
                {
                    bitGraphics.DrawLine(pen, startPoint.X, startPoint.Y, x, y);
                }

                if (isRect)
                {
                    Rectangle rectangle = makeRectangle(startPoint, new Point(x, y));
                    bitGraphics.DrawRectangle(pen, rectangle);
                }

                if (isFillRect)
                {
                    Rectangle rectangle = makeRectangle(startPoint, new Point(x, y));
                    bitGraphics.FillRectangle(solidBrush, rectangle);
                }

                if (isTri)
                {
                    bitGraphics.DrawPolygon(pen, makeTriangle(startPoint, new Point(x, y)));
                }

                if (isFillTri)
                {
                    bitGraphics.FillPolygon(solidBrush, makeTriangle(startPoint, new Point(x, y)));
                }

                if (isElli)
                {
                    Rectangle ellipse = makeRectangle(startPoint, new Point(x, y));
                    bitGraphics.DrawEllipse(pen, ellipse);
                }

                if (isFillElli)
                {
                    Rectangle ellipse = makeRectangle(startPoint, new Point(x, y));
                    bitGraphics.FillEllipse(solidBrush, ellipse);
                }

                if (isPointTo)
                {
                    makePointTo(startPoint, new Point(x, y));
                }

                // 选取使用虚线 但不划入缓存
                if (isAreaBtn)
                {
                    try
                    {
                        Graphics picGraphics = picBox.CreateGraphics();
                        picGraphics.SmoothingMode = SmoothingMode.HighQuality;
                        pen = new Pen(Color.Azure, 2);
                        pen.DashStyle = DashStyle.Dash;
                        Rectangle rectangle = makeRectangle(startPoint, new Point(x, y));
                        picGraphics.DrawRectangle(pen, rectangle);
                        // 剪切板
                        PixelFormat format = bitmap.PixelFormat;
                        setAreaBitmap = bitmap.Clone(rectangle, format);
                        Clipboard.SetDataObject(setAreaBitmap);
                        // 获取该区域 当剪切时将该区域覆盖
                        getAreaStartPoint = startPoint;
                        getAreaEndPoint = new Point(x, y);
                        // 默认为复制操作 剪切ToolStripMenuItem.Enabled = !复制ToolStripMenuItem.Enabled;
                        剪切ToolStripMenuItem_Click(null, null);
                    }
                    catch (Exception exception) {}
                }
                
                picBox.Image = bitmap;

                // 记录操作
                Bitmap record = new Bitmap(bitmap);
                undoStack.Push(record);
                redoStack.Clear();
                optState();
            }
        }
        
    }
}