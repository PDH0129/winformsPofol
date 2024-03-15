namespace draw_ing
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnColor = new System.Windows.Forms.Panel();
            this.cBSaveColor = new System.Windows.Forms.ComboBox();
            this.pBColorDialog = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pBEraser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcondition = new System.Windows.Forms.Label();
            this.rBtnClick = new System.Windows.Forms.RadioButton();
            this.rBtnPressing = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBColorDialog)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEraser)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnColor);
            this.panel1.Controls.Add(this.cBSaveColor);
            this.panel1.Controls.Add(this.pBColorDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 144);
            this.panel1.TabIndex = 0;
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.Color.Black;
            this.pnColor.Location = new System.Drawing.Point(1, 81);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(104, 34);
            this.pnColor.TabIndex = 2;
            // 
            // cBSaveColor
            // 
            this.cBSaveColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSaveColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBSaveColor.FormattingEnabled = true;
            this.cBSaveColor.Items.AddRange(new object[] {
            "0, 0, 0"});
            this.cBSaveColor.Location = new System.Drawing.Point(3, 119);
            this.cBSaveColor.Name = "cBSaveColor";
            this.cBSaveColor.Size = new System.Drawing.Size(101, 20);
            this.cBSaveColor.TabIndex = 1;
            this.cBSaveColor.SelectedIndexChanged += new System.EventHandler(this.cBSaveColor_SelectedIndexChanged);
            // 
            // pBColorDialog
            // 
            this.pBColorDialog.Image = global::draw_ing.Properties.Resources.팔레투;
            this.pBColorDialog.Location = new System.Drawing.Point(3, 8);
            this.pBColorDialog.Name = "pBColorDialog";
            this.pBColorDialog.Size = new System.Drawing.Size(102, 68);
            this.pBColorDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBColorDialog.TabIndex = 0;
            this.pBColorDialog.TabStop = false;
            this.pBColorDialog.Click += new System.EventHandler(this.pBColorDialog_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(125, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 144);
            this.panel2.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(50, 122);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 12);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "12%";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "크\r\n기";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 3);
            this.trackBar1.Maximum = 16;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(41, 137);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pBEraser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(214, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 144);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "지우개";
            // 
            // pBEraser
            // 
            this.pBEraser.BackColor = System.Drawing.Color.Transparent;
            this.pBEraser.Image = global::draw_ing.Properties.Resources.지우개;
            this.pBEraser.Location = new System.Drawing.Point(19, 3);
            this.pBEraser.Name = "pBEraser";
            this.pBEraser.Size = new System.Drawing.Size(42, 40);
            this.pBEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEraser.TabIndex = 0;
            this.pBEraser.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(309, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 144);
            this.panel4.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcondition);
            this.groupBox1.Controls.Add(this.rBtnClick);
            this.groupBox1.Controls.Add(this.rBtnPressing);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "그리기 모드";
            // 
            // lblcondition
            // 
            this.lblcondition.AutoSize = true;
            this.lblcondition.Location = new System.Drawing.Point(235, 91);
            this.lblcondition.Name = "lblcondition";
            this.lblcondition.Size = new System.Drawing.Size(32, 12);
            this.lblcondition.TabIndex = 4;
            this.lblcondition.Text = "false";
            // 
            // rBtnClick
            // 
            this.rBtnClick.AutoSize = true;
            this.rBtnClick.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rBtnClick.Location = new System.Drawing.Point(6, 81);
            this.rBtnClick.Name = "rBtnClick";
            this.rBtnClick.Size = new System.Drawing.Size(112, 25);
            this.rBtnClick.TabIndex = 3;
            this.rBtnClick.Text = "클릭하기";
            this.rBtnClick.UseVisualStyleBackColor = true;
            this.rBtnClick.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rBtnPressing
            // 
            this.rBtnPressing.AutoSize = true;
            this.rBtnPressing.Checked = true;
            this.rBtnPressing.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rBtnPressing.Location = new System.Drawing.Point(6, 34);
            this.rBtnPressing.Name = "rBtnPressing";
            this.rBtnPressing.Size = new System.Drawing.Size(140, 25);
            this.rBtnPressing.TabIndex = 2;
            this.rBtnPressing.TabStop = true;
            this.rBtnPressing.Text = "길게 누르기";
            this.rBtnPressing.UseVisualStyleBackColor = true;
            this.rBtnPressing.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.199048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.740682F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.216495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.84377F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(171, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1317, 152);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 962);
            this.panel5.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(171, 962);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "붓모양.png");
            this.imageList1.Images.SetKeyName(1, "원모양.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 962);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "그림판";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBColorDialog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEraser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pBEraser;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.ComboBox cBSaveColor;
        private System.Windows.Forms.PictureBox pBColorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnClick;
        private System.Windows.Forms.RadioButton rBtnPressing;
        private System.Windows.Forms.Label lblcondition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSize;
    }
}

