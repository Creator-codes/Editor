using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class mainForm : Form
    {
        private Graphics graphics;
        private Bitmap bitmap;
        private Pen pen;
        // 样式
        Color penColor = Color.Azure;
        private int penShape = 2;
        // 坐标
        private int x = 0, y = 0;
        private Point point;
        // 判断是否绘画 及其操作
        private bool isPaint = false;
        private bool isBrush = true;
        private bool isEraser = false;
        private bool isLine = false;
        private bool isRect = false;
        private bool isTri = false;
        private bool isElli = false;
        private bool isPointTo = false;
        private bool isTxt = false;
        // 文件路径
        private string filePath = "";
        
        public mainForm()
        {
            InitializeComponent();
            
            //初始化图片及图片大小
            bitmap = new Bitmap(Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
            graphics = Graphics.FromImage(bitmap);
            //初始化画板
            picBox.Image = bitmap;
            //释放画板资源
            graphics.Dispose();
        }

        /*
         * 清空
         */
        private void clear()
        {
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.FromArgb(62, 89, 62));
            //初始化画板
            picBox.Image = bitmap;
        }
        /*
         * 文件操作
         *  新建
         *  打开
         *  保存
         *  另存为
         */
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否保存", "提示", MessageBoxButtons.YesNo)) 
            { 
                另存为AToolStripMenuItem_Click(null, null);
            }
            clear();
        }
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(png)|*.png|(jpg)|*.jpg";    //图像保存方式为      
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                picBox.Load(filePath);
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
                bitmap.Save(filePath, ImageFormat.Jpeg);
            }
        }
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(png)|*.png|(jpg)|*.jpg";    //图像保存方式为      
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                bitmap.Save(filePath, ImageFormat.Png);
            }
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
         * 工具操作
         *  初始化 initTools
         *  画笔 brushBtn_Click
         *  橡皮 eraserBtn_Click
         *  直线 lineBtn_Click
         *  矩形 rectBtn_Click
         *  三角 triBtn_Click
         *  椭圆 ellipseBtn_Click
         *  指向 pointToBtn_Click
         *  颜色板 colorBtn_Click
         *  大小 sizeMenuItem_Click
         *  文字 textBtn_Click
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

            brushBtn.BackColor = Color.FromArgb(165, 165, 170);
            eraserBtn.BackColor = Color.FromArgb(165, 165, 170);
            lineBtn.BackColor = Color.FromArgb(165, 165, 170);
            rectBtn.BackColor = Color.FromArgb(165, 165, 170);
            triBtn.BackColor = Color.FromArgb(165, 165, 170);
            ellipseBtn.BackColor = Color.FromArgb(165, 165, 170);
            pointToBtn.BackColor = Color.FromArgb(165, 165, 170);
            textBtn.BackColor = Color.FromArgb(165, 165, 170);
        }
        private void brushBtn_Click(object sender, EventArgs e)
        {
            initTools();
            isBrush = true;
            brushBtn.BackColor = Color.FromArgb(120, 165, 170);
        }
        private void eraserBtn_Click(object sender, EventArgs e)
        {
            initTools();
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
            textBtn.BackColor = Color.FromArgb(120, 165, 170);
            isTxt = true;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void whiteboardBtn_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            Opacity = Opacity == 1 ? 0.5 : 1;
        }
        /*
         * 绘图
         */
        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint && e.Button == MouseButtons.Left)
            {
                graphics = Graphics.FromImage(bitmap);
                
                if (isBrush)
                {
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawLine(pen, new Point((int)x, (int)y), new Point(e.X, e.Y));
                    picBox.Image = bitmap;
                    x = e.X;
                    y = e.Y;
                }

                if (isEraser)
                {
                    pen = new Pen(Color.FromArgb(62, 89, 62), penShape);
                   
                    graphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
                    x = e.X;
                    y = e.Y;
                }

                picBox.Image = bitmap;
                graphics.Dispose();
            }
        }
        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                point.X = e.X;
                point.Y = e.Y;
                pen = new Pen(penColor, penShape);
                isPaint = true;
            }

            if (isTxt)
            {
                Font font = new Font("宋体", penShape + 20);
                Brush brush = new SolidBrush(penColor);
            
                graphics = Graphics.FromImage(bitmap);
                graphics.DrawString(textBox.Text, font, brush, x, y);
                graphics.Dispose();
            }
        }
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);

            if (e.Button == MouseButtons.Left)
            {
                if (isLine)
                {
                    graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                }

                if (isRect)
                {
                    if (point.X > e.X && point.Y > e.Y)
                    {
                        graphics.DrawRectangle(pen , e.X, e.Y, point.X - e.X, point.Y - e.Y);
                    }
                    else if (point.X > e.X && point.Y < e.Y)
                    {
                        graphics.DrawRectangle(pen , e.X, point.Y, point.X - e.X, e.Y - point.Y);
                    }
                    else if (point.Y > e.Y && point.X < e.X)
                    {
                        graphics.DrawRectangle(pen , point.X, e.Y, e.X - point.X, point.Y - e.Y);
                    }
                    else
                    {
                        graphics.DrawRectangle(pen , point.X, point.Y, e.X - point.X, e.Y - point.Y);
                    }
                }

                if (isTri)
                {
                    Point p1 = new Point(point.X, point.Y);
                    Point p2 = new Point(point.X, e.Y);
                    Point p3 = new Point(e.X, e.Y);
                    Point[] triPoints = { p1, p2, p3 };
                    graphics.DrawPolygon(pen, triPoints);
                }

                if (isElli)
                {
                    graphics.DrawEllipse(pen, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                }

                if (isPointTo)
                {
                    pen.CustomEndCap = new AdjustableArrowCap(12, 12, false);
                    graphics.DrawLine(pen, point.X, point.Y, e.X, e.Y);
                }
            }
            
            picBox.Image = bitmap;
            graphics.Dispose();
        }
    }
}