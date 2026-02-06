#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BlazorDemos.Model
{
    public class ChartConfig : INotifyPropertyChanged
    {
        private string title = string.Empty;
        private bool showLegend;
        private ChartTypeEnum chartType;

        public string Title
        {
            get => title;
            set { title = value; OnPropertyChanged(nameof(Title)); }
        }

        public bool ShowLegend
        {
            get => showLegend;
            set { showLegend = value; OnPropertyChanged(nameof(ShowLegend)); }
        }

        public ChartTypeEnum ChartType
        {
            get => chartType;
            set { chartType = value; OnPropertyChanged(nameof(ChartType)); }
        }

        public ObservableCollection<AxisConfig> XAxis { get; set; } = new();
        public ObservableCollection<AxisConfig> YAxis { get; set; } = new();
        public ObservableCollection<SeriesConfig> Series { get; set; } = new();
        public bool SideBySidePlacement { get; set; } = true;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public class SeriesConfig
    {
        public SeriesType Type { get; set; }
        public string XBindingPath { get; set; } = "XValue";
        public string YBindingPath { get; set; } = "YValue";
        public string Name { get; set; } = string.Empty;
        public ObservableCollection<ChartDataModel> DataSource { get; set; } = new();
        public bool EnableTooltip { get; set; } = true;
        public string Fill { get; set; } = string.Empty;
    }

    public class AxisConfig
    {
        public string Title { get; set; } = string.Empty;
        public AxisType Type { get; set; } = AxisType.Category;
        public double? Minimum { get; set; }
        public double? Maximum { get; set; }
        public double LabelRotation { get; set; } = 0;
    }

    public class ChartDataModel
    {
        public string XValue { get; set; } = string.Empty;
        public double YValue { get; set; }
        public DateTime? DateValue { get; set; }
        public string Category { get; set; } = string.Empty;
        public double Value { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}