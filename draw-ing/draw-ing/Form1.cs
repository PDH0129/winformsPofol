using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace draw_ing
{
    enum DrawMode { LINE, RECTANGLE, CIRCLE, CURVER_LINE, ERASER };

    public partial class Form1 : Form
    {
       /* [DllImport("user32.dll")]
        public static extern int ShowCursor(bool bShow);*/

        public Form1()
        {
            InitializeComponent();

            g = CreateGraphics();
            this.BackColor = Color.White;
            this.eraser = new Pen(this.BackColor, 2);
            drawMode = DrawMode.CURVER_LINE;

            pBEraser.Parent = this;
            pBEraser.BackColor = Color.Transparent;
            pColor = Color.Black;
            trackBar1.Value = (int)pen.Width;
        }

        #region 변수
        string[] shapes = new string[] { "직선", "원", "사각형", "선", "지우개" };
        bool drawmFlag = false;
        DrawMode drawMode;
        Color pColor = new Color();
        List<Color> colors = new List<Color>() { Color.Black };
       
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 2);
        private Pen eraser;

        Point startP;  // 시작점
        Point endP;  // 끝점
        Point currP;  // 현재 위치
        Point prevP;  // 이전 위치 
        #endregion

        #region 초기화
        private void Form1_Load(object sender, EventArgs e)
        {
            // 리스트뷰 아이템 추가 
            for (int i = 0; i < shapes.Length; i++)
            {
                ListViewItem item = new ListViewItem(shapes[i], i);
                listView1.Items.Add(item);
            }
            this.Refresh();
        }
        #endregion

        #region 그리기 설정
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)  // 그리기모드 선택
        {
            switch(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text.Trim())
            {
                case "직선":
                    drawMode = DrawMode.LINE;
                    pBEraser.Visible = false;
                    break;
                case "원":
                    drawMode = DrawMode.CIRCLE;
                    pBEraser.Visible = false;
                    break;
                case "사각형":
                    drawMode = DrawMode.RECTANGLE;
                    pBEraser.Visible = false;
                    break;
                case "선":
                    drawMode = DrawMode.CURVER_LINE;
                    pBEraser.Visible = false;
                    break;
                case "지우개":
                    drawMode = DrawMode.ERASER;
                    pBEraser.Visible = true;
                    break;
            }

            drawmFlag = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);
            prevP = startP;
            currP = startP;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            prevP = currP;
            currP = new Point(e.X, e.Y);
            if (rBtnPressing.Checked)
            {
                if (e.Button != MouseButtons.Left)
                    return;

                switch (drawMode)
                {
                   /* case DrawMode.LINE:
                        g.DrawLine(eraser, startP, prevP);
                        g.DrawLine(pen, startP, currP);
                        break;*/
                    case DrawMode.RECTANGLE:
                        g.DrawRectangle(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                        g.DrawRectangle(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                        break;
                    case DrawMode.CIRCLE:
                        g.DrawEllipse(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                        g.DrawEllipse(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                        break;
                    case DrawMode.CURVER_LINE:
                        g.DrawLine(pen, prevP, currP);
                        break;
                    case DrawMode.ERASER:
                        //pBEraser.Location = currP;
                        pBEraser.Location = new Point((pBEraser.Location.X + currP.X) / 2, (pBEraser.Location.Y + currP.Y) / 2);
                        g.DrawEllipse(eraser, new Rectangle(currP, pBEraser.Size));
                        break;
                }
            }
            else
            {
                if (drawmFlag == false)
                    return;

                switch (drawMode)
                {
                    case DrawMode.LINE:
                        g.DrawLine(eraser, startP, prevP);
                        g.DrawLine(pen, startP, currP);
                        break;
                    case DrawMode.RECTANGLE:
                        g.DrawRectangle(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                        g.DrawRectangle(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                        break;
                    case DrawMode.CIRCLE:
                        g.DrawEllipse(eraser, new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                        g.DrawEllipse(pen, new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                        break;
                    case DrawMode.CURVER_LINE:
                        g.DrawLine(pen, prevP, currP);
                        break;
                    case DrawMode.ERASER:
                        //pBEraser.Location = currP;
                        pBEraser.Location = new Point((pBEraser.Location.X + currP.X) / 2, (pBEraser.Location.Y + currP.Y) / 2);
                        g.DrawEllipse(eraser, new Rectangle(currP, pBEraser.Size));
                        break;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(rBtnClick.Checked == true && drawmFlag == false) return;
            endP = new Point(e.X, e.Y);
            switch (drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(pen, startP, endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(pen, new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVER_LINE:
                    break;
            }
        }
#endregion

        #region 잡설정들

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           drawmFlag = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            drawmFlag = false;
        }
       

        private void Form1_Click(object sender, EventArgs e)
        {
            if (rBtnClick.Checked == true)
            {
                if (drawmFlag)
                    drawmFlag = false;
                else drawmFlag = true;
            }

            lblcondition.Text = drawmFlag.ToString();
        }
        #endregion

        #region 펜 크기, 색깔 설정

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen = new Pen(pColor, trackBar1.Value);
            eraser = new Pen(this.BackColor, trackBar1.Value);
            drawmFlag = false;
            lblSize.Text = (trackBar1.Value * 100 / 16).ToString() + "%";
        }

        private void pBColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = pColor;

            if(cd.ShowDialog() == DialogResult.OK)
            {
                pColor = cd.Color;
                cBSaveColor.Items.Add(cd.Color);
                colors.Add(cd.Color);
            }

            pen = new Pen(pColor, trackBar1.Value);
        }

        private void cBSaveColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnColor.BackColor = colors[cBSaveColor.SelectedIndex];
            pColor = colors[cBSaveColor.SelectedIndex];
            pen = new Pen(pColor, trackBar1.Value);
        }
        #endregion

        #region 저장
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                this.TopMost = true;
                listView1.Visible = false;
                tableLayoutPanel1.Visible = false;
                this.FormBorderStyle = FormBorderStyle.None;
                FormCapture(new Point(this.Left, this.Top), this.Size, sfd.FileName);
                this.TopMost = false;
                listView1.Visible = true;
                tableLayoutPanel1.Visible = true;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        public void FormCapture(Point _point, Size _size, string fn)
        {
            string strOutput = fn + ".png";
            Rectangle rectangle = new Rectangle(_point, _size);

            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics grp = Graphics.FromImage(bitmap);

            grp.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, rectangle.Size);

            bitmap.Save(strOutput, ImageFormat.Png);
            bitmap.Dispose();
        }
        #endregion
    }
}
