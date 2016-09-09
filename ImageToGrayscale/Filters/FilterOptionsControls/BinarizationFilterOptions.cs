using System;
using System.Windows.Forms;

namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    public partial class BinarizationFilterOptions : UserControl
    {
        private readonly BinarizationFilter _filter;

        public BinarizationFilterOptions(BinarizationFilter filter)
        {
            _filter = filter;
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _filter.Threshold = trackBar1.Value;
            lblThreshold.Text = trackBar1.Value.ToString();
        }

        private void BinarizationFilterOptions_Load(object sender, EventArgs e)
        {
            trackBar1.Value = _filter.Threshold;
            lblThreshold.Text = trackBar1.Value.ToString();
        }
    }
}
