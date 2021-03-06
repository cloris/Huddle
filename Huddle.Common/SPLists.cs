﻿namespace Huddle.Common
{
    public class SPLists
    {
        public const string ID = "ID";
        public const string Title = "Title";
        public const string State = "State";
        public const string Created = "Created";
        public const string Issue = "Issue";
        public const string Reason = "Reason";
        public const string InputDate = "Input_x0020_Date";

        public static class Categories
        {
            public const string ListTitle = "Categories";

            public static class Columns
            {
                public const string ID = SPLists.ID;
                public const string Title = SPLists.Title;
            }
        }

        public static class Issues
        {
            public const string Title = "Issues";

            public static class Columns
            {
                public const string ID = SPLists.ID;
                public const string Title = SPLists.Title;
                public const string State = SPLists.State;
                public const string Category = "Issue_x0020_Category";
                public const string IssueMetric = "Issue_x0020_Metric";
                public const string TargetGoal = "Target_x0020_Goal";
                public const string TeamId = "Team_x0020_Id";
                public const string Created = SPLists.Created;
            }

            public static class States
            {
                public const string Active = "1";
            }
        }

        public static class Reasons
        {
            public const string Title = "Reasons";

            public static class Columns
            {
                public const string ID = SPLists.ID;
                public const string Title = SPLists.Title;
                public const string State = SPLists.State;
                public const string Issue = SPLists.Issue;
                public const string Created = SPLists.Created;
            }
        }

        public static class IssueMetrics
        {
            public const string Title = "Issue Metrics";

            public static class Columns
            {
                public const string ID = SPLists.ID;
                public const string Issue = "Issue";
                public const string MetricValue = "Metric_x0020_Value";
                public const string InputDate = SPLists.InputDate;
            }
        }

        public static class ReasonMetrics
        {
            public const string Title = "Reason Metrics";

            public static class Columns
            {
                public const string ID = SPLists.ID;
                public const string Reason = SPLists.Reason;
                public const string ReasonMetricValue = "Reason_x0020_Metric_x0020_Value";
                public const string InputDate = SPLists.InputDate;
            }
        }

        public static class MetricIdeas
        {
            public const string Title = "Metric Ideas";

            public static class Columns
            {
                public const string ID = "ID";
                public const string Metric = "Metric";
                public const string TaskId = "Task_x0020_Id";
                public const string TaskURL = "Task_x0020_URL";
                public const string TaskName = "Task_x0020_Name";
                public const string InputDate = SPLists.InputDate;
                public const string TaskStartDate = "Task_x0020_Start_x0020_Date";
                public const string TaskStatus = "Current_x0020_Status";
                public const string TaskCompletedDate = "Task_x0020_Completed_x0020_Date";
            }
        }
    }
}
