namespace MyQRCode
{
    partial class QRCWnd
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDown_reqVer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_pixel = new System.Windows.Forms.ComboBox();
            this.cBox_drawQuietZones = new System.Windows.Forms.CheckBox();
            this.cBox_eccLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBox_forceUtf8 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_utf8BOM = new System.Windows.Forms.CheckBox();
            this.cBox_eciMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addIcon = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ccBox_darkColor = new MyQRCode.ColorComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ccBox_lightColor = new MyQRCode.ColorComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_reqVer)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "要求的版本：";
            // 
            // numUpDown_reqVer
            // 
            this.numUpDown_reqVer.Location = new System.Drawing.Point(360, 11);
            this.numUpDown_reqVer.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numUpDown_reqVer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_reqVer.Name = "numUpDown_reqVer";
            this.numUpDown_reqVer.Size = new System.Drawing.Size(44, 21);
            this.numUpDown_reqVer.TabIndex = 4;
            this.numUpDown_reqVer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDown_reqVer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "像素块大小：";
            // 
            // cBox_pixel
            // 
            this.cBox_pixel.FormattingEnabled = true;
            this.cBox_pixel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cBox_pixel.Location = new System.Drawing.Point(360, 37);
            this.cBox_pixel.Name = "cBox_pixel";
            this.cBox_pixel.Size = new System.Drawing.Size(44, 20);
            this.cBox_pixel.TabIndex = 5;
            // 
            // cBox_drawQuietZones
            // 
            this.cBox_drawQuietZones.AutoSize = true;
            this.cBox_drawQuietZones.Location = new System.Drawing.Point(360, 62);
            this.cBox_drawQuietZones.Name = "cBox_drawQuietZones";
            this.cBox_drawQuietZones.Size = new System.Drawing.Size(15, 14);
            this.cBox_drawQuietZones.TabIndex = 6;
            this.cBox_drawQuietZones.UseVisualStyleBackColor = true;
            // 
            // cBox_eccLevel
            // 
            this.cBox_eccLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_eccLevel.FormattingEnabled = true;
            this.cBox_eccLevel.Location = new System.Drawing.Point(360, 81);
            this.cBox_eccLevel.Name = "cBox_eccLevel";
            this.cBox_eccLevel.Size = new System.Drawing.Size(44, 20);
            this.cBox_eccLevel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "容错率等级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "是否有白边：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 107);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Force UTF8：";
            // 
            // cBox_forceUtf8
            // 
            this.cBox_forceUtf8.AutoSize = true;
            this.cBox_forceUtf8.Location = new System.Drawing.Point(360, 106);
            this.cBox_forceUtf8.Name = "cBox_forceUtf8";
            this.cBox_forceUtf8.Size = new System.Drawing.Size(15, 14);
            this.cBox_forceUtf8.TabIndex = 8;
            this.cBox_forceUtf8.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 126);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "UTF8-BOM：";
            // 
            // cBox_utf8BOM
            // 
            this.cBox_utf8BOM.AutoSize = true;
            this.cBox_utf8BOM.Location = new System.Drawing.Point(360, 125);
            this.cBox_utf8BOM.Name = "cBox_utf8BOM";
            this.cBox_utf8BOM.Size = new System.Drawing.Size(15, 14);
            this.cBox_utf8BOM.TabIndex = 9;
            this.cBox_utf8BOM.UseVisualStyleBackColor = true;
            // 
            // cBox_eciMode
            // 
            this.cBox_eciMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_eciMode.FormattingEnabled = true;
            this.cBox_eciMode.Location = new System.Drawing.Point(360, 144);
            this.cBox_eciMode.Name = "cBox_eciMode";
            this.cBox_eciMode.Size = new System.Drawing.Size(76, 20);
            this.cBox_eciMode.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "编码的模式：";
            // 
            // btn_addIcon
            // 
            this.btn_addIcon.Location = new System.Drawing.Point(272, 227);
            this.btn_addIcon.Name = "btn_addIcon";
            this.btn_addIcon.Size = new System.Drawing.Size(164, 35);
            this.btn_addIcon.TabIndex = 2;
            this.btn_addIcon.Text = "添加图标";
            this.btn_addIcon.UseVisualStyleBackColor = true;
            this.btn_addIcon.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(272, 266);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(164, 35);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Text = "生成二维码";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 268);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 72);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(272, 305);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(164, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Button_Click);
            // 
            // ccBox_darkColor
            // 
            this.ccBox_darkColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccBox_darkColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccBox_darkColor.FormattingEnabled = true;
            this.ccBox_darkColor.ItemHeight = 16;
            this.ccBox_darkColor.Location = new System.Drawing.Point(360, 169);
            this.ccBox_darkColor.Name = "ccBox_darkColor";
            this.ccBox_darkColor.Size = new System.Drawing.Size(76, 22);
            this.ccBox_darkColor.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "二维码暗色：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "二维码亮色：";
            // 
            // ccBox_lightColor
            // 
            this.ccBox_lightColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccBox_lightColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccBox_lightColor.FormattingEnabled = true;
            this.ccBox_lightColor.ItemHeight = 16;
            this.ccBox_lightColor.Location = new System.Drawing.Point(360, 196);
            this.ccBox_lightColor.Name = "ccBox_lightColor";
            this.ccBox_lightColor.SelectedColor = System.Drawing.Color.White;
            this.ccBox_lightColor.Size = new System.Drawing.Size(76, 22);
            this.ccBox_lightColor.TabIndex = 12;
            // 
            // QRCWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 353);
            this.Controls.Add(this.ccBox_lightColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ccBox_darkColor);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_addIcon);
            this.Controls.Add(this.cBox_eciMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBox_utf8BOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBox_forceUtf8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBox_eccLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_drawQuietZones);
            this.Controls.Add(this.cBox_pixel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDown_reqVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QRCWnd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QRCWnd_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_reqVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDown_reqVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBox_pixel;
        private System.Windows.Forms.CheckBox cBox_drawQuietZones;
        private System.Windows.Forms.ComboBox cBox_eccLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cBox_forceUtf8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cBox_utf8BOM;
        private System.Windows.Forms.ComboBox cBox_eciMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_addIcon;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Save;
        private ColorComboBox ccBox_darkColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ColorComboBox ccBox_lightColor;
    }
}

