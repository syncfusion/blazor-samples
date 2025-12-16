#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class EducationScheduler
    {
        [CascadingParameter]
        protected MainLayout? Layout { get; set; }
        public SfGantt<EducationSchedulerData.EducationCourseModel> GanttInstance { get; set; }
        public List<EducationSchedulerData.EducationCourseModel> EducationCollection { get; set; } = new List<EducationSchedulerData.EducationCourseModel>();
        public List<EducationSchedulerData.SegmentModel> SegmentCollection { get; set; } = new List<EducationSchedulerData.SegmentModel>();
        public string SubjectCode { get; set; } = string.Empty;
        public string AcademicPeriod { get; set; } = string.Empty;
        public string AcademicSemester{ get; set; } = string.Empty;
        public string ProfessorName { get; set; } = string.Empty;
        public string ProfessorNameTooltip { get; set; } = string.Empty;
        public string GroupByContent { get; set; } = "Default";
        private bool ganttCreated { get; set; }
        public string[] GroupByName { get; set; } = new string[] { "Default", "Professor", "Exams" };
        public string[] EducationYears { get; set; } = new string[]
        {
            "Freshman Year",
            "Sophomore Year",
            "Junior Year",
            "Senior Year"
        };

        public string[] Semesters { get; set; } = new string[]
        {
            "Fall semester",
            "Spring semester"
        };

        public string[] ProfessorNames { get; set; } = new string[]
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

        public Query QueryCollection { get; set; } = new Query();
        public bool IsBatchColumnVisible { get; set; } = true;
        public bool IsProfessorVisible { get; set; } = true;
        public bool IsPortionCompletionVisible { get; set; } = true;
        public static string LabelColor;
        public static string SarchInputBackgroundColor;
        public bool SidebarToggle { get; set; } = false;
        public bool IsSideBar { get; set; } = false;
        public int SplitterColumnIndex { get; set; } = 0;
        public string SubjectNameColumnWidth { get; set; } = "265";
        public DateTime ProjectStartDate { get; set; } = new DateTime(2023, 08, 25);
        public DateTime ProjectEndDate { get; set; } = new DateTime(2027, 05, 30);        

        /// <summary>
        /// Adds Gantt indicators for each course based on term and exam settings.
        /// </summary>
        private List<EducationSchedulerData.EducationCourseModel> AddIndicators(List<EducationSchedulerData.EducationCourseModel> courseModels, bool isExam = false)
        {
            foreach (EducationSchedulerData.EducationCourseModel course in courseModels)
            {
                if (!isExam)
                {
                    if (course.Duration != null && !course.Term.Contains("Midterms") && !course.Term.Contains("Finals"))
                    {
                        DateTime startDate = course.StartDate;
                        course.Indicators = new List<GanttIndicator>
                        {
                            new GanttIndicator
                            {
                                IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                                Date = startDate.AddDays(-2),
                                Tooltip = $"Professor : {course.Professor}"
                            }
                        };
                    }
                    else if (course.Term != null && course.CourseName != null && (course.Term.Contains("Midterms") || course.Term.Contains("Finals") || course.CourseName.Contains("Midterms") || course.CourseName.Contains("Finals")))
                    {
                        DateTime startDate = course.StartDate;
                        if (!string.IsNullOrEmpty(course.Duration))
                        {
                            course.Indicators = new List<GanttIndicator>
                            {
                                new GanttIndicator
                                {
                                    IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                                    Date = startDate.AddDays(-2),
                                    Tooltip = $"Exam : {course.Term}"
                                }
                            };
                        }
                    }
                }
                else
                {
                    if (course.Term != null && (!course.Term.Contains("Midterms") || !course.Term.Contains("Finals")))
                    {
                        DateTime startDate = course.StartDate;
                        if (!string.IsNullOrEmpty(course.Duration))
                        {
                            course.Indicators = new List<GanttIndicator>
                            {
                                new GanttIndicator
                                {
                                    IconClass = "e-btn-icon e-bookmark e-icons e-icon-left e-gantt e-bookmark::before",
                                    Date = startDate.AddDays(-2),
                                    Tooltip = $"Term : {course.Term}"
                                }
                            };
                        }
                    }
                }
            }
            return courseModels;
        }

        /// <summary>
        /// Sets label and search input colors based on the current theme in the URL.
        /// </summary>
        private void GetCurrentTheme(string navURL)
        {
            if (navURL.Contains("dark") || navURL.Contains("highcontrast"))
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
        private async Task SetProfessorName(string value)
        {
            ProfessorNameTooltip = value;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Returns a random professor image key from a predefined list.
        /// </summary>
        private string GetProfessorImgHandler()
        {
            string[] professors = { "fullerking", "jack", "jackdavolio", "margaretbuchanan", "martintamer", "rosefuller", "vanjack" };
            Random random = new Random();
            int randomIndex = random.Next(professors.Length);
            string randomString = professors[randomIndex];
            return randomString;
        }

        /// <summary>
        /// Generates segmented course durations excluding holidays for Gantt rendering.
        /// </summary>
        private List<EducationSchedulerData.SegmentModel> GetSegmentCollection(List<EducationSchedulerData.EducationCourseModel> courses)
        {
            List<EducationSchedulerData.SegmentModel> segments = new List<EducationSchedulerData.SegmentModel>();
            var count = 0;
            foreach (var course in courses)
            {
                if (course.Duration != null)
                {
                    DateTime currentStartDate = course.StartDate;
                    DateTime courseEndDate = course.StartDate.AddDays(double.Parse(course.Duration));

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
                                segments.Add(new EducationSchedulerData.SegmentModel() { Id = count, CourseId = course.CourseId, StartDate = currentStartDate, EndDate = currentEndDate });
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
                           
                            if(previousHoliday != null)
                            {
                                currentStartDate = currentStartDate.AddDays(-1);
                            }
                            if(nextHoliday != null)
                            {
                                currentStartDate = currentStartDate.AddDays(1);
                            }
                            segments.Add(new EducationSchedulerData.SegmentModel() { Id = count, CourseId = course.CourseId, StartDate = currentStartDate, EndDate = courseEndDate });
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
        private void SubjectCodeHandler(string value)
        {
            SubjectCode = value;
        }

        /// <summary>
        /// Updates the academic period filter with the provided value.
        /// </summary>
        private void AcademicPeriodHandler(string value)
        {
            AcademicPeriod = value;
        }

        /// <summary>
        /// Updates the academic semester filter with the provided value.
        /// </summary>
        private void AcademicSemesterHandler(string value)
        {
            AcademicSemester = value;
        }

        /// <summary>
        /// Updates the professor name filter with the provided value.
        /// </summary>
        private void ProfessorNameHandler(string value)
        {
            ProfessorName = value;
        }

        /// <summary>
        /// Changes the grouping mode and refreshes data collections accordingly.
        /// </summary>
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
                    await SetDefaultCollection();
                    break;
                case "Professor":
                    await PrepareProfessorCollection();
                    break;
                case "Exams":
                    await SetExamCollection();
                    break;
            }
            await Task.CompletedTask; 
        }

        /// <summary>
        /// Builds and applies query filters based on current input selections.
        /// </summary>
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
            if(predicateList.Count == 0)
            {
                QueryCollection = new Query();
            }
            else
            {
                QueryCollection = new Query().Where(WhereFilter.And(predicateList));
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Clears all filter inputs and resets the query.
        /// </summary>
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
        private async Task PrepareProfessorCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.ProfessorsCollection);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = true;
            IsProfessorVisible = false;
            IsPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Prepares and loads the exams dataset and corresponding segments.
        /// </summary>
        private async Task SetExamCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.ExamCollection, true);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = false;
            IsProfessorVisible = false;
            IsPortionCompletionVisible = false;
            QueryCollection = new Query();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Restores and loads the default dataset and segments.
        /// </summary>
        private async Task SetDefaultCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.EducationCourses);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            IsBatchColumnVisible = true;
            IsProfessorVisible = true;
            IsPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask;
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
        private async Task DataBoundHandler()
        {
            if (!ganttCreated) return;
            if (!IsBatchColumnVisible)
            {
                await GanttInstance.ScrollToTimelineAsync(new DateTime(2023, 10, 12));
            }
            else
            {
                await GanttInstance.ScrollToTimelineAsync(ProjectStartDate);
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Marks the Gantt component as created when the Splitter's Created event is triggered.
        /// </summary>
        private async Task CreatedHandler(object args)
        {
            ganttCreated = true;
            await Task.CompletedTask;
        }
    }
}