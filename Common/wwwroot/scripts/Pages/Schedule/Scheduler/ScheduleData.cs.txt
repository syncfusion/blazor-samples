#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.Schedule.Scheduler
{
    public class ScheduleData
    {
        private int CurrentYear = DateTime.Now.Year;
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 1, 6, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 14, 0, 0),
                CategoryColor = "#357cd2",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2022",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 8, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 14, 30, 0),
                CategoryColor = "#ea7a57",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting Pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 0, 0),
                CategoryColor = "#8e24aa"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                CategoryColor = "#8e24aa"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(CurrentYear, 1, 15, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2022",
                Location = "London",
                StartTime = new DateTime(CurrentYear, 1, 16, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 12, 31, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 1, 17, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 5, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Francisco",
                StartTime = new DateTime(CurrentYear, 1, 9, 6, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 11, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            return appData;
        }
        public List<ContextEventsData> GetContextEventData()
        {
            List<ContextEventsData> appData = new List<ContextEventsData>();
            appData.Add(new ContextEventsData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 11, 0, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new ContextEventsData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 1, 6, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new ContextEventsData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new ContextEventsData
            {
                Id = 4,
                Subject = "Meteor Showers in 2022",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 8, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 14, 30, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 5,
                Subject = "Milky Way as Melting Pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new ContextEventsData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 0, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new ContextEventsData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new ContextEventsData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new ContextEventsData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new ContextEventsData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(CurrentYear, 1, 15, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 11,
                Subject = "Best Photography 2022",
                Location = "London",
                StartTime = new DateTime(CurrentYear, 1, 16, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new ContextEventsData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new ContextEventsData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new ContextEventsData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 12, 31, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new ContextEventsData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new ContextEventsData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 1, 17, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 5, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new ContextEventsData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new ContextEventsData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Francisco",
                StartTime = new DateTime(CurrentYear, 1, 9, 6, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new ContextEventsData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new ContextEventsData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new ContextEventsData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 11, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            return appData;
        }
        public List<AppointmentData> GetZooEventData()
        {
            List<AppointmentData> zooEventData = new List<AppointmentData>();
            zooEventData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Story Time for Kids",
                StartTime = new DateTime(CurrentYear, 1, 12, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Camping with Turtles",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Wildlife Warriors",
                StartTime = new DateTime(CurrentYear, 1, 14, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 30, 0),
                CategoryColor = "#7fa900"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Parrot Talk",
                StartTime = new DateTime(CurrentYear, 1, 15, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 10, 0, 0),
                CategoryColor = "#ea7a57"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Birds of Prey",
                StartTime = new DateTime(CurrentYear, 1, 16, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 11, 30, 0),
                CategoryColor = "#00bdae"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Croco World",
                StartTime = new DateTime(CurrentYear, 1, 17, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                CategoryColor = "#f57f17"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Venomous Snake Hunt",
                StartTime = new DateTime(CurrentYear, 1, 18, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Face Painting & Drawing Events",
                StartTime = new DateTime(CurrentYear, 1, 20, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 11, 0, 0),
                CategoryColor = "#357cd2"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Pony Rides",
                StartTime = new DateTime(CurrentYear, 1, 22, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Feed the Giants",
                StartTime = new DateTime(CurrentYear, 1, 23, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 11, 0, 0),
                CategoryColor = "#ea7a57"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Jungle Treasure Hunt",
                StartTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 30, 0),
                CategoryColor = "#00bdae"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Endangered Species Program",
                StartTime = new DateTime(CurrentYear, 1, 8, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 12, 30, 0),
                CategoryColor = "#f57f17"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Black Cockatoos Playtime",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Walk with Jungle King",
                StartTime = new DateTime(CurrentYear, 1, 15, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Trained Climbers",
                StartTime = new DateTime(CurrentYear, 1, 20, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Playtime with Chimpanzees",
                StartTime = new DateTime(CurrentYear, 1, 23, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 14, 30, 0),
                CategoryColor = "#ea7a57"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "Story Time for Kids",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                CategoryColor = "#1aaa55"
            });
            zooEventData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Black Cockatoos Playtime",
                StartTime = new DateTime(CurrentYear, 1, 16, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 16, 0, 0),
                CategoryColor = "#7fa900"
            });
            return zooEventData;
        }
        public List<ReadonlyEventsData> GetReadonlyEventsData()
        {
            DateTime dateNow = DateTime.Now;
            DateTime dateNow1 = DateTime.Now.AddDays(-2);
            DateTime dateNow2 = DateTime.Now.AddDays(-1);
            DateTime dateNow3 = DateTime.Now.AddDays(1);
            DateTime dateNow4 = DateTime.Now.AddDays(2);
            List<ReadonlyEventsData> readonlyEventsData = new List<ReadonlyEventsData>();
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 1,
                Subject = "Project Workflow Analysis",
                StartTime = new DateTime(dateNow1.Year, dateNow1.Month, dateNow1.Day, dateNow1.AddHours(2).Hour, 0, 0),
                EndTime = new DateTime(dateNow1.Year, dateNow1.Month, dateNow1.Day, dateNow1.AddHours(4).Hour, 0, 0),
                IsReadonly = true
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 2,
                Subject = "Project Requirement Planning",
                StartTime = new DateTime(dateNow2.Year, dateNow2.Month, dateNow2.Day, dateNow2.AddHours(2).Hour, 0, 0),
                EndTime = new DateTime(dateNow2.Year, dateNow2.Month, dateNow2.Day, dateNow2.AddHours(4).Hour, 0, 0),
                IsReadonly = true
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 3,
                Subject = "Meeting with Developers",
                StartTime = new DateTime(dateNow2.Year, dateNow2.Month, dateNow2.Day, dateNow2.AddHours(-3).Hour, 0, 0),
                EndTime = new DateTime(dateNow2.Year, dateNow2.Month, dateNow2.Day, dateNow2.AddHours(-1).Hour, 0, 0),
                IsReadonly = true
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 4,
                Subject = "Team Fun Activities",
                StartTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(-4).Hour, 0, 0),
                EndTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(-2).Hour, 0, 0),
                IsReadonly = true
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 5,
                Subject = "Quality Analysis",
                StartTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(1).Hour, 0, 0),
                EndTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(3).Hour, 0, 0),
                IsReadonly = false
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 6,
                Subject = "Customer meeting – John Mackenzie",
                StartTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(5).Hour, 0, 0),
                EndTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(6).Hour, 0, 0),
                IsReadonly = false
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 7,
                Subject = "General meeting",
                StartTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(9).Hour, 0, 0),
                EndTime = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, dateNow.AddHours(10).Hour, 0, 0),
                IsReadonly = false
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 8,
                Subject = "Project Review",
                StartTime = new DateTime(dateNow3.Year, dateNow3.Month, dateNow3.Day, dateNow3.AddHours(3).Hour, 0, 0),
                EndTime = new DateTime(dateNow3.Year, dateNow3.Month, dateNow3.Day, dateNow3.AddHours(5).Hour, 0, 0),
                IsReadonly = false
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 9,
                Subject = "Project demo meeting with Andrew",
                StartTime = new DateTime(dateNow3.Year, dateNow3.Month, dateNow3.Day, dateNow3.AddHours(-4).Hour, 0, 0),
                EndTime = new DateTime(dateNow3.Year, dateNow3.Month, dateNow3.Day, dateNow3.AddHours(-3).Hour, 0, 0),
                IsReadonly = false
            });
            readonlyEventsData.Add(new ReadonlyEventsData
            {
                Id = 10,
                Subject = "Online Hosting of Project",
                StartTime = new DateTime(dateNow4.Year, dateNow4.Month, dateNow4.Day, dateNow4.AddHours(4).Hour, 0, 0),
                EndTime = new DateTime(dateNow4.Year, dateNow4.Month, dateNow4.Day, dateNow4.AddHours(6).Hour, 0, 0),
                IsReadonly = false
            });
            return readonlyEventsData;
        }

        public List<ResourceData> GetResourceData()
        {
            List<ResourceData> resourceData = new List<ResourceData>();
            resourceData.Add(new ResourceData
            {
                Id = 1,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(CurrentYear, 1, 5, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 12, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 2,
                Subject = "Requirement planning",
                StartTime = new DateTime(CurrentYear, 1, 5, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 14, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 3,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 4,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 6, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 5,
                Subject = "Timeline estimation",
                StartTime = new DateTime(CurrentYear, 1, 7, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 6,
                Subject = "Developers Meeting",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 7,
                Subject = "Project Review",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 15, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 8,
                Subject = "Manual testing",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 15, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 9,
                Subject = "Project Preview",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 12, 45, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 10,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(CurrentYear, 1, 9, 13, 45, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 11,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 15, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 12,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 13,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(CurrentYear, 1, 11, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 15, 15, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 14,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 15,
                Subject = "Test case correction",
                StartTime = new DateTime(CurrentYear, 1, 12, 9, 45, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 16,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 1, 12, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 17,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 18,
                Subject = "Debugging",
                StartTime = new DateTime(CurrentYear, 1, 13, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 11, 15, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 19,
                Subject = "Exception handling",
                StartTime = new DateTime(CurrentYear, 1, 14, 10, 10, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 13, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 20,
                Subject = "Decoding",
                StartTime = new DateTime(CurrentYear, 1, 14, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 21,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(CurrentYear, 1, 15, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 22,
                Subject = "Requirement planning",
                StartTime = new DateTime(CurrentYear, 1, 15, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 14, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 23,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 16, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 24,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 16, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 14, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 25,
                Subject = "Timeline estimation",
                StartTime = new DateTime(CurrentYear, 1, 17, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 26,
                Subject = "Developers Meeting",
                StartTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 15, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 27,
                Subject = "Project Review",
                StartTime = new DateTime(CurrentYear, 1, 18, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 13, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 28,
                Subject = "Manual testing",
                StartTime = new DateTime(CurrentYear, 1, 18, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 29,
                Subject = "Project Preview",
                StartTime = new DateTime(CurrentYear, 1, 19, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 30,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(CurrentYear, 1, 19, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 31,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 20, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 32,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 20, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 33,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(CurrentYear, 1, 21, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 34,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 21, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 35,
                Subject = "Test case correction",
                StartTime = new DateTime(CurrentYear, 1, 22, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 36,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 1, 22, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 37,
                Subject = "Bug fixing",
                StartTime = new DateTime(CurrentYear, 1, 13, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 38,
                Subject = "Debugging",
                StartTime = new DateTime(CurrentYear, 1, 23, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 39,
                Subject = "Exception handling",
                StartTime = new DateTime(CurrentYear, 1, 24, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 24, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 40,
                Subject = "Decoding",
                StartTime = new DateTime(CurrentYear, 1, 24, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 24, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 41,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(CurrentYear, 1, 25, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 42,
                Subject = "Requirement planning",
                StartTime = new DateTime(CurrentYear, 1, 25, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 13, 45, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 43,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 26, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 44,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 45,
                Subject = "Timeline estimation",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 46,
                Subject = "Developers Meeting",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 47,
                Subject = "Project Review",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 48,
                Subject = "Manual testing",
                StartTime = new DateTime(CurrentYear, 1, 10, 17, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 19, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 49,
                Subject = "Project Preview",
                StartTime = new DateTime(CurrentYear, 1, 10, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 50,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(CurrentYear, 1, 29, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 29, 15, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 51,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 30, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 52,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 30, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 53,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(CurrentYear, 1, 31, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 31, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 54,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 31, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 31, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 55,
                Subject = "Test case correction",
                StartTime = new DateTime(CurrentYear, 2, 1, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 1, 11, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 56,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 2, 1, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 1, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 57,
                Subject = "Bug fixing",
                StartTime = new DateTime(CurrentYear, 2, 2, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 2, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 58,
                Subject = "Debugging",
                StartTime = new DateTime(CurrentYear, 2, 2, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 2, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 59,
                Subject = "Exception handling",
                StartTime = new DateTime(CurrentYear, 2, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 3, 11, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 60,
                Subject = "Decoding",
                StartTime = new DateTime(CurrentYear, 2, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 3, 12, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 61,
                Subject = "Decoding",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 62,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 63,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 10, 30, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 1
            });
            resourceData.Add(new ResourceData
            {
                Id = 64,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(CurrentYear, 1, 10, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 4
            });
            resourceData.Add(new ResourceData
            {
                Id = 65,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 18, 0, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 6
            });
            resourceData.Add(new ResourceData
            {
                Id = 66,
                Subject = "Test case correction",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                IsAllDay = false,
                ProjectId = 1,
                TaskId = 2
            });
            resourceData.Add(new ResourceData
            {
                Id = 67,
                Subject = "Bug fixing",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 18, 30, 0),
                IsAllDay = false,
                ProjectId = 3,
                TaskId = 5
            });
            resourceData.Add(new ResourceData
            {
                Id = 68,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 1, 10, 18, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 21, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 4
            });
            resourceData.Add(new ResourceData
            {
                Id = 69,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 20, 0, 0),
                IsAllDay = false,
                ProjectId = 2,
                TaskId = 3
            });
            return resourceData;
        }
        public List<ResourceConferenceData> GetResourceConferenceData()
        {
            List<ResourceConferenceData> resourceConferenceData = new List<ResourceConferenceData>();
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 1,
                Subject = "Burning Man",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 17, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 2,
                Subject = "Data-Driven Economy",
                StartTime = new DateTime(CurrentYear, 1, 4, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 14, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 3,
                Subject = "Techweek",
                StartTime = new DateTime(CurrentYear, 1, 4, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 17, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 4,
                Subject = "Content Marketing World",
                StartTime = new DateTime(CurrentYear, 1, 4, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 20, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 5,
                Subject = "B2B Marketing Forum",
                StartTime = new DateTime(CurrentYear, 1, 5, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 12, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 6,
                Subject = "Business Innovation Factory",
                StartTime = new DateTime(CurrentYear, 1, 5, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 15, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 7,
                Subject = "Grow Conference",
                StartTime = new DateTime(CurrentYear, 1, 5, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 18, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 8,
                Subject = "Journalism Interactive",
                StartTime = new DateTime(CurrentYear, 1, 5, 19, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 21, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 9,
                Subject = "Blogcademy",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 11, 30, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 10,
                Subject = "Sustainable Brands",
                StartTime = new DateTime(CurrentYear, 1, 6, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 15, 30, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 11,
                Subject = "Fashion Confidential",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 9, 45, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 12,
                Subject = "Mobile World Conference",
                StartTime = new DateTime(CurrentYear, 1, 7, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 14, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 13,
                Subject = "The Human Gathering",
                StartTime = new DateTime(CurrentYear, 1, 7, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 17, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 14,
                Subject = "Web Summit",
                StartTime = new DateTime(CurrentYear, 1, 7, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 15,
                Subject = "Funnel Hacking Live",
                StartTime = new DateTime(CurrentYear, 1, 8, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 14, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 16,
                Subject = "Data Science Conference",
                StartTime = new DateTime(CurrentYear, 1, 8, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 17, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 17,
                Subject = "Powerful Living Experience",
                StartTime = new DateTime(CurrentYear, 1, 8, 21, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 23, 30, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 18,
                Subject = "World Domination Summit",
                StartTime = new DateTime(CurrentYear, 1, 9, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 19,
                Subject = "Burning Man",
                StartTime = new DateTime(CurrentYear, 1, 9, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 17, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 20,
                Subject = "Data-Driven Economy",
                StartTime = new DateTime(CurrentYear, 1, 9, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 21,
                Subject = "Techweek",
                StartTime = new DateTime(CurrentYear, 1, 10, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 22,
                Subject = "Content Marketing World",
                StartTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 17, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 23,
                Subject = "B2B Marketing Forum",
                StartTime = new DateTime(CurrentYear, 1, 10, 20, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 21, 30, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 24,
                Subject = "Business Innovation Factory",
                StartTime = new DateTime(CurrentYear, 1, 11, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 25,
                Subject = "Grow Conference",
                StartTime = new DateTime(CurrentYear, 1, 11, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 17, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 26,
                Subject = "Journalism Interactive",
                StartTime = new DateTime(CurrentYear, 1, 11, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 20, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 27,
                Subject = "Blogcademy",
                StartTime = new DateTime(CurrentYear, 1, 12, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 14, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 28,
                Subject = "Sustainable Brands",
                StartTime = new DateTime(CurrentYear, 1, 12, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 17, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 29,
                Subject = "Fashion Confidential",
                StartTime = new DateTime(CurrentYear, 1, 12, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 30,
                Subject = "Mobile World Conference",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 31,
                Subject = "The Human Gathering",
                StartTime = new DateTime(CurrentYear, 1, 13, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 17, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 32,
                Subject = "Web Summit",
                StartTime = new DateTime(CurrentYear, 1, 13, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 20, 0, 0),
                ConferenceId = new int[] { 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 33,
                Subject = "Funnel Hacking Live",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                ConferenceId = new int[] { 1 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 34,
                Subject = "Data Science Conference",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                ConferenceId = new int[] { 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 35,
                Subject = "Powerful Living Experience",
                StartTime = new DateTime(CurrentYear, 1, 14, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 36,
                Subject = "World Domination Summit",
                StartTime = new DateTime(CurrentYear, 1, 14, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 20, 0, 0),
                ConferenceId = new int[] { 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 37,
                Subject = "Burning Man",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 38,
                Subject = "Data-Driven Economy",
                StartTime = new DateTime(CurrentYear, 1, 15, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 16, 0, 0),
                ConferenceId = new int[] { 1 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 39,
                Subject = "Techweek",
                StartTime = new DateTime(CurrentYear, 1, 15, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 20, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 40,
                Subject = "Content Marketing World",
                StartTime = new DateTime(CurrentYear, 1, 15, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 41,
                Subject = "B2B Marketing Forum",
                StartTime = new DateTime(CurrentYear, 1, 16, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 16, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 42,
                Subject = "Business Innovation Factory",
                StartTime = new DateTime(CurrentYear, 1, 16, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 16, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 43,
                Subject = "Grow Conference",
                StartTime = new DateTime(CurrentYear, 1, 16, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 20, 0, 0),
                ConferenceId = new int[] { 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 44,
                Subject = "Journalism Interactive",
                StartTime = new DateTime(CurrentYear, 1, 16, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 20, 0, 0),
                ConferenceId = new int[] { 1, 2, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 45,
                Subject = "Blogcademy",
                StartTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 16, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 46,
                Subject = "Sustainable Brands",
                StartTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 16, 0, 0),
                ConferenceId = new int[] { 1, 3 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 47,
                Subject = "Fashion Confidential",
                StartTime = new DateTime(CurrentYear, 1, 17, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 20, 0, 0),
                ConferenceId = new int[] { 1, 2 }
            });
            resourceConferenceData.Add(new ResourceConferenceData
            {
                Id = 48,
                Subject = "Mobile World Conference",
                StartTime = new DateTime(CurrentYear, 1, 17, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 20, 0, 0),
                ConferenceId = new int[] { 2, 3 }
            });
            return resourceConferenceData;
        }
        public List<ResourceTeamData> GetResourceTeamData()
        {
            List<ResourceTeamData> resourceTeamData = new List<ResourceTeamData>();
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 1,
                Subject = "Developers Meeting",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
                ProjectId = 1,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 2,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 4, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 13, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,WE,FR",
                ProjectId = 1,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 3,
                Subject = "Requirement planning",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 10, 45, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 4,
                Subject = "Bug Automation",
                StartTime = new DateTime(CurrentYear, 1, 4, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 13, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,WE,FR",
                ProjectId = 2,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 5,
                Subject = "Timeline estimation",
                StartTime = new DateTime(CurrentYear, 1, 5, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 12, 0, 0),
                ProjectId = 1,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 6,
                Subject = "Timeline estimation",
                StartTime = new DateTime(CurrentYear, 1, 5, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 15, 0, 0),
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 7,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 6, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 15, 30, 0),
                ProjectId = 1,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 8,
                Subject = "Functionality testing",
                StartTime = new DateTime(CurrentYear, 1, 6, 19, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 21, 0, 0),
                ProjectId = 2,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 9,
                Subject = "Workflow Analysis",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 15, 30, 0),
                ProjectId = 1,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 10,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 7, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 0, 0),
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 11,
                Subject = "Cross-browser testing",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 45, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 15, 0),
                ProjectId = 1,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 12,
                Subject = "Resolution-based testing",
                StartTime = new DateTime(CurrentYear, 1, 7, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 17, 30, 0),
                ProjectId = 2,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 13,
                Subject = "Project Preview",
                StartTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 18, 0, 0),
                ProjectId = 1,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 14,
                Subject = "Project Preview",
                StartTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 17, 30, 0),
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 15,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 10, 15, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 17, 45, 0),
                ProjectId = 1,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 16,
                Subject = "Test report validation",
                StartTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 17, 0, 0),
                ProjectId = 2,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 17,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 8, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 18, 0, 0),
                ProjectId = 1,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 18,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 17, 0, 0),
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 19,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 18, 0, 0),
                ProjectId = 1,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 20,
                Subject = "Run test cases",
                StartTime = new DateTime(CurrentYear, 1, 8, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 17, 30, 0),
                ProjectId = 2,
                CategoryId = 2
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 21,
                Subject = "Resource planning",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 30, 0),
                ProjectId = 2,
                CategoryId = 1
            });
            resourceTeamData.Add(new ResourceTeamData
            {
                Id = 22,
                Subject = "Developers Meeting",
                StartTime = new DateTime(CurrentYear, 12, 1, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 1, 13, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=1;BYDAY=MO,TU,WE,TH,FR",
                ProjectId = 2,
                CategoryId = 1
            });
            return resourceTeamData;
        }
        public List<RoomData> GetRoomData()
        {
            List<RoomData> roomData = new List<RoomData>();
            roomData.Add(new RoomData
            {
                Id = 1,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business goal of 2020.",
                StartTime = new DateTime(CurrentYear, 12, 30, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 11, 0, 0),
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 2,
                Subject = "Training session on JSP",
                Description = "Knowledge sharing on JSP topics.",
                StartTime = new DateTime(CurrentYear, 12, 30, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 17, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 3,
                Subject = "Sprint Planning with Team Members",
                Description = "Planning tasks for sprint.",
                StartTime = new DateTime(CurrentYear, 12, 30, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 11, 0, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 4,
                Subject = "Meeting with Client",
                Description = "Customer meeting to discuss features.",
                StartTime = new DateTime(CurrentYear, 12, 30, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 13, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 5,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 12, 30, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 17, 30, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 6,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 12, 30, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 13, 0, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 7,
                Subject = "Appraisal Meeting",
                Description = "Meeting to discuss employee appraisals.",
                StartTime = new DateTime(CurrentYear, 12, 30, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 16, 30, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 8,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 12, 30, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 9, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 9,
                Subject = "Customer Meeting",
                Description = "Meeting to discuss customer reported issues.",
                StartTime = new DateTime(CurrentYear, 12, 30, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 12, 0, 0),
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 10,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 12, 30, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 17, 0, 0),
                RoomId = 9
            });
            roomData.Add(new RoomData
            {
                Id = 11,
                Subject = "Training session on Vue",
                Description = "Knowledge sharing on Vue concepts.",
                StartTime = new DateTime(CurrentYear, 12, 30, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 10, 30, 0),
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 12,
                Subject = "Meeting with Team Members",
                Description = "Meeting to discuss on work report.",
                StartTime = new DateTime(CurrentYear, 12, 30, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 12, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 13,
                Subject = "Meeting with General Manager",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 12, 30, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 30, 16, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 14,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business goal of 2020.",
                StartTime = new DateTime(CurrentYear, 12, 31, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 11, 0, 0),
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 15,
                Subject = "Training session on JSP",
                Description = "Knowledge sharing on JSP topics.",
                StartTime = new DateTime(CurrentYear, 12, 31, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 17, 0, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 16,
                Subject = "Sprint Planning with Team Members",
                Description = "Planning tasks for sprint.",
                StartTime = new DateTime(CurrentYear, 12, 31, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 11, 0, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 17,
                Subject = "Meeting with Client",
                Description = "Customer meeting to discuss features.",
                StartTime = new DateTime(CurrentYear, 12, 31, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 13, 0, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 18,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 12, 31, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 17, 30, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 19,
                Subject = "Training session on C#",
                Description = "Training session",
                StartTime = new DateTime(CurrentYear, 12, 31, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 16, 0, 0),
                RoomId = 9
            });
            roomData.Add(new RoomData
            {
                Id = 20,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 12, 31, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 13, 0, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 21,
                Subject = "Appraisal Meeting",
                Description = "Meeting to discuss employee appraisals.",
                StartTime = new DateTime(CurrentYear, 12, 31, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 16, 30, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 22,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 12, 31, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 9, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 23,
                Subject = "Customer Meeting",
                Description = "Meeting to discuss customer reported issues.",
                StartTime = new DateTime(CurrentYear, 12, 31, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 12, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 24,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 16, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 18, 0, 0),
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 25,
                Subject = "Training session on Vue",
                Description = "Knowledge sharing on Vue concepts.",
                StartTime = new DateTime(CurrentYear, 12, 31, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 10, 30, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 26,
                Subject = "Meeting with Team Members",
                Description = "Meeting to discuss on work report.",
                StartTime = new DateTime(CurrentYear, 12, 31, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 12, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 27,
                Subject = "Meeting with General Manager",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 12, 31, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 16, 0, 0),
                RoomId = 10
            });

            roomData.Add(new RoomData
            {
                Id = 28,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business goal of 2020.",
                StartTime = new DateTime(CurrentYear, 1, 3, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 29,
                Subject = "Training session on JSP",
                Description = "Knowledge sharing on JSP topics.",
                StartTime = new DateTime(CurrentYear, 1, 3, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 20, 0, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 30,
                Subject = "Sprint Planning with Team Members",
                Description = "Planning tasks for sprint.",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 31,
                Subject = "Meeting with Client",
                Description = "Customer meeting to discuss features.",
                StartTime = new DateTime(CurrentYear, 1, 3, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 20, 0, 0),
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 32,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 3, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 17, 30, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 33,
                Subject = "Training session on C#",
                Location = "Office",
                Description = "Training session",
                StartTime = new DateTime(CurrentYear, 1, 3, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 16, 0, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 34,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 35,
                Subject = "Appraisal Meeting",
                Description = "Meeting to discuss employee appraisals.",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 16, 30, 0),
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 36,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 37,
                Subject = "Customer Meeting",
                Description = "Meeting to discuss customer reported issues.",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                RoomId = 9
            });
            roomData.Add(new RoomData
            {
                Id = 38,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 17, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 39,
                Subject = "Training session on Vue",
                Description = "Knowledge sharing on Vue concepts.",
                StartTime = new DateTime(CurrentYear, 1, 3, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 40,
                Subject = "Meeting with Team Members",
                Description = "Meeting to discuss on work report.",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 41,
                Subject = "Meeting with General Manager",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 16, 0, 0),
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 43,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 20, 0, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 44,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 19, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 21, 0, 0),
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 45,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 1, 3, 16, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 18, 0, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 46,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 18, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 20, 30, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 47,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 18, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 48,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 19, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 22, 0, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 49,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 16, 0, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 50,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 3, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 51,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 52,
                Subject = "Appraisal Meeting",
                Description = "Meeting to discuss employee appraisals.",
                StartTime = new DateTime(CurrentYear, 1, 3, 20, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 21, 30, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 53,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 17, 0, 0),
                RoomId = 9
            });
            roomData.Add(new RoomData
            {
                Id = 54,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 55,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 56,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 57,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 58,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 59,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 60,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 61,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 62,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 63,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 64,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 9
            });
            roomData.Add(new RoomData
            {
                Id = 65,
                Subject = "Lunch Break",
                StartTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;",
                IsBlock = true,
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 66,
                Subject = "Support Meeting with Managers",
                Description = "Planning tasks for sprint.",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                RoomId = 2
            });
            return roomData;
        }
        public List<RoomData> GetRoomsData()
        {
            List<RoomData> roomData = new List<RoomData>();
            roomData.Add(new RoomData
            {
                Id = 1,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business goal of 2020.",
                StartTime = new DateTime(CurrentYear, 1, 5, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 11, 0, 0),
                RoomId = 10
            });
            roomData.Add(new RoomData
            {
                Id = 2,
                Subject = "Training session on JSP",
                Description = "Knowledge sharing on JSP topics.",
                StartTime = new DateTime(CurrentYear, 1, 7, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 0, 0),
                RoomId = 8
            });
            roomData.Add(new RoomData
            {
                Id = 3,
                Subject = "Sprint Planning with Team Members",
                Description = "Planning tasks for sprint.",
                StartTime = new DateTime(CurrentYear, 1, 9, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 0, 0),
                RoomId = 3
            });
            roomData.Add(new RoomData
            {
                Id = 4,
                Subject = "Meeting with Client",
                Description = "Customer meeting to discuss features.",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 10, 30, 0),
                RoomId = 2
            });
            roomData.Add(new RoomData
            {
                Id = 5,
                Subject = "Support Meeting with Managers",
                Description = "Meeting to discuss support plan.",
                StartTime = new DateTime(CurrentYear, 1, 6, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 13, 30, 0),
                RoomId = 5
            });
            roomData.Add(new RoomData
            {
                Id = 6,
                Subject = "Client Meeting",
                Description = "Meeting to discuss client requirements.",
                StartTime = new DateTime(CurrentYear, 1, 8, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 13, 0, 0),
                RoomId = 1
            });
            roomData.Add(new RoomData
            {
                Id = 7,
                Subject = "Appraisal Meeting",
                Description = "Meeting to discuss employee appraisals.",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                RoomId = 7
            });
            roomData.Add(new RoomData
            {
                Id = 8,
                Subject = "HR Meeting",
                Description = "Meeting to discuss HR plans.",
                StartTime = new DateTime(CurrentYear, 1, 5, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 14, 30, 0),
                RoomId = 6
            });
            roomData.Add(new RoomData
            {
                Id = 9,
                Subject = "Customer Meeting",
                Description = "Meeting to discuss customer reported issues.",
                StartTime = new DateTime(CurrentYear, 1, 9, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                RoomId = 4
            });
            roomData.Add(new RoomData
            {
                Id = 10,
                Subject = "Board Meeting",
                Description = "Meeting to discuss business plans.",
                StartTime = new DateTime(CurrentYear, 1, 11, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 30, 0),
                RoomId = 9
            });
            return roomData;
        }
        public List<HospitalData> GetHospitalData()
        {
            List<HospitalData> hospitalData = new List<HospitalData>();
            hospitalData.Add(new HospitalData
            {
                Id = 10,
                Name = "David",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                Description = "Health Checkup",
                DepartmentID = 1,
                ConsultantID = 1,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 11,
                Name = "John",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 11, 30, 0),
                Description = "Tooth Erosion",
                DepartmentID = 2,
                ConsultantID = 2,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 12,
                Name = "Peter",
                StartTime = new DateTime(CurrentYear, 1, 6, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 13, 0, 0),
                Description = "Eye and Spectacles Checkup",
                DepartmentID = 1,
                ConsultantID = 3,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 13,
                Name = "Starc",
                StartTime = new DateTime(CurrentYear, 1, 6, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 15, 0, 0),
                Description = "Toothaches",
                DepartmentID = 2,
                ConsultantID = 4,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 14,
                Name = "James",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 11, 0, 0),
                Description = "Surgery Appointment",
                DepartmentID = 1,
                ConsultantID = 5,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 15,
                Name = "Jercy",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 10, 30, 0),
                Description = "Tooth Sensitivity",
                DepartmentID = 2,
                ConsultantID = 6,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 16,
                Name = "Albert",
                StartTime = new DateTime(CurrentYear, 1, 7, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 30, 0),
                Description = "Skin care treatment",
                DepartmentID = 1,
                ConsultantID = 7,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 17,
                Name = "Louis",
                StartTime = new DateTime(CurrentYear, 1, 7, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 13, 30, 0),
                Description = "General Checkup",
                DepartmentID = 1,
                ConsultantID = 9,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 18,
                Name = "Williams",
                StartTime = new DateTime(CurrentYear, 1, 7, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 14, 0, 0),
                Description = "Mouth Sores",
                DepartmentID = 2,
                ConsultantID = 10,
                DepartmentName = "DENTAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 19,
                Name = "David",
                StartTime = new DateTime(CurrentYear, 1, 7, 16, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 18, 45, 0),
                Description = "Eye checkup and Treatment",
                DepartmentID = 1,
                ConsultantID = 1,
                DepartmentName = "GENERAL"
            });
            hospitalData.Add(new HospitalData
            {
                Id = 20,
                Name = "John",
                StartTime = new DateTime(CurrentYear, 1, 7, 19, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 21, 45, 0),
                Description = "Tooth Decay",
                DepartmentID = 2,
                ConsultantID = 2,
                DepartmentName = "DENTAL"
            });
            return hospitalData;
        }

        public List<HospitalData> GetWaitingListData()
        {
            List<HospitalData> waitingData = new List<HospitalData>();
            waitingData.Add(new HospitalData
            {
                Id = 1,
                Name = "Steven",
                StartTime = new DateTime(CurrentYear, 1, 3, 7, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 9, 30, 0),
                Description = "Consulting",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 2,
                Name = "Milan",
                StartTime = new DateTime(CurrentYear, 1, 4, 8, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 10, 30, 0),
                Description = "Bad Breath",
                DepartmentName = "DENTAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 3,
                Name = "Laura",
                StartTime = new DateTime(CurrentYear, 1, 4, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 10, 30, 0),
                Description = "Extraction",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 4,
                Name = "Janet",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                Description = "Gum Disease",
                DepartmentName = "DENTAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 5,
                Name = "Adams",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                Description = "Observation",
                DepartmentName = "GENERAL"
            });
            waitingData.Add(new HospitalData
            {
                Id = 6,
                Name = "John",
                StartTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                Description = "Mouth Sores",
                DepartmentName = "DENTAL"
            });
            return waitingData;
        }
        public List<AppointmentData> GetHeaderRowData()
        {
            List<AppointmentData> headerRowData = new List<AppointmentData>();
            headerRowData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Story Time for Kids",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 11, 0, 0),
                CategoryColor = "#df5286"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Camping with Turtles",
                StartTime = new DateTime(CurrentYear, 1, 7, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 17, 0, 0),
                CategoryColor = "#7fa900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Wildlife Warriors",
                StartTime = new DateTime(CurrentYear, 1, 8, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 11, 0, 0),
                CategoryColor = "#ea7a57"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Parrot Talk",
                StartTime = new DateTime(CurrentYear, 1, 8, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 13, 0, 0),
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Croco World",
                StartTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 17, 30, 0),
                CategoryColor = "#fec200"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Venomous Snake Hunt",
                StartTime = new DateTime(CurrentYear, 1, 11, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 16, 30, 0),
                CategoryColor = "#5978ee"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Face Painting & Drawing Events",
                StartTime = new DateTime(CurrentYear, 1, 12, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 9, 0, 0),
                IsAllDay = true,
                CategoryColor = "#00bdae"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Jungle Treasure Hunt",
                StartTime = new DateTime(CurrentYear, 1, 16),
                EndTime = new DateTime(CurrentYear, 1, 19),
                IsAllDay = true,
                CategoryColor = "#7FA900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Endangered Species Program",
                StartTime = new DateTime(CurrentYear, 1, 17, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 12, 0, 0),
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Black Cockatoos Playtime",
                StartTime = new DateTime(CurrentYear, 1, 18),
                EndTime = new DateTime(CurrentYear, 1, 22),
                IsAllDay = true,
                CategoryColor = "#ea7a57"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Walk with Jungle King",
                StartTime = new DateTime(CurrentYear, 1, 22, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 11, 0, 0),
                CategoryColor = "#fec200"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Trained Climbers",
                StartTime = new DateTime(CurrentYear, 1, 25),
                EndTime = new DateTime(CurrentYear, 1, 27),
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Playtime with Chimpanzees",
                StartTime = new DateTime(CurrentYear, 1, 23, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 11, 0, 0),
                CategoryColor = "#df5286"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Meet a small Mammal",
                StartTime = new DateTime(CurrentYear, 1, 28, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Amazon Fish Feeding",
                StartTime = new DateTime(CurrentYear, 1, 27),
                EndTime = new DateTime(CurrentYear, 1, 29),
                IsAllDay = true,
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Elephant Ride",
                StartTime = new DateTime(CurrentYear, 1, 29, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 1, 16, 0, 0),
                CategoryColor = "#7fa900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "Black Cockatoos Playtime",
                StartTime = new DateTime(CurrentYear, 1, 31),
                EndTime = new DateTime(CurrentYear, 2, 4),
                IsAllDay = true,
                CategoryColor = "#ea7a57"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Endangered Species Program",
                StartTime = new DateTime(CurrentYear, 2, 1, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 3, 12, 0, 0),
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Feed the Giants",
                StartTime = new DateTime(CurrentYear, 2, 2, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 5, 17, 0, 0),
                CategoryColor = "#00bdae"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Birds of Prey",
                StartTime = new DateTime(CurrentYear, 2, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 12, 17, 30, 0),
                CategoryColor = "#865fcf"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Trained Climbers",
                StartTime = new DateTime(CurrentYear, 2, 5),
                EndTime = new DateTime(CurrentYear, 2, 8),
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "Venomous Snake Hunt",
                StartTime = new DateTime(CurrentYear, 2, 7, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 10, 16, 30, 0),
                CategoryColor = "#5978ee"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Croco World",
                StartTime = new DateTime(CurrentYear, 2, 11, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 14, 17, 30, 0),
                CategoryColor = "#7fa900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Amazon Fish Feeding",
                StartTime = new DateTime(CurrentYear, 2, 13),
                EndTime = new DateTime(CurrentYear, 2, 16),
                IsAllDay = true,
                CategoryColor = "#1aaa55"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 25,
                Subject = "Playtime with Chimpanzees",
                StartTime = new DateTime(CurrentYear, 2, 15, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 2, 18, 11, 0, 0),
                CategoryColor = "#df5286"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 26,
                Subject = "Meet a Small Mammal",
                StartTime = new DateTime(CurrentYear, 2, 17, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 20, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            headerRowData.Add(new AppointmentData
            {
                Id = 27,
                Subject = "Black Cockatoos Playtime",
                StartTime = new DateTime(CurrentYear, 2, 18),
                EndTime = new DateTime(CurrentYear, 2, 22),
                IsAllDay = true,
                CategoryColor = "#ea7a57"
            });
            return headerRowData;
        }
        public List<BlockData> GetBlockData()
        {
            List<BlockData> blockData = new List<BlockData>();
            blockData.Add(new BlockData
            {
                Id = 1,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=10",
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 1
            });
            blockData.Add(new BlockData
            {
                Id = 2,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 3, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 20, 0, 0),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 2
            });
            blockData.Add(new BlockData
            {
                Id = 3,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 3
            });
            blockData.Add(new BlockData
            {
                Id = 4,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 4, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 10, 0, 0),
                IsAllDay = true,
                IsBlock = true,
                EmployeeId = 4
            });
            blockData.Add(new BlockData
            {
                Id = 5,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 10, 0, 0),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 5
            });
            blockData.Add(new BlockData
            {
                Id = 6,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 8),
                EndTime = new DateTime(CurrentYear, 1, 11),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 6
            });
            blockData.Add(new BlockData
            {
                Id = 7,
                Subject = "Client Meeting",
                StartTime = new DateTime(CurrentYear, 1, 3, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                IsAllDay = false,
                EmployeeId = 3
            });
            blockData.Add(new BlockData
            {
                Id = 8,
                Subject = "Conference",
                StartTime = new DateTime(CurrentYear, 1, 2, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 2, 15, 0, 0),
                IsAllDay = false,
                EmployeeId = 4
            });
            blockData.Add(new BlockData
            {
                Id = 9,
                Subject = "Employee Recruitment",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 13, 0, 0),
                IsAllDay = false,
                EmployeeId = 5
            });
            blockData.Add(new BlockData
            {
                Id = 10,
                Subject = "Data Analyzing",
                StartTime = new DateTime(CurrentYear, 1, 3, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 17, 0, 0),
                IsAllDay = false,
                EmployeeId = 6
            });
            blockData.Add(new BlockData
            {
                Id = 11,
                Subject = "Content Writing",
                StartTime = new DateTime(CurrentYear, 1, 2, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 2, 16, 0, 0),
                IsAllDay = false,
                EmployeeId = 1
            });
            blockData.Add(new BlockData
            {
                Id = 12,
                Subject = "Meeting",
                StartTime = new DateTime(CurrentYear, 1, 3, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 0, 0),
                IsAllDay = false,
                EmployeeId = 4
            });
            blockData.Add(new BlockData
            {
                Id = 13,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 29, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 31, 10, 0, 0),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 4
            });
            blockData.Add(new BlockData
            {
                Id = 14,
                Subject = "Not available",
                StartTime = new DateTime(CurrentYear, 1, 12),
                EndTime = new DateTime(CurrentYear, 1, 15),
                IsAllDay = false,
                IsBlock = true,
                EmployeeId = 3
            });
            return blockData;
        }
        public List<AppointmentData> GetRecurrenceData()
        {
            List<AppointmentData> recurrenceData = new List<AppointmentData>();
            recurrenceData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Project demo meeting with Andrew",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 8, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 13, 0, 0),
                RecurrenceRule = "FREQ=WEEKLY;INTERVAL=2;BYDAY=MO;COUNT=10",
                CategoryColor = "#1aaa55",
                Description = "Project demo meeting with Andrew regarding timeline"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Scrum Meeting",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 6, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 10, 30, 0),
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR;INTERVAL=1",
                RecurrenceException = CurrentYear + "0113T040000Z",
                CategoryColor = "#357cd2",
                Description = "Daily work plan discussion"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "General meeting",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 10, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
                CategoryColor = "#7fa900",
                Description = "Future plans and possibilities"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Customer meeting – John Mackenzie",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 14, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 13, 30, 0),
                RecurrenceRule = "FREQ=MONTHLY;BYMONTHDAY=20;INTERVAL=1;COUNT=5",
                CategoryColor = "#ea7a57",
                Description = "Regarding DataSource issue"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Annual day",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 14, 0, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 0, 0, 0),
                IsAllDay = true,
                RecurrenceRule = "FREQ=YEARLY;BYMONTHDAY=14;BYMONTH=1;INTERVAL=1;COUNT=5",
                CategoryColor = "#7fa900",
                Description = "Annual day celebration"
            });
            recurrenceData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Scrum Meeting - Postponed",
                Location = "Office",
                StartTime = new DateTime(CurrentYear, 1, 13, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 11, 30, 0),
                RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU,WE,TH,FR;INTERVAL=1",
                RecurrenceID = 2,
                CategoryColor = "#357cd2",
                Description = "Daily work plan discussion"
            });
            return recurrenceData;
        }
        public List<FifaEventsData> GetFifaEventsData()
        {
            List<FifaEventsData> fifaEventsData = new List<FifaEventsData>();
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 1,
                Subject = "RUSSIA vs SAUDI ARABIA",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 16, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 2,
                Subject = "EGYPT vs URUGUAY",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 17, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 3,
                Subject = "MOROCCO vs IR IRAN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 17, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 4,
                Subject = "PORTUGAL vs SPAIN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 17, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 5,
                Subject = "FRANCE vs AUSTRALIA",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 1, 18, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 12, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 6,
                Subject = "ARGENTINA vs ICELAND",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 18, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 15, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 7,
                Subject = "PERU vs DENMARK",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 1, 18, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 18, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 8,
                Subject = "CROATIA vs NIGERIA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 18, 19, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 21, 0, 0),
                StartTimezone = "Europe/Kaliningrad",
                EndTimezone = "Europe/Kaliningrad",
                City = "Kaliningrad",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 9,
                Subject = "COSTA RICA vs SERBIA",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 19, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 14, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#00bdae",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 10,
                Subject = "GERMANY vs MEXICO",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 19, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 11,
                Subject = "BRAZIL vs SWITZERLAND",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 19, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#00bdae",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 12,
                Subject = "SWEDEN vs KOREA REPUBLIC",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 20, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 13,
                Subject = "BELGIUM vs PANAMA",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 20, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#8e24aa",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 14,
                Subject = "TUNISIA vs ENGLAND",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 20, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 20, 0, 0),
                StartTimezone = "Europe/Volgograd",
                EndTimezone = "Europe/Volgograd",
                City = "Volgograd",
                CategoryColor = "#8e24aa",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 15,
                Subject = "COLOMBIA vs JAPAN",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 21, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 16,
                Subject = "POLAND vs SENEGAL",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 21, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#7fa900",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 17,
                Subject = "RUSSIA vs EGYPT",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 21, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 18,
                Subject = "PORTUGAL vs MOROCCO",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 22, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 19,
                Subject = "URUGUAY vs SAUDI ARABIA",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 22, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 20,
                Subject = "IR IRAN vs SPAIN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 22, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 21,
                Subject = "DENMARK vs AUSTRALIA",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 1, 23, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 14, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 22,
                Subject = "FRANCE vs PERU",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 23, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 17, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 23,
                Subject = "ARGENTINA vs CROATIA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 23, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#ea7a57",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 24,
                Subject = "BRAZIL vs COSTA RICA",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 24, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 24, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#00bdae",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 25,
                Subject = "NIGERIA vs ICELAND",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 24, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 24, 17, 0, 0),
                StartTimezone = "Europe/Volgograd",
                EndTimezone = "Europe/Volgograd",
                City = "Volgograd",
                CategoryColor = "#ea7a57",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 26,
                Subject = "SERBIA vs SWITZERLAND",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 24, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 24, 20, 0, 0),
                StartTimezone = "Europe/Kaliningrad",
                EndTimezone = "Europe/Kaliningrad",
                City = "Kaliningrad",
                CategoryColor = "#00bdae",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 27,
                Subject = "BELGIUM vs TUNISIA",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 25, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#8e24aa",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 28,
                Subject = "KOREA REPUBLIC vs MEXICO",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 25, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 29,
                Subject = "GERMANY vs SWEDEN",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 25, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#f57f17",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 30,
                Subject = "ENGLAND vs PANAMA",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 26, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#8e24aa",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 31,
                Subject = "JAPAN vs SENEGAL",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 26, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 17, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 32,
                Subject = "POLAND vs COLOMBIA",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 26, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#7fa900",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 33,
                Subject = "URUGUAY vs RUSSIA",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 27, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 27, 16, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 34,
                Subject = "SAUDI ARABIA vs EGYPT",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 1, 27, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 27, 16, 0, 0),
                StartTimezone = "Europe/Volgograd",
                EndTimezone = "Europe/Volgograd",
                City = "Volgograd",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 35,
                Subject = "IR IRAN vs PORTUGAL",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 27, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 27, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 36,
                Subject = "SPAIN vs MOROCCO",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 1, 27, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 27, 20, 0, 0),
                StartTimezone = "Europe/Kaliningrad",
                EndTimezone = "Europe/Kaliningrad",
                City = "Kaliningrad",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 37,
                Subject = "DENMARK vs FRANCE",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 1, 28, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 28, 16, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 38,
                Subject = "AUSTRALIA vs PERU",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 1, 28, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 28, 16, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#7fa900",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 39,
                Subject = "NIGERIA vs ARGENTINA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 28, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 28, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#ea7a57",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 40,
                Subject = "ICELAND vs CROATIA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 1, 28, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 28, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 41,
                Subject = "MEXICO vs SWEDEN",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 29, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 29, 16, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#f57f17",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 42,
                Subject = "KOREA REPUBLIC vs GERMANY",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 1, 29, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 29, 16, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 43,
                Subject = "SERBIA vs BRAZIL",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 29, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 29, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#00bdae",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 44,
                Subject = "SWITZERLAND vs COSTA RICA",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 1, 29, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 29, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#00bdae",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 45,
                Subject = "JAPAN vs POLAND",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 30, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 16, 0, 0),
                StartTimezone = "Europe/Volgograd",
                EndTimezone = "Europe/Volgograd",
                City = "Volgograd",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 46,
                Subject = "SENEGAL vs COLOMBIA",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 1, 30, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 16, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#7fa900",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 47,
                Subject = "PANAMA vs TUNISIA",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 30, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#8e24aa",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 48,
                Subject = "ENGLAND vs BELGIUM",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 1, 30, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 30, 20, 0, 0),
                StartTimezone = "Europe/Kaliningrad",
                EndTimezone = "Europe/Kaliningrad",
                City = "Kaliningrad",
                CategoryColor = "#8e24aa",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 49,
                Subject = "RUSSIA vs SAUDI ARABIA",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 2, 1, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 1, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 50,
                Subject = "EGYPT vs URUGUAY",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 2, 3, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 3, 14, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 51,
                Subject = "MOROCCO vs IR IRAN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 2, 4, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 4, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 52,
                Subject = "PORTUGAL vs SPAIN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 2, 5, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 5, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 53,
                Subject = "FRANCE vs AUSTRALIA",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 2, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 6, 12, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 54,
                Subject = "ARGENTINA vs ICELAND",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 2, 7, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 7, 15, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 55,
                Subject = "PERU vs DENMARK",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 2, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 9, 18, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 56,
                Subject = "CROATIA vs NIGERIA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 2, 10, 19, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 10, 21, 0, 0),
                StartTimezone = "Europe/Kaliningrad",
                EndTimezone = "Europe/Kaliningrad",
                City = "Kaliningrad",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 57,
                Subject = "COSTA RICA vs SERBIA",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 2, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 13, 14, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#00bdae",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 58,
                Subject = "GERMANY vs MEXICO",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 2, 14, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 14, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 59,
                Subject = "BRAZIL vs SWITZERLAND",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 2, 14, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 14, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#00bdae",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 60,
                Subject = "SWEDEN vs KOREA REPUBLIC",
                Description = "Group F",
                StartTime = new DateTime(CurrentYear, 2, 17, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 17, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#f57f17",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 61,
                Subject = "BELGIUM vs PANAMA",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 2, 17, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 17, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Sochi",
                CategoryColor = "#8e24aa",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 62,
                Subject = "TUNISIA vs ENGLAND",
                Description = "Group G",
                StartTime = new DateTime(CurrentYear, 2, 17, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 17, 20, 0, 0),
                StartTimezone = "Europe/Volgograd",
                EndTimezone = "Europe/Volgograd",
                City = "Volgograd",
                CategoryColor = "#8e24aa",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 63,
                Subject = "COLOMBIA vs JAPAN",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 2, 18, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 18, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saransk",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 64,
                Subject = "POLAND vs SENEGAL",
                Description = "Group H",
                StartTime = new DateTime(CurrentYear, 2, 21, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 21, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#7fa900",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 65,
                Subject = "RUSSIA vs EGYPT",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 2, 21, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 21, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 66,
                Subject = "PORTUGAL vs MOROCCO",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 2, 22, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 22, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Rostov-On-Don",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 67,
                Subject = "URUGUAY vs SAUDI ARABIA",
                Description = "Group A",
                StartTime = new DateTime(CurrentYear, 2, 22, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 22, 17, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Moscow",
                CategoryColor = "#1aaa55",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 68,
                Subject = "IR IRAN vs SPAIN",
                Description = "Group B",
                StartTime = new DateTime(CurrentYear, 3, 4, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 4, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Kazan",
                CategoryColor = "#357cd2",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 69,
                Subject = "DENMARK vs AUSTRALIA",
                Description = "Group C",
                StartTime = new DateTime(CurrentYear, 3, 5, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 5, 14, 0, 0),
                StartTimezone = "Europe/Samara",
                EndTimezone = "Europe/Samara",
                City = "Samara",
                CategoryColor = "#7fa900",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 70,
                Subject = "FRANCE vs PERU",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 3, 5, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 7, 17, 0, 0),
                StartTimezone = "Asia/Yekaterinburg",
                EndTimezone = "Asia/Yekaterinburg",
                City = "Ekaterinburg",
                CategoryColor = "#ea7a57",
                GroupId = 2
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 71,
                Subject = "ARGENTINA vs CROATIA",
                Description = "Group D",
                StartTime = new DateTime(CurrentYear, 3, 7, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 7, 20, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Nizhny Novgorod",
                CategoryColor = "#ea7a57",
                GroupId = 1
            });
            fifaEventsData.Add(new FifaEventsData
            {
                Id = 72,
                Subject = "BRAZIL vs COSTA RICA",
                Description = "Group E",
                StartTime = new DateTime(CurrentYear, 3, 24, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 24, 14, 0, 0),
                StartTimezone = "Europe/Moscow",
                EndTimezone = "Europe/Moscow",
                City = "Saint Petersburg",
                CategoryColor = "#00bdae",
                GroupId = 2
            });
            return fifaEventsData;
        }
        public List<DoctorsEventData> GetDoctorsEventData()
        {
            List<DoctorsEventData> doctorsEventData = new List<DoctorsEventData>();
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 1,
                Subject = "Surgery - Andrew",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 0, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 2,
                Subject = "Consulting - John",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 3,
                Subject = "Therapy - Robert",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 4,
                Subject = "Observation - Steven",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 13, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 5,
                Subject = "Extraction - Nancy",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 10, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 15, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 6,
                Subject = "Surgery - Paul",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 10, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 7,
                Subject = "Extraction - Josephs",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 11, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 11, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 8,
                Subject = "Consulting - Mario",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 11, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 12, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 9,
                Subject = "Therapy - Saveley",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 11, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 13, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 10,
                Subject = "Observation - Cartrain",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 11, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 15, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 11,
                Subject = "Consulting - Yang",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 12, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 10, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 12,
                Subject = "Observation - Michael",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 12, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 13,
                Subject = "Surgery - Roland",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 12, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 14,
                Subject = "Extraction - Francisco",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 12, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 13, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 15,
                Subject = "Therapy - Henriette",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 12, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 15, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 16,
                Subject = "Observation - Bernardo",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 13, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 10, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 17,
                Subject = "Therapy - Wilson",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 13, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 18,
                Subject = "Consulting - Horst",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 19,
                Subject = "Surgery - Limeira",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 13, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 20,
                Subject = "Observation - Victoria",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 13, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 15, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 21,
                Subject = "Extraction - Afonso",
                EventType = "Confirmed",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 10, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 22,
                Subject = "Extraction - Paula",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 14, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 23,
                Subject = "Observation - George",
                EventType = "Requested",
                StartTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 12, 0, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 24,
                Subject = "Therapy - Smith",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 14, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 13, 30, 0)
            });
            doctorsEventData.Add(new DoctorsEventData
            {
                Id = 25,
                Subject = "Surgery - Jennifer",
                EventType = "New",
                StartTime = new DateTime(CurrentYear, 1, 14, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 15, 30, 0, 0)
            });
            return doctorsEventData;
        }
        public List<WebinarData> GetWebinarData()
        {
            List<WebinarData> webinarData = new List<WebinarData>();
            webinarData.Add(new WebinarData
            {
                Id = 1,
                Subject = "Environment Day",
                Tags = "Eco day, Forest conserving, Earth & its resources",
                Description = "A day that creates awareness to promote the healthy planet and reduce the air pollution crisis on nature earth.",
                StartTime = new DateTime(CurrentYear, 1, 10, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 14, 0, 0),
                ImageName = "environment-day",
                PrimaryColor = "#1aaa55",
                SecondaryColor = "#47bb76"
            });
            webinarData.Add(new WebinarData
            {
                Id = 2,
                Subject = "Health Day",
                Tags = "Reduce mental stress, Follow good food habits",
                Description = "A day that raises awareness on different health issues. It marks the anniversary of the foundation of WHO.",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 0, 0),
                ImageName = "health-day",
                PrimaryColor = "#357cd2",
                SecondaryColor = "#5d96db"
            });
            webinarData.Add(new WebinarData
            {
                Id = 3,
                Subject = "Cancer Day",
                Tags = "Life threatening cancer effects, Palliative care",
                Description = "A day that raises awareness on cancer and its preventive measures. Early detection saves life.",
                StartTime = new DateTime(CurrentYear, 1, 12, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 14, 0, 0),
                ImageName = "cancer-day",
                PrimaryColor = "#7fa900",
                SecondaryColor = "#a4c932"
            });
            webinarData.Add(new WebinarData
            {
                Id = 4,
                Subject = "Happiness Day",
                Tags = "Stress-free, Smile, Resolve frustration and bring happiness",
                Description = "A general idea is to promote happiness and smile around the world.",
                StartTime = new DateTime(CurrentYear, 1, 13, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                ImageName = "happiness-day",
                PrimaryColor = "#ea7a57",
                SecondaryColor = "#ee9478"
            });
            webinarData.Add(new WebinarData
            {
                Id = 5,
                Subject = "Tourism Day",
                Tags = "Diverse cultural heritage, strengthen peace",
                Description = "A day that raises awareness on the role of tourism and its effect on social and economic values.",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 14, 0, 0),
                ImageName = "tourism-day",
                PrimaryColor = "#00bdae",
                SecondaryColor = "#32cabe"
            });
            return webinarData;
        }
        public List<EventsData> GetEventsData()
        {
            List<EventsData> eventsData = new List<EventsData>();
            eventsData.Add(new EventsData
            {
                Id = 1,
                Subject = "Server Maintenance",
                StartTime = new DateTime(CurrentYear, 1, 12, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0),
                EventType = "maintenance",
                City = "Seattle",
                CategoryColor = "#1aaa55"
            });
            eventsData.Add(new EventsData
            {
                Id = 2,
                Subject = "Art & Painting Gallery",
                StartTime = new DateTime(CurrentYear, 1, 13, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                EventType = "public-event",
                City = "Costa Rica",
                CategoryColor = "#357cd2"
            });
            eventsData.Add(new EventsData
            {
                Id = 3,
                Subject = "Dany Birthday Celebration",
                StartTime = new DateTime(CurrentYear, 1, 14, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 30, 0),
                EventType = "family-event",
                City = "Kirkland",
                CategoryColor = "#7fa900"
            });
            eventsData.Add(new EventsData
            {
                Id = 4,
                Subject = "John Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 1, 15, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 10, 0, 0),
                EventType = "family-event",
                City = "Redmond",
                CategoryColor = "#ea7a57"
            });
            eventsData.Add(new EventsData
            {
                Id = 5,
                Subject = "ISA Annual Conference",
                StartTime = new DateTime(CurrentYear, 1, 16, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 11, 30, 0),
                EventType = "commercial-event",
                City = "USA",
                CategoryColor = "#00bdae"
            });
            eventsData.Add(new EventsData
            {
                Id = 6,
                Subject = "Equipment Maintenance",
                StartTime = new DateTime(CurrentYear, 1, 17, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 14, 0, 0),
                EventType = "maintenance",
                City = "Seattle",
                CategoryColor = "#f57f17"
            });
            eventsData.Add(new EventsData
            {
                Id = 7,
                Subject = "Aircraft Maintenance",
                StartTime = new DateTime(CurrentYear, 1, 18, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 11, 30, 0),
                EventType = "maintenance",
                City = "Seattle",
                CategoryColor = "#1aaa55"
            });
            eventsData.Add(new EventsData
            {
                Id = 8,
                Subject = "Facilities Maintenance",
                StartTime = new DateTime(CurrentYear, 1, 20, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 11, 0, 0),
                EventType = "maintenance",
                City = "Seattle",
                CategoryColor = "#357cd2"
            });
            eventsData.Add(new EventsData
            {
                Id = 9,
                Subject = "Britto Birthday Celebration",
                StartTime = new DateTime(CurrentYear, 1, 22, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 13, 0, 0),
                EventType = "family-event",
                City = "Greenland",
                CategoryColor = "#7fa900"
            });
            eventsData.Add(new EventsData
            {
                Id = 10,
                Subject = "Justin Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 1, 23, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 11, 0, 0),
                EventType = "family-event",
                City = "Finland",
                CategoryColor = "#ea7a57"
            });
            eventsData.Add(new EventsData
            {
                Id = 11,
                Subject = "AIEA Annual Meet",
                StartTime = new DateTime(CurrentYear, 1, 10, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 11, 30, 0),
                EventType = "commercial-event",
                City = "USA",
                CategoryColor = "#00bdae"
            });
            eventsData.Add(new EventsData
            {
                Id = 12,
                Subject = "AAN Conference",
                StartTime = new DateTime(CurrentYear, 1, 8, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 12, 30, 0),
                EventType = "commercial-event",
                City = "USA",
                CategoryColor = "#f57f17"
            });
            eventsData.Add(new EventsData
            {
                Id = 13,
                Subject = "Photography Gallery",
                StartTime = new DateTime(CurrentYear, 1, 6, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 11, 30, 0),
                EventType = "public-event",
                City = "Chennai",
                CategoryColor = "#1aaa55"
            });
            eventsData.Add(new EventsData
            {
                Id = 14,
                Subject = "Beach Clean-up",
                StartTime = new DateTime(CurrentYear, 1, 15, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 2, 0, 0),
                EventType = "public-event",
                City = "Mumbai",
                CategoryColor = "#357cd2"
            });
            eventsData.Add(new EventsData
            {
                Id = 15,
                Subject = "Turtle Walk",
                StartTime = new DateTime(CurrentYear, 1, 20, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 14, 30, 0),
                EventType = "public-event",
                City = "Costa Rica",
                CategoryColor = "#7fa900"
            });
            eventsData.Add(new EventsData
            {
                Id = 16,
                Subject = "Silent Walk for Cancer day",
                StartTime = new DateTime(CurrentYear, 1, 23, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 23, 14, 30, 0),
                EventType = "public-event",
                City = "Chennai",
                CategoryColor = "#ea7a57"
            });
            eventsData.Add(new EventsData
            {
                Id = 17,
                Subject = "Beach Clean-up",
                StartTime = new DateTime(CurrentYear, 1, 14, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 16, 0, 0),
                EventType = "public-event",
                City = "Mumbai",
                CategoryColor = "#357cd2"
            });
            eventsData.Add(new EventsData
            {
                Id = 18,
                Subject = "Photography Gallery",
                StartTime = new DateTime(CurrentYear, 1, 16, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 16, 0, 0),
                EventType = "public-event",
                City = "Chennai",
                CategoryColor = "#1aaa55"
            });

            return eventsData;
        }
        public List<AppointmentData> GetEmployeeEventData()
        {
            List<AppointmentData> employeeEventData = new List<AppointmentData>();
            employeeEventData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Project Workflow Analysis",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 11, 0, 0),
                CategoryColor = "#1aaa55"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Project Requirement Planning",
                StartTime = new DateTime(CurrentYear, 1, 12, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 12, 14, 0, 0),
                CategoryColor = "#357cd2"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Quality Analysis",
                StartTime = new DateTime(CurrentYear, 1, 13, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Timeline Estimation",
                StartTime = new DateTime(CurrentYear, 1, 13, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 14, 0, 0),
                CategoryColor = "#ea7a57"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Project Resource Planning",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 12, 0, 0),
                CategoryColor = "#00bdae"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Meeting with Developers",
                StartTime = new DateTime(CurrentYear, 1, 15, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 13, 0, 0),
                CategoryColor = "#f57f17"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Task Assignment to Developers",
                StartTime = new DateTime(CurrentYear, 1, 18, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 18, 11, 30, 0),
                CategoryColor = "#1aaa55"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Project Review - 1",
                StartTime = new DateTime(CurrentYear, 1, 19, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 19, 12, 30, 0),
                CategoryColor = "#357cd2"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Project Review - 2",
                StartTime = new DateTime(CurrentYear, 1, 20, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 20, 13, 30, 0),
                CategoryColor = "#7fa900"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Project Review - 3",
                StartTime = new DateTime(CurrentYear, 1, 21, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 21, 12, 30, 0),
                CategoryColor = "#ea7a57"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Project Output Preview",
                StartTime = new DateTime(CurrentYear, 1, 22, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 22, 12, 0, 0),
                CategoryColor = "#00bdae"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Testing Project Quality",
                StartTime = new DateTime(CurrentYear, 1, 25, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 25, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Draft Technical Documentation",
                StartTime = new DateTime(CurrentYear, 1, 26, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 26, 13, 0, 0),
                CategoryColor = "#1aaa55"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Online Hosting of Project",
                StartTime = new DateTime(CurrentYear, 1, 27, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 27, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Project Submission to Client",
                StartTime = new DateTime(CurrentYear, 2, 1, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 1, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            employeeEventData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Review Meeting with Client",
                StartTime = new DateTime(CurrentYear, 2, 2, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 2, 2, 11, 30, 0),
                CategoryColor = "#ea7a57"
            });
            return employeeEventData;
        }
        public List<ResourceEventsData> GetHolidayData()
        {
            List<ResourceEventsData> holidayData = new List<ResourceEventsData>();
            holidayData.Add(new ResourceEventsData
            {
                Id = 401,
                Subject = "Global Family Day",
                StartTime = new DateTime(CurrentYear, 1, 1),
                EndTime = new DateTime(CurrentYear, 1, 2),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 402,
                Subject = "World Braille Day",
                StartTime = new DateTime(CurrentYear, 1, 4),
                EndTime = new DateTime(CurrentYear, 1, 5),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 403,
                Subject = "World Literary Day",
                StartTime = new DateTime(CurrentYear, 1, 8),
                EndTime = new DateTime(CurrentYear, 1, 9),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 404,
                Subject = "International Thank-You Day",
                StartTime = new DateTime(CurrentYear, 1, 11),
                EndTime = new DateTime(CurrentYear, 1, 12),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 405,
                Subject = "World Leprosy Day",
                StartTime = new DateTime(CurrentYear, 1, 30),
                EndTime = new DateTime(CurrentYear, 1, 31),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 406,
                Subject = "Darwin Day",
                StartTime = new DateTime(CurrentYear, 2, 12),
                EndTime = new DateTime(CurrentYear, 2, 13),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 407,
                Subject = "International Mother Language Day",
                StartTime = new DateTime(CurrentYear, 2, 21),
                EndTime = new DateTime(CurrentYear, 2, 22),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 408,
                Subject = "World Thinking Day",
                StartTime = new DateTime(CurrentYear, 2, 22),
                EndTime = new DateTime(CurrentYear, 2, 23),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 409,
                Subject = "International Day of the Seal",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 410,
                Subject = "International Women’s Day",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 411,
                Subject = "World Book Day",
                StartTime = new DateTime(CurrentYear, 3, 14),
                EndTime = new DateTime(CurrentYear, 3, 15),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 412,
                Subject = "World Frog Day",
                StartTime = new DateTime(CurrentYear, 3, 20),
                EndTime = new DateTime(CurrentYear, 3, 21),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 413,
                Subject = "World Down Syndrome Day",
                StartTime = new DateTime(CurrentYear, 3, 21),
                EndTime = new DateTime(CurrentYear, 3, 22),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 414,
                Subject = "World Day for Water",
                StartTime = new DateTime(CurrentYear, 3, 22),
                EndTime = new DateTime(CurrentYear, 3, 23),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 415,
                Subject = "World Meteorological Day",
                StartTime = new DateTime(CurrentYear, 3, 23),
                EndTime = new DateTime(CurrentYear, 3, 24),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 416,
                Subject = "International Children’s Book Day",
                StartTime = new DateTime(CurrentYear, 4, 2),
                EndTime = new DateTime(CurrentYear, 4, 3),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 417,
                Subject = "World Health Day",
                StartTime = new DateTime(CurrentYear, 4, 7),
                EndTime = new DateTime(CurrentYear, 4, 8),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 418,
                Subject = "International Special Librarian’s",
                StartTime = new DateTime(CurrentYear, 4, 13),
                EndTime = new DateTime(CurrentYear, 4, 14),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 419,
                Subject = "International Creativity and Innovation Day",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 420,
                Subject = "Earth Day",
                StartTime = new DateTime(CurrentYear, 4, 22),
                EndTime = new DateTime(CurrentYear, 4, 23),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 421,
                Subject = "World Copyright Day",
                StartTime = new DateTime(CurrentYear, 4, 23),
                EndTime = new DateTime(CurrentYear, 4, 24),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 422,
                Subject = "World Penguin Day",
                StartTime = new DateTime(CurrentYear, 4, 25),
                EndTime = new DateTime(CurrentYear, 4, 26),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 423,
                Subject = "World Press Freedom Day",
                StartTime = new DateTime(CurrentYear, 5, 3),
                EndTime = new DateTime(CurrentYear, 5, 4),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 424,
                Subject = "International Midwives Day",
                StartTime = new DateTime(CurrentYear, 5, 5),
                EndTime = new DateTime(CurrentYear, 5, 5),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 425,
                Subject = "World Red Cross Day",
                StartTime = new DateTime(CurrentYear, 5, 8),
                EndTime = new DateTime(CurrentYear, 5, 9),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 426,
                Subject = "World Lupus Day",
                StartTime = new DateTime(CurrentYear, 5, 10),
                EndTime = new DateTime(CurrentYear, 5, 11),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 427,
                Subject = "International Nurses Day",
                StartTime = new DateTime(CurrentYear, 5, 12),
                EndTime = new DateTime(CurrentYear, 5, 12),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 428,
                Subject = "IEEE Global Engineering Day",
                StartTime = new DateTime(CurrentYear, 5, 13),
                EndTime = new DateTime(CurrentYear, 5, 14),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 429,
                Subject = "International Day of Families",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 430,
                Subject = "International Museum Day",
                StartTime = new DateTime(CurrentYear, 5, 18),
                EndTime = new DateTime(CurrentYear, 5, 19),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 431,
                Subject = "World Turtle Day",
                StartTime = new DateTime(CurrentYear, 5, 23),
                EndTime = new DateTime(CurrentYear, 5, 24),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 432,
                Subject = "World No-Tobacco Day",
                StartTime = new DateTime(CurrentYear, 5, 31),
                EndTime = new DateTime(CurrentYear, 6, 1),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 433,
                Subject = "World Ocean Day",
                StartTime = new DateTime(CurrentYear, 6, 8),
                EndTime = new DateTime(CurrentYear, 6, 9),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 434,
                Subject = "World Blood Donor Day",
                StartTime = new DateTime(CurrentYear, 6, 14),
                EndTime = new DateTime(CurrentYear, 6, 15),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 435,
                Subject = "World Day to Combat Desertification & Drought",
                StartTime = new DateTime(CurrentYear, 6, 17),
                EndTime = new DateTime(CurrentYear, 6, 18),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 436,
                Subject = "World Refugee Day",
                StartTime = new DateTime(CurrentYear, 6, 20),
                EndTime = new DateTime(CurrentYear, 6, 21),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 437,
                Subject = "International Day Against Drug Abuse & Trafficking",
                StartTime = new DateTime(CurrentYear, 6, 26),
                EndTime = new DateTime(CurrentYear, 6, 27),
                IsAllDay = true,
                CalendarId = 4
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 201,
                Subject = "Conference meeting",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 202,
                Subject = "Product discussion",
                StartTime = new DateTime(CurrentYear, 3, 4),
                EndTime = new DateTime(CurrentYear, 3, 5),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 203,
                Subject = "Company's growth related discussion",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 204,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 3, 11),
                EndTime = new DateTime(CurrentYear, 3, 12),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 205,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 3, 13),
                EndTime = new DateTime(CurrentYear, 3, 14),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 206,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 3, 18),
                EndTime = new DateTime(CurrentYear, 3, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 207,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 3, 21),
                EndTime = new DateTime(CurrentYear, 3, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 208,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 3, 24),
                EndTime = new DateTime(CurrentYear, 3, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 209,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 3, 28),
                EndTime = new DateTime(CurrentYear, 3, 29),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 210,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 3, 30),
                EndTime = new DateTime(CurrentYear, 3, 31),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 211,
                Subject = "Conference Meeting",
                StartTime = new DateTime(CurrentYear, 4, 1),
                EndTime = new DateTime(CurrentYear, 4, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 212,
                Subject = "Product Discussion",
                StartTime = new DateTime(CurrentYear, 4, 3),
                EndTime = new DateTime(CurrentYear, 4, 4),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 213,
                Subject = "Company's growth related issues",
                StartTime = new DateTime(CurrentYear, 4, 7),
                EndTime = new DateTime(CurrentYear, 4, 8),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 214,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 4, 12),
                EndTime = new DateTime(CurrentYear, 4, 13),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 215,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 216,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 4, 18),
                EndTime = new DateTime(CurrentYear, 4, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 217,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 218,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 4, 24),
                EndTime = new DateTime(CurrentYear, 4, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 219,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 4, 26),
                EndTime = new DateTime(CurrentYear, 4, 27),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 220,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 221,
                Subject = "Conference Meeting",
                StartTime = new DateTime(CurrentYear, 5, 1),
                EndTime = new DateTime(CurrentYear, 5, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 222,
                Subject = "Product Discussion",
                StartTime = new DateTime(CurrentYear, 5, 3),
                EndTime = new DateTime(CurrentYear, 5, 4),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 223,
                Subject = "Company's growth related issues",
                StartTime = new DateTime(CurrentYear, 5, 9),
                EndTime = new DateTime(CurrentYear, 5, 10),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 224,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 5, 13),
                EndTime = new DateTime(CurrentYear, 5, 14),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 225,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 226,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 5, 18),
                EndTime = new DateTime(CurrentYear, 5, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 227,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 5, 21),
                EndTime = new DateTime(CurrentYear, 5, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 228,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 5, 24),
                EndTime = new DateTime(CurrentYear, 5, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 229,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 5, 26),
                EndTime = new DateTime(CurrentYear, 5, 27),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 230,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 5, 29),
                EndTime = new DateTime(CurrentYear, 5, 30),
                IsAllDay = true,
                CalendarId = 2
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 301,
                Subject = "Gladys Spellman",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 302,
                Subject = "Susanna Salter",
                StartTime = new DateTime(CurrentYear, 3, 2),
                EndTime = new DateTime(CurrentYear, 3, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 303,
                Subject = "Dora Marsden",
                StartTime = new DateTime(CurrentYear, 3, 5),
                EndTime = new DateTime(CurrentYear, 3, 6),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 304,
                Subject = "Anne Bonny",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 305,
                Subject = "Clare Boothe Luce",
                StartTime = new DateTime(CurrentYear, 3, 10),
                EndTime = new DateTime(CurrentYear, 3, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 306,
                Subject = "Ethel Anderson",
                StartTime = new DateTime(CurrentYear, 3, 16),
                EndTime = new DateTime(CurrentYear, 3, 17),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 307,
                Subject = "Louise Otto-Peters",
                StartTime = new DateTime(CurrentYear, 3, 26),
                EndTime = new DateTime(CurrentYear, 3, 27),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 308,
                Subject = "Faith Leech",
                StartTime = new DateTime(CurrentYear, 3, 31),
                EndTime = new DateTime(CurrentYear, 3, 1),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 309,
                Subject = "Wilhelmine Reichard",
                StartTime = new DateTime(CurrentYear, 4, 2),
                EndTime = new DateTime(CurrentYear, 4, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 310,
                Subject = "Janet Rowley",
                StartTime = new DateTime(CurrentYear, 4, 5),
                EndTime = new DateTime(CurrentYear, 4, 6),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 311,
                Subject = "Kathleen Major",
                StartTime = new DateTime(CurrentYear, 4, 10),
                EndTime = new DateTime(CurrentYear, 4, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 312,
                Subject = "Kasturba Gandhi",
                StartTime = new DateTime(CurrentYear, 4, 11),
                EndTime = new DateTime(CurrentYear, 4, 12),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 313,
                Subject = "Elizabeth Huckaby",
                StartTime = new DateTime(CurrentYear, 4, 14),
                EndTime = new DateTime(CurrentYear, 4, 15),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 314,
                Subject = "Helene Hanff",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 315,
                Subject = "Caresse Crosby",
                StartTime = new DateTime(CurrentYear, 4, 20),
                EndTime = new DateTime(CurrentYear, 4, 21),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 316,
                Subject = "Angela Burdett-Coutts",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 317,
                Subject = "Pandita Ramabai",
                StartTime = new DateTime(CurrentYear, 4, 23),
                EndTime = new DateTime(CurrentYear, 4, 24),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 318,
                Subject = "Melissa Hayden",
                StartTime = new DateTime(CurrentYear, 4, 25),
                EndTime = new DateTime(CurrentYear, 4, 26),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 319,
                Subject = "Mary Wollstonecraft",
                StartTime = new DateTime(CurrentYear, 4, 27),
                EndTime = new DateTime(CurrentYear, 4, 28),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 320,
                Subject = "Mary Petty",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 321,
                Subject = "Doris Fisher",
                StartTime = new DateTime(CurrentYear, 5, 2),
                EndTime = new DateTime(CurrentYear, 5, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 322,
                Subject = "Kay Petre",
                StartTime = new DateTime(CurrentYear, 5, 10),
                EndTime = new DateTime(CurrentYear, 5, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 323,
                Subject = "Williamina Fleming",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 324,
                Subject = "Ondina Valla",
                StartTime = new DateTime(CurrentYear, 5, 20),
                EndTime = new DateTime(CurrentYear, 5, 21),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 325,
                Subject = "Marie Menken",
                StartTime = new DateTime(CurrentYear, 5, 25),
                EndTime = new DateTime(CurrentYear, 5, 26),
                IsAllDay = true,
                CalendarId = 3
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 101,
                Subject = "Father Birthday",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 102,
                Subject = "Engagement day",
                StartTime = new DateTime(CurrentYear, 3, 4),
                EndTime = new DateTime(CurrentYear, 3, 5),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 103,
                Subject = "Wedding day",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 104,
                Subject = "Mother Birthday",
                StartTime = new DateTime(CurrentYear, 3, 11),
                EndTime = new DateTime(CurrentYear, 3, 12),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 105,
                Subject = "Peter`s Wedding Day",
                StartTime = new DateTime(CurrentYear, 3, 13),
                EndTime = new DateTime(CurrentYear, 3, 14),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 106,
                Subject = "Family Trip",
                StartTime = new DateTime(CurrentYear, 3, 18),
                EndTime = new DateTime(CurrentYear, 3, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 107,
                Subject = "Cousin Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 3, 21),
                EndTime = new DateTime(CurrentYear, 3, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 108,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 3, 24),
                EndTime = new DateTime(CurrentYear, 3, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 109,
                Subject = "Grandfather Birthday",
                StartTime = new DateTime(CurrentYear, 3, 28),
                EndTime = new DateTime(CurrentYear, 3, 29),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 110,
                Subject = "Sister-in-law Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 3, 30),
                EndTime = new DateTime(CurrentYear, 3, 31),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 111,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 4, 1),
                EndTime = new DateTime(CurrentYear, 4, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 112,
                Subject = "Grandparent Wedding day",
                StartTime = new DateTime(CurrentYear, 4, 3),
                EndTime = new DateTime(CurrentYear, 4, 4),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 113,
                Subject = "Cousin Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 4, 7),
                EndTime = new DateTime(CurrentYear, 4, 8),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 114,
                Subject = "Family Vacation Trip",
                StartTime = new DateTime(CurrentYear, 4, 12),
                EndTime = new DateTime(CurrentYear, 4, 13),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 115,
                Subject = "Brother-in-law Birthday",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 116,
                Subject = "Brother`s Birthday",
                StartTime = new DateTime(CurrentYear, 4, 18),
                EndTime = new DateTime(CurrentYear, 4, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 117,
                Subject = "Sister Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 118,
                Subject = "Family Vacation Trip",
                StartTime = new DateTime(CurrentYear, 4, 24),
                EndTime = new DateTime(CurrentYear, 4, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 119,
                Subject = "Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 4, 26),
                EndTime = new DateTime(CurrentYear, 4, 27),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 120,
                Subject = "Month End-trip",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 121,
                Subject = "John Birthday",
                StartTime = new DateTime(CurrentYear, 5, 1),
                EndTime = new DateTime(CurrentYear, 5, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 122,
                Subject = "Vishnu Birthday",
                StartTime = new DateTime(CurrentYear, 5, 3),
                EndTime = new DateTime(CurrentYear, 5, 4),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 123,
                Subject = "Family Trip",
                StartTime = new DateTime(CurrentYear, 5, 9),
                EndTime = new DateTime(CurrentYear, 5, 10),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 124,
                Subject = "Revanth Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 5, 13),
                EndTime = new DateTime(CurrentYear, 5, 14),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 125,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 126,
                Subject = "Family get-together",
                StartTime = new DateTime(CurrentYear, 5, 18),
                EndTime = new DateTime(CurrentYear, 5, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 127,
                Subject = "Friends Reunion",
                StartTime = new DateTime(CurrentYear, 5, 21),
                EndTime = new DateTime(CurrentYear, 5, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 128,
                Subject = "Rahul Wedding Anniversary Celebration",
                StartTime = new DateTime(CurrentYear, 5, 24),
                EndTime = new DateTime(CurrentYear, 5, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 129,
                Subject = "Vacation Trip with friends",
                StartTime = new DateTime(CurrentYear, 5, 26),
                EndTime = new DateTime(CurrentYear, 5, 27),
                IsAllDay = true,
                CalendarId = 1
            });
            holidayData.Add(new ResourceEventsData
            {
                Id = 130,
                Subject = "Friends Reunion",
                StartTime = new DateTime(CurrentYear, 5, 29),
                EndTime = new DateTime(CurrentYear, 5, 30),
                IsAllDay = true,
                CalendarId = 1
            });
            return holidayData;
        }

        public List<ResourceEventsData> GetBirthdayData()
        {
            List<ResourceEventsData> birthdayData = new List<ResourceEventsData>();
            birthdayData.Add(new ResourceEventsData
            {
                Id = 301,
                Subject = "Gladys Spellman",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 302,
                Subject = "Susanna Salter",
                StartTime = new DateTime(CurrentYear, 3, 2),
                EndTime = new DateTime(CurrentYear, 3, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 303,
                Subject = "Dora Marsden",
                StartTime = new DateTime(CurrentYear, 3, 5),
                EndTime = new DateTime(CurrentYear, 3, 6),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 304,
                Subject = "Anne Bonny",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 305,
                Subject = "Clare Boothe Luce",
                StartTime = new DateTime(CurrentYear, 3, 10),
                EndTime = new DateTime(CurrentYear, 3, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 306,
                Subject = "Ethel Anderson",
                StartTime = new DateTime(CurrentYear, 3, 16),
                EndTime = new DateTime(CurrentYear, 3, 17),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 307,
                Subject = "Louise Otto-Peters",
                StartTime = new DateTime(CurrentYear, 3, 26),
                EndTime = new DateTime(CurrentYear, 3, 27),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 308,
                Subject = "Faith Leech",
                StartTime = new DateTime(CurrentYear, 3, 31),
                EndTime = new DateTime(CurrentYear, 3, 1),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 309,
                Subject = "Wilhelmine Reichard",
                StartTime = new DateTime(CurrentYear, 4, 2),
                EndTime = new DateTime(CurrentYear, 4, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 310,
                Subject = "Janet Rowley",
                StartTime = new DateTime(CurrentYear, 4, 5),
                EndTime = new DateTime(CurrentYear, 4, 6),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 311,
                Subject = "Kathleen Major",
                StartTime = new DateTime(CurrentYear, 4, 10),
                EndTime = new DateTime(CurrentYear, 4, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 312,
                Subject = "Kasturba Gandhi",
                StartTime = new DateTime(CurrentYear, 4, 11),
                EndTime = new DateTime(CurrentYear, 4, 12),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 313,
                Subject = "Elizabeth Huckaby",
                StartTime = new DateTime(CurrentYear, 4, 14),
                EndTime = new DateTime(CurrentYear, 4, 15),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 314,
                Subject = "Helene Hanff",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 315,
                Subject = "Caresse Crosby",
                StartTime = new DateTime(CurrentYear, 4, 20),
                EndTime = new DateTime(CurrentYear, 4, 21),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 316,
                Subject = "Angela Burdett-Coutts",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 317,
                Subject = "Pandita Ramabai",
                StartTime = new DateTime(CurrentYear, 4, 23),
                EndTime = new DateTime(CurrentYear, 4, 24),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 318,
                Subject = "Melissa Hayden",
                StartTime = new DateTime(CurrentYear, 4, 25),
                EndTime = new DateTime(CurrentYear, 4, 26),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 319,
                Subject = "Mary Wollstonecraft",
                StartTime = new DateTime(CurrentYear, 4, 27),
                EndTime = new DateTime(CurrentYear, 4, 28),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 320,
                Subject = "Mary Petty",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 321,
                Subject = "Doris Fisher",
                StartTime = new DateTime(CurrentYear, 5, 2),
                EndTime = new DateTime(CurrentYear, 5, 3),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 322,
                Subject = "Kay Petre",
                StartTime = new DateTime(CurrentYear, 5, 10),
                EndTime = new DateTime(CurrentYear, 5, 11),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 323,
                Subject = "Williamina Fleming",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 324,
                Subject = "Ondina Valla",
                StartTime = new DateTime(CurrentYear, 5, 20),
                EndTime = new DateTime(CurrentYear, 5, 21),
                IsAllDay = true,
                CalendarId = 3
            });
            birthdayData.Add(new ResourceEventsData
            {
                Id = 325,
                Subject = "Marie Menken",
                StartTime = new DateTime(CurrentYear, 5, 25),
                EndTime = new DateTime(CurrentYear, 5, 26),
                IsAllDay = true,
                CalendarId = 3
            });
            return birthdayData;
        }

        public List<ResourceEventsData> GetCompanyData()
        {
            List<ResourceEventsData> companyData = new List<ResourceEventsData>();
            companyData.Add(new ResourceEventsData
            {
                Id = 201,
                Subject = "Conference meeting",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 202,
                Subject = "Product discussion",
                StartTime = new DateTime(CurrentYear, 3, 4),
                EndTime = new DateTime(CurrentYear, 3, 5),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 203,
                Subject = "Company's growth related discussion",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 204,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 3, 11),
                EndTime = new DateTime(CurrentYear, 3, 12),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 205,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 3, 13),
                EndTime = new DateTime(CurrentYear, 3, 14),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 206,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 3, 18),
                EndTime = new DateTime(CurrentYear, 3, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 207,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 3, 21),
                EndTime = new DateTime(CurrentYear, 3, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 208,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 3, 24),
                EndTime = new DateTime(CurrentYear, 3, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 209,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 3, 28),
                EndTime = new DateTime(CurrentYear, 3, 29),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 210,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 3, 30),
                EndTime = new DateTime(CurrentYear, 3, 31),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 211,
                Subject = "Conference Meeting",
                StartTime = new DateTime(CurrentYear, 4, 1),
                EndTime = new DateTime(CurrentYear, 4, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 212,
                Subject = "Product Discussion",
                StartTime = new DateTime(CurrentYear, 4, 3),
                EndTime = new DateTime(CurrentYear, 4, 4),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 213,
                Subject = "Company's growth related issues",
                StartTime = new DateTime(CurrentYear, 4, 7),
                EndTime = new DateTime(CurrentYear, 4, 8),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 214,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 4, 12),
                EndTime = new DateTime(CurrentYear, 4, 13),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 215,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 216,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 4, 18),
                EndTime = new DateTime(CurrentYear, 4, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 217,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 218,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 4, 24),
                EndTime = new DateTime(CurrentYear, 4, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 219,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 4, 26),
                EndTime = new DateTime(CurrentYear, 4, 27),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 220,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 221,
                Subject = "Conference Meeting",
                StartTime = new DateTime(CurrentYear, 5, 1),
                EndTime = new DateTime(CurrentYear, 5, 2),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 222,
                Subject = "Product Discussion",
                StartTime = new DateTime(CurrentYear, 5, 3),
                EndTime = new DateTime(CurrentYear, 5, 4),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 223,
                Subject = "Company's growth related issues",
                StartTime = new DateTime(CurrentYear, 5, 9),
                EndTime = new DateTime(CurrentYear, 5, 10),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 224,
                Subject = "Customer issues",
                StartTime = new DateTime(CurrentYear, 5, 13),
                EndTime = new DateTime(CurrentYear, 5, 14),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 225,
                Subject = "Development related chat",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 226,
                Subject = "Product meeting",
                StartTime = new DateTime(CurrentYear, 5, 18),
                EndTime = new DateTime(CurrentYear, 5, 19),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 227,
                Subject = "General discussion",
                StartTime = new DateTime(CurrentYear, 5, 21),
                EndTime = new DateTime(CurrentYear, 5, 22),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 228,
                Subject = "Hike discussion",
                StartTime = new DateTime(CurrentYear, 5, 24),
                EndTime = new DateTime(CurrentYear, 5, 25),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 229,
                Subject = "Customer meeting",
                StartTime = new DateTime(CurrentYear, 5, 26),
                EndTime = new DateTime(CurrentYear, 5, 27),
                IsAllDay = true,
                CalendarId = 2
            });
            companyData.Add(new ResourceEventsData
            {
                Id = 230,
                Subject = "New launch discussion",
                StartTime = new DateTime(CurrentYear, 5, 29),
                EndTime = new DateTime(CurrentYear, 5, 30),
                IsAllDay = true,
                CalendarId = 2
            });
            return companyData;
        }

        public List<ResourceEventsData> GetPersonalData()
        {
            List<ResourceEventsData> personalData = new List<ResourceEventsData>();
            personalData.Add(new ResourceEventsData
            {
                Id = 101,
                Subject = "Father Birthday",
                StartTime = new DateTime(CurrentYear, 3, 1),
                EndTime = new DateTime(CurrentYear, 3, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 102,
                Subject = "Engagement day",
                StartTime = new DateTime(CurrentYear, 3, 4),
                EndTime = new DateTime(CurrentYear, 3, 5),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 103,
                Subject = "Wedding day",
                StartTime = new DateTime(CurrentYear, 3, 8),
                EndTime = new DateTime(CurrentYear, 3, 9),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 104,
                Subject = "Mother Birthday",
                StartTime = new DateTime(CurrentYear, 3, 11),
                EndTime = new DateTime(CurrentYear, 3, 12),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 105,
                Subject = "Peter`s Wedding Day",
                StartTime = new DateTime(CurrentYear, 3, 13),
                EndTime = new DateTime(CurrentYear, 3, 14),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 106,
                Subject = "Family Trip",
                StartTime = new DateTime(CurrentYear, 3, 18),
                EndTime = new DateTime(CurrentYear, 3, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 107,
                Subject = "Cousin Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 3, 21),
                EndTime = new DateTime(CurrentYear, 3, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 108,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 3, 24),
                EndTime = new DateTime(CurrentYear, 3, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 109,
                Subject = "Grandfather Birthday",
                StartTime = new DateTime(CurrentYear, 3, 28),
                EndTime = new DateTime(CurrentYear, 3, 29),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 110,
                Subject = "Sister-in-law Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 3, 30),
                EndTime = new DateTime(CurrentYear, 3, 31),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 111,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 4, 1),
                EndTime = new DateTime(CurrentYear, 4, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 112,
                Subject = "Grandparent Wedding day",
                StartTime = new DateTime(CurrentYear, 4, 3),
                EndTime = new DateTime(CurrentYear, 4, 4),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 113,
                Subject = "Cousin Wedding Ceremony",
                StartTime = new DateTime(CurrentYear, 4, 7),
                EndTime = new DateTime(CurrentYear, 4, 8),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 114,
                Subject = "Family Vacation Trip",
                StartTime = new DateTime(CurrentYear, 4, 12),
                EndTime = new DateTime(CurrentYear, 4, 13),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 115,
                Subject = "Brother-in-law Birthday",
                StartTime = new DateTime(CurrentYear, 4, 15),
                EndTime = new DateTime(CurrentYear, 4, 16),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 116,
                Subject = "Brother`s Birthday",
                StartTime = new DateTime(CurrentYear, 4, 18),
                EndTime = new DateTime(CurrentYear, 4, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 117,
                Subject = "Sister Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 4, 21),
                EndTime = new DateTime(CurrentYear, 4, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 118,
                Subject = "Family Vacation Trip",
                StartTime = new DateTime(CurrentYear, 4, 24),
                EndTime = new DateTime(CurrentYear, 4, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 119,
                Subject = "Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 4, 26),
                EndTime = new DateTime(CurrentYear, 4, 27),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 120,
                Subject = "Month End-trip",
                StartTime = new DateTime(CurrentYear, 4, 29),
                EndTime = new DateTime(CurrentYear, 4, 30),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 121,
                Subject = "John Birthday",
                StartTime = new DateTime(CurrentYear, 5, 1),
                EndTime = new DateTime(CurrentYear, 5, 2),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 122,
                Subject = "Vishnu Birthday",
                StartTime = new DateTime(CurrentYear, 5, 3),
                EndTime = new DateTime(CurrentYear, 5, 4),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 123,
                Subject = "Family Trip",
                StartTime = new DateTime(CurrentYear, 5, 9),
                EndTime = new DateTime(CurrentYear, 5, 10),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 124,
                Subject = "Revanth Wedding Anniversary",
                StartTime = new DateTime(CurrentYear, 5, 13),
                EndTime = new DateTime(CurrentYear, 5, 14),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 125,
                Subject = "Family Meetup",
                StartTime = new DateTime(CurrentYear, 5, 15),
                EndTime = new DateTime(CurrentYear, 5, 16),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 126,
                Subject = "Family get-together",
                StartTime = new DateTime(CurrentYear, 5, 18),
                EndTime = new DateTime(CurrentYear, 5, 19),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 127,
                Subject = "Friends Reunion",
                StartTime = new DateTime(CurrentYear, 5, 21),
                EndTime = new DateTime(CurrentYear, 5, 22),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 128,
                Subject = "Rahul Wedding Anniversary Celebration",
                StartTime = new DateTime(CurrentYear, 5, 24),
                EndTime = new DateTime(CurrentYear, 5, 25),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 129,
                Subject = "Vacation Trip with friends",
                StartTime = new DateTime(CurrentYear, 5, 26),
                EndTime = new DateTime(CurrentYear, 5, 27),
                IsAllDay = true,
                CalendarId = 1
            });
            personalData.Add(new ResourceEventsData
            {
                Id = 130,
                Subject = "Friends Reunion",
                StartTime = new DateTime(CurrentYear, 5, 29),
                EndTime = new DateTime(CurrentYear, 5, 30),
                IsAllDay = true,
                CalendarId = 1
            });
            return personalData;
        }

        public List<DoctorData> GetDoctorData()
        {
            List<DoctorData> doctorData = new List<DoctorData>();
            doctorData.Add(new DoctorData
            {
                Id = 1,
                Subject = "Echocardiogram",
                StartTime = new DateTime(CurrentYear, 3, 1, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 1, 11, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 2,
                Subject = "Lumbar punctures",
                StartTime = new DateTime(CurrentYear, 3, 1, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 1, 10, 45, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 3,
                Subject = "Osteoarthritis",
                StartTime = new DateTime(CurrentYear, 3, 1, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 1, 10, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 4,
                Subject = "Ambulatory ECG",
                StartTime = new DateTime(CurrentYear, 3, 2, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 2, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 5,
                Subject = "Osteoporosis",
                StartTime = new DateTime(CurrentYear, 3, 2, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 2, 11, 50, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 6,
                Subject = "Neuromuscular",
                StartTime = new DateTime(CurrentYear, 3, 3, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 3, 13, 30, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 7,
                Subject = "Rheumatoid arthritis",
                StartTime = new DateTime(CurrentYear, 3, 3, 13, 40, 0),
                EndTime = new DateTime(CurrentYear, 3, 3, 14, 40, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 8,
                Subject = "Cardiac Catheterization",
                StartTime = new DateTime(CurrentYear, 3, 4, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 4, 13, 0, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 9,
                Subject = "Growth abnormalities",
                StartTime = new DateTime(CurrentYear, 3, 4, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 4, 15, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 10,
                Subject = "Sleep disorders",
                StartTime = new DateTime(CurrentYear, 3, 5, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 5, 14, 0, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 11,
                Subject = "Torn ligaments",
                StartTime = new DateTime(CurrentYear, 3, 5, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 5, 14, 45, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 12,
                Subject = "Coronary angiogram",
                StartTime = new DateTime(CurrentYear, 3, 5, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 5, 9, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 13,
                Subject = "Blood pressure",
                StartTime = new DateTime(CurrentYear, 3, 8, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 8, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 14,
                Subject = "Radiculopathy",
                StartTime = new DateTime(CurrentYear, 3, 8, 15, 45, 0),
                EndTime = new DateTime(CurrentYear, 3, 8, 16, 30, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 15,
                Subject = "Sprains and strains",
                StartTime = new DateTime(CurrentYear, 3, 8, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 8, 15, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 16,
                Subject = "Cardiac stress testing",
                StartTime = new DateTime(CurrentYear, 3, 9, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 9, 10, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 17,
                Subject = "Tendon injuries",
                StartTime = new DateTime(CurrentYear, 3, 9, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 9, 15, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 18,
                Subject = "Dementia",
                StartTime = new DateTime(CurrentYear, 3, 10, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 10, 17, 0, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 19,
                Subject = "Pulled muscles",
                StartTime = new DateTime(CurrentYear, 3, 10, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 10, 15, 50, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 20,
                Subject = "Coronary angiogram",
                StartTime = new DateTime(CurrentYear, 3, 11, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 11, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 21,
                Subject = "Back pain",
                StartTime = new DateTime(CurrentYear, 3, 11, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 11, 11, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 22,
                Subject = "Neuropathy",
                StartTime = new DateTime(CurrentYear, 3, 12, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 12, 13, 45, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 23,
                Subject = "Ruptured disks",
                StartTime = new DateTime(CurrentYear, 3, 12, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 12, 15, 50, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 24,
                Subject = "Atherosclerosis",
                StartTime = new DateTime(CurrentYear, 3, 12, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 12, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 25,
                Subject = "Arthroplasty",
                StartTime = new DateTime(CurrentYear, 3, 15, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 15, 10, 0, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 26,
                Subject = "Hyperactivity disorder",
                StartTime = new DateTime(CurrentYear, 3, 15, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 15, 15, 45, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 27,
                Subject = "Muscular dystrophy",
                StartTime = new DateTime(CurrentYear, 3, 15, 13, 10, 0),
                EndTime = new DateTime(CurrentYear, 3, 15, 15, 20, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 28,
                Subject = "Consulting",
                StartTime = new DateTime(CurrentYear, 3, 16, 9, 20, 0),
                EndTime = new DateTime(CurrentYear, 3, 16, 10, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 29,
                Subject = "Hand surgery",
                StartTime = new DateTime(CurrentYear, 3, 16, 13, 20, 0),
                EndTime = new DateTime(CurrentYear, 3, 16, 15, 22, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 30,
                Subject = "Neuromuscular",
                StartTime = new DateTime(CurrentYear, 3, 17, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 17, 15, 40, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 31,
                Subject = "Spine surgery",
                StartTime = new DateTime(CurrentYear, 3, 17, 12, 18, 0),
                EndTime = new DateTime(CurrentYear, 3, 17, 14, 23, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 32,
                Subject = "Fibrinogen",
                StartTime = new DateTime(CurrentYear, 3, 18, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 18, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 33,
                Subject = "Bone tumors",
                StartTime = new DateTime(CurrentYear, 3, 18, 10, 45, 0),
                EndTime = new DateTime(CurrentYear, 3, 18, 12, 20, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 34,
                Subject = "Neuromuscular",
                StartTime = new DateTime(CurrentYear, 3, 19, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 19, 17, 0, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 35,
                Subject = "Osteoporosis",
                StartTime = new DateTime(CurrentYear, 3, 19, 11, 45, 0),
                EndTime = new DateTime(CurrentYear, 3, 19, 14, 30, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 36,
                Subject = "Triglyceride",
                StartTime = new DateTime(CurrentYear, 3, 19, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 19, 10, 45, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 37,
                Subject = "Fibrinogen",
                StartTime = new DateTime(CurrentYear, 3, 22, 8, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 22, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 38,
                Subject = "Head trauma",
                StartTime = new DateTime(CurrentYear, 3, 22, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 22, 15, 0, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 39,
                Subject = "Arthroplasty",
                StartTime = new DateTime(CurrentYear, 3, 22, 12, 18, 0),
                EndTime = new DateTime(CurrentYear, 3, 22, 13, 22, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 40,
                Subject = "Echocardiogram",
                StartTime = new DateTime(CurrentYear, 3, 23, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 23, 12, 40, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 41,
                Subject = "Skull reconstruction",
                StartTime = new DateTime(CurrentYear, 3, 23, 13, 20, 0),
                EndTime = new DateTime(CurrentYear, 3, 23, 15, 45, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 42,
                Subject = "Dementia",
                StartTime = new DateTime(CurrentYear, 3, 24, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 24, 16, 45, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 43,
                Subject = "Orthopedic trauma",
                StartTime = new DateTime(CurrentYear, 3, 24, 10, 18, 0),
                EndTime = new DateTime(CurrentYear, 3, 24, 12, 20, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 44,
                Subject = "Blood pressure",
                StartTime = new DateTime(CurrentYear, 3, 25, 10, 50, 0),
                EndTime = new DateTime(CurrentYear, 3, 25, 12, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 45,
                Subject = "Ruptured disks",
                StartTime = new DateTime(CurrentYear, 3, 25, 12, 50, 0),
                EndTime = new DateTime(CurrentYear, 3, 25, 15, 20, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 46,
                Subject = "Head trauma",
                StartTime = new DateTime(CurrentYear, 3, 26, 11, 50, 0),
                EndTime = new DateTime(CurrentYear, 3, 26, 12, 45, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 47,
                Subject = "Cerebral palsy",
                StartTime = new DateTime(CurrentYear, 3, 26, 14, 50, 0),
                EndTime = new DateTime(CurrentYear, 3, 26, 15, 50, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            doctorData.Add(new DoctorData
            {
                Id = 48,
                Subject = "Consulting",
                StartTime = new DateTime(CurrentYear, 3, 26, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 26, 11, 30, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 49,
                Subject = "Electrocardiogram",
                StartTime = new DateTime(CurrentYear, 3, 29, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 3, 29, 11, 50, 0),
                IsAllDay = false,
                DoctorId = 1
            });
            doctorData.Add(new DoctorData
            {
                Id = 50,
                Subject = "Radiculopathy",
                StartTime = new DateTime(CurrentYear, 3, 29, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 29, 15, 30, 0),
                IsAllDay = false,
                DoctorId = 2
            });
            doctorData.Add(new DoctorData
            {
                Id = 51,
                Subject = "Skull reconstruction",
                StartTime = new DateTime(CurrentYear, 3, 29, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 3, 29, 16, 0, 0),
                IsAllDay = false,
                DoctorId = 3
            });
            return doctorData;
        }

        public List<ResourceSampleData> GetResourceSampleData()
        {
            List<ResourceSampleData> data = new List<ResourceSampleData>();
            data.Add(new ResourceSampleData
            {
                Id = 1,
                Subject = "Burning Man",
                StartTime = new DateTime(CurrentYear, 5, 29, 15, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 29, 17, 0, 0),
                OwnerId = 1
            });
            data.Add(new ResourceSampleData
            {
                Id = 2,
                Subject = "Marketing Forum",
                StartTime = new DateTime(CurrentYear, 5, 31, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 5, 31, 11, 30, 0),
                OwnerId = 2
            });
            data.Add(new ResourceSampleData
            {
                Id = 3,
                Subject = "Business Factory",
                StartTime = new DateTime(CurrentYear, 5, 31, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 5, 31, 15, 0, 0),
                OwnerId = 3
            });
            data.Add(new ResourceSampleData
            {
                Id = 4,
                Subject = "Burning Man",
                StartTime = new DateTime(CurrentYear, 6, 1, 11, 30, 0),
                EndTime = new DateTime(CurrentYear, 6, 1, 13, 0, 0),
                OwnerId = 1
            });
            data.Add(new ResourceSampleData
            {
                Id = 5,
                Subject = "Funnel Hacking",
                StartTime = new DateTime(CurrentYear, 6, 2, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 6, 2, 11, 0, 0),
                OwnerId = 3
            });
            data.Add(new ResourceSampleData
            {
                Id = 6,
                Subject = "The human gathering",
                StartTime = new DateTime(CurrentYear, 6, 2, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 2, 14, 30, 0),
                OwnerId = 2
            });
            data.Add(new ResourceSampleData
            {
                Id = 7,
                Subject = "Techweek",
                StartTime = new DateTime(CurrentYear, 6, 3, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 3, 12, 30, 0),
                OwnerId = 2
            });
            data.Add(new ResourceSampleData
            {
                Id = 8,
                Subject = "Grow Conference",
                StartTime = new DateTime(CurrentYear, 6, 4, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 4, 11, 30, 0),
                OwnerId = 1
            });
            data.Add(new ResourceSampleData
            {
                Id = 9,
                Subject = "Data Science Conference",
                StartTime = new DateTime(CurrentYear, 6, 4, 13, 30, 0),
                EndTime = new DateTime(CurrentYear, 6, 4, 15, 0, 0),
                OwnerId = 1
            });
            data.Add(new ResourceSampleData
            {
                Id = 10,
                Subject = "Blogcademy",
                StartTime = new DateTime(CurrentYear, 6, 5, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 5, 13, 30, 0),
                OwnerId = 3
            });
            data.Add(new ResourceSampleData
            {
                Id = 11,
                Subject = "World Domination Summit",
                StartTime = new DateTime(CurrentYear, 6, 6, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 6, 6, 11, 0, 0),
                OwnerId = 2
            });
            data.Add(new ResourceSampleData
            {
                Id = 12,
                Subject = "Content Marketing",
                StartTime = new DateTime(CurrentYear, 6, 6, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 6, 14, 30, 0),
                OwnerId = 1
            });
            data.Add(new ResourceSampleData
            {
                Id = 13,
                Subject = "Mobile World Conference",
                StartTime = new DateTime(CurrentYear, 6, 12, 18, 0, 0),
                EndTime = new DateTime(CurrentYear, 6, 12, 20, 0, 0),
                OwnerId = 1
            });
            return data;
        }

        public List<AppointmentData> GetExportingData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            {
                Id = 1,
                Subject = "Explosion of Betelgeuse Star",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 11, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5;",
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 2,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 1, 3, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 14, 0, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5;",
                RecurrenceException = CurrentYear + "0107T073000Z",
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 25,
                Subject = "Thule Air Crash Report",
                Location = "Newyork City",
                StartTime = new DateTime(CurrentYear, 1, 7, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 12, 30, 0),
                RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5;",
                RecurrenceID = 2,
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 3,
                Subject = "Blue Moon Eclipse",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 11, 0, 0),
                CategoryColor = "#7fa900",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 4,
                Subject = "Meteor Showers in 2022",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 8, 13, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 8, 14, 30, 0),
                CategoryColor = "#ea7a57",
                IsAllDay = true
            });
            appData.Add(new AppointmentData
            {
                Id = 5,
                Subject = "Milky Way as Melting Pot",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 12, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 14, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 6,
                Subject = "Mysteries of Bermuda Triangle",
                Location = "Bermuda",
                StartTime = new DateTime(CurrentYear, 1, 4, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 4, 16, 0, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 7,
                Subject = "Glaciers and Snowflakes",
                Location = "Himalayas",
                StartTime = new DateTime(CurrentYear, 1, 10, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 8,
                Subject = "Life on Mars",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 11, 9, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 10, 0, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 9,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 13, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 13, 13, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 10,
                Subject = "Wildlife Galleries",
                Location = "Africa",
                StartTime = new DateTime(CurrentYear, 1, 15, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 15, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 11,
                Subject = "Best Photography 2022",
                Location = "London",
                StartTime = new DateTime(CurrentYear, 1, 16, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 16, 11, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 12,
                Subject = "Smarter Puppies",
                Location = "Sweden",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 11, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 13,
                Subject = "Myths of Andromeda Galaxy",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 3, 10, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 3, 12, 30, 0),
                CategoryColor = "#1aaa55"
            });
            appData.Add(new AppointmentData
            {
                Id = 14,
                Subject = "Aliens vs Humans",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 12, 31, 10, 0, 0),
                EndTime = new DateTime(CurrentYear, 12, 31, 11, 30, 0),
                CategoryColor = "#357cd2"
            });
            appData.Add(new AppointmentData
            {
                Id = 15,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 14, 9, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 14, 11, 0, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 16,
                Subject = "Sky Gazers",
                Location = "Alaska",
                StartTime = new DateTime(CurrentYear, 1, 17, 11, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 17, 13, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 17,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 5, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 7, 30, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 18,
                Subject = "Space Galaxies and Planets",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 6, 17, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 6, 18, 30, 0),
                CategoryColor = "#f57f17"
            });
            appData.Add(new AppointmentData
            {
                Id = 19,
                Subject = "Lifecycle of Bumblebee",
                Location = "San Francisco",
                StartTime = new DateTime(CurrentYear, 1, 9, 6, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 7, 30, 0),
                CategoryColor = "#7fa900"
            });
            appData.Add(new AppointmentData
            {
                Id = 20,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 9, 16, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 9, 18, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 21,
                Subject = "Alien Civilization",
                Location = "Space Centre USA",
                StartTime = new DateTime(CurrentYear, 1, 5, 14, 0, 0),
                EndTime = new DateTime(CurrentYear, 1, 5, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 22,
                Subject = "The Cycle of Seasons",
                Location = "Research Centre of USA",
                StartTime = new DateTime(CurrentYear, 1, 7, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 7, 16, 0, 0),
                CategoryColor = "#00bdae"
            });
            appData.Add(new AppointmentData
            {
                Id = 23,
                Subject = "Sky Gazers",
                Location = "Greenland",
                StartTime = new DateTime(CurrentYear, 1, 10, 14, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 10, 16, 0, 0),
                CategoryColor = "#ea7a57"
            });
            appData.Add(new AppointmentData
            {
                Id = 24,
                Subject = "Facts of Humming Birds",
                Location = "California",
                StartTime = new DateTime(CurrentYear, 1, 11, 12, 30, 0),
                EndTime = new DateTime(CurrentYear, 1, 11, 14, 30, 0),
                CategoryColor = "#7fa900"
            });
            return appData;
        }
        public static Dictionary<string, object> ApplyCategoryColor(string CategoryColor, Dictionary<string, object> Attributes, Syncfusion.Blazor.Schedule.View CurrentView)
        {
            Dictionary<string, object> attributes = new Dictionary<string, object>();
            if (CurrentView == Syncfusion.Blazor.Schedule.View.Agenda)
            {
                attributes.Add("style", "border-left-color: " + CategoryColor);
            }
            else
            {
                attributes.Add("style", "background: " + CategoryColor);
            }
            return attributes;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public Nullable<bool> IsAllDay { get; set; }
            public string CategoryColor { get; set; }
            public string RecurrenceRule { get; set; }
            public Nullable<int> RecurrenceID { get; set; }
            public Nullable<int> FollowingID { get; set; }
            public string RecurrenceException { get; set; }
            public string StartTimezone { get; set; }
            public string EndTimezone { get; set; }
        }
        public class ContextEventsData : AppointmentData
        {
            public virtual Guid Guid { get; set; }
        }
        public class ReadonlyEventsData : AppointmentData
        {
            public bool IsReadonly { get; set; }
        }
        public class ResourceData : AppointmentData
        {
            public int ProjectId { get; set; }
            public int TaskId { get; set; }
        }
        public class BlockData : AppointmentData
        {
            public bool IsBlock { get; set; }
            public int EmployeeId { get; set; }
        }
        public class EmployeeData
        {
            public string Text { get; set; }
            public int Id { get; set; }
            public int GroupId { get; set; }
            public string Color { get; set; }
            public string Designation { get; set; }
        }
        public class ResourceConferenceData : AppointmentData
        {
            public int[] ConferenceId { get; set; }
        }
        public class ConferenceData
        {
            public string Text { get; set; }
            public int Id { get; set; }
            public string Color { get; set; }
            public string Designation { get; set; }
        }
        public class RoomData : AppointmentData
        {
            public int RoomId { get; set; }
            public bool IsBlock { get; set; }
            public virtual DateTime? StartTimeValue { get; set; }
            public virtual DateTime? EndTimeValue { get; set; }
        }
        public class RoomsData
        {
            public string Name { get; set; }
            public int? Id { get; set; }
            public int Capacity { get; set; }
            public string Color { get; set; }
            public string Type { get; set; }
        }
        public class ResourceTeamData : AppointmentData
        {
            public int ProjectId { get; set; }
            public int CategoryId { get; set; }
        }
        public class HospitalData : AppointmentData
        {
            public string Name { get; set; }
            public int DepartmentID { get; set; }
            public int ConsultantID { get; set; }
            public string DepartmentName { get; set; }
        }
        public class FifaEventsData : AppointmentData
        {
            public string City { get; set; }
            public int GroupId { get; set; }
        }
        public class DoctorsEventData : AppointmentData
        {
            public string EventType { get; set; }
        }
        public class WebinarData : AppointmentData
        {
            public string Tags { get; set; }
            public string ImageName { get; set; }
            public string PrimaryColor { get; set; }
            public string SecondaryColor { get; set; }
        }
        public class EventsData : AppointmentData
        {
            public string EventType { get; set; }
            public string City { get; set; }
        }
        public class ResourceEventsData : AppointmentData
        {
            public int CalendarId { get; set; }
        }
        public class DoctorData : AppointmentData
        {
            public int DoctorId { get; set; }
        }
        public class ResourceSampleData : AppointmentData
        {
            public int OwnerId { get; set; }
        }
    }
}
