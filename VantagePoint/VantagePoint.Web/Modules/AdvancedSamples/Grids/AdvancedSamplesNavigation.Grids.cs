using Serenity.Navigation;
using VantagePoint.AdvancedSamples.Pages;

[assembly: NavigationMenu(7951, "Advanced Samples/Grids")]
[assembly: NavigationLink(7951, "Advanced Samples/Grids/Auto Column Width", typeof(AdvancedSamplesController), action: "AutoColumnWidth")]
[assembly: NavigationLink(7951, "Advanced Samples/Grids/Customizable Summaries", typeof(AdvancedSamplesController), action: "CustomizableSummaries")]
[assembly: NavigationLink(7951, "Advanced Samples/Grids/Drag & Drop Grouping", typeof(AdvancedSamplesController), action: "DragDropGrouping")]
[assembly: NavigationLink(7951, "Advanced Samples/Grids/Excel Style Filtering", typeof(AdvancedSamplesController), action: "ExcelStyleFilters")]
[assembly: NavigationLink(7951, "Advanced Samples/Grids/Split Master Detail Grids", typeof(AdvancedSamplesController), action: "SplitMasterDetail")]