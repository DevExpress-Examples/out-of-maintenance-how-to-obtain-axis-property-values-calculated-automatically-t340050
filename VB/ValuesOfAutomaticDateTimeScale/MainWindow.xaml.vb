Imports DevExpress.Xpf.Charts
Imports System.Windows

Namespace ValuesOfDateTimeScale

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub ChartControl_AxisScaleChanged(ByVal sender As Object, ByVal e As AxisScaleChangedEventArgs)
            Dim axisX2D As AxisX2D = TryCast(e.Axis, AxisX2D)
            If axisX2D Is Nothing Then Return
            Dim options As ContinuousDateTimeScaleOptions = New ContinuousDateTimeScaleOptions()
            If options Is Nothing Then Return
            axisX2D.Title = New AxisTitle With {.Visible = True, .Content = String.Format("The Axis Grid Alignment Unit is {0}" & Microsoft.VisualBasic.Constants.vbCrLf & "The Axis Grid Spacing is {1}", options.GridAlignment, options.GridSpacing)}
        End Sub
    End Class
End Namespace
