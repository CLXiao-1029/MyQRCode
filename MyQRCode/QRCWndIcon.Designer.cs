namespace MyQRCode
{
    partial class QRCWndIcon
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
            this.btn_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.pBox_icon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDown_Size = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_Border = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ccBox_BorderCol = new MyQRCode.ColorComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Border)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(372, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(47, 23);
            this.btn_Select.TabIndex = 0;
            this.btn_Select.Text = "选择";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图标路径：";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(83, 5);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(283, 21);
            this.tBox_Name.TabIndex = 4;
            // 
            // pBox_icon
            // 
            this.pBox_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_icon.Location = new System.Drawing.Point(14, 37);
            this.pBox_icon.Name = "pBox_icon";
            this.pBox_icon.Size = new System.Drawing.Size(69, 63);
            this.pBox_icon.TabIndex = 3;
            this.pBox_icon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图标大小：";
            // 
            // numUpDown_Size
            // 
            this.numUpDown_Size.Location = new System.Drawing.Point(160, 33);
            this.numUpDown_Size.Name = "numUpDown_Size";
            this.numUpDown_Size.Size = new System.Drawing.Size(49, 21);
            this.numUpDown_Size.TabIndex = 5;
            // 
            // numUpDown_Border
            // 
            this.numUpDown_Border.Location = new System.Drawing.Point(160, 56);
            this.numUpDown_Border.Name = "numUpDown_Border";
            this.numUpDown_Border.Size = new System.Drawing.Size(49, 21);
            this.numUpDown_Border.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "图标边框：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "边框颜色：";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(231, 77);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(56, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(297, 77);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(56, 23);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(359, 77);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(56, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "取消";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Button_Click);
            // 
            // ccBox_BorderCol
            // 
            this.ccBox_BorderCol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ccBox_BorderCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccBox_BorderCol.FormattingEnabled = true;
            this.ccBox_BorderCol.ItemHeight = 16;
            this.ccBox_BorderCol.Location = new System.Drawing.Point(160, 79);
            this.ccBox_BorderCol.Name = "ccBox_BorderCol";
            this.ccBox_BorderCol.Size = new System.Drawing.Size(49, 22);
            this.ccBox_BorderCol.TabIndex = 7;
            // 
            // QRCWndIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(423, 108);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.ccBox_BorderCol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpDown_Border);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDown_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBox_icon);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QRCWndIcon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.QRCWndIcon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Border)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_Name;
        private System.Windows.Forms.PictureBox pBox_icon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDown_Size;
        private System.Windows.Forms.NumericUpDown numUpDown_Border;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColorComboBox ccBox_BorderCol;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Close;
    }
}