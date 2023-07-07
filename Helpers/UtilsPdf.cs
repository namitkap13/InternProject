using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace SchoolProject.Helpers
{
    public class UtilsPdf
    {
        public static byte[] ConvertBitmapSourceToByteArray(ImageSource imageSource)
        {
            try
            {
                var image = imageSource as BitmapSource;
                byte[] data;
                BitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                using (MemoryStream ms = new MemoryStream())
                {
                    encoder.Save(ms);
                    data = ms.ToArray();
                }
                return data;
            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio un error: " + er.Message);
                return null;
            }

        }
    }
}
