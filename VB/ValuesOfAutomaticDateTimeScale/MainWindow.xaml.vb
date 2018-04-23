Imports DevExpress.Xpf.Charts
Imports System
Imports System.Windows

Namespace ValuesOfDateTimeScale
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ChartControl_AxisScaleChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Charts.AxisScaleChangedEventArgs)
            Dim axisX2D As AxisX2D = TryCast(e.Axis, AxisX2D)
            If axisX2D Is Nothing Then
                Return
            End If
            Dim options As New ContinuousDateTimeScaleOptions()
            If options Is Nothing Then
                Return
            End If
            axisX2D.Title = New AxisTitle With {.Visible = True, .Content = String.Format("The Axis Grid Alignment Unit is {0}" & ControlChars.CrLf & "The Axis Grid Spacing is {1}", options.GridAlignment, options.GridSpacing)}
        End Sub
    End Class
End Namespace
