using DevExpress.Drawing;
using DevExpress.XtraReports.UI;

namespace DocumentViewerApp.PredefinedReports
{
    public partial class TestReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TestReport()
        {
            InitializeComponent();
            DXFont itemFont = new DXFont("Raleway", 12);
            DXFont titleFont = new DXFont("Fredericka the Great", 22);


            label1.Font = titleFont;

            foreach (XRControlStyle style in StyleSheet)
            {
                style.Font = itemFont;
            }
        }
    }
}
