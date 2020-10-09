﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Scheduler { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/overview",
                FileName = "Overview.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Scheduler",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/default-functionalities",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/local-data",
                FileName = "LocalData.razor"
            },
            new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/remote-data",
                FileName = "RemoteData.razor"
            },
            new Sample
            {
                Name = "Custom Binding",
                Category = "Data Binding",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-binding",
                FileName = "CustomBinding.razor"
            },
            new Sample
            {
                Name = "Recurring Events",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-events",
                FileName = "RecurrenceEvents.razor"
            },
            new Sample
            {
                Name = "Block-out Dates and Hours",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/block-out-dates-and-hours",
                FileName = "BlockEvents.razor"
            },
            new Sample
            {
                Name = "External Drag And Drop",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/external-drag-and-drop",
                FileName = "ExternalDragDrop.razor"
            },
            new Sample
            {
                Name = "Inline Editing",
                Category = "Appointments",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/inline-editing",
                FileName = "InlineEditing.razor"
            },
            new Sample
            {
                Name = "Virtual Scrolling",
                Category = "Scrolling",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/virtual-scrolling",
                FileName = "VirtualScrolling.razor"
            },

            new Sample
            {
                Name = "Basic Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/basic-views",
                FileName = "Views.razor"
            },
            new Sample
            {
                Name = "Timeline View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-view",
                FileName = "Timeline.razor"
            },
            new Sample
            {
                Name = "Agenda View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/agenda-view",
                FileName = "Agenda.razor"
            },
            new Sample
            {
                Name = "Month Agenda View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/month-agenda-view",
                FileName = "MonthAgenda.razor"
            },
            new Sample
            {
                Name = "Individual View Settings",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/individual-view-settings",
                FileName = "IndividualViewSettings.razor"
            },
            new Sample
            {
                Name = "Custom Views",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/custom-views",
                FileName = "ExtendedViews.razor"
            },
            new Sample
            {
                Name = "Year View",
                Category = "Views",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/year-view",
                FileName = "Year.razor"
            },
            new Sample
            {
                Name = "Room Scheduler",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/room-scheduler",
                FileName = "TimelineResource.razor"
            },
            new Sample
            {
                Name = "Shared Events",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/shared-events",
                FileName = "GroupEditing.razor"
            },
            new Sample
            {
                Name = "Different Work Days",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/different-work-days",
                FileName = "GroupCustomWorkdays.razor"
            },
            new Sample
            {
                Name = "Add or Remove Resources",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/add-remove-resources",
                FileName = "AddRemoveResources.razor"
            },
            new Sample
            {
                Name = "Adaptive Rows",
                Category = "Multiple Resources",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/adaptive-rows",
                FileName = "AdaptiveRows.razor"
            },
            new Sample
            {
                Name = "Horizontal Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/horizontal-grouping",
                FileName = "Group.razor"
            },
            new Sample
            {
                Name = "Timeline Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/timeline-grouping",
                FileName = "TimelineResourceGroup.razor"
            },
            new Sample
            {
                Name = "Date-wise Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-wise-grouping",
                FileName = "GroupByDate.razor"
            },
            new Sample
            {
                Name = "Hierarchical Grouping",
                Category = "Resource Grouping",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hierarchical-grouping",
                FileName = "GroupByChild.razor"
            },
            new Sample
            {
                Name = "Date Header",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/date-header",
                FileName = "DateHeader.razor"
            },
            new Sample
            {
                Name = "Cell Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-template",
                FileName = "CustomCell.razor"
            },
            new Sample
            {
                Name = "Event Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/event-template",
                FileName = "AppointmentTemplate.razor"
            },
            new Sample
            {
                Name = "Tooltip Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/tooltip-template",
                FileName = "Tooltip.razor"
            },
            new Sample
            {
                Name = "Quick Info Template",
                Category = "Templates",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/quick-info-template",
                FileName = "QuickInfoTemplate.razor"
            },
            new Sample
            {
                Name = "Field Validation",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/field-validation",
                FileName = "EditorValidation.razor"
            },
            new Sample
            {
                Name = "Editor Template",
                Category = "Editor Window",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/editor-template",
                FileName = "EditorPopupTemplate.razor"
            },
            new Sample
            {
                Name = "Header Rows",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/header-rows",
                FileName = "HeaderRows.razor"
            },
            new Sample
            {
                Name = "Timescale",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/time-scale",
                FileName = "Timescale.razor"
            },
            new Sample
            {
                Name = "Context Menu",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/context-menu",
                FileName = "ContextMenu.razor"
            },
             new Sample
             {
                 Name = "Scroll Time",
                 Category = "Customization",
                 Directory = "Schedule/Scheduler",
                 Url = "scheduler/scroll-time",
                 FileName = "ScrollTime.razor"
             },
            new Sample
            {
                Name = "Working Days",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/working-days",
                FileName = "WorkDays.razor"
            },
            new Sample
            {
                Name = "Hide Non-Working Days",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hide-non-working-days",
                FileName = "HideWeekend.razor"
            },
            new Sample
            {
               Name = "Working Hours",
               Category = "Customization",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/working-hours",
               FileName = "WorkHours.razor"
            },
            new Sample
            {
                Name = "Hide Non-Working Hours",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/hide-non-working-hours",
                FileName = "DayHourLimit.razor"
            },
            new Sample
            {
                Name = "Cell Dimension",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/cell-dimensions",
                FileName = "CellDimensions.razor"
            },
            new Sample
            {
                Name = "Read-only Events",
                Category = "Customization",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/readonly-events",
                FileName = "ReadonlyEvents.razor"
            },
            new Sample
            {
                Name = "Export to Excel",
                Category = "Exporting",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/export-to-excel",
                FileName = "ExcelExport.razor"
            },
            new Sample
            {
               Name = "Export and Import ICS",
               Category = "Exporting",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/export-and-import-ics",
               FileName = "CalendarExportImport.razor"
            },
            //new Sample
            //{
            //    Name = "Print Appointments",
            //    Category = "Exporting",
            //    Directory = "Schedule/Scheduler",
            //    Url = "scheduler/print-appointments",
            //    FileName = "Print.razor"
            //},
            new Sample
            {
               Name = "RRule Generator",
               Category = "Recurrence Editor",
               Directory = "Schedule/Scheduler",
               Url = "scheduler/recurrence-editor-rrule-generator",
               FileName = "RecurrenceRuleGenerator.razor"
            },
            new Sample
            {
                Name = "Recurrence Rules",
                Category = "Recurrence Editor",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/recurrence-rules",
                FileName = "RecurrenceEditorPopulateRule.razor"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Miscellaneous",
                Directory = "Schedule/Scheduler",
                Url = "scheduler/keyboard-interaction",
                FileName = "KeyboardInteraction.razor"
            }
        };
    }
}
