using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.QueryBuilder;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class AdvancedFiltering
    {
        internal SfGantt<FilterData.TaskData>? GanttInstance { get; set; }
        internal List<FilterData.TaskData> TaskCollection { get; set; } = new List<FilterData.TaskData>();
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        internal List<ToolbarItem> ToolbarItems = new List<ToolbarItem>()
        {
            new ToolbarItem() { Text = "Advanced Filters",TooltipText = "Advanced Filters", Id = "Advanced_Filters" ,PrefixIcon = "e-filter-icon", Align = ItemAlign.Right }
        };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        public bool IsSidebarOpen { get; set; }
        public bool IsSidebarVisible { get; set; }
        public Query? SearchQuery { get; set; }
        private IEnumerable<ColumnDetail> QueryBuilderDataSource { get; set; } = Enumerable.Empty<ColumnDetail>();
        private SfQueryBuilder<ColumnDetail> QueryBuilder { get; set; } = default!;
        private string filterQuery = string.Empty;
        private bool querybuilderevent;
        private WhereFilter columnPredicate = new WhereFilter();
        private List<WhereFilter> filterPredicates = new List<WhereFilter>();
        private WhereFilter? predicateValue;

        /// <summary>
        /// Initializes the Advanced Filtering sample with task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = FilterData.GetTaskCollection();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the row selection event in the Gantt Chart.
        /// Closes the sidebar and stores the current filter query.
        /// </summary>
        private void OnRowSelected(RowSelectEventArgs<FilterData.TaskData> args)
        {
            IsSidebarOpen = false;
            if (IsSidebarVisible)
            {
                filterQuery = QueryBuilder?.GetSqlFromRules() ?? string.Empty;
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
            predicateValue = QueryBuilder?.GetPredicate(args.Rule);
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
                QueryBuilder?.SetRulesFromSql(filterQuery);
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
            QueryBuilder?.Reset();
            predicateValue = null;
            SearchQuery = new Query();
        }

        /// <summary>
        /// Closes the advanced filter sidebar and stores the current filter query.
        /// </summary>
        public void CloseSidebar()
        {
            filterQuery = QueryBuilder?.GetSqlFromRules() ?? string.Empty;
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
                filterQuery = QueryBuilder?.GetSqlFromRules() ?? string.Empty;
            }

            StateHasChanged();
        }
    }
}
