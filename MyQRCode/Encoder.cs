using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQRCode
{
    internal static class Encoder
    {
        /// <summary>
        /// 编码格式
        /// </summary>
        public enum EciMode
        {
            Default = 0,
            Iso8859_1 = 3,
            Iso8859_2 = 4,
            Utf8 = 26
        }
        /// <summary>
        /// 容错等级
        /// </summary>
        public enum ECCLevel
        {
            L,
            M,
            Q,
            H
        }
        /// <summary>
        /// 二维码图标
        /// </summary>
        public class Icon
        {
            public string Name { get; set; }

            private int size = 15;
            /// <summary>
            /// 图标大小
            /// </summary>
            public int Size
            {
                get { return size; }
                set { size = value; }
            }
            private int border = 2;
            /// <summary>
            /// 边框尺寸
            /// </summary>
            public int Border
            {
                get { return border; }
                set { border = value; }
            }
            /// <summary>
            /// 边框颜色
            /// </summary>
            public Color? BorderCol { get; set; }
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="plainText">转二维码文本</param>
        /// <param name="version">版本 1 ~ 40</param>
        /// <param name="pixel">像素点大小</param>
        /// <param name="darkColor">暗色块</param>
        /// <param name="lightColor">亮色块</param>
        /// <param name="drawQuietZones">绘制安静区域。二维码白边</param>
        /// <param name="icon">图标</param>
        /// <param name="level">容错等级。0~3，默认1级</param>
        /// <param name="forceUtf8">强制Utf-8。默认开启，如果有乱码可以将其关闭。</param>
        /// <param name="utf8BOM">开启Utf-8BOM。默认开启，如果有乱码可以将其关闭。</param>
        /// <param name="eciMode">编码。默认UTF-8，如果扫描不出来，可以将编码改为 Default</param>
        /// <returns>返回二维码图片</returns>
        public static Bitmap code(string plainText, int version, int pixel, Color ?darkColor =null, Color? lightColor=null, bool drawQuietZones = true, Icon icon  = null, ECCLevel level = ECCLevel.M, bool forceUtf8 = false, bool utf8BOM = false, EciMode eciMode = EciMode.Utf8)
        {
            QRCoder.QRCodeGenerator code_generator = new QRCoder.QRCodeGenerator();
            
            QRCoder.QRCodeData code_data = code_generator.CreateQrCode(
                plainText,
                (QRCoder.QRCodeGenerator.ECCLevel)level,
                forceUtf8,
                utf8BOM, 
                (QRCoder.QRCodeGenerator.EciMode)eciMode,
                version);

            QRCoder.QRCode code = new QRCoder.QRCode(code_data);

            Color _darkColor = darkColor.HasValue ? darkColor.Value : Color.Black;
            Color _lightColor = lightColor.HasValue ? lightColor.Value : Color.White;
            if (icon != null)
            {
                Bitmap bit_icon = new Bitmap(icon.Name);
                //Color color = icon.Value.BorderCol.HasValue? icon.Value.BorderCol.Value : Color.White;
                return code.GetGraphic(
                    pixel,
                    _darkColor,
                    _lightColor,
                    bit_icon,
                    icon.Size,
                    icon.Border,
                    drawQuietZones,
                    icon.BorderCol);
            }
            Bitmap bmp = code.GetGraphic(pixel, _darkColor, _lightColor, drawQuietZones);
            return bmp;
        }
        /// <summary>
        /// ColorTranslator.ToHtml()
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string ToHexValue(this Color color) 
        { 
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2"); 
        }
    }
}
