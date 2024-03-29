﻿using Domain.Comman;
using Domain.Entities.Homeworks;
using Domain.Entities.Users;
using Domain.Enums;
using System.Diagnostics;

namespace Domain.Entities.Tasks
{
    public class TaskResult : Auditable
    {
        public long StudentId { get; set; }
        public long HomeworkId { get; set; }
        public string Description { get; set; }
        public TaskResultStatus TaskResultStatus { get; set; }

        public virtual Student Student { get; set; }
        public virtual Homework Homework { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<TaskResultFile> TaskResultFiles { get; set; }
    }
}
