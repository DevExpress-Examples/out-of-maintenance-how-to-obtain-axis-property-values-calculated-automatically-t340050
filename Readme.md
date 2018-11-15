<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/ValuesOfAutomaticDateTimeScale/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ValuesOfAutomaticDateTimeScale/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/ValuesOfAutomaticDateTimeScale/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/ValuesOfAutomaticDateTimeScale/MainWindow.xaml))
<!-- default file list end -->
# How to obtain axis property values calculated automatically


This example demonstrates how to obtain axis parameters, which are calculated automatically, for example, in ContinuouslDateTimeScale mode.


<h3>Description</h3>

For this, handle the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_AxisScaleChangedtopic">ChartControl.AxisScaleChanged</a>&nbsp;event. In the event handler, it is possible to obtain axis parameters using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisScaleChangedEventArgs_Axistopic">AxisScaleChangedEventArgs.Axis</a>&nbsp;property. In this example, the property is cast to the ContinuouslDateTimeScale type and its&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsContinuousDateTimeScaleOptions_GridSpacingtopic">ContinuousDateTimeScaleOptions.GridSpacing</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsContinuousDateTimeScaleOptions_GridAlignmenttopic">ContinuousDateTimeScaleOptions.GridAlignment</a>&nbsp;properties are used.

<br/>


