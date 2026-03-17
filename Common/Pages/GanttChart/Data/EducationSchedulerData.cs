#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.Gantt;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class EducationSchedulerData
    {
        public class SegmentModel
        {
            public int Id { get; set; }
            public int CourseId { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }

        public class HolidayModel
        {
            public int Id { get; set; }
            public string HolidayName { get; set; } = string.Empty;
            public DateTime Date { get; set; }
        }

        public class EducationCourseModel
        {
            public int CourseId { get; set; }
            public string Department { get; set; } = string.Empty;
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public string? Duration { get; set; }
            public string CourseCode { get; set; } = string.Empty;
            public string CourseName { get; set; } = string.Empty;
            public string AcademicYear { get; set; } = string.Empty;
            public int? ParentId { get; set; }
            public int Coverage { get; set; }
            public string Professor { get; set; } = string.Empty;
            public string Prerequisite { get; set; } = string.Empty;
            public string Term { get; set; } = string.Empty;
            public List<GanttIndicator>? Indicators { get; set; }
        }

        public static List<HolidayModel> HolidayCollection = new List<HolidayModel>()
        {
            // 2023-2024 Academic Year
            new HolidayModel(){ Id = 1, HolidayName = "Labor Day", Date = new DateTime(2023, 09, 04) },
            new HolidayModel(){ Id = 2, HolidayName = "Fall Break", Date = new DateTime(2023, 10, 09) },
            new HolidayModel(){ Id = 3, HolidayName = "Thanksgiving Break", Date = new DateTime(2023, 11, 23) },
            new HolidayModel(){ Id = 4, HolidayName = "Winter Break Start", Date = new DateTime(2023, 12, 20) },
            new HolidayModel(){ Id = 5, HolidayName = "Martin Luther King Jr. Day", Date = new DateTime(2024, 01, 15) },
            new HolidayModel(){ Id = 6, HolidayName = "Presidents' Day", Date = new DateTime(2024, 02, 19) },
            new HolidayModel(){ Id = 7, HolidayName = "Spring Break Start", Date = new DateTime(2024, 03, 11) },
            new HolidayModel(){ Id = 8, HolidayName = "Memorial Day", Date = new DateTime(2024, 05, 27) },
            new HolidayModel(){ Id = 9, HolidayName = "Independence Day", Date = new DateTime(2024, 07, 04) },

            // 2024-2025 Academic Year
            new HolidayModel(){ Id = 10, HolidayName = "Labor Day", Date = new DateTime(2024, 09, 02) },
            new HolidayModel(){ Id = 11, HolidayName = "Fall Break", Date = new DateTime(2024, 10, 14) },
            new HolidayModel(){ Id = 12, HolidayName = "Thanksgiving Break", Date = new DateTime(2024, 11, 28) },
            new HolidayModel(){ Id = 13, HolidayName = "Winter Break Start", Date = new DateTime(2024, 12, 18) },
            new HolidayModel(){ Id = 14, HolidayName = "Martin Luther King Jr. Day", Date = new DateTime(2025, 01, 20) },
            new HolidayModel(){ Id = 15, HolidayName = "Presidents' Day", Date = new DateTime(2025, 02, 17) },
            new HolidayModel(){ Id = 16, HolidayName = "Spring Break Start", Date = new DateTime(2025, 03, 10) },
            new HolidayModel(){ Id = 17, HolidayName = "Memorial Day", Date = new DateTime(2025, 05, 26) },
            new HolidayModel(){ Id = 18, HolidayName = "Independence Day", Date = new DateTime(2025, 07, 04) },

            // 2025-2026 Academic Year
            new HolidayModel(){ Id = 19, HolidayName = "Labor Day", Date = new DateTime(2025, 09, 01) },
            new HolidayModel(){ Id = 20, HolidayName = "Fall Break", Date = new DateTime(2025, 10, 13) },
            new HolidayModel(){ Id = 21, HolidayName = "Thanksgiving Break", Date = new DateTime(2025, 11, 27) },
            new HolidayModel(){ Id = 22, HolidayName = "Winter Break Start", Date = new DateTime(2025, 12, 17) },
            new HolidayModel(){ Id = 23, HolidayName = "Martin Luther King Jr. Day", Date = new DateTime(2026, 01, 19) },
            new HolidayModel(){ Id = 24, HolidayName = "Presidents' Day", Date = new DateTime(2026, 02, 16) },
            new HolidayModel(){ Id = 25, HolidayName = "Spring Break Start", Date = new DateTime(2026, 03, 09) },
            new HolidayModel(){ Id = 26, HolidayName = "Memorial Day", Date = new DateTime(2026, 05, 25) },
            new HolidayModel(){ Id = 27, HolidayName = "Independence Day", Date = new DateTime(2026, 07, 03) },

            // 2026-2027 Academic Year
            new HolidayModel(){ Id = 28, HolidayName = "Labor Day", Date = new DateTime(2026, 09, 07) },
            new HolidayModel(){ Id = 29, HolidayName = "Fall Break", Date = new DateTime(2026, 10, 12) },
            new HolidayModel(){ Id = 30, HolidayName = "Thanksgiving Break", Date = new DateTime(2026, 11, 26) },
            new HolidayModel(){ Id = 31, HolidayName = "Winter Break Start", Date = new DateTime(2026, 12, 16) },
            new HolidayModel(){ Id = 32, HolidayName = "Martin Luther King Jr. Day", Date = new DateTime(2027, 01, 18) },
            new HolidayModel(){ Id = 33, HolidayName = "Presidents' Day", Date = new DateTime(2027, 02, 15) },
            new HolidayModel(){ Id = 34, HolidayName = "Spring Break Start", Date = new DateTime(2027, 03, 08) },
            new HolidayModel(){ Id = 35, HolidayName = "Memorial Day", Date = new DateTime(2027, 05, 31) },
            new HolidayModel(){ Id = 36, HolidayName = "Independence Day", Date = new DateTime(2027, 07, 05) },
        };


        public static List<EducationCourseModel> EducationCourses => new List<EducationCourseModel>()
        {
            // 2023-2024 Academic Year (Freshman Year)
            new EducationCourseModel(){ CourseId = 1, Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 2, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "CS101", CourseName = "Introduction to Programming", Professor = "Dr. John Smith", Coverage = 100, StartDate = new DateTime(2023, 08, 28), Duration = "16", ParentId = 1, Prerequisite = "" },
            new EducationCourseModel(){ CourseId = 3, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "MATH101", CourseName = "Calculus I", Professor = "Dr. Emily Johnson", Coverage = 100, StartDate = new DateTime(2023, 08, 28), Duration = "16", ParentId = 1, Prerequisite = "" },
            new EducationCourseModel(){ CourseId = 4, Term = "Fall semester midterms", Department = "Freshman year", StartDate = new DateTime(2023, 10, 16), Duration = "7", Coverage = 100, ParentId = 1, Prerequisite = "2,3" },
            new EducationCourseModel(){ CourseId = 5, Term = "Fall semester finals", Department = "Freshman year", StartDate = new DateTime(2023, 12, 11), Duration = "7", Coverage = 100, ParentId = 1, Prerequisite = "2,3,4" },
            new EducationCourseModel(){ CourseId = 6, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "CS102", CourseName = "Data Structures", Professor = "Dr. Sarah Davis", StartDate = new DateTime(2024, 01, 22), Duration = "16", Coverage = 100, ParentId = 1, Prerequisite = "2" },
            new EducationCourseModel(){ CourseId = 7, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "MATH102", CourseName = "Calculus II", Professor = "Dr. Robert Wilson", StartDate = new DateTime(2024, 01, 22), Duration = "16", Coverage = 100, ParentId = 1, Prerequisite = "3" },
            new EducationCourseModel(){ CourseId = 8, Term = "Spring semester midterms", Department = "Freshman year", StartDate = new DateTime(2024, 03, 18), Duration = "7", Coverage = 100, ParentId = 1, Prerequisite = "6,7" },
            new EducationCourseModel(){ CourseId = 9, Term = "Spring semester finals", Department = "Freshman year", StartDate = new DateTime(2024, 05, 13), Duration = "7", Coverage = 100, ParentId = 1, Prerequisite = "6,7,8" },
            // 2024-2025 Academic Year (Sophomore Year)
            new EducationCourseModel(){ CourseId = 10, Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 11, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS201", CourseName = "Algorithms", Professor = "Dr. Michael Brown", Coverage = 100, StartDate = new DateTime(2024, 08, 26), Duration = "16", ParentId = 10, Prerequisite = "6" },
            new EducationCourseModel(){ CourseId = 12, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS202", CourseName = "Computer Architecture", Professor = "Dr. Lisa Wang", Coverage = 100, StartDate = new DateTime(2024, 08, 26), Duration = "16", ParentId = 10, Prerequisite = "2" },
            new EducationCourseModel(){ CourseId = 13, Term = "Fall semester midterms", Department = "Sophomore year", StartDate = new DateTime(2024, 10, 14), Duration = "7", Coverage = 100, ParentId = 10, Prerequisite = "11,12" },
            new EducationCourseModel(){ CourseId = 14, Term = "Fall semester finals", Department = "Sophomore year", StartDate = new DateTime(2024, 12, 09), Duration = "7", Coverage = 100, ParentId = 10, Prerequisite = "11,12,13" },
            new EducationCourseModel(){ CourseId = 15, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS203", CourseName = "Database Systems", Professor = "Dr. Jennifer Lee", StartDate = new DateTime(2025, 01, 20), Duration = "16", Coverage = 100, ParentId = 10, Prerequisite = "6,11" },
            new EducationCourseModel(){ CourseId = 16, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS204", CourseName = "Operating Systems", Professor = "Dr. David Chen", StartDate = new DateTime(2025, 01, 20), Duration = "16", Coverage = 100, ParentId = 10, Prerequisite = "12" },
            new EducationCourseModel(){ CourseId = 17, Term = "Spring semester midterms", Department = "Sophomore year", StartDate = new DateTime(2025, 03, 17), Duration = "7", Coverage = 100, ParentId = 10, Prerequisite = "15,16" },
            new EducationCourseModel(){ CourseId = 18, Term = "Spring semester finals", Department = "Sophomore year", StartDate = new DateTime(2025, 05, 12), Duration = "7", Coverage = 100, ParentId = 10, Prerequisite = "15,16,17" },
            // 2025-2026 Academic Year (Junior Year)
            new EducationCourseModel(){ CourseId = 19, Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 20, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS301", CourseName = "Software Engineering", Professor = "Dr. Rachel Green", Coverage = 100, StartDate = new DateTime(2025, 08, 25), Duration = "16", ParentId = 19, Prerequisite = "11,15" },
            new EducationCourseModel(){ CourseId = 21, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS302", CourseName = "Artificial Intelligence", Professor = "Dr. Alan Turing", Coverage = 100, StartDate = new DateTime(2025, 08, 25), Duration = "16", ParentId = 19, Prerequisite = "11" },
            new EducationCourseModel(){ CourseId = 22, Term = "Fall semester midterms", Department = "Junior year", StartDate = new DateTime(2025, 10, 13), Duration = "7", Coverage = 100, ParentId = 19, Prerequisite = "20,21" },
            new EducationCourseModel(){ CourseId = 23, Term = "Fall semester finals", Department = "Junior year", StartDate = new DateTime(2025, 12, 08), Duration = "7", Coverage = 100, ParentId = 19, Prerequisite = "20,21,22" },
            new EducationCourseModel(){ CourseId = 24, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS303", CourseName = "Computer Networks", Professor = "Dr. Grace Hopper", StartDate = new DateTime(2026, 01, 19), Duration = "16", Coverage = 100, ParentId = 19, Prerequisite = "16" },
            new EducationCourseModel(){ CourseId = 25, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS304", CourseName = "Web Development", Professor = "Dr. Tim Berners-Lee", StartDate = new DateTime(2026, 01, 19), Duration = "16", Coverage = 100, ParentId = 19, Prerequisite = "20" },
            new EducationCourseModel(){ CourseId = 26, Term = "Spring semester midterms", Department = "Junior year", StartDate = new DateTime(2026, 03, 16), Duration = "7", Coverage = 100, ParentId = 19, Prerequisite = "24,25" },
            new EducationCourseModel(){ CourseId = 27, Term = "Spring semester finals", Department = "Junior year", StartDate = new DateTime(2026, 05, 11), Duration = "7", Coverage = 100, ParentId = 19, Prerequisite = "24,25,26" },
            // 2026-2027 Academic Year (Senior Year)
            new EducationCourseModel(){ CourseId = 28, Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 29, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS401", CourseName = "Capstone Project I", Professor = "Dr. Linus Torvalds", Coverage = 90, StartDate = new DateTime(2026, 08, 24), Duration = "16", ParentId = 28, Prerequisite = "20,21,24,25" },
            new EducationCourseModel(){ CourseId = 30, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS402", CourseName = "Machine Learning", Professor = "Dr. Andrew Ng", Coverage = 70, StartDate = new DateTime(2026, 08, 24), Duration = "16", ParentId = 28, Prerequisite = "21" },
            new EducationCourseModel(){ CourseId = 31, Term = "Fall semester midterms", Department = "Senior year", StartDate = new DateTime(2026, 10, 12), Duration = "7", Coverage = 0, ParentId = 28, Prerequisite = "29,30" },
            new EducationCourseModel(){ CourseId = 32, Term = "Fall semester finals", Department = "Senior year", StartDate = new DateTime(2026, 12, 07), Duration = "7", Coverage = 0, ParentId = 28, Prerequisite = "29,30,31" },
            new EducationCourseModel(){ CourseId = 33, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS403", CourseName = "Capstone Project II", Professor = "Dr. Ada Lovelace", StartDate = new DateTime(2027, 01, 18), Duration = "16", Coverage = 0, ParentId = 28, Prerequisite = "29" },
            new EducationCourseModel(){ CourseId = 34, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS404", CourseName = "Cybersecurity", Professor = "Dr. Bruce Schneier", StartDate = new DateTime(2027, 01, 18), Duration = "16", Coverage = 0, ParentId = 28, Prerequisite = "24" },
            new EducationCourseModel(){ CourseId = 35, Term = "Spring semester midterms", Department = "Senior year", StartDate = new DateTime(2027, 03, 15), Duration = "7", Coverage = 0, ParentId = 28, Prerequisite = "33,34" },
            new EducationCourseModel(){ CourseId = 36, Term = "Spring semester finals", Department = "Senior year", StartDate = new DateTime(2027, 05, 10), Duration = "7", Coverage = 0, ParentId = 28, Prerequisite = "33,34,35" },
        };

        public static List<EducationCourseModel> ProfessorsCollection => new List<EducationCourseModel>()
        {
            // 2023-2024 Academic Year (Freshman Year)
            new EducationCourseModel(){ CourseId = 1, Term = "Dr. John Smith", Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 2, Term = "Fall Semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "CS101", CourseName = "Introduction to Programming", Professor = "Dr. John Smith", Coverage = 100, StartDate = new DateTime(2023, 08, 28), Duration = "16", ParentId = 1 },
            new EducationCourseModel(){ CourseId = 3, Term = "Dr. Emily Johnson", Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 4, Term = "Fall Semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "MATH101", CourseName = "Calculus I", Professor = "Dr. Emily Johnson", Coverage = 100, StartDate = new DateTime(2023, 08, 28), Duration = "16", ParentId = 3 },
            new EducationCourseModel(){ CourseId = 5, Term = "Dr. Sarah Davis", Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 6, Term = "Spring Semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "CS102", CourseName = "Data Structures", Professor = "Dr. Sarah Davis", StartDate = new DateTime(2024, 01, 22), Duration = "16", Coverage = 100, ParentId = 5 },
            new EducationCourseModel(){ CourseId = 7, Term = "Dr. Robert Wilson", Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 8, Term = "Spring Semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseCode = "MATH102", CourseName = "Calculus II", Professor = "Dr. Robert Wilson", StartDate = new DateTime(2024, 01, 22), Duration = "16", Coverage = 100, ParentId = 7 },
            // 2024-2025 Academic Year (Sophomore Year)
            new EducationCourseModel(){ CourseId = 9, Term = "Dr. Michael Brown", Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 10, Term = "Fall Semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS201", CourseName = "Algorithms", Professor = "Dr. Michael Brown", Coverage = 100, StartDate = new DateTime(2024, 08, 26), Duration = "16", ParentId = 9 },
            new EducationCourseModel(){ CourseId = 11, Term = "Dr. Lisa Wang", Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 12, Term = "Fall Semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS202", CourseName = "Computer Architecture", Professor = "Dr. Lisa Wang", Coverage = 100, StartDate = new DateTime(2024, 08, 26), Duration = "16", ParentId = 11 },
            new EducationCourseModel(){ CourseId = 13, Term = "Dr. Jennifer Lee", Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 14, Term = "Spring Semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS203", CourseName = "Database Systems", Professor = "Dr. Jennifer Lee", StartDate = new DateTime(2025, 01, 20), Duration = "16", Coverage = 100, ParentId = 13 },
            new EducationCourseModel(){ CourseId = 15, Term = "Dr. David Chen", Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 16, Term = "Spring Semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseCode = "CS204", CourseName = "Operating Systems", Professor = "Dr. David Chen", StartDate = new DateTime(2025, 01, 20), Duration = "16", Coverage = 100, ParentId = 15 },
            // 2025-2026 Academic Year (Junior Year)
            new EducationCourseModel(){ CourseId = 17, Term = "Dr. Rachel Green", Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 18, Term = "Fall Semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS301", CourseName = "Software Engineering", Professor = "Dr. Rachel Green", Coverage = 100, StartDate = new DateTime(2025, 08, 25), Duration = "16", ParentId = 17 },
            new EducationCourseModel(){ CourseId = 19, Term = "Dr. Alan Turing", Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 20, Term = "Fall Semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS302", CourseName = "Artificial Intelligence", Professor = "Dr. Alan Turing", Coverage = 100, StartDate = new DateTime(2025, 08, 25), Duration = "16", ParentId = 19 },
            new EducationCourseModel(){ CourseId = 21, Term = "Dr. Grace Hopper", Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 22, Term = "Spring Semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS303", CourseName = "Computer Networks", Professor = "Dr. Grace Hopper", StartDate = new DateTime(2026, 01, 19), Duration = "16", Coverage = 100, ParentId = 21 },
            new EducationCourseModel(){ CourseId = 23, Term = "Dr. Tim Berners-Lee", Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 24, Term = "Spring Semester", Department = "Junior year", AcademicYear = "2025-2026", CourseCode = "CS304", CourseName = "Web Development", Professor = "Dr. Tim Berners-Lee", StartDate = new DateTime(2026, 01, 19), Duration = "16", Coverage = 100, ParentId = 23 },

            new EducationCourseModel(){ CourseId = 25, Term = "Dr. Linus Torvalds", Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 26, Term = "Fall Semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS401", CourseName = "Capstone Project I", Professor = "Dr. Linus Torvalds", Coverage = 90, StartDate = new DateTime(2026, 08, 24), Duration = "16", ParentId = 25 },
            new EducationCourseModel(){ CourseId = 27, Term = "Dr. Andrew Ng", Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 28, Term = "Fall Semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS402", CourseName = "Machine Learning", Professor = "Dr. Andrew Ng", Coverage = 70, StartDate = new DateTime(2026, 08, 24), Duration = "16", ParentId = 27 },
            new EducationCourseModel(){ CourseId = 29, Term = "Dr. Ada Lovelace", Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 30, Term = "Spring Semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS403", CourseName = "Capstone Project II", Professor = "Dr. Ada Lovelace", StartDate = new DateTime(2027, 01, 18), Duration = "16", Coverage = 0, ParentId = 29 },
            new EducationCourseModel(){ CourseId = 31, Term = "Dr. Bruce Schneier", Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 32, Term = "Spring Semester", Department = "Senior year", AcademicYear = "2026-2027", CourseCode = "CS404", CourseName = "Cybersecurity", Professor = "Dr. Bruce Schneier", StartDate = new DateTime(2027, 01, 18), Duration = "16", Coverage = 0, ParentId = 31 },
        };

        public static List<EducationCourseModel> ExamCollection => new List<EducationCourseModel>()
        {
            // 2023-2024 Academic Year (Freshman Year)
            new EducationCourseModel(){ CourseId = 1, Department = "Freshman year", AcademicYear = "2023-2024", ParentId = null },
            new EducationCourseModel(){ CourseId = 2, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="CS101 Midterm", StartDate = new DateTime(2023, 10, 16), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 3, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="MATH101 Midterm", StartDate = new DateTime(2023, 10, 18), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 4, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="CS101 Final", StartDate = new DateTime(2023, 12, 11), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 5, Term = "Fall semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="MATH101 Final", StartDate = new DateTime(2023, 12, 13), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 6, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="CS102 Midterm", StartDate = new DateTime(2024, 03, 18), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 7, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="MATH102 Midterm", StartDate = new DateTime(2024, 03, 20), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 8, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="CS102 Final", StartDate = new DateTime(2024, 05, 13), Duration="1", Coverage = 100, ParentId = 1 },
            new EducationCourseModel(){ CourseId = 9, Term = "Spring semester", Department = "Freshman year", AcademicYear = "2023-2024", CourseName="MATH102 Final", StartDate = new DateTime(2024, 05, 15), Duration="1", Coverage = 100, ParentId = 1 },
            // 2024-2025 Academic Year (Sophomore Year)
            new EducationCourseModel(){ CourseId = 10, Department = "Sophomore year", AcademicYear = "2024-2025", ParentId = null },
            new EducationCourseModel(){ CourseId = 11, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS201 Midterm", StartDate = new DateTime(2024, 10, 14), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 12, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS202 Midterm", StartDate = new DateTime(2024, 10, 16), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 13, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS201 Final", StartDate = new DateTime(2024, 12, 09), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 14, Term = "Fall semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS202 Final", StartDate = new DateTime(2024, 12, 11), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 15, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS203 Midterm", StartDate = new DateTime(2025, 03, 17), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 16, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS204 Midterm", StartDate = new DateTime(2025, 03, 19), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 17, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS203 Final", StartDate = new DateTime(2025, 05, 12), Duration="1", Coverage = 100, ParentId = 10 },
            new EducationCourseModel(){ CourseId = 18, Term = "Spring semester", Department = "Sophomore year", AcademicYear = "2024-2025", CourseName="CS204 Final", StartDate = new DateTime(2025, 05, 14), Duration="1", Coverage = 100, ParentId = 10 },
            // 2025-2026 Academic Year (Junior Year)
            new EducationCourseModel(){ CourseId = 19, Department = "Junior year", AcademicYear = "2025-2026", ParentId = null },
            new EducationCourseModel(){ CourseId = 20, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS301 Midterm", StartDate = new DateTime(2025, 10, 13), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 21, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS302 Midterm", StartDate = new DateTime(2025, 10, 15), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 22, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS301 Final", StartDate = new DateTime(2025, 12, 08), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 23, Term = "Fall semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS302 Final", StartDate = new DateTime(2025, 12, 10), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 24, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS303 Midterm", StartDate = new DateTime(2026, 03, 16), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 25, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS304 Midterm", StartDate = new DateTime(2026, 03, 18), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 26, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS303 Final", StartDate = new DateTime(2026, 05, 11), Duration="1", Coverage = 100, ParentId = 19 },
            new EducationCourseModel(){ CourseId = 27, Term = "Spring semester", Department = "Junior year", AcademicYear = "2025-2026", CourseName="CS304 Final", StartDate = new DateTime(2026, 05, 13), Duration="1", Coverage = 100, ParentId = 19 },
            // 2026-2027 Academic Year (Senior Year)
            new EducationCourseModel(){ CourseId = 28, Department = "Senior year", AcademicYear = "2026-2027", ParentId = null },
            new EducationCourseModel(){ CourseId = 29, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS401 Midterm", StartDate = new DateTime(2026, 10, 12), Duration="1", Coverage = 90, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 30, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS402 Midterm", StartDate = new DateTime(2026, 10, 14), Duration="1", Coverage = 70, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 31, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS401 Final", StartDate = new DateTime(2026, 12, 07), Duration="1", Coverage = 30, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 32, Term = "Fall semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS402 Final", StartDate = new DateTime(2026, 12, 09), Duration="1", Coverage = 20, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 33, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS403 Midterm", StartDate = new DateTime(2027, 03, 15), Duration="1", Coverage = 0, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 34, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS404 Midterm", StartDate = new DateTime(2027, 03, 17), Duration="1", Coverage = 0, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 35, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS403 Final", StartDate = new DateTime(2027, 05, 10), Duration="1", Coverage = 0, ParentId = 28 },
            new EducationCourseModel(){ CourseId = 36, Term = "Spring semester", Department = "Senior year", AcademicYear = "2026-2027", CourseName="CS404 Final", StartDate = new DateTime(2027, 05, 12), Duration="1", Coverage = 0, ParentId = 28 },
        };
    }
}