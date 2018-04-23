using DevExpress.Xpf.Charts;
using System;
using System.Windows;

namespace ValuesOfDateTimeScale {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ChartControl_AxisScaleChanged(object sender, DevExpress.Xpf.Charts.AxisScaleChangedEventArgs e) {
            AxisX2D axisX2D = e.Axis as AxisX2D;
            if (axisX2D == null) return;
            ContinuousDateTimeScaleOptions options = new ContinuousDateTimeScaleOptions();
            if (options == null) return;
            axisX2D.Title = new AxisTitle {
                Visible = true,
                Content = String.Format(
                    "The Axis Grid Alignment Unit is {0}\r\nThe Axis Grid Spacing is {1}",
                    options.GridAlignment,
                    options.GridSpacing
                )
            };
        }
    }
}
