<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570032/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T340050)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/ValuesOfAutomaticDateTimeScale/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ValuesOfAutomaticDateTimeScale/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/ValuesOfAutomaticDateTimeScale/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ValuesOfAutomaticDateTimeScale/MainWindow.xaml.vb))
<!-- default file list end -->
# How to obtain axis property values calculated automatically


This example demonstrates how to obtain axis parameters, which are calculated automatically, for example, in ContinuouslDateTimeScale mode.


<h3>Description</h3>

For this, handle the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_AxisScaleChangedtopic">ChartControl.AxisScaleChanged</a>&nbsp;event. In the event handler, it is possible to obtain axis parameters using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsAxisScaleChangedEventArgs_Axistopic">AxisScaleChangedEventArgs.Axis</a>&nbsp;property. In this example, the property is cast to the ContinuouslDateTimeScale type and its&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsContinuousDateTimeScaleOptions_GridSpacingtopic">ContinuousDateTimeScaleOptions.GridSpacing</a>&nbsp;and&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfChartsContinuousDateTimeScaleOptions_GridAlignmenttopic">ContinuousDateTimeScaleOptions.GridAlignment</a>&nbsp;properties are used.

<br/>


