using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Schedule { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Default",
                FileName = "Default.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Agenda View",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Agenda",
                FileName = "Agenda.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Timeline View",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Timeline",
                FileName = "Timeline.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/TimelineResourceGroup",
                FileName = "TimelineResourceGroup.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Scheduler",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Group",
                FileName = "Group.cshtml",
                Type = SampleType.New
            }
        };
    }
}