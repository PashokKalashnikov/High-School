using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Lvl_2_Math_Project
{
    public partial class Images : Form
    {
        public Images()
        {
            InitializeComponent();
        }

        DirectoryInfo di = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "/PicPuzImages"));
        
        private void Images_Load(object sender, EventArgs e)
        {
            FileInfo[] fi = di.GetFiles();
            
            foreach (FileInfo fiNames in fi)
            {
                listBox1.Items.Add(fiNames.Name.ToString());
            }

            ChooseButton.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo[] fi = di.GetFiles();

            try
            {
                string sPictureName = fi[listBox1.SelectedIndex].Name;
                Previewpx.Image = ResizeImage(Image.FromFile(fi[listBox1.SelectedIndex].FullName), 256, 256);
                ChooseButton.Enabled = true;
            }
            catch
            {
                Previewpx.Image = null;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height) // https://stackoverflow.com/questions/1922040/how-to-resize-an-image-c-sharp
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            FileInfo[] fi = di.GetFiles();

            lblPicName.Text = fi[listBox1.SelectedIndex].Name;
            PicturePuzzle.Instance.OrPix.pictureBox1.Image = Original_px.Instance.pictureBox1.Image = Image.FromFile(fi[listBox1.SelectedIndex].FullName);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        
        private void Images_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
