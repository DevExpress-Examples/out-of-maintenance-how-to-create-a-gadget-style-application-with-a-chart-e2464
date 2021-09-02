Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace WpfChartGadget
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			FillChartWithTestData()
			PositionChartAboveTheTaskbar()
		End Sub

		Private Sub Window_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
			Me.DragMove()
		End Sub

		Private Sub Window_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
			Me.Close()
		End Sub

		Private Sub FillChartWithTestData()
			chartControl1.Diagram.Series(0).ArgumentScaleType = ScaleType.Numerical
			chartControl1.Diagram.Series(0).ValueScaleType = ScaleType.Numerical

			chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(1, 0.1))
			chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(2, 0.5))
			chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(3, 0.2))
			chartControl1.Diagram.Series(0).Points.Add(New SeriesPoint(4, 0.3))
		End Sub

		Private Sub PositionChartAboveTheTaskbar()
			Me.Left = SystemParameters.WorkArea.Width - Me.Width
			Me.Top = SystemParameters.WorkArea.Height - Me.Height
		End Sub

	End Class
End Namespace
