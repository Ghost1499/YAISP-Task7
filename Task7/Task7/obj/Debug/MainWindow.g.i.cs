﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07C16A5EA7E7CC8A776F1D886A22317AAF9F4753"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SciChart.Charting;
using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Common;
using SciChart.Charting.Common.AttachedProperties;
using SciChart.Charting.Common.Databinding;
using SciChart.Charting.Common.Extensions;
using SciChart.Charting.Common.Helpers;
using SciChart.Charting.Common.MarkupExtensions;
using SciChart.Charting.HistoryManagers;
using SciChart.Charting.Model;
using SciChart.Charting.Model.ChartData;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Numerics;
using SciChart.Charting.Numerics.CoordinateCalculators;
using SciChart.Charting.Numerics.CoordinateProviders;
using SciChart.Charting.Numerics.DeltaCalculators;
using SciChart.Charting.Numerics.TickProviders;
using SciChart.Charting.Themes;
using SciChart.Charting.ViewportManagers;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.Axes.DiscontinuousAxis;
using SciChart.Charting.Visuals.Axes.LabelProviders;
using SciChart.Charting.Visuals.Axes.LogarithmicAxis;
using SciChart.Charting.Visuals.PointMarkers;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Charting.Visuals.Shapes;
using SciChart.Charting.Visuals.TradeChart;
using SciChart.Charting.Visuals.TradeChart.MultiPane;
using SciChart.Core.AttachedProperties;
using SciChart.Core.MarkupExtensions;
using SciChart.Core.Utility.Mouse;
using SciChart.Data.Model;
using SciChart.Data.Numerics;
using SciChart.Drawing;
using SciChart.Drawing.Common;
using SciChart.Drawing.Extensions;
using SciChart.Drawing.HighQualityRasterizer;
using SciChart.Drawing.HighSpeedRasterizer;
using SciChart.Drawing.XamlRasterizer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Task7;


namespace Task7 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.TradeChart.SciStockChart StockChart;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.FastCandlestickRenderableSeries CandleSeries;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries SarSeries;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.TradeChart.SciStockChart indicatorChar;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries LineSeries;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries ScatterSeries;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Task7;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MainMenu_FileOpen_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StockChart = ((SciChart.Charting.Visuals.TradeChart.SciStockChart)(target));
            return;
            case 3:
            this.CandleSeries = ((SciChart.Charting.Visuals.RenderableSeries.FastCandlestickRenderableSeries)(target));
            return;
            case 4:
            this.SarSeries = ((SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries)(target));
            return;
            case 5:
            this.indicatorChar = ((SciChart.Charting.Visuals.TradeChart.SciStockChart)(target));
            return;
            case 6:
            this.LineSeries = ((SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries)(target));
            return;
            case 7:
            this.ScatterSeries = ((SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

