using System;
using System.Windows.Forms;

namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    public partial class GrayFilterOptions : UserControl
    {
        private readonly GrayFilter _filter;

        public GrayFilterOptions(GrayFilter filter)
        {
            _filter = filter;
            InitializeComponent();
        }

        private void GrayFilterOptions_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(GrayAlgorithmType)))
            {
                comboBoxType.Items.Add(item);
            }

            comboBoxType.SelectedText = _filter.Type.ToString();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _filter.Type = (GrayAlgorithmType)Enum.Parse(typeof (GrayAlgorithmType), comboBoxType.SelectedItem.ToString());
        }
    }
}
