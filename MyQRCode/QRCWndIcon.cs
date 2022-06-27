using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQRCode
{
    public partial class QRCWndIcon : Form
    {
        string cfg_full_path;
        public QRCWndIcon(string cfg_full_path)
        {
            InitializeComponent();
            this.cfg_full_path = cfg_full_path;
        }

        private void QRCWndIcon_Load(object sender, EventArgs e)
        {
            tBox_Name.Text = INIOperatorSys.Read(cfg_full_path, "Icon", "Name", "");
            numUpDown_Size.Value = INIOperatorSys.Read(cfg_full_path, "Icon", "Size", 15);
            numUpDown_Border.Value = INIOperatorSys.Read(cfg_full_path, "Icon", "Border", 2);
            string borderCol = INIOperatorSys.Read(cfg_full_path, "Icon", "BorderCol", Color.White.ToHexValue());
            ccBox_BorderCol.SelectedColor = ColorTranslator.FromHtml(borderCol);
            RefPreviewIcon();
        }

        void RefPreviewIcon()
        {
            if (string.IsNullOrEmpty(tBox_Name.Text) || string.IsNullOrWhiteSpace(tBox_Name.Text))
            {
                pBox_icon.BackgroundImage = null;
                return;
            }
            if (File.Exists(tBox_Name.Text))
                pBox_icon.BackgroundImage = new Bitmap(tBox_Name.Text);
            else
                pBox_icon.BackgroundImage = null;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Contains("Select"))
                SelectFile();
            else if (button.Name.Contains("Save"))
                SaveFile();
            else if(button.Name.Contains("Clear"))
                ClearFile();
            else if(button.Name.Contains("Close"))
                Close();
        }
        void SelectFile()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = " 请选择您要导入的模板文件：";
            openfile.Filter = "图片(*.png)|*.png|图片(*.jpg)|*.jpg";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                tBox_Name.Text = openfile.FileName;
                RefPreviewIcon();
            }
            openfile.Dispose();
        }

        void SaveFile()
        {
            INIOperatorSys.Write(cfg_full_path, "Icon", "Name", tBox_Name.Text);
            INIOperatorSys.Write(cfg_full_path, "Icon", "Size", (int)numUpDown_Size.Value);
            INIOperatorSys.Write(cfg_full_path, "Icon", "Border", (int)numUpDown_Border.Value);
            INIOperatorSys.Write(cfg_full_path, "Icon", "BorderCol", ccBox_BorderCol.SelectedColor.ToHexValue());
            Close();
        }

        void ClearFile()
        {
            tBox_Name.Text = "";
            INIOperatorSys.Write(cfg_full_path, "Icon", "Name", "");
            RefPreviewIcon();
        }
    }
}
