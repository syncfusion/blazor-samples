using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class EducationScheduler
    {
        [CascadingParameter]
        private MainLayout? Layout { get; set; }
        public SfGantt<EducationCourseModel>? GanttInstance { get; set; }
        internal List<EducationCourseModel> EducationCollection { get; set; } = new List<EducationCourseModel>();
        internal List<SegmentModel> SegmentCollection { get; set; } = new List<SegmentModel>();
        public string SubjectCode { get; set; } = string.Empty;
        public string AcademicPeriod { get; set; } = string.Empty;
        public string AcademicSemester { get; set; } = string.Empty;
        public string ProfessorName { get; set; } = string.Empty;
        public string ProfessorNameTooltip { get; set; } = string.Empty;
        public string GroupByContent { get; set; } = "Default";
        private bool ganttCreated { get; set; }
        public Query QueryCollection { get; set; } = new Query();
        public bool IsBatchColumnVisible { get; set; } = true;
        public bool IsProfessorVisible { get; set; } = true;
        public bool IsPortionCompletionVisible { get; set; } = true;
        internal static string? LabelColor;
        internal static string? SarchInputBackgroundColor;
        public bool SidebarToggle { get; set; }
        public bool IsSideBar { get; set; }
        public int SplitterColumnIndex { get; set; }
        public string SubjectNameColumnWidth { get; set; } = "265";
        public DateTime ProjectStartDate { get; set; } = new DateTime(2023, 08, 25);
        public DateTime ProjectEndDate { get; set; } = new DateTime(2027, 05, 30);
        string[] GroupByName { get; set; } = new string[] { "Default", "Professor", "Exams" };
        string[] EducationYears { get; set; } = new string[]
        {
            "Freshman Year",
            "Sophomore Year",
            "Junior Year",
            "Senior Year"
        };

        string[] Semesters { get; set; } = new string[]
        {
            "Fall semester",
            "Spring semester"
        };

        string[] ProfessorNames { get; set; } = new string[]
        {
            "Dr. John Smith",
            "Dr. Emily Johnson",
            "Dr. Sarah Davis",
            "Dr. Robert Wilson",
            "Dr. Michael Brown",
            "Dr. Lisa Wang",
            "Dr. Jennifer Lee",
            "Dr. David Chen",
            "Dr. Rachel Green",
            "Dr. Alan Turing",
            "Dr. Grace Hopper",
            "Dr. Tim Berners-Lee",
            "Dr. Linus Torvalds",
            "Dr. Andrew Ng",
            "Dr. Ada Lovelace",
            "Dr. Bruce Schneier"
        };

        /// <summary>
        /// Initializes the component, sets theme and data collections, and configures layout and splitter settings.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            Layout?.Collapse();
            GetCurrentTheme(NavigationManager.Uri);
            EducationCollection = AddIndicators(EducationSchedulerData.EducationCourses);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            if (CustomSampleService.IsDevice)
            {
                SplitterColumnIndex = 2;
                SubjectNameColumnWidth = "220";
            }
            else
            {
                SplitterColumnIndex = 3;
                SubjectNameColumnWidth = "265";
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Adds Gantt indicators for each course based on term and exam settings.
        /// </summary>
        /// <param name="courseModels">The course collection to enrich with indicators.</param>
        /// <param name="isExam">A value indicating whether the current collection contains exam items.</param>
        /// <returns>The updated course collection with indicators applied.</returns>
        private static List<EducationCourseModel> AddIndicators(List<EducationCourseModel> courseModels, bool isExam = false)
        {
            foreach (EducationCourseModel course in courseModels)
            {
                if (!isExam)
                {
                    if (course != null && course.Duration != null && !string.IsNullOrEmpty(course.Term) && !course.Term.Contains("Midterms", StringComparison.OrdinalIgnoreCase) && !course.Term.Contains("Finals", StringComparison.OrdinalIgnoreCase))
                    {
                        DateTime startDate = course.StartDate;
                        course.Indicators.Clear();
                        course.Indicators.Add(new GanttIndicator
                        {
                            IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                            Date = startDate.AddDays(-2),
                            Tooltip = $"Professor : {course.Professor}"
                        });
                    }
                    else if (course != null && course.Term != null && course.CourseName != null && (course.Term.Contains("Midterms", StringComparison.OrdinalIgnoreCase) || course.Term.Contains("Finals", StringComparison.OrdinalIgnoreCase) || course.CourseName.Contains("Midterms", StringComparison.OrdinalIgnoreCase) || course.CourseName.Contains("Finals", StringComparison.OrdinalIgnoreCase)))
                    {
                        DateTime startDate = course.StartDate;
                        if (!string.IsNullOrEmpty(course.Duration))
                        {
                            course.Indicators.Clear();
                            course.Indicators.Add(new GanttIndicator
                            {
                                IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                                Date = startDate.AddDays(-2),
                                Tooltip = $"Exam : {course.Term}"
                            });
                        }
                    }
                }
                else
                {
                    if (course.Term != null && (!course.Term.Contains("Midterms", StringComparison.OrdinalIgnoreCase) || !course.Term.Contains("Finals", StringComparison.OrdinalIgnoreCase)))
                    {
                        DateTime startDate = course.StartDate;
                        if (!string.IsNullOrEmpty(course.Duration))
                        {
                            course.Indicators.Clear();
                            course.Indicators.Add(new GanttIndicator
                            {
                                IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                                Date = startDate.AddDays(-2),
                                Tooltip = $"Term : {course.Term}"
                            });
                        }
                    }
                }
            }
            return courseModels;
        }

        /// <summary>
        /// Sets label and search input colors based on the current theme in the URL.
        /// </summary>
        /// <param name="navURL">The navigation URL used to detect the active theme.</param>
        private static void GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark", StringComparison.OrdinalIgnoreCase) || navURL.Contains("highcontrast", StringComparison.OrdinalIgnoreCase))
            {
                LabelColor = "#FFFFFF";
                SarchInputBackgroundColor = "#141414";
            }
            else
            {
                LabelColor = "#242424";
                SarchInputBackgroundColor = "#F5F5F5";
            }
        }

        /// <summary>
        /// Updates the professor name tooltip with the provided value.
        /// </summary>
        /// <param name="value">The professor name or tooltip text.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task SetProfessorName(string value)
        {
            ProfessorNameTooltip = value;
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Returns a random professor image key from a predefined list.
        /// </summary>
        /// <returns>A random professor image key.</returns>
        private static string GetProfessorImgHandler()
        {
            string[] professors = { "fullerking", "jack", "jackdavolio", "margaretbuchanan", "martintamer", "rosefuller", "vanjack" };
            //int randomIndex = Random.Shared.Next(professors.Length);
            int randomIndex = System.Security.Cryptography.RandomNumberGenerator.GetInt32(professors.Length);
            string randomString = professors[randomIndex];
            return randomString;
        }

        /// <summary>
        /// Generates segmented course durations excluding holidays for Gantt rendering.
        /// </summary>
        /// <param name="courses">The course collection used to build split segments.</param>
        /// <returns>The segmented collection for Gantt rendering.</returns>
        private static List<SegmentModel> GetSegmentCollection(List<EducationCourseModel> courses)
        {
            List<SegmentModel> segments = new List<SegmentModel>();
            var count = 0;
            foreach (var course in courses)
            {
                if (course.Duration != null)
                {
                    DateTime currentStartDate = course.StartDate;
                    DateTime courseEndDate = course.StartDate.AddDays(double.Parse(course.Duration, CultureInfo.InvariantCulture));

                    var minusDay = 1;
                    while (currentStartDate < courseEndDate)
                    {
                        DateTime currentEndDate = currentStartDate.AddDays(1);

                        bool isHoliday = EducationSchedulerData.HolidayCollection.Any(h => h.Date.Date == currentStartDate.Date);
                        if (isHoliday)
                        {
                            currentStartDate = currentEndDate;
                            continue;
                        }
                        while (currentEndDate < courseEndDate)
                        {
                            bool isNextDateHoliday = EducationSchedulerData.HolidayCollection.Any(h => h.Date.Date.AddDays(-minusDay) == currentEndDate.Date);
                            if (isNextDateHoliday)
                            {
                                count++;
                                minusDay++;
                                segments.Add(new SegmentModel() { Id = count, CourseId = course.CourseId, StartDate = currentStartDate, EndDate = currentEndDate });
                                currentStartDate = currentEndDate.AddDays(2);
                                break;
                            }

                            currentEndDate = currentEndDate.AddDays(1);
                        }

                        if (currentEndDate >= courseEndDate)
                        {
                            count++;
                            DateTime? previousHoliday = EducationSchedulerData.HolidayCollection.FirstOrDefault(h => h.Date.Date == currentStartDate.Date || h.Date.Date == currentStartDate.AddDays(-1).Date)?.Date;
                            DateTime? nextHoliday = EducationSchedulerData.HolidayCollection.FirstOrDefault(h => h.Date.Date == currentStartDate.Date || h.Date.Date == currentStartDate.AddDays(1).Date)?.Date;

                            if (previousHoliday != null)
                            {
                                currentStartDate = currentStartDate.AddDays(-1);
                            }
                            if (nextHoliday != null)
                            {
                                currentStartDate = currentStartDate.AddDays(1);
                            }
                            segments.Add(new SegmentModel() { Id = count, CourseId = course.CourseId, StartDate = currentStartDate, EndDate = courseEndDate });
                            break;
                        }
                    }
                }

            }
            return segments;
        }

        /// <summary>
        /// Updates the subject code filter with the provided value.
        /// </summary>
        /// <param name="value">The selected subject code.</param>
        private void SubjectCodeHandler(string value)
        {
            SubjectCode = value;
        }

        /// <summary>
        /// Updates the academic period filter with the provided value.
        /// </summary>
        /// <param name="value">The selected academic period.</param>
        private void AcademicPeriodHandler(string value)
        {
            AcademicPeriod = value;
        }

        /// <summary>
        /// Updates the academic semester filter with the provided value.
        /// </summary>
        /// <param name="value">The selected academic semester.</param>
        private void AcademicSemesterHandler(string value)
        {
            AcademicSemester = value;
        }

        /// <summary>
        /// Updates the professor name filter with the provided value.
        /// </summary>
        /// <param name="value">The selected professor name.</param>
        private void ProfessorNameHandler(string value)
        {
            ProfessorName = value;
        }

        /// <summary>
        /// Changes the grouping mode and refreshes data collections accordingly.
        /// </summary>
        /// <param name="value">The selected grouping mode.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task GroupByHandler(string value)
        {
            GroupByContent = value;
            AcademicSemester = string.Empty;
            AcademicPeriod = string.Empty;
            ProfessorName = string.Empty;
            SubjectCode = string.Empty;
            switch (value)
            {
                case "Default":
                    await SetDefaultCollection().ConfigureAwait(true);
                    break;
                case "Professor":
                    await PrepareProfessorCollection().ConfigureAwait(true);
                    break;
                case "Exams":
                    await SetExamCollection().ConfigureAwait(true);
                    break;
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Builds and applies query filters based on current input selections.
        /// </summary>
        /// <param name="args">The mouse event arguments for the filter action.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task FilterHandler(MouseEventArgs args)
        {
            List<WhereFilter> predicateList = new List<WhereFilter>();
            if (!string.IsNullOrEmpty(SubjectCode))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "CourseCode",
                    Operator = "contains",
                    Condition = "and",
                    value = SubjectCode,
                    IgnoreCase = true,
                });
            }
            if (!string.IsNullOrEmpty(ProfessorName))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Professor",
                    Operator = "contains",
                    Condition = "and",
                    value = ProfessorName,
                    IgnoreCase = true,
                });
            }

            if (!string.IsNullOrEmpty(AcademicPeriod))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Department",
                    Operator = "contains",
                    Condition = "and",
                    value = AcademicPeriod,
                    IgnoreCase = true,
                });
            }

            if (!string.IsNullOrEmpty(AcademicSemester))
            {
                predicateList.Add(new WhereFilter()
                {
                    Field = "Term",
                    Operator = "contains",
                    Condition = "and",
                    value = AcademicSemester,
                    IgnoreCase = true,

                });
            }
            if (predicateList.Count == 0)
            {
                QueryCollection = new Query();
            }
            else
            {
                QueryCollection = new Query().Where(WhereFilter.And(predicateList));
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Clears all filter inputs and resets the query.
        /// </summary>
        /// <param name="args">The mouse event arguments for the clear action.</param>
        private void ClearFilterHandler(MouseEventArgs args)
        {
            SubjectCode = string.Empty;
            AcademicSemester = string.Empty;
            ProfessorName = string.Empty;
            AcademicPeriod = string.Empty;
            QueryCollection = new Query();
        }

        /// <summary>
        /// Prepares and loads the professor-grouped dataset and segments.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task PrepareProfessorCollection()
        {
            EducationCollection = new List<EducationCourseModel>();
            SegmentCollection = new List<SegmentModel>();
            await Task.Delay(1000).ConfigureAwait(true);
            EducationCollection = AddIndicators(EducationSchedulerData.ProfessorsCollection);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = true;
            IsProfessorVisible = false;
            IsPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Prepares and loads the exams dataset and corresponding segments.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task SetExamCollection()
        {
            EducationCollection = new List<EducationCourseModel>();
            SegmentCollection = new List<SegmentModel>();
            await Task.Delay(1000).ConfigureAwait(true);
            EducationCollection = AddIndicators(EducationSchedulerData.ExamCollection, true);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = false;
            IsProfessorVisible = false;
            IsPortionCompletionVisible = false;
            QueryCollection = new Query();
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Restores and loads the default dataset and segments.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task SetDefaultCollection()
        {
            EducationCollection = new List<EducationCourseModel>();
            SegmentCollection = new List<SegmentModel>();
            await Task.Delay(1000).ConfigureAwait(true);
            EducationCollection = AddIndicators(EducationSchedulerData.EducationCourses);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = true;
            IsProfessorVisible = true;
            IsPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask.ConfigureAwait(true);
        }
        /// <summary>
        /// Toggles the sidebar visibility state.
        /// </summary>
        private void onToggleClick()
        {
            SidebarToggle = !SidebarToggle;
            IsSideBar = true;
        }

        /// <summary>
        /// Closes the sidebar by resetting the toggle state.
        /// </summary>
        public void Close()
        {
            SidebarToggle = false;
        }

        /// <summary>
        /// Scrolls the Gantt timeline to the appropriate date after data binding.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task DataBoundHandler()
        {
            if (GanttInstance == null)
            {
                return;
            }
            if (!ganttCreated) return;
            if (!IsBatchColumnVisible)
            {
                await GanttInstance.ScrollToTimelineAsync(new DateTime(2023, 10, 12)).ConfigureAwait(true);
            }
            else
            {
                await GanttInstance.ScrollToTimelineAsync(ProjectStartDate).ConfigureAwait(true);
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Marks the Gantt component as created when the Splitter's Created event is triggered.
        /// </summary>
        /// <param name="args">The event arguments.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task CreatedHandler(object args)
        {
            ganttCreated = true;
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}