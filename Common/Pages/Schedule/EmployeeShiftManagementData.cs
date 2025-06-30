#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace employeeshiftmanagement.DefaultData
{
    public class EmployeeShiftManagementData
    {
            public int Id { get; set; }
            public int RoleId { get; set; }
            public int DesignationId { get; set; }
            public int EmployeeId { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string Description { get; set; }
            public bool? IsReadonly { get; set; }
            public bool IsSwapped { get; set; }
            public string? SwapWithId { get; set; }
        public static List<EmployeeShiftManagementData> GetShiftData()
        {
            List<EmployeeShiftManagementData> employeeData = new List<EmployeeShiftManagementData>() {

                new EmployeeShiftManagementData {
                  Id=1,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 2, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=2,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=3,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 3, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=4,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=5,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 4, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=6,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=7,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 5, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=8,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=9,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 6, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=10,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=11,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 7, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=12,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 00, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=13,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=1,
                  Subject="John",
                  StartTime=new DateTime(2025, 3, 8, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=14,
                  RoleId=1,
                  DesignationId=1,
                  EmployeeId=2,
                  Subject="Nashil",
                  StartTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=15,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 2, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=16,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=17,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 3, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=18,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=19,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 4, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=20,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=21,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 5, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=22,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 00, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=23,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 6, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=24,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=25,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 7, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=26,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 00, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=27,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=3,
                  Subject="Jennifer",
                  StartTime=new DateTime(2025, 3, 8, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=28,
                  RoleId=1,
                  DesignationId=2,
                  EmployeeId=4,
                  Subject="William",
                  StartTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=29,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 2, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=30,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=31,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 3, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=32,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=33,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 4, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=34,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 4, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=35,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 5, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  Description="Leave (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=36,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 5, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=37,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 6, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=38,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 6, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 00, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=39,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 7, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=40,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 7, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=41,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=5,
                  Subject="David",
                  StartTime=new DateTime(2025, 3, 8, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=42,
                  RoleId=1,
                  DesignationId=3,
                  EmployeeId=6,
                  Subject="Michael",
                  StartTime=new DateTime(2025, 3, 8, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 00, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=43,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 2, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=44,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 2, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=45,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 3, 7, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=46,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 3, 15, 00, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 00, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=47,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 4, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=48,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=49,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 5, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=50,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=51,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 6, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=52,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 0, 0),
                  Description="Leave (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=53,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 7, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=54,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 0, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=55,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=7,
                  Subject="Thomas",
                  StartTime=new DateTime(2025, 3, 8, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=56,
                  RoleId=1,
                  DesignationId=4,
                  EmployeeId=8,
                  Subject="Daniel",
                  StartTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=57,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 2, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=58,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=59,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 3, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=60,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=61,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 4, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=62,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime = new DateTime(2025, 3, 4, 15, 0, 0),
                  EndTime = new DateTime(2025, 3, 4, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=63,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 5, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=64,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=65,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 6, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=66,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=67,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 7, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=68,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 0, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=69,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=9,
                  Subject="Emma",
                  StartTime=new DateTime(2025, 3, 8, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  Description="Leave (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=70,
                  RoleId=2,
                  DesignationId=5,
                  EmployeeId=10,
                  Subject="Lily",
                  StartTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=71,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime = new DateTime(2025, 3, 2, 7, 0, 0),
                  EndTime = new DateTime(2025, 3, 2, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=72,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=73,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 3, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=74,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=75,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 4, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=76,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=77,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 5, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=78,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=79,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 6, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=80,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=81,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 7, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=82,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=83,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=11,
                  Subject="Ava",
                  StartTime=new DateTime(2025, 3, 8, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=84,
                  RoleId=2,
                  DesignationId=6,
                  EmployeeId=12,
                  Subject="Grace",
                  StartTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=85,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 2, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=86,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=87,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 3, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=88,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=89,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 4, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=90,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=91,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 5, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=92,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=93,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 6, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=94,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=95,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 7, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=96,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 0, 0),
                  Description="Leave (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=97,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=13,
                  Subject="James",
                  StartTime=new DateTime(2025, 3, 8, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=98,
                  RoleId=3,
                  DesignationId=7,
                  EmployeeId=14,
                  Subject="Benjamin",
                  StartTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=99,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 2, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=100,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 2, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 2, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=101,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 3, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=102,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 3, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 3, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=103,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 4, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  Description="Available (Morning Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=104,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 4, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 4, 23, 0, 0),
                  Description="Available (Evening Shift)",
                  IsReadonly=true
                }

                ,
                new EmployeeShiftManagementData {
                  Id=105,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 5, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=106,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 5, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 5, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=107,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 6, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=108,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 6, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 6, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=109,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 7, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  Description="Available (Morning Shift)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=110,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 7, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 7, 23, 0, 0),
                  Description="Available (Evening Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=111,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=15,
                  Subject="Olivia",
                  StartTime=new DateTime(2025, 3, 8, 7, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  Description="Available (Morning Shift - Swap-Request)"
                }

                ,
                new EmployeeShiftManagementData {
                  Id=112,
                  RoleId=3,
                  DesignationId=8,
                  EmployeeId=16,
                  Subject="Chloe",
                  StartTime=new DateTime(2025, 3, 8, 15, 0, 0),
                  EndTime=new DateTime(2025, 3, 8, 23, 0, 0),
                  Description="Available (Evening Shift)"
                }

            };
            return employeeData;
        }
    }
}
