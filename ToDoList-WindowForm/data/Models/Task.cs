using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

#nullable disable

namespace data.Models
{
    public partial class Task
    {
        public Task()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ScheduleDate { get; set; }
        public Nullable <DateTime> CompleteDate { get; set; }
        public bool Status { get; set; }
    }
}
