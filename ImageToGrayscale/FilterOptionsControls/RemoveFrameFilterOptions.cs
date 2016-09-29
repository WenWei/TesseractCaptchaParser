using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OcrPreprocessorLib.Preprocessor.Filters;

namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    public partial class RemoveFrameFilterOptions : UserControl
    {
        private readonly RemoveFrameFilter _filter;

        public RemoveFrameFilterOptions(RemoveFrameFilter filter)
        {
            _filter = filter;
            InitializeComponent();
        }

        private void RemoveFrameFilterOptions_Load(object sender, EventArgs e)
        {
            numTop.Value = _filter.Padding.Top;
            numLeft.Value = _filter.Padding.Left;
            numRight.Value = _filter.Padding.Right;
            numBottom.Value = _filter.Padding.Bottom;
            pictureBox1.BackColor = _filter.Color;
        }

        private void numBottom_ValueChanged(object sender, EventArgs e)
        {
            _filter.Padding.Bottom = (int)numBottom.Value;
        }

        private void numLeft_ValueChanged(object sender, EventArgs e)
        {
            _filter.Padding.Left = (int)numLeft.Value;
        }

        private void numTop_ValueChanged(object sender, EventArgs e)
        {
            _filter.Padding.Top = (int)numTop.Value;
        }

        private void numRight_ValueChanged(object sender, EventArgs e)
        {
            _filter.Padding.Right = (int)numRight.Value;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDlg.Color;
                _filter.Color = colorDlg.Color;
            }
        }

        private void btnColorBlack_Click(object sender, EventArgs e)
        {
             pictureBox1.BackColor = Color.FromArgb(255,0,0,0);
                _filter.Color = Color.FromArgb(255,0,0,0);
        }

        private void btnColorWhite_Click(object sender, EventArgs e)
        {
             pictureBox1.BackColor = Color.FromArgb(255,255,255,255);
            _filter.Color = Color.FromArgb(255, 255, 255, 255);
        }
    }
}
