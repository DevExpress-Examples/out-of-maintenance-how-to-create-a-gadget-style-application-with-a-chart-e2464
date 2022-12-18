Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace WpfChartGadget

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            FillChartWithTestData()
            PositionChartAboveTheTaskbar()
        End Sub

        Private Sub Window_MouseLeftButtonDown(ByVal sender As Object, ByVal e As Input.MouseButtonEventArgs)
            DragMove()
        End Sub

        Private Sub Window_MouseDoubleClick(ByVal sender As Object, ByVal e As Input.MouseButtonEventArgs)
            Close()
        End Sub

        Private Sub FillChartWithTestData()
            Me.chartControl1.Diagram.Series(0).ArgumentScaleType = ScaleType.Numerical
            Me.chartControl1.Diagram.Series(0).ValueScaleType = ScaleType.Numerical
            Me.chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(1, 0.1))
            Me.chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(2, 0.5))
            Me.chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(3, 0.2))
            Me.chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(4, 0.3))
        End Sub

        Private Sub PositionChartAboveTheTaskbar()
            Left = SystemParameters.WorkArea.Width - Width
            Top = SystemParameters.WorkArea.Height - Height
        End Sub
    End Class
End Namespace
