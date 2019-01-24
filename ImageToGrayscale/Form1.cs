using ImageToGrayscale.Filters;
using OcrPreprocessorLib.Preprocessor.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using OcrPreprocessorLib;
using Tesseract;

namespace ImageToGrayscale
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Bitmap _bitmapApplyFilters;

        private HttpUtils _httpUtils;

        public Form1()
        {
            InitializeComponent();

            _httpUtils = new HttpUtils();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var filters = (from type in System.Reflection.Assembly.GetAssembly(typeof(IFilter)).GetTypes()
                                where typeof(IFilter).IsAssignableFrom(type) && type.IsInterface == false
                                select  (IFilter)Activator.CreateInstance(type)).ToArray();
            cmbFilter.Items.AddRange(filters);
            cmbFilter.DisplayMember = "Name";

            panelRaw.BorderStyle= BorderStyle.FixedSingle;
            panelRaw.AutoScroll = true;
            pictureBoxRaw.Parent = panelRaw;
            pictureBoxRaw.BorderStyle= BorderStyle.None;
            pictureBoxRaw.Location=new Point(0,0);
            pictureBoxRaw.Size = panelRaw.ClientSize;
            pictureBoxRaw.MouseWheel += pictureBoxRaw_MouseWheel;


        }

        private void btnDownloadImage_Click(object sender, EventArgs e)
        {
            var imageUrl = textBox1.Text;

            if(string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Url is not validated.");

            _bitmap = _httpUtils.GetBitmap(new Uri(imageUrl));
            pictureBoxRaw.Image = _bitmap;

            _bitmap.Save(FileUtils.GetNextUniqueFile("12bet_code.png").FullName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "*.png|*.png|*.jpg|*.jpg|*.*|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                _bitmap = new Bitmap(dlg.FileName);
                pictureBoxRaw.Refresh();
                lblWidth.Text = $"Width: {_bitmap.Width}";
                lblHeight.Text = $"Height: {_bitmap.Height}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
#if DEBUG
            _bitmapApplyFilters.Save(FileUtils.GetNextUniqueFile("code.png").FullName);
#else
            var dlg = new SaveFileDialog();
            dlg.DefaultExt = ".png";
            dlg.OverwritePrompt = true;
            dlg.AddExtension = true;
            dlg.CheckPathExists = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _bitmapApplyFilters.Save(dlg.FileName);
            }
#endif
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var bitmap = (Bitmap)_bitmapApplyFilters.Clone();
            Graphics g = Graphics.FromImage(bitmap);

            using(var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", textBoxCharacters.Text);

                using(var page = engine.Process(bitmap, PageSegMode.SingleWord))
                {
                    var text = page.GetText().Trim();
                    textBoxParse.Text = text;

                    using(var iter = page.GetIterator())
                    {

                        //Note that the general result hierarchy is as follows:
                        //Block -> Para -> TextLine -> Word -> Symbol
                        do
                        {
                            do
                            {
                                do
                                {
                                    do
                                    {


                                        if(iter.IsAtBeginningOf(PageIteratorLevel.Block))
                                        {
                                            // do whatever you need to do when a block (top most level result) is encountered.
                                        }
                                        if(iter.IsAtBeginningOf(PageIteratorLevel.Para))
                                        {
                                            // do whatever you need to do when a paragraph is encountered.
                                        }
                                        if(iter.IsAtBeginningOf(PageIteratorLevel.TextLine))
                                        {
                                            // do whatever you need to do when a line of text is encountered is encountered.
                                        }
                                        if(iter.IsAtBeginningOf(PageIteratorLevel.Word))
                                        {
                                            // do whatever you need to do when a word is encountered is encountered.
                                            Rect rect;
                                            iter.TryGetBoundingBox(PageIteratorLevel.Word, out rect);

                                            g.SmoothingMode = SmoothingMode.AntiAlias;
                                            g.DrawRectangle(new Pen(Brushes.Blue), rect.X1, rect.Y1, rect.Width,
                                                rect.Height);
                                        }

                                        // get bounding box for symbol
                                        if(iter.IsAtBeginningOf(PageIteratorLevel.Symbol))
                                        {
                                            // do whatever you want with bounding box for the symbol
                                            Rect symbolBounds;
                                            if(iter.TryGetBoundingBox(PageIteratorLevel.Symbol, out symbolBounds))
                                            {
                                                Rect rect;
                                                iter.TryGetBoundingBox(PageIteratorLevel.Symbol, out rect);

                                                g.SmoothingMode = SmoothingMode.AntiAlias;
                                                g.DrawRectangle(new Pen(Brushes.Red), rect.X1, rect.Y1, rect.Width,
                                                    rect.Height);
                                            }
                                        }
                                    } while(iter.Next(PageIteratorLevel.Word, PageIteratorLevel.Symbol));
                                } while(iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word));
                            } while(iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine));
                        } while(iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para));
                    }
                }
            }

            pictureBoxRegion.Image = bitmap;
        }

        private void btnParseRegions_Click(object sender, EventArgs e)
        {
            //var bitmap = (Bitmap)pictureBoxApplyFilters.Image;
            //using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            //{
            //    engine.SetVariable("tessedit_char_whitelist", "0123456789");

            //    var rects = new Rectangle[]
            //    {
            //        new Rectangle(8, 11, 25, 31),
            //        new Rectangle(32, 11, 25, 31),
            //        new Rectangle(56, 12, 25, 31),
            //        new Rectangle(80, 12, 25, 31)
            //    };

            //    var sb = new StringBuilder();
            //    for (int i = 0; i < rects.Length; i++)
            //    {
            //        var bmp = bitmap.Clone(rects[i], bitmap.PixelFormat);
            //        var picturebox = (PictureBox) this.Controls.Find($"pictureBoxRegionItem{i}", true)[0];
            //        picturebox.Image = bmp;

            //        using (var page = engine.Process(bmp, PageSegMode.SingleChar))
            //        {
            //            var text = page.GetText().Trim();
            //            sb.Append(text);
            //        }
            //    }
            //    textBoxRegions.Text = sb.ToString();
            //}
        }

        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            listBoxFilter.Items.Add(cmbFilter.SelectedItem);
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            var bitmap = _bitmap.Clone(new Rectangle(0, 0, _bitmap.Width, _bitmap.Height), _bitmap.PixelFormat);
            foreach(IFilter filter in listBoxFilter.Items)
            {
                bitmap = filter.Apply(bitmap);
            }
            _bitmapApplyFilters = bitmap;
            pictureBoxApplyFilters.Image = bitmap;
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            var idx = listBoxFilter.SelectedIndex;
            if(idx >= 0) listBoxFilter.Items.RemoveAt(idx);
        }

        private void listBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterOptionPanel.Controls.Clear();
            try
            {
                var filter = (IFilter)listBoxFilter.SelectedItem;
                if (filter == null) return;

                Type t = Type.GetType($"ImageToGrayscale.Filters.FilterOptionsControls.{filter.Id}FilterOptions");
                var ui = Activator.CreateInstance(t, filter);
                //var ui=System.Reflection.Assembly.GetExecutingAssembly().CreateInstance($"{filter.Id}FilterOptions");
                //var ui = GetInstance($"ImageToGrayscale.Filters.{filter.Id}FilterOptions");
                if(ui != null) filterOptionPanel.Controls.Add((UserControl)ui);
            }
            catch(Exception)
            {
            }
        }

        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if(type != null)
                return Activator.CreateInstance(type);
            foreach(var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                type = asm.GetType(strFullyQualifiedName);
                if(type != null)
                    return Activator.CreateInstance(type);
            }
            return null;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MoveUp(listBoxFilter);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MoveDown(listBoxFilter);
        }


        void MoveUp(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if(selectedIndex > 0)
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex + 1);
                myListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        void MoveDown(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if(selectedIndex < myListBox.Items.Count - 1 & selectedIndex != -1)
            {
                myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex);
                myListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        private void btnSaveFilters_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "*.bin|*.bin";
            dlg.AddExtension = true;
            dlg.DefaultExt = ".bin";
            dlg.OverwritePrompt = true;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                var list = new List<Object>();
                for(int i = 0; i < listBoxFilter.Items.Count; i++)
                {
                    list.Add(listBoxFilter.Items[i]);

                }
                SerializableUtils.SerializeToBinary(list, dlg.FileName);
            }
        }

        private void btnLoadFilters_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "*.bin|*.bin";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                listBoxFilter.Items.Clear();
                var list = SerializableUtils.DeserializeFromBinary<List<Object>>(dlg.FileName);
                for(int i = 0; i < list.Count; i++)
                {
                    var o = list[i];
                    listBoxFilter.Items.Add((IFilter)o);
                }
            }
        }


        #region Picture ZoomIn/ZoomOut
        private float zoom = 1;
        // this is for a 1:1 scaling ratio that should be the starting value
        // these are values i used for my testing, i don`t know how you are getting these values
        private int[] Xg = { 10, 80, 25 };

        private int[] Yg = { 5, -40, 5 };

        private int count2 = 3; //Xg.Length;
        private void pictureBoxRaw_Paint(object sender, PaintEventArgs e)
        {

            int Xn = 0;
            int Yn = 0;
            e.Graphics.SmoothingMode = SmoothingMode.Default;

            if (_bitmap != null)
            {
                var srcRect=new Rectangle(0,0,_bitmap.Width,_bitmap.Height);
                var destRect=new Rectangle(0,0,(int)(_bitmap.Width*zoom),(int)(_bitmap.Height*zoom));
                e.Graphics.InterpolationMode= InterpolationMode.NearestNeighbor;
                e.Graphics.DrawImage(_bitmap,destRect,srcRect, GraphicsUnit.Pixel);
            }
            if (zoom > 10)
            {
                for(float y = 0; y <= pictureBoxRaw.Height - 1; y += 1 * zoom)
            {
                e.Graphics.DrawLine(Pens.LightGray, 0, y, pictureBoxRaw.Width, y);
            }


            for(float x = 0; x <= pictureBoxRaw.Width - 1; x += 1 * zoom)
            {
                e.Graphics.DrawLine(Pens.LightGray, x, 0, x, pictureBoxRaw.Height);
            }

            e.Graphics.TranslateTransform((pictureBoxRaw.Width - 1) / 2f, (pictureBoxRaw.Height - 1) / 2f);
            e.Graphics.ScaleTransform(zoom, zoom);

            //for(int i = 0; i <= (count2 - 1); i++)
            //{
            //    e.Graphics.DrawLine(Pens.Black, Xn, Yn, (Xn + Xg[i]), (Yn + Yg[i]));
            //    Xn += Xg[i];
            //    Yn += Yg[i];
            //}
            }
            



            e.Graphics.ResetTransform();
        }

        private void pictureBoxRaw_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRaw.Focus();
        }
        private void pictureBoxRaw_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                // if delta is 120 wheel is scrolled up,  if it is -120 wheel is scrolled down
                zoom += 0.1f;
            }
            else
            {
                zoom -= 0.1f;

            }

            if(zoom < 0.1)
            {
                zoom = 0.1f;
            }

            // do not let zoom reach 0.0
            if((zoom > 10))
            {
                zoom = 10;
            }

            // stops it from zooming more than 10 times the original size
            pictureBoxRaw.Width = (int)(panelRaw.Width * zoom) - 2;
            // subtract 2 to make up for Panel1`s border width
            pictureBoxRaw.Height = (int)(panelRaw.Height * zoom) - 2;
            pictureBoxRaw.Refresh();
            // force the picturebox to repaint itself so the grid and lines are redrawn to the new zoom value
        }

        private Point _startPoint;
        private void pictureBoxRaw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _startPoint = e.Location;
                pictureBoxRaw.Cursor= Cursors.SizeAll;       
            }
        }

        private void pictureBoxRaw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var changePoint=new Point(
                    e.Location.X-_startPoint.X, 
                    e.Location.Y-_startPoint.Y);
                panelRaw.AutoScrollPosition=new Point(
                    -panelRaw.AutoScrollPosition.X-changePoint.X,
                    -panelRaw.AutoScrollPosition.Y-changePoint.Y);
            }
        }
        private void pictureBoxRaw_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxRaw.Cursor= Cursors.Default;
        }

        #endregion

       
    }
}
