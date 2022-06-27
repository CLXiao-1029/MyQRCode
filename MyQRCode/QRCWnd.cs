using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyQRCode
{
    public partial class QRCWnd : Form
    {
        string base_path = AppDomain.CurrentDomain.BaseDirectory;
        string cfg_full_path;
        QRCWndIcon wndIcon;
        QRCWndImage wndImage = new QRCWndImage();
        Encoder.Icon en_icon = new Encoder.Icon();
        Bitmap qrcImage = null;
        int picture_x = 0, picture_y = 0;
        public QRCWnd()
        {
            InitializeComponent();
            cfg_full_path = Path.Combine(base_path, "MyQRCode.ini");
            wndIcon = new QRCWndIcon(cfg_full_path);
            picture_x = this.Width - this.ClientRectangle.Width + pictureBox1.Location.X;
            picture_y = this.Height - this.ClientRectangle.Height + pictureBox1.Location.Y;
            Text = "二维码生成器";
            Icon = Properties.Resources.icon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(cfg_full_path))
            {
                INIOperatorSys.Write(cfg_full_path, "Config", "requestedVersion", 5);
                INIOperatorSys.Write(cfg_full_path, "Config", "pixelsPerModule", 7);
                INIOperatorSys.Write(cfg_full_path, "Config", "darkColor", Color.Black.ToHexValue());
                INIOperatorSys.Write(cfg_full_path, "Config", "lightColor", Color.White.ToHexValue());
                INIOperatorSys.Write(cfg_full_path, "Config", "drawQuietZones", true);
                INIOperatorSys.Write(cfg_full_path, "Config", "eccLevel", (int)Encoder.ECCLevel.M);
                INIOperatorSys.Write(cfg_full_path, "Config", "eciMode", (int)Encoder.EciMode.Utf8);
                INIOperatorSys.Write(cfg_full_path, "Config", "forceUtf8", true);
                INIOperatorSys.Write(cfg_full_path, "Config", "utf8BOM", true);
                INIOperatorSys.Write(cfg_full_path, "Icon", "Name", "");
                INIOperatorSys.Write(cfg_full_path, "Icon", "Size", 15);
                INIOperatorSys.Write(cfg_full_path, "Icon", "Border", 2);
                INIOperatorSys.Write(cfg_full_path, "Icon", "BorderCol", Color.White.ToHexValue());
            }
            numUpDown_reqVer.Value = INIOperatorSys.Read(cfg_full_path, "Config", "requestedVersion", 0);
            cBox_pixel.SelectedIndex = INIOperatorSys.Read(cfg_full_path, "Config", "pixelsPerModule", 0) ;
            
            string darkColor = INIOperatorSys.Read(cfg_full_path, "Config", "darkColor", Color.Black.ToHexValue());
            string lightColor = INIOperatorSys.Read(cfg_full_path, "Config", "lightColor", Color.White.ToHexValue());
            ccBox_darkColor.SelectedColor = ColorTranslator.FromHtml(darkColor);
            ccBox_lightColor.SelectedColor = ColorTranslator.FromHtml(lightColor);
            
            cBox_drawQuietZones.Checked = INIOperatorSys.Read(cfg_full_path, "Config", "drawQuietZones", true);
            
            cBox_eccLevel.Items.AddRange(Enum.GetNames(typeof(Encoder.ECCLevel)));
            int eccLevel = INIOperatorSys.Read(cfg_full_path, "Config", "eccLevel", (int)Encoder.ECCLevel.M);
            cBox_eccLevel.SelectedIndex = eccLevel;

            cBox_eciMode.Items.AddRange(Enum.GetNames(typeof(Encoder.EciMode)));
            int eciMode = INIOperatorSys.Read(cfg_full_path, "Config", "eciMode", (int)Encoder.EciMode.Utf8);
            cBox_eciMode.SelectedItem = Enum.GetName(typeof(Encoder.EciMode),eciMode) ;

            cBox_forceUtf8.Checked = INIOperatorSys.Read(cfg_full_path, "Config", "forceUtf8", true);
            cBox_utf8BOM.Checked = INIOperatorSys.Read(cfg_full_path, "Config", "utf8BOM", true);

            CreateQRC();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Contains("addIcon"))
                wndIcon.ShowDialog(this);
            else if (button.Name.Contains("Create"))
                CreateQRC(true);
            else if (button.Name.Contains("Save"))
                SavePicture();
        }

        private void CreateQRC(bool is_save = false)
        {
            qrcImage = Encoder.code(
                textBox1.Text,
                (int)numUpDown_reqVer.Value,
                cBox_pixel.SelectedIndex + 1,
                ccBox_darkColor.SelectedColor,
                ccBox_lightColor.SelectedColor,
                cBox_drawQuietZones.Checked,
                GetEncoderIcon(),
                (Encoder.ECCLevel)cBox_eccLevel.SelectedIndex,
                cBox_forceUtf8.Checked,
                cBox_utf8BOM.Checked,
                (Encoder.EciMode)cBox_eciMode.SelectedIndex
                );
            pictureBox1.BackgroundImage = qrcImage;
            if (is_save)
                SaveFile();
        }

        private Encoder.Icon GetEncoderIcon()
        {
            string icon_name = INIOperatorSys.Read(cfg_full_path, "Icon", "Name", "");
            if (string.IsNullOrEmpty(icon_name) || string.IsNullOrWhiteSpace(icon_name))
                return null;
            en_icon.Name = icon_name;
            en_icon.Size = INIOperatorSys.Read(cfg_full_path, "Icon", "Size", 15);
            en_icon.Border = INIOperatorSys.Read(cfg_full_path, "Icon", "Border", 2);
            string borderCol = INIOperatorSys.Read(cfg_full_path, "Icon", "BorderCol", Color.White.ToHexValue());
            en_icon.BorderCol = ColorTranslator.FromHtml(borderCol);
            return en_icon;
        }

        private void SaveFile()
        {
            INIOperatorSys.Write(cfg_full_path, "Config", "requestedVersion", (int)numUpDown_reqVer.Value);
            INIOperatorSys.Write(cfg_full_path, "Config", "pixelsPerModule", cBox_pixel.SelectedIndex);
            INIOperatorSys.Write(cfg_full_path, "Config", "darkColor", ccBox_darkColor.SelectedColor.ToHexValue());
            INIOperatorSys.Write(cfg_full_path, "Config", "lightColor", ccBox_lightColor.SelectedColor.ToHexValue());
            INIOperatorSys.Write(cfg_full_path, "Config", "drawQuietZones", cBox_drawQuietZones.Checked);
            INIOperatorSys.Write(cfg_full_path, "Config", "eccLevel", cBox_eccLevel.SelectedIndex);
            Encoder.EciMode eciMode = (Encoder.EciMode)Enum.Parse(typeof(Encoder.EciMode), cBox_eciMode.SelectedItem.ToString());
            INIOperatorSys.Write(cfg_full_path, "Config", "eciMode", (int)eciMode);
            INIOperatorSys.Write(cfg_full_path, "Config", "forceUtf8", cBox_forceUtf8.Checked);
            INIOperatorSys.Write(cfg_full_path, "Config", "utf8BOM", cBox_utf8BOM.Checked);
        }

        private void SavePicture()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //设置文件类型 
            saveFileDialog1.Filter = "png(*.png)|*.png|jpg(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|All files(*.*)|*.*";
            //设置默认文件类型显示顺序 
            saveFileDialog1.FilterIndex = 2;
            //保存对话框是否记忆上次打开的目录 
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径 
                string filePath = Path.GetFullPath(saveFileDialog1.FileName);
                string fileExtension = Path.GetExtension(saveFileDialog1.FileName);
                System.Drawing.Imaging.ImageFormat imgformat;
                switch (fileExtension)
                {
                    case ".jpg":
                        imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imgformat = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case ".bmp":
                        imgformat = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    default:
                        imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                }
                //Image img = pictureBox1.Image;
                //img.Save(Path.Combine(filePath, fileName + fileExtension), imgformat);
                Bitmap bitmap = new Bitmap(pictureBox1.BackgroundImage);
                bitmap.Save(filePath, imgformat);
                bitmap.Dispose();
            }
            saveFileDialog1.Dispose();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (qrcImage != null)
            {
                if (qrcImage.Size.Width > pictureBox1.Width 
                    && qrcImage.Size.Height> pictureBox1.Height)
                {
                    if(!wndImage.isShow)
                        wndImage.Show();

                    if (!wndImage.Visible)
                    {
                        wndImage.Size = qrcImage.Size;
                        wndImage.BackgroundImage = qrcImage;
                        wndImage.Location = new Point(Location.X + picture_x, Location.Y + picture_y);
                        wndImage.Visible = true;
                    }
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            wndImage.Visible = false;
        }

        private void QRCWnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            wndImage.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!wndImage.Visible)
            {
                wndImage.Size = qrcImage.Size;
                wndImage.BackgroundImage = qrcImage;
                
                wndImage.Location = new Point( Location.X + picture_x, Location.Y + picture_y);
                wndImage.Visible = true;
            }
        }
    }
}
