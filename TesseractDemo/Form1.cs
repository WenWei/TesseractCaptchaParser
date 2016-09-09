///https://github.com/charlesw/tesseract

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;


namespace TesseractDemo
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "*.png|*.png|*.jpg|*.jpg|*.*|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                _bitmap = new Bitmap(dlg.FileName);
                pictureBoxRaw.Image = _bitmap;
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //var filename = "./Data/code_sample1.png";
            //var filename = "./Data/code_sample.tif";
            var filename = "./Data/numbers.png";

            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default)) {
                engine.SetVariable("tessedit_char_whitelist", "0123456789");
				using (var pix = Pix.LoadFromFile(filename)) {
					using (var page = engine.Process(pix, PageSegMode.SingleLine)) {
						var text = page.GetText().Trim();
					    textBox1.Text = text;
					}
				}
			}
        }
    }
}
