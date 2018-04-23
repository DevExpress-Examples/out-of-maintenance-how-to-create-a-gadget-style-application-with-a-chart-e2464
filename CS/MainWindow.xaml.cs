using System.Windows;
using DevExpress.Xpf.Charts;

namespace WpfChartGadget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillChartWithTestData();
            PositionChartAboveTheTaskbar();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void FillChartWithTestData()
        {
            chartControl1.Diagram.Series[0].ArgumentScaleType = ScaleType.Numerical;
            chartControl1.Diagram.Series[0].ValueScaleType = ScaleType.Numerical;

            chartControl1.Diagram.Series[0].Points.Add(new SeriesPoint(1, 0.1));
            chartControl1.Diagram.Series[0].Points.Add(new SeriesPoint(2, 0.5));
            chartControl1.Diagram.Series[0].Points.Add(new SeriesPoint(3, 0.2));
            chartControl1.Diagram.Series[0].Points.Add(new SeriesPoint(4, 0.3));
        }

        private void PositionChartAboveTheTaskbar()
        {
            this.Left = SystemParameters.WorkArea.Width - this.Width;
            this.Top = SystemParameters.WorkArea.Height - this.Height;
        }

    }
}
