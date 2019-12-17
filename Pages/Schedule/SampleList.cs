﻿using System;
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
                FileName = "Default.razor",
                TitleTag = "Scheduler . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how the flat Blazor Scheduler looks like with its default set of minimal configurations.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases how the flat Schedule looks like with its default set of minimal configurations. Here, some
                        of the documentary shows are displayed as events parallel to its relevant telecast timings. The show names are
                        given as event's subject and simply notified of the start and end of it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Scheduler, a.k.a. event calendar, facilitates almost all calendar features, thus allowing users
                        to manage their time efficiently. It features easy resource scheduling, appointments rescheduling through
                        editor pop-ups, drag and drop, and a resizing action. It includes wide variety of view modes with unique
                        configuration options for each view. The available view modes are listed below, out of which the <code>Week</code>
                        view is set as active.
                    </p>
                    <ul>
                        <li>Day</li>
                        <li>Week</li>
                        <li>Work Week</li>
                        <li>Month</li>
                        <li>Agenda</li>
                        <li>Month Agenda</li>
                        <li>Timeline Day</li>
                        <li>Timeline Week</li>
                        <li>Timeline Work Week</li>
                        <li>Timeline Month</li>

                    </ul>
                    <p>
                        To navigate between views and dates, the navigation options are available at the Scheduler header bar and the
                        active view option is highlighted by default. The date range of the active view will also be displayed in the
                        header bar, clicking on which will open a calendar popup for ease of desired date selection.
                    </p>
                    <p>
                        <strong>Touch actions on Mobile mode</strong>
                    </p>
                    <table style=""width:100%"">
                        <tr>
                            <th style=""width:100px"">
                                <strong>Action</strong>
                            </th>
                            <th>
                                <strong>Description</strong>
                            </th>
                        </tr>
                        <tr>
                            <td style=""vertical-align: top;padding:4px 0"">Single Tap</td>
                        <td>
                            <ol style=""padding-left:12px;"">
                                <li>Single tapping on events, opens the popup showing event information</li>
                                <li>Single tapping on cells, will display a “+” icon on the cell. Again tapping on it will open the
                                    new event editor.
                                </li>
                            </ol>
                        </td>
                        </tr>
                        <tr>
                            <td style=""vertical-align: top;padding: 4px 0;"">Tap hold </td>
                            <td>
                                <ol style=""padding-left:12px;"">
                                    <li>Tap holding on cells, opens the new event editor. </li>
                                    <li>
                                        Tap holding on events, opens a small popup at the top holding the options to edit or delete and
                                        also displays the selected event's subject. As a continuation of this action, if user keeps on
                                        single tapping on other events, it will allow the multiple event selection.Also, the previous
                                        popup remains in opened state, showing the count of the number of events selected.
                                    </li>
                                    <li>
                                        Tap hold the event and try moving it over the scheduler to enable drag and drop action.
                                    </li>
                                </ol>
                            </td>
                        </tr>
                    </table>"
                }
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Schedule",
                Url = "Schedule/LocalData",
                FileName = "LocalData.razor",
                TitleTag = "Scheduler . Local Data . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the way of binding appointments with local datasource.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo shows the way of binding appointments with local datasource.
                    </p>"
                },
                Description = new string[] {
                    @"<p>Scheduler can be bound either to local or remote data services which will load the data by default on demand to reduce the
                        data transfer and load time. In this sample, the
                        <code>DataSource</code> property available within the
                        <code>EventSettings</code> needs to be assigned with the valid local JSON data.
                    </p>"
                }

            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Schedule/Schedule",
                Url = "Schedule/RemoteData",
                FileName = "RemoteData.razor",
                TitleTag = "Scheduler . Remote Data . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the way of binding remote services by using the DataManager in Blazor platform.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the way of binding remote services to Scheduler component. Here, the DataManager is used to bind the
                        remote data with Scheduler.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Scheduler can be bound to remote services by assigning the
                        <code>DataSource</code> property with the instance of
                        <code><a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Data.EjsDataManager_members.html"">DataManager</a></code>.
                    </p>
                    <p>
                        The DataManager here acts as an interface between the service endpoint and the Scheduler, and will require the below minimal
                        information to interact with the service endpoint properly.
                    </p>
                    <ul>
                        <li>
                            <code>url</code> - Defines the service endpoint from where the data needs to be fetched
                        </li>
                        <li>
                            <code>adaptor</code> - Defines the adaptor option. By default,
                            <code>ODataAdaptor</code> is used for remote binding.
                        </li>
                    </ul>
                    <p>
                        Adaptor is responsible for processing response and request from/to the service endpoint.
                        <code>@@syncfusion/ejs-data</code> package provides some predefined adaptors which are designed to interact with particular service endpoints. They
                        are as follows,
                    </p>
                    <ul>
                        <li>
                            <code>UrlAdaptor</code> - Use this to interact with any remote services. This is the base adaptor for all the remote based adaptors.
                        </li>
                        <li>
                            <code>ODataAdaptor</code> - Use this to interact with OData endpoints.
                        </li>
                        <li>
                            <code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.
                        </li>
                        <li>
                            <code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.
                        </li>
                        <li>
                            <code>WebMethodAdaptor</code> - Use this to interact with web methods.
                        </li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Schedule",
                Url = "Schedule/RecurrenceEvents",
                FileName = "RecurrenceEvents.razor",
                TitleTag = "Scheduler . Recurring Events . Syncfusion Blazor Components",
                MetaDescription = "This demo shows the Blazor Scheduler with recurring meetings handled on a regular pattern.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the Scheduler with recurring meetings handled by a top-level manager on a regular pattern.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the recurrence events are defined with different repeat patterns. It can be defined through
                        <code>RecurrenceRule</code> field. The recurring events are differentiated from other events by a repeat marker added
                        to the right-bottom of it. These events can repeat on daily, weekly, monthly or yearly basis.
                    </p>
                    <p>
                        Here, the daily patterned events are depicted in blue color, weekly events are differentiated with green color, monthly events
                        are depicted in orange color and the yearly event is depicted in the all-day section with another green shade for
                        reference.
                    </p>
                    <p>
                        Scheduler requires only the <code>startTime</code> and <code>endTime</code> fields as mandatory to be mapped from the dataSource. The Scheduler events can be categorized into 3 types based on its time range and all-day type.
                    </p>
                    <table style=""width:100%"">
                        <tr>
                            <th style=""width:100px"">
                                <strong>Event</strong>
                            </th>
                            <th>
                                <strong>Description</strong>
                            </th>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0;"">Normal events</td>
                            <td>
                                The events that has its start and end time duration on the same date.
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0;"">Spanned events</td>
                            <td>
                                The events on which its start and end time spans over multiple days and usually displays together with all-day events.
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0;"">All-day events</td>
                            <td>
                                The events that are defined as all-day in its event object by setting
                                <code>IsAllDay</code> to true.
                            </td>
                        </tr>
                    </table>
                </div>"
                }
            },
            new Sample
            {
                Name = "Blocking Dates and Time",
                Category = "Appointments",
                Directory = "Schedule/Schedule",
                Url = "Schedule/BlockEvents",
                FileName = "BlockEvents.razor",
                TitleTag = "Scheduler . Blocking Dates and Time . Syncfusion Blazor Components",
                MetaDescription = "This example shows how to block specific days or time intervals on Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example shows how to block specific time intervals or days on the Scheduler.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, few blocked events are defined to block the specific time range with the text “Unavailable”.
                        No events can be created on those blocked time range as well as edited through it. These blocked events can be
                        defined by setting <code>IsBlock</code> field to true within the <code>EventSettings</code> and assigned
                        altogether with the events <code>DataSource</code>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "External Drag And Drop",
                Category = "Appointments",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ExternalDragDrop",
                FileName = "ExternalDragDrop.razor",
                TitleTag = "Scheduler . External Drag And Drop . Syncfusion Blazor Components",
                MetaDescription = "This example shows how to drag and drop the events from an external source into Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example illustrates how to drag and drop the events from an external source into scheduler. Here, you can drag and drop the items from TreeView control into scheduler.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this example, <code>ResourceHeaderTemplate</code> is used to change the default appearance of the resource header
                        column. Within the <code>actionBegin</code> event of scheduler, the dragged item from the TreeView control is removed,
                        when it is being dragged and dropped onto the scheduler. When the item is being dropped onto the scheduler, the event editor is
                        explicitly made to open with the target details by invoking the <code>OpenEditor</code> method of scheduler within the <code>OnNodeDragged</code> event of TreeView.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Schedule/Schedule",
                Url = "Schedule/VirtualScrolling",
                FileName = "VirtualScrolling.razor",
                TitleTag = "Scheduler . Virtual Scrolling . Syncfusion Blazor Components",
                MetaDescription = "This example illustrates how to enable the virtual loading of resources and its events in Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example illustrates how to dynamically load the resources and events as you scroll through the scheduler.
                        All the events in this example are loaded at the initial rendering of scheduler, but the events in the visible
                        area alone will be rendered. Here, the scheduler is made to dynamically load 300 resources along with the
                        events count of 3600 (300 resources * 12 events).

                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, the virtual scrolling option is enabled on timeline month view to load the large number of
                        resources and its associated events. To enable the dynamic loading of events and resources in timeline view of
                        Scheduler, set the <code>AllowVirtualScrolling</code> property to <code>true</code> within the view-specific settings.
                    </p>"
                }
            },

            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Views",
                FileName = "Views.razor",
                TitleTag = "Scheduler . Basic Views . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the usage of basic views such as Day, Week, Work Week and Month.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the usage of basic views available in Scheduler such as Day, Week, Work Week, Month and Agenda. Here, the wildlife
                        events being held in zoos are displayed against its respective timings.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, Scheduler is showcased with 4 basic views namely
                    </p>
                    <ul>
                        <li>Day</li>
                        <li>Week</li>
                        <li>Work Week</li>
                        <li>Month</li>
                    </ul>
                    <p>
                        The user can navigate between different view options available on the header section just by clicking on it. From any of
                        the views, the user can switch back to the day view by clicking dates in the date header section. These view options
                        to be displayed on the Scheduler header bar is based on the values ['Day', 'Week', 'WorkWeek', 'Month'] assigned to
                        the
                        <code>Views</code> property.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Timeline View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Timeline",
                FileName = "Timeline.razor",
                TitleTag = "Scheduler . Timeline View . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how the timeline Scheduler looks like with its default set of configurations.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>This demo showcases how the timeline scheduler looks like with its default set of configurations.</p>"
                    },
                Description = new string[] {
                    @"<p>
                        Like the vertical scheduler, timeline view has the similar view types such as
                    </p>
                    <ul>
                        <li>Timeline Day</li>
                        <li>Timeline Week</li>
                        <li>Timeline WorkWeek</li>
                        <li>Timeline Month</li>
                    </ul>
                    <p>The Agenda and MonthAgenda views shares the same layout for both the vertical and timeline views.</p>"
                    }
            },
            new Sample
            {
                Name = "Agenda View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Agenda",
                FileName = "Agenda.razor",
                TitleTag = "Scheduler . Agenda View . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the agenda view and the configurations available in it.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the agenda view and the configurations available in it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, Agenda view is set as active view on Scheduler and made its
                        <code>AllowVirtualScrolling</code> option as false. With this settings, the Agenda view loads the initial data for the next 7 days count from the date
                        value assigned to the
                        <code>SelectedDate</code> property of the Scheduler. The initial data loading for 7 days count is due to the default value assigned to the
                        <code>AgendaDaysCount</code> property which can be customized as per the user needs.
                    </p>
                    <p>
                        When the
                        <code>AllowVirtualScrolling</code> property is set to true, the user is allowed to scroll through all the events simply by scrolling up and down upto
                        the last event available in Scheduler.
                    </p>
                    <p>
                        By default, the days which doesn't have any events will be hidden on this view - but by setting
                        <code>HideEmptyAgendaDays</code> property to false will allow the
                        <code>No Events</code> text to be displayed against the dates that has no events.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Month Agenda View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/MonthAgenda",
                FileName = "MonthAgenda.razor",
                TitleTag = "Scheduler . Month Agenda View . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the layout of Month Agenda view and how it works.",
                Type = SampleType.New,
                Description = new string[] {
                    @"<p>
                        In this demo, the active view of Scheduler is set to
                        <code>MonthAgenda</code> and no other view options are provided to
                        <code>Views</code> property. This view is designed by considering the combination of both the calendar and agenda layout together,
                        so that whenever a particular date is selected - the events belonging to that date will be displayed on the event
                        section at the bottom. Also, the dates which holds one or more events are marked with a round indicator below that
                        date.
                    </p>
                    <p>
                        On double clicking the date cells, the user can open the default event editor to create events. The events displayed on this
                        view at the bottom section can be edited or deleted either through popup options or edit event editor.
                    </p>"
                },
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the layout of Month Agenda view and its working.
                    </p>"
                }
            },
            //new Sample
            //{
            //    Name = "Individual View Settings",
            //    Category = "Views",
            //    Directory = "Schedule/Schedule",
            //    Url = "Schedule/IndividualViewSettings",
            //    FileName = "IndividualViewSettings.razor",
            //    TitleTag = "Scheduler . Individual View Settings . Syncfusion Blazor Components",
            //    MetaDescription = "This demo for Blazor Scheduler control shows how to customize each of the view with specific configurations.",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "View Intervals",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ExtendedViews",
                FileName = "ExtendedViews.razor",
                TitleTag = "Scheduler . View Intervals . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to display n number of days, weeks and months on a single view.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo illustrates how to display n number of days, weeks and months on a single view.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the
                        <code>Interval</code> property has been defined with different values on each view such as 3 on day view, 2 on week view and 4 on month
                        view. so that 3 days, 2 weeks and 4 months displayed on the respective views. This property is not applicable on
                        agenda and month agenda views.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Year View",
                Category = "Views",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Year",
                FileName = "Year.razor",
                TitleTag = "Scheduler . Year . Syncfusion Blazor Components",
                MetaDescription = "This example for Blazor Scheduler control shows the layout of Horizontal and Vertical Year views and how it works.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases how the scheduler looks like in Year view with its default set of configurations.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        This demo showcases how the scheduler looks like in Year view with its default set of configurations. In this demo, the active view of Scheduler is set to
                        <code>Vertical Year</code> and <code>Horizontal Year</code> view options are provided to
                        <code>Schedule Views</code>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Room Scheduler",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/TimelineResource",
                FileName = "TimelineResource.razor",
                TitleTag = "Scheduler . Room Scheduler . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to design the room Scheduling calendar and manage the events booked on a particular time interval.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                This demo showcases how the multiple resources are grouped as well as how the events are portrayed in timeline view layouts.
                </p>"
                },
                Description = new string[] {
                @"<p>
                In the timeline view, each row depicts a single resource whereas in vertical views, each resource are grouped parallelly
                as columns. Here, the resource grouping follows the tree-view like hierarchical grouping structure and can contain
                any level of child resources. In this sample, we have used two level hierarchy, where the
                <code>PROJECT 1</code> and
                <code>PROJECT 2</code> are the parent level and the
                <code>development</code> and
                <code>testing</code> are child level resources which are defined using the
                <code>Resources</code> property. They are grouped in layout by making use of the
                <code>Group</code> property and its order of grouping depends on the order of names passed onto the
                <code>Resources</code> option within
                <code>Group</code>.
                </p>
                <p>
                Also, the colors defined for the child level resources will get applied to the events of those resources by default. In case,
                if the colors of parent level needs to be applied to those child events, then it is necessary to define the
                <code>ResourceColorField</code> option within the
                <code>EventSettings</code> property with the parent level resource name value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Shared Events",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupEditing",
                FileName = "GroupEditing.razor",
                TitleTag = "Scheduler . Shared Events . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the usage of single event that are shared by multiple resources.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This demo illustrates the usage of single event that are shared by multiple resources.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this demo,
                        <code>AllowGroupEdit</code> option is set to true within the
                        <code>Group</code> property to enable the same event to be shared with multiple resources. With this property enabled, a single appointment
                        object will be maintained within the appointment collection, even if it is shared by more than one resource - whereas
                        the resource fields of such appointment object will hold the IDs of the multiple resources separated by commas. Any
                        actions such as create, edit or delete held on any one of the event, will be reflected on all other related instances
                        visible on the UI. The
                        <code>AllowMultiple</code> option when set as true within the
                        <code>Resource</code> property, will allow the user to select multiple resources from the resource field of editor window, while trying
                        to create appointments.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Different Work Days",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupCustomWorkdays",
                FileName = "GroupCustomWorkdays.razor",
                TitleTag = "Scheduler . Different Work Days . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to set different working days for each of the resources.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the different available dates of doctors and their appointments on those days.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, different working days are assigned by passing the
                        <code>WorkDays</code> collection for each doctor to show their available dates. On each of their available dates, their daily available
                        time range is also depicted by mentioning the
                        <code>StartHour</code> and
                        <code>EndHour</code> for each doctor. These values needs to be provided along with the resource
                        <code>DataSource</code> by mapping the appropriate fields namely
                        <code>WorkDaysField</code>,
                        <code>StartHourField</code> and
                        <code>EndHourField</code>.
                    </p>"
                }

            },
            new Sample
            {
                Name = "Show/Hide Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/AddRemoveResources",
                FileName = "AddRemoveResources.razor",
                TitleTag = "Scheduler . Show/Hide Resources . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to dynamically add or remove the resources to and from the Blazor Scheduler layout.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo illustrates how to dynamically add or remove resources to and from the Scheduler layout.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, Scheduler is initially displayed with single resource with its related set of appointments. When the additional
                        checkboxes given are checked and unchecked, the respective resources gets added up or removed from the scheduler layout.
                        To add new resources dynamically,
                        <code>AddResource</code> method is used which accepts the arguments such as resource object, resource name (within which level, the resource
                        object to be added) and index (position where the resource needs to be added). To remove the resources dynamically,
                        <code>RemoveResource</code> method is used which accepts the index (position from where the resource to be removed) and resource name (within
                        which level, the resource object presents) as parameters.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Row Auto Height",
                Category = "Multiple Resources",
                Directory = "Schedule/Schedule",
                Url = "Schedule/AdaptiveRows",
                FileName = "AdaptiveRows.razor",
                TitleTag = "Scheduler . Row Auto Height . Syncfusion Blazor Components",
                MetaDescription = "This example showcases how the work cells of Blazor Scheduler auto adjusts its height based on the exceeding appointment count.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example showcases how the work-cells of Scheduler auto-adjust its height based on the number of
                        appointments present in those time ranges.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, <code>RowAutoHeight</code> property is set as <code>true</code> to auto-adjust the height
                        of work cells based
                        on the number of appointments present in the same time ranges. Also, this functionality is applicable only on
                        all the timeline views as well as on the calendar month view. When this option is disabled, the height of the
                        work
                        cells remains static and at the time of exceeding appointments count, the <code>+n more</code> text indicator
                        will be
                        shown at the bottom of the cells.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Group",
                FileName = "Group.razor",
                TitleTag = "Scheduler . Horizontal Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how the calendars of multiple resources are grouped in default view layouts.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo illustrates the timings of different flight services on a specific route say between Barcelona and Los Angeles,
                        on a daily basis. Here, the Scheduler is grouped based on the 3 Airline services.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the scheduler has been grouped with multiple resources by making use of the property
                        <code>Group</code>. The resources to be grouped depends on the values of
                        <code>Resources</code> option within the
                        <code>Group</code> property, which accepts the array of resource names.
                    </p>
                    <p>
                        In mobile mode, when the grouping is enabled, the resources will be listed out in a treeview as a side-panel which opens
                        or closes, on clicking the hamburger icon at the resource header. Only a single resource will be viewable at a time,
                        due to the space constraints on mobile. If in case, the users want to view the grouped layout on mobile with scrolling
                        content, then it is necessary to set
                        <code>false</code> to the
                        <code>EnableCompactView</code> option within the
                        <code>Group</code> property which is set to
                        <code>true</code> by default. This option is not applicable on desktop mode.
                    </p>
                    <p>
                        Note: If the
                        <code>Group</code> property is not defined, then the default scheduler will be rendered with no grouping on layout, but the appointments
                        of all the resources will be displayed on a single scheduler.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/TimelineResourceGroup",
                FileName = "TimelineResourceGroup.razor",
                TitleTag = "Scheduler . Timeline Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how the calendars of multiple resources are grouped in timeline view layouts.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the scheduler that lists out the meeting rooms of an office and its availability.      </p>"
                },
                Description = new string[] {
                    @"<p>
                        Here, the timeline view is grouped with single level of resources by making use of the
                        <code>Group</code> property.The resource header displayed at the left panel is customized
                        to render as columns with the help of
                        <code>ResourceHeaderTemplate</code>.
                    </p>
                    <p>
                        <b>Note:</b> The dates which lies beyond the current date set to scheduler through
                        <code>SelectedDate</code> property is considered as the past dates here in this sample.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Date-wise Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupByDate",
                FileName = "GroupByDate.razor",
                TitleTag = "Scheduler . Date-wise Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how the resources are grouped under each date.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                This demo illustrates the daily tasks of two employees grouped by date-wise.
                </p>"
                },
                Description = new string[] {
                @"<p>
                    In this demo, there are 2 resources defined namely
                    <strong>Alice</strong> and
                    <strong>Smith</strong> under the resource
                    <code>DataSource</code>. The Scheduler can be switched to group by date, by setting
                    <code>true</code> to the option
                    <code>ByDate</code> within the
                    <code>Group</code> property.

                </p>"
                }

            },
            new Sample
            {
                Name = "Hierarchical Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Schedule",
                Url = "Schedule/GroupByChild",
                FileName = "GroupByChild.razor",
                TitleTag = "Scheduler . Hierarchical Grouping . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to group the child level resources against each of the parent level resources.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                This demo illustrates the work progress under two different projects which are categorized as 'Development' and 'Testing',
                            since both the projects comes across the two common stages.

                </p>"
                },
                Description = new string[] {
                @"<p>
                In this demo, there are two resource levels defined under the
                            <code>Resources</code> property - one with the name
                            <code>Projects</code> and other with the name
                            <code>Categories</code> respectively. Also, both the names are defined in the
                            <code>Group</code> property to allow two level hierarchical grouping. The order of grouping depends on the order of names passed onto
                            the
                            <code>Resources</code> option within
                            <code>Group</code>. The requirement here is to categorize the sub-options that are common to both the projects and therefore to enable
                            such grouping, it is necessary to set
                            <code>ByGroupID</code> option within the
                            <code>GroupID</code> - whereby allowing all the resources available in each child level to group under its parent resources. With this
                            option available, we can avoid the need to provide multiple definitions of the same data to be grouped under different
                            parent.
                        </p>
                        <p>
                            Also, the colors defined at the last level resources will get applied to the events of those resources by default. In case,
                            if the colors of parent level needs to be applied to child events, then it is necessary to define the
                            <code>resourceColorField</code> option within the
                            <code>EventSettings</code> property with the parent level resource name value.
                </p>"
                }
            },
            new Sample
            {
                Name = "Date Header",
                Category = "Templates",
                Directory = "Schedule/Schedule",
                Url = "Schedule/DateHeader",
                FileName = "DateHeader.razor",
                TitleTag = "Scheduler . Date Header . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to customize the date header cells using the template option.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                This demo depicts the way to add images and custom text to the date header bar by making use of the date header template
                option.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                In this demo, the
                <code>DateHeaderTemplate</code> option is used to customize the date header cells of day, week and workweek views. In month view, the date header
                is not applicable.
            </p>"
                }
            },
            new Sample
            {
                Name = "Cell",
                Category = "Templates",
                Directory = "Schedule/Schedule",
                Url = "Schedule/CustomCell",
                FileName = "CustomCell.razor",
                TitleTag = "Scheduler . Cell . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to customize the background of the specific cells using cell template option.",
                Type = SampleType.New,

            },
            new Sample
            {
                Name = "Event Template",
                Category = "Templates",
                Directory = "Schedule/Schedule",
                Url = "Schedule/AppointmentTemplate",
                FileName = "AppointmentTemplate.razor",
                TitleTag = "Scheduler . Event Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor control shows how to customize the appearance of events using event template option.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                        @"<p>
                        This demo showcases the way of customizing the look of events that are displayed on Schedule. Any kind of text, images
                            and links can be added to customize the look of the events. Here, the webinar sessions on specific topic that are
                            scheduled on respective week days have been displayed on scheduler across its respective time duration.
                </p>"
                    },
                    Description = new string[] {
                        @"<p>
                            With the usage of template, the user can format and change the default appearance of the events by making use of the
                            <code>Template</code> option which is available within the
                            <code>EventSettings</code> property. Here, the HTML template design is compiled and then the resultant output will be displayed directly on
                            the events.
                </p>"
                    }
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Templates",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Tooltip",
                FileName = "Tooltip.razor",
                TitleTag = "Scheduler . Tooltip . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to display tooltip over events as well as the way to customize it using template option.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                        @"<p>
                        This demo illustrates how to enable tooltip on scheduler events as well as the way to customize it. The tooltip can be
                            customized to display any of the information in a formatted style by making use of the tooltip template option.
                </p>"
                    },
                    Description = new string[] {
                        @"<p>
                            In this demo, the tooltip is enabled to display on events by setting true to
                            <code>EnableTooltip</code> option within the
                            <code>EventSettings</code> property. After enabling the default tooltip, it is customized to display the needed event information along with
                            the appropriate images by making use of the <code>TooltipTemplate</code> option within the <code>EventSettings</code>.
                        </p>
                        <p>
                            The <code>TooltipTemplate</code> option will not work, if
                            <code>EnableTooltip</code> is set to false. In mobile devices, tap holding the events will open the tooltip.
                        </p>"
                    }
            },
            new Sample
            {
                Name = "Field Validation",
                Category = "Editor Window",
                Directory = "Schedule/Schedule",
                Url = "Schedule/EditorValidation",
                FileName = "EditorValidation.razor",
                TitleTag = "Scheduler . Field Validation . Syncfusion Blazor Components",
                MetaDescription = "This demo shows the way of adding default and custom validation rules to the editor fields of Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo shows the way of adding default and custom validation rules to the editor fields of Scheduler.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the specific fields of Scheduler editor window such as
                        <code>Subject</code>,
                        <code>Location</code>,
                        <code>Description</code>,
                        <code>StartTime</code> and
                        <code>EndTime</code> are made to undergo validation such that if it is left as blank, then the default required validation message will
                        be displayed in a separate tooltip, on clicking a save button.
                    </p>
                    <p>
                        Additionally, the regex condition has been added to the
                        <code>Location</code> field, so that if any special characters are typed into it, then the custom validation message will be displayed.
                        The
                        <code>Description</code> field has been validated to restrict the character count to be typed into it between 5 and 500 and not beyond that.
                        This validation can be given by making use of the
                        <code>Validation</code> API available within each
                        <code>Fields</code> of
                        <code>EventSettings</code> property.
                    </p>
                    <p>
                        Apart from this validation feature, the built-in validation has been provided to the start and end time fields - so that,
                        when the selected end time occurs before the start time, a validation message will be displayed as well as when some
                        unwanted characters are typed into the date fields, the invalid date message will be alerted.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Editor Template",
                Category = "Editor Window",
                Directory = "Schedule/Schedule",
                Url = "Schedule/EditorPopupTemplate",
                FileName = "EditorPopupTemplate.razor",
                TitleTag = "Scheduler . Editor Template . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows the way of customizing the default editor window with custom template design.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                        @"<p>
                This demo illustrates the way of customizing the default editor window with custom template option and the customized
                design is automatically replaced onto the usual event editor. Here, a doctor's daily appointment with his patients
                is listed out and shaded with specific color based on its status.

                </p>"
                    },
                Description = new string[] {
                        @"<p>
                            In this demo, the event window is customized based on the doctor's required appointment related fields which can be achieved
                            by making use of the <code>EditorTemplate</code> API. Here, the custom design is built with the required field.
                        </p>
                        <p>
                            Each field defined through it should contain the <code>e-field</code> class, so as to allow the processing of those fields in the default event object from internal source. So that this customized fields will be replaced onto the default editor window.
                        </p>
                        <p>
                            As we are using our Syncfusion sub-components within this editor in this demo, therefore the custom defined form elements
                            needs to be configured as required Syncfusion components such as DropDownList and DateTimePicker. This particular step can be skipped, if the user needs to simply use the normal form design with applicable
                            fields.
                        </p>"
                    }
            },
            new Sample
            {
                Name = "Header Rows",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/HeaderRows",
                FileName = "HeaderRows.razor",
                TitleTag = "Scheduler . Header Rows . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to display the additional header rows on timeline view.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p> This demo showcases how to display the additional header rows on timeline view. In this demo, an additional row for displaying
                                <b>month</b> and
                                <b>week number</b> has been added.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Unlike the usual date and time rows, timeline view can be displayed with additional header rows to display the years, months
                                and week numbers. To do so, define the
                                <code>HeaderRows</code> property which accepts an array of object and each object includes the
                                <code>Option</code> API to define the specific header row type such as
                                <code>Year</code>,
                                <code>Month</code>,
                                <code>Week</code> and
                                <code>Date</code>. The object also includes the
                                <code>Template</code> option to provide label customization on these rows. This
                                <code>HeaderRows</code> property is applicable only on timeline views.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Timescale",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Timescale",
                FileName = "Timescale.razor",
                TitleTag = "Scheduler . Timescale . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to customize the grid lines of Blazor Scheduler with different duration and count.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo depicts how to customize the grid lines of scheduler with different duration, count and also, how to
                        apply template customizations on it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this demo, schedule has been allowed to display different number of grid lines per hour assigned with different duration
                        to each cell, by making use of the
                        <code>Interval</code> and
                        <code>SlotCount</code> properties. The grid lines can also be disabled on schedule, by setting <code>false</code> to the
                        <code>Enable</code> property available within
                        <code>TimeScale</code>. The time header text can be customized by making use of the
                        <code>MajorSlotTemplate</code> and
                        <code>MinorSlotTemplate</code> properties.
                    </p>"
                }
            },
             new Sample
             {
                 Name = "Scroll Time",
                 Category = "Customization",
                 Directory = "Schedule/Schedule",
                 Url = "Schedule/ScrollTime",
                 FileName = "ScrollTime.razor",
                 TitleTag = "Scheduler . Scroll Time . Syncfusion Blazor Components",
                 MetaDescription = "This demo shows the way of manually scrolling to specific time on Blazor Scheduler.",
                 Type = SampleType.New,
                 ActionDescription = new string[] {
                     @"<p>
                         This demo illustrates the way of manually scrolling to specific time on Scheduler.
                     </p>"
                 },Description = new string[] {
                     @"<p>
                         In this demo, the way of manually scrolling to specific time on scheduler has been demonstrated by making use of the
                         <code>ScrollTo</code> method of Scheduler.
                     </p>"
                 }
             },
            new Sample
            {
                Name = "Work Days",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/WorkDays",
                FileName = "WorkDays.razor",
                TitleTag = "Scheduler . Work Days . Syncfusion Blazor Components",
                MetaDescription = "This demo showcases how to set customized working days as well as first day of a week on Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This demo showcases how to set customized working days as well as first day of a week on Scheduler.
                    </p>"
                },Description = new string[] {
                    @"<p>
                        In this demo, the working days of a week can be set on Scheduler using the
                        <code>WorkDays</code> property which accepts the collection of day indexes (from 0 to 6) of a week. By default, it is set to
                        <code>[1, 2, 3, 4, 5]</code> and in this demo, it has been set to
                        <code>[1, 3, 5]</code> which means that
                        <code>Monday, Wednesday, Friday</code> is being set as working days of a week and is visually differentiated from non-working days. The working hours usually
                        applies only on these given working days.
                    </p>
                    <p>
                        The first day of the week can also be set on the Schedule by making use of the
                        <code>FirstDayOfWeek</code> property, doing so which will make the Scheduler to start with that day.
                    </p>
                    <p>
                        <strong>Note: </strong> Here, Sunday is always denoted as 0, Monday as 1 and so on.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Hide Non-Working Days",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/HideWeekend",
                FileName = "HideWeekend.razor",
                TitleTag = "Scheduler . Hide Non-Working Days . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control depicts the way to show or hide the weekend days of a week.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo depicts the way to show or hide the weekend days of a week on Scheduler. The days whichever not specified in
                        working days collections will be taken into consideration as weekend days.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the
                        <code>ShowWeekend</code> property is used either to show or hide the weekend days of a week and it is not applicable on
                        <code>Workweek</code> view. By default, it is set to
                        <code>true</code>. The days which are not a part of the working days collection of a Scheduler are usually considered as weekend days
                        here.
                    </p>
                    <p>
                        Here, the working days are defined as
                        <code>[1, 3, 4, 5]</code> on Scheduler. Therefore, the remaining days (0, 2, 6 - Sunday, Tuesday and Saturday) are considered as weekend days
                        and will be hidden from the views as the
                        <code>ShowWeekend</code> property is set to false.
                    </p>"
                }
            },
            new Sample
            {
               Name = "Work Hours",
               Category = "Customization",
               Directory = "Schedule/Schedule",
               Url = "Schedule/WorkHours",
               FileName = "WorkHours.razor",
               TitleTag = "Scheduler . Work Hours . Syncfusion Blazor Components",
               MetaDescription = "This demo showcases how to set the work hour range on Blazor Scheduler.",
               Type = SampleType.New,
               ActionDescription = new string[] {
                    @"<p>
                        This demo showcases how to set the required working hours on Scheduler, thus visually highlighting the cells underlying the
                        given work hour range.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the work hours are set by using the
                        <code>WorkHours</code> property and it usually applies only on the working days defined for the Schedule. It can either be highlighted
                        or not by defining the
                        <code>Highlight</code> option within the
                        <code>WorkHours</code> property. The working hour range can be defined by making use of the
                        <code>Start</code> and <code>End</code> option available within the
                        <code>WorkHours</code> property.
                    </p>
                    <p>
                        To set discontinuous working hours on a day, then the default
                        <code>WorkHours</code> on Scheduler needs to be disabled by setting false to
                        <code>Highlight</code> option within it. Then, make use of the
                        <code>SetWorkHours</code> method which accepts the days collection and the start & end hour values as parameters.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Day Hour Limit",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/DayHourLimit",
                FileName = "DayHourLimit.razor",
                TitleTag = "Scheduler . Day Hour Limit . Syncfusion Blazor Components",
                MetaDescription = "This demo depicts how to restrict the start and end hours on Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo depicts how to restrict the start and end hours of Schedule, thus limiting it to display only the given hour range.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, the Scheduler is made to display from 8 AM to 8 PM and the rest of the hours are hidden, as it is restricted
                        to start from <code>08:00</code> hours and end on <code>20:00</code> hours by setting to
                        <code>StartHour</code> and <code>EndHour</code> properties respectively.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Cell Dimension",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/CellDimensions",
                FileName = "CellDimensions.razor",
                TitleTag = "Scheduler . Cell Dimension . Syncfusion Blazor Components",
                MetaDescription = "This demo for Blazor Scheduler control shows how to set the width and height of the cells by overriding the default CSS classes.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                        @"<p>
                    This demo shows how to set the width and height of the cells by overriding the default CSS classes, so that the Schedule
                    events are viewable in a zoomed in style.
                </p>"
                    },
                    Description = new string[] {
                        @"<p>
                    In this demo, the height and width of the Scheduler cells are set by overriding the default CSS class.
                </p>"
                    }
            },
            new Sample
            {
                Name = "Read-only Events",
                Category = "Customization",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ReadonlyEvents",
                FileName = "ReadonlyEvents.razor",
                TitleTag = "Scheduler . Read-only Events . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to make specific events on the Blazor Scheduler to be displayed in a read-only mode.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases how to make specific events on the Scheduler to be displayed in a read-only mode. The read-only events
                        can be simply viewed and prevented from undergoing any edit actions.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                    In this demo, the events that has occurred on the past hours from the current time are made as read-only and
                        the CRUD actions has been prevented on it. This has been done by setting <code>true</code> to the <code>IsReadonly</code> field of
                        past events. By doing so, the <code>aria-readonly</code> attribute gets added into the event element and differentiate it
                        from the other normal events.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Excel Exporting",
                Category = "Exporting",
                Directory = "Schedule/Schedule",
                Url = "Schedule/ExcelExport",
                FileName = "ExcelExport.razor",
                TitleTag = "Scheduler . Excel Exporting . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to export the Blazor Scheduler events to the excel file format at client-side.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates how to export the Scheduler events to an Excel file format at client-side.
                    </p>"
                },
                Description = new string[] {
                    @" <p>In this example, the Scheduler events data are exported to an Excel file by making use of the public method
                    <code>ExportToExcel</code>. By default, the whole event collection bound to the Scheduler gets exported as an excel file. To
                    export only specific events of Scheduler, you need to pass the custom data collection as a parameter to the
                    <code>ExportToExcel</code> method. This method accepts the export options as its arguments such as FileName, ExportType,
                    Fields, CustomData, and IncludeOccurrences. The FileName denotes the name to be given for the exported file and
                    the <code>ExportType</code> allows you to set the format of the excel file to be exported either as .xlsx or .csv. The custom
                    or specific field collection of event dataSource to be exported can be provided through <code>Fields</code> option and the
                    custom data collection can be exported by passing them through the <code>CustomData</code> option. There also exists option
                    to export individual instances of the recurring events to an excel file, by setting true or false to the
                    <code>IncludeOccurrences</code> option, denoting either to include or exclude the occurrences as separate instances on an
                    exported excel file.
                    </p>"
                }
            },
            //new Sample
            //{
            //    Name = "Export and Import ICS",
            //    Category = "Exporting",
            //    Directory = "Schedule/Schedule",
            //    Url = "Schedule/CalendarExportImport",
            //    FileName = "CalendarExportImport.razor",
            //    TitleTag = "Scheduler . Export and Import ICS . Syncfusion Blazor Components",
            //    MetaDescription = "This example shows how to export the appointments to a calendar file, and also how to import events from an .ics file into our Blazor Scheduler.",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Print",
                Category = "Exporting",
                Directory = "Schedule/Schedule",
                Url = "Schedule/Print",
                FileName = "Print.razor",
                TitleTag = "Scheduler . Print . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to print the Blazor Scheduler element at client-side with themes enabled.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates how to print the Scheduler elements.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        In this example, the Scheduler element is Printed by making use of the public method
                    <code>Print</code>.</p>
                    </p>"
                }
            },
            //new Sample
            //{
            //    Name = "Rule Generator",
            //    Category = "Recurrence Editor",
            //    Directory = "Schedule/Schedule",
            //    Url = "Schedule/RecurrenceRuleGenerator",
            //    FileName = "RecurrenceRuleGenerator.razor",
            //    TitleTag = "Scheduler . Rule Generator . Syncfusion Blazor Components",
            //    MetaDescription = "This demo showcases the recurrence rule generation based on the options selected from the recurrence editor.",
            //    Type = SampleType.New
            //},
            new Sample
            {
                Name = "Populate Rule",
                Category = "Recurrence Editor",
                Directory = "Schedule/Schedule",
                Url = "Schedule/RecurrenceEditorPopulateRule",
                FileName = "RecurrenceEditorPopulateRule.razor",
                TitleTag = "Scheduler . Populate Rule . Syncfusion Blazor Components",
                MetaDescription = "This demo shows how to fill the recurrence editor fields with values based on the provided recurrence rule string.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases how to fill the recurrence editor fields with appropriate values based on the user-provided recurrence
                        rule string.
                    </p>"
                },Description = new string[] {
                    @"<p>
                        In this demo, the <code>SetRecurrenceRule</code> method is used to populate the fields of recurrence editor based on the static rule options selected from the dropdown list.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "Schedule/Schedule",
                Url = "Schedule/KeyboardInteraction",
                FileName = "KeyboardInteraction.razor",
                TitleTag = "Scheduler . Keyboard Interaction . Syncfusion Blazor Components",
                MetaDescription = "This demo showcases the keyboard shortcuts available on Blazor Scheduler.",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        This demo showcases the keyboard shortcuts applicable on Scheduler and also lists out in below description, how those applicable
                        shortcuts interacts with Scheduler actions.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        All the Scheduler actions can be controlled via keyboard keys and is availed by using
                        <code>AllowKeyboardInteraction</code> property which is set to true by default. The applicable key combinations and its relative functionalities are listed
                        below.
                    </p>
                    <table style=""width:100%"">
                        <tr>
                            <th style=""width:200px"">
                                <strong>Keys</strong>
                            </th>
                            <th>
                                <strong>Description</strong>
                            </th>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Tab</kbd>
                            </td>
                            <td>
                                Focuses the first or active item on the schedule header bar and then move the focus to the next available event
                                elements. If no events present, then focus moves out of the component.
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Shift</kbd> +
                                <kbd>Tab</kbd>
                            </td>
                            <td>
                                Reverse focusing of the Tab functionality. Inverse focusing of event elements from the last one and then move
                                onto the first or active item on Schedule header bar and then moves out of the component.
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Enter</kbd> key
                            </td>
                            <td>Opens the quick popup on the selected cells or events.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Escape</kbd> key
                            </td>
                            <td>Closes any of the popup that are in open state.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Arrow</kbd> keys
                            </td>
                            <td>To move onto the next available cells in either of the needed directions (left, right, top and right)</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Shift</kbd> +
                                <kbd> Arrow</kbd> keys
                            </td>
                            <td>For multiple cell selection on either direction.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Delete</kbd> key
                            </td>
                            <td>Deletes one or more selected events.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Ctrl</kbd> +
                                <kbd>Click</kbd> on events
                            </td>
                            <td>To select multiple events.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Alt</kbd> +
                                <kbd>Number</kbd> keys (from 1 to 6)
                            </td>
                            <td>To switch between the views on Schedule.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Ctrl</kbd> +
                                <kbd>Left Arrow</kbd> keys
                            </td>
                            <td>To navigate to the previous date period.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Ctrl</kbd> +
                                <kbd>Right Arrow</kbd> keys
                            </td>
                            <td>To navigate to the next date period.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Left</kbd> or
                                <kbd>Right Arrow</kbd> keys
                            </td>
                            <td>
                                On pressing any of these keys when focus is currently on the Schedule header bar, moves the focus to the previous
                                or next items in the header bar.
                            </td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Space</kbd> or
                                <kbd>Enter</kbd> keys
                            </td>
                            <td>It activates any of the focused items.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Page Up</kbd> &
                                <kbd>Page Down</kbd> keys
                            </td>
                            <td>To scroll through the work cells area.</td>
                        </tr>
                        <tr>
                            <td style=""padding:4px 0"">
                                <kbd>Home</kbd> key
                            </td>
                            <td>To move the selection to the first cell of Schedule.</td>
                        </tr>
                    </table>"
                }
            }
        };
    }
}
