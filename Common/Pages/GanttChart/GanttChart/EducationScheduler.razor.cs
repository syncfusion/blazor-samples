#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Data;
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class EducationScheduler
    {
        [CascadingParameter]
        protected MainLayout Layout { get; set; }
        SfGantt<EducationSchedulerData.EducationCourseModel> ganttInstance;
        List<EducationSchedulerData.EducationCourseModel> EducationCollection { get; set; }
        List<EducationSchedulerData.SegmentModel> SegmentCollection { get; set; }
        string SubjectCode = string.Empty;
        string AcademicPeriod = string.Empty;
        string AcademicSemester = string.Empty;
        string ProfessorName = string.Empty;
        string ProfessorNameTooltip = string.Empty;
        string GroupByContent = "Default";
        string[] GroupByName = new string[] { "Default", "Professor", "Exams" };
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

        Query QueryCollection = new Query();
        bool isBatchColumnVisible = true;
        bool isProfessorVisible = true;
        bool isPortionCompletionVisible = true;
        static string LabelColor;
        static string SarchInputBackgroundColor;
        bool SidebarToggle = false;
        public bool IsSideBar = false;
        int SplitterColumnIndex = 0;
        string SubjectNameColumnWidth = "265";
        DateTime ProjectStartDate = new DateTime(2023, 08, 25);
        DateTime ProjectEndDate = new DateTime(2027, 05, 30);
        protected override async Task OnInitializedAsync()
        {
            Layout.Collapse();
            GetCurrentTheme(NavigationManager.Uri);
            EducationCollection = AddIndicators(EducationSchedulerData.EducationCourses);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            if (SampleService.IsDevice) 
            {
                SplitterColumnIndex = 2;
                SubjectNameColumnWidth = "220";
            }
            else
            {
                SplitterColumnIndex = 3;
                SubjectNameColumnWidth = "265";
            }
            await Task.CompletedTask;
        }

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
                    else if ((course.Term != null && course.CourseName != null) && (course.Term.Contains("Midterms") || course.Term.Contains("Finals") || course.CourseName.Contains("Midterms") || course.CourseName.Contains("Finals")))
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

        private async Task SetProfessorName(string value)
        {
            ProfessorNameTooltip = value;
            await Task.CompletedTask;
        }

        private string GetProfessorImgHandler()
        {
            string[] professors = { "fullerking", "jack", "jackdavolio", "margaretbuchanan", "martintamer", "rosefuller", "vanjack" };
            Random random = new Random();
            int randomIndex = random.Next(professors.Length);
            string randomString = professors[randomIndex];
            return randomString;
        }
       
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
       
        private void SubjectCodeHandler(string value)
        {
            SubjectCode = value;
        }

        private void AcademicPeriodHandler(string value)
        {
            AcademicPeriod = value;
        }

        private void AcademicSemesterHandler(string value)
        {
            AcademicSemester = value;
        }

        private void ProfessorNameHandler(string value)
        {
            ProfessorName = value;
        }

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
        
        private void ClearFilterHandler(MouseEventArgs args)
        {
            SubjectCode = string.Empty;
            AcademicSemester = string.Empty;
            ProfessorName = string.Empty;
            AcademicPeriod = string.Empty;
            QueryCollection = new Query();
        }

        private async Task PrepareProfessorCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.ProfessorsCollection);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            isBatchColumnVisible = true;
            isProfessorVisible = false;
            isPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask;
        }

        private async Task SetExamCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.ExamCollection, true);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            isBatchColumnVisible = false;
            isProfessorVisible = false;
            isPortionCompletionVisible = false;
            QueryCollection = new Query();
            await Task.CompletedTask;
        }

        private async Task SetDefaultCollection()
        {
            EducationCollection = new List<EducationSchedulerData.EducationCourseModel>();
            SegmentCollection = new List<EducationSchedulerData.SegmentModel>();
            await Task.Delay(1000);
            EducationCollection = AddIndicators(EducationSchedulerData.EducationCourses);
            SegmentCollection = GetSegmentCollection(EducationCollection);
            isBatchColumnVisible = true;
            isProfessorVisible = true;
            isPortionCompletionVisible = true;
            QueryCollection = new Query();
            await Task.CompletedTask;
        }
        private void onToggleClick()
        {
            SidebarToggle = !SidebarToggle;
            IsSideBar = true;
        }
        public void Close()
        {
            SidebarToggle = false;
        }

        private async Task DataBoundHandler()
        {
            if (!isBatchColumnVisible)
            {
                await ganttInstance.ScrollToTimelineAsync(new DateTime(2023, 10, 12));
            }
            else
            {
                await ganttInstance.ScrollToTimelineAsync(ProjectStartDate);
            }
            await Task.CompletedTask;
        }
    }
}