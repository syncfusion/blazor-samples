#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.QueryBuilder;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class AdvancedFiltering
    {
        public SfGantt<FilterData.TaskData>? GanttInstance { get; set; }
        public List<FilterData.TaskData> TaskCollection { get; set; } = new List<FilterData.TaskData>();
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        public List<ToolbarItem> ToolbarItems = new List<ToolbarItem>()
        {
            new ToolbarItem() { Text = "Advanced Filters",TooltipText = "Advanced Filters", Id = "Advanced_Filters" ,PrefixIcon = "e-filter-icon", Align = ItemAlign.Right }
        };        
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        public bool IsSidebarOpen { get; set; }
        public bool IsSidebarVisible { get; set; }
        public Query? SearchQuery { get; set; }
        public IEnumerable<ColumnDetail> QueryBuilderDataSource { get; set; }
        public SfQueryBuilder<ColumnDetail> QueryBuilder { get; set; }
        private string filterQuery = string.Empty;
        private bool querybuilderevent = false;
        private WhereFilter columnPredicate = new WhereFilter();
        private List<WhereFilter> filterPredicates = new List<WhereFilter>();
        private WhereFilter predicateValue;        

        /// <summary>
        /// Handles the row selection event in the Gantt Chart.
        /// Closes the sidebar and stores the current filter query.
        /// </summary>
        public void OnRowSelected(RowSelectEventArgs<FilterData.TaskData> args)
        {
            IsSidebarOpen = false;
            if (IsSidebarVisible)
            {
                filterQuery = QueryBuilder.GetSqlFromRules();
                IsSidebarVisible = false;
            }
        }

        /// <summary>
        /// Handles toolbar click events.
        /// Opens the advanced filter sidebar when the corresponding button is clicked.
        /// </summary>
        void ToolbarClickHandler(ClickEventArgs args)
        {
            if (args.Item.Text == "Advanced Filters")
            {
                ToggleSidebar();
            }
        }

        /// <summary>
        /// Updates the filter rule based on changes in the QueryBuilder.
        /// Sets the search query for the Gantt Chart accordingly.
        /// </summary>
        private void UpdateRule(Syncfusion.Blazor.QueryBuilder.RuleChangeEventArgs args)
        {
            predicateValue = QueryBuilder.GetPredicate(args.Rule);
            if (args.Type == "DeleteRule" && predicateValue != null)
            {
                SearchQuery = new Query().Where(predicateValue);
            }
            else if (predicateValue == null && args.Type == "DeleteRule")
            {
                columnPredicate = WhereFilter.And(filterPredicates);
                SearchQuery = new Query().Where(columnPredicate);
            }
        }

        /// <summary>
        /// Called when the QueryBuilder is created.
        /// Restores previous filter rules if available.
        /// </summary>
        private void OnCreated()
        {
            querybuilderevent = true;
            if (!string.IsNullOrEmpty(filterQuery))
            {
                QueryBuilder.SetRulesFromSql(filterQuery);
            }
        }

        /// <summary>
        /// Applies the current filter rules to the Gantt Chart.
        /// </summary>
        private void ApplyFilters()
        {
            if (predicateValue != null)
            {
                SearchQuery = new Query().Where(predicateValue);
            }
            else
            {
                columnPredicate = WhereFilter.And(filterPredicates);
                SearchQuery = new Query().Where(columnPredicate);
            }
        }

        /// <summary>
        /// Clears all filters and resets the QueryBuilder.
        /// </summary>
        private void ClearFilters()
        {
            QueryBuilder.Reset();
            predicateValue = null;
            SearchQuery = new Query();
        }

        /// <summary>
        /// Closes the advanced filter sidebar and stores the current filter query.
        /// </summary>
        public void CloseSidebar()
        {
            filterQuery = QueryBuilder.GetSqlFromRules();
            IsSidebarOpen = false;
            IsSidebarVisible = false;
        }

        /// <summary>
        /// Toggles the visibility of the advanced filter sidebar.
        /// Updates the filter query if the QueryBuilder is initialized.
        /// </summary>
        private void ToggleSidebar()
        {
            IsSidebarOpen = !IsSidebarOpen;
            IsSidebarVisible = true;
            if (querybuilderevent)
            {
                filterQuery = QueryBuilder.GetSqlFromRules();
            }

            StateHasChanged();
        }

        /// <summary>
        /// Represents a column used in the QueryBuilder for advanced filtering in the Gantt Chart.
        /// </summary>
        public class ColumnDetail
        {
            /// <summary>
            /// Retrieves all column records used for configuring the QueryBuilder.
            /// </summary>
            public static List<ColumnDetail> GetAllRecords()
            {
                return new List<ColumnDetail>();
            }
        }
    }
}
