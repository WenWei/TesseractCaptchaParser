using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    public partial class ResizeFilterOptions : UserControl
    {
        private readonly ResizeFilter _filter;

        public ResizeFilterOptions(ResizeFilter filter)
        {
            _filter = filter;
            InitializeComponent();
        }


        private void ResizeFilterOptions_Load(object sender, EventArgs e)
        {
            numWidth.Value = _filter.Size.Width;
            numHeight.Value = _filter.Size.Height;
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            _filter.Size = new Size((int)numWidth.Value, _filter.Size.Height);
        }
        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            _filter.Size = new Size(_filter.Size.Width, (int)numHeight.Value);
        }

    }
}
